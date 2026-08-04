using Npgsql;
using System;
using System.Collections.Generic;

namespace reseau_sociaux
{
    public static class GroupeRepository
    {
        private static string connectionString = "Host=localhost;Database=reseaux_sociaux;Username=postgres;Persist Security Info=True;Password=DannyRandria";

        // Cree un nouveau groupe et inscrit le createur comme Administrateur
        public static bool CreerGroupe(int createurId, string nom, string description)
        {
            if (string.IsNullOrWhiteSpace(nom)) { return false; }

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    int groupeId;
                    string insertGroupe = @"INSERT INTO groupe (nom, description, createur_id) 
                                        VALUES (@nom, @description, @createurId) RETURNING groupe_id;";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(insertGroupe, conn))
                    {
                        cmd.Parameters.AddWithValue("@nom", nom);
                        cmd.Parameters.AddWithValue("@description", (object?)description ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@createurId", createurId);

                        object result = cmd.ExecuteScalar();
                        if (result == null || result == DBNull.Value) { return false; }
                        groupeId = Convert.ToInt32(result);
                    }

                    string insertMembre = @"INSERT INTO groupe_membre (groupe_id, etudiant_id, role) 
                                        VALUES (@groupeId, @createurId, 'Administrateur');";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(insertMembre, conn))
                    {
                        cmd.Parameters.AddWithValue("@groupeId", groupeId);
                        cmd.Parameters.AddWithValue("@createurId", createurId);
                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la creation du groupe : " + ex.Message);
                    return false;
                }
            }
        }

        // Recupere tous les groupes avec le nom du createur, le nombre de membres
        // et le role de l'utilisateur courant (null s'il n'en est pas membre)
        public static List<Groupe> GetAllGroupes(int currentUserId)
        {
            List<Groupe> groupes = new List<Groupe>();

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT 
                                        g.groupe_id,
                                        g.nom,
                                        g.description,
                                        g.createur_id,
                                        g.date_creation,
                                        e.fullname AS createur_nom,
                                        (SELECT COUNT(*) FROM groupe_membre gm WHERE gm.groupe_id = g.groupe_id) AS membre_count,
                                        gm_me.role AS role_moi
                                    FROM groupe g
                                    JOIN etudiant e ON g.createur_id = e.id
                                    LEFT JOIN groupe_membre gm_me ON gm_me.groupe_id = g.groupe_id AND gm_me.etudiant_id = @currentUserId
                                    ORDER BY g.date_creation DESC;";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@currentUserId", currentUserId);

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Groupe groupe = new Groupe
                                {
                                    GroupeId = Convert.ToInt32(reader["groupe_id"]),
                                    Nom = reader["nom"].ToString() ?? "",
                                    Description = reader["description"] != DBNull.Value ? reader["description"].ToString() ?? "" : "",
                                    CreateurId = Convert.ToInt32(reader["createur_id"]),
                                    CreateurNom = reader["createur_nom"].ToString() ?? "",
                                    DateCreation = Convert.ToDateTime(reader["date_creation"]),
                                    MembreCount = Convert.ToInt32(reader["membre_count"]),
                                    RoleMoi = reader["role_moi"] != DBNull.Value ? Convert.ToString(reader["role_moi"]) : null
                                };

                                groupes.Add(groupe);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la lecture des groupes : " + ex.Message);
                }
            }

            return groupes;
        }

        // Recupere les membres d'un groupe (administrateurs en premier)
        public static List<GroupeMembre> GetMembres(int groupeId)
        {
            List<GroupeMembre> membres = new List<GroupeMembre>();

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT 
                                        gm.groupe_id,
                                        gm.etudiant_id,
                                        gm.role,
                                        gm.date_ajout,
                                        e.fullname,
                                        e.profile_image
                                    FROM groupe_membre gm
                                    JOIN etudiant e ON gm.etudiant_id = e.id
                                    WHERE gm.groupe_id = @groupeId
                                    ORDER BY (gm.role = 'Administrateur') DESC, gm.date_ajout;";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@groupeId", groupeId);

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                GroupeMembre membre = new GroupeMembre
                                {
                                    GroupeId = Convert.ToInt32(reader["groupe_id"]),
                                    EtudiantId = Convert.ToInt32(reader["etudiant_id"]),
                                    Role = reader["role"].ToString() ?? "Membre",
                                    DateAjout = Convert.ToDateTime(reader["date_ajout"]),
                                    FullName = reader["fullname"].ToString() ?? "",
                                    ProfileImage = reader["profile_image"] as byte[]
                                };

                                membres.Add(membre);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la lecture des membres : " + ex.Message);
                }
            }

            return membres;
        }

        // Invite un etudiant dans un groupe. Re-inviter est sans effet (ON CONFLICT DO NOTHING).
        public static bool InviterMembre(int groupeId, int etudiantId)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO groupe_membre (groupe_id, etudiant_id, role) 
                                    VALUES (@groupeId, @etudiantId, 'Membre') ON CONFLICT DO NOTHING;";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@groupeId", groupeId);
                        cmd.Parameters.AddWithValue("@etudiantId", etudiantId);
                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'invitation du membre : " + ex.Message);
                    return false;
                }
            }
        }

        // Recupere tous les etudiants invitable (hors utilisateur courant et hors membres du groupe)
        public static List<Etudiant> GetEtudiantsInvitable(int groupeId, int currentUserId)
        {
            List<Etudiant> etudiants = new List<Etudiant>();

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT e.id, e.fullname, e.profile_image 
                                    FROM etudiant e 
                                    WHERE e.id != @currentUserId 
                                    AND e.id NOT IN (SELECT etudiant_id FROM groupe_membre WHERE groupe_id = @groupeId) 
                                    ORDER BY e.fullname;";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@currentUserId", currentUserId);
                        cmd.Parameters.AddWithValue("@groupeId", groupeId);

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Etudiant etudiant = new Etudiant
                                {
                                    id = Convert.ToInt32(reader["id"]),
                                    fullName = reader["fullname"].ToString() ?? "",
                                    profileImage = reader["profile_image"] as byte[]
                                };

                                etudiants.Add(etudiant);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la lecture des etudiants : " + ex.Message);
                }
            }

            return etudiants;
        }

        // Envoie un message texte dans un groupe
        public static bool EnvoyerMessageGroupe(int groupeId, int etudiantId, string contenu)
        {
            if (string.IsNullOrWhiteSpace(contenu)) { return false; }

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO groupe_message (groupe_id, etudiant_id, content) 
                                    VALUES (@groupeId, @etudiantId, @contenu);";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@groupeId", groupeId);
                        cmd.Parameters.AddWithValue("@etudiantId", etudiantId);
                        cmd.Parameters.AddWithValue("@contenu", contenu);
                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'envoi du message : " + ex.Message);
                    return false;
                }
            }
        }

        // Recupere tous les messages d'un groupe (du plus ancien au plus recent)
        public static List<GroupeMessage> GetMessagesGroupe(int groupeId)
        {
            List<GroupeMessage> messages = new List<GroupeMessage>();

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT 
                                        gm.message_id,
                                        gm.groupe_id,
                                        gm.etudiant_id,
                                        gm.content,
                                        gm.time_sent,
                                        e.fullname
                                    FROM groupe_message gm
                                    JOIN etudiant e ON gm.etudiant_id = e.id
                                    WHERE gm.groupe_id = @groupeId
                                    ORDER BY gm.time_sent ASC;";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@groupeId", groupeId);

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                GroupeMessage message = new GroupeMessage
                                {
                                    MessageId = Convert.ToInt32(reader["message_id"]),
                                    GroupeId = Convert.ToInt32(reader["groupe_id"]),
                                    EtudiantId = Convert.ToInt32(reader["etudiant_id"]),
                                    FullName = reader["fullname"].ToString() ?? "",
                                    Content = reader["content"] != DBNull.Value ? reader["content"].ToString() ?? "" : "",
                                    TimeSent = Convert.ToDateTime(reader["time_sent"])
                                };

                                messages.Add(message);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la lecture des messages : " + ex.Message);
                }
            }

            return messages;
        }
    }
}
