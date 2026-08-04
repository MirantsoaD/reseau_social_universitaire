using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Npgsql;
using System.Reflection.Metadata.Ecma335;
using System.Security.Permissions;

namespace reseau_sociaux
{
    public static class EtudiantRepository
    {
        private static  string connectionString = "Host=localhost;Database=reseaux_sociaux;Username=postgres;Persist Security Info=True;Password=DannyRandria";
        
    // fonction de recuperation par email 
        public static Etudiant GetByEmail(string email) 
        {
            if (string.IsNullOrWhiteSpace(email)) 
            {
                return null;
            }
            else
            {
                using( NpgsqlConnection connection = new NpgsqlConnection(connectionString)) 
                {
                    try
                    {
                        connection.Open();
                        String query = "SELECT * FROM etudiant WHERE email = @email";

                        using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@email", email);

                            using (NpgsqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    return new Etudiant
                                    {
                                        id = Convert.ToInt32(reader["id"]),
                                        fullName = Convert.ToString(reader["fullname"]),
                                        password = Convert.ToString(reader["passwordhash"]),
                                        bio = Convert.ToString(reader["bio"]),
                                        profileImage = reader["profile_image"] as byte[],
                                        email = reader["email"].ToString()


                                    };
                                }
                            }
                        }
                    }catch(Exception ex) 
                    {
                        MessageBox.Show("Erreur lors de la lecture de l'etudiant : " + ex.Message);
                    }
                    

                }
            } // S'il n'y a rien
            return null;
        }

        public static  bool UpdateProfile( Etudiant etudiant)
        {   //verification que l'etudiant existe dans la base
            if( etudiant == null || etudiant.id <= 0) { return false; }

            //Condition valide 
            try 
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE etudiant SET email = @email, fullname = @fullname," +
                        "profile_image = @profile_image, bio = @bio where id = @id";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@email", etudiant.email);
                        command.Parameters.AddWithValue("@fullname", etudiant.fullName);
                        command.Parameters.AddWithValue("@profile_image",etudiant.profileImage);
                        command.Parameters.AddWithValue("@bio",etudiant.bio);
                        command.Parameters.AddWithValue("@id", etudiant.id);
                        command.ExecuteNonQuery();

                        return true;

                    }
                }
            }catch(Exception ex) { MessageBox.Show("Erreur lors du mise a jour : " + ex.Message);
                return false;
            }
            return true;
        }

        public static bool UpdatePassword(Etudiant etudiant)
        {
            if (etudiant == null || etudiant.id <= 0) { return false; }

            //condition valide
            try 
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE etudiant SET passwordhash = @passwordhash WHERE id = @id";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@passwordhash", etudiant.password);
                        command.Parameters.AddWithValue("@id", etudiant.id);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Modification du mot de passe reussi! ", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }catch(Exception ex) 
            { 
                MessageBox.Show("Erreur lors de la modification ! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public static void RefreshUpdate(Etudiant etudiant)
        {
            UserSession.CurrentUser = etudiant;
        }

        public static List<Etudiant> GetAllOtherUsers(int currentUserId)
        {
            List<Etudiant> utilisateurs = new List<Etudiant>();

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id, fullname, profile_image FROM etudiant WHERE id != @currentUserId";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@currentUserId", currentUserId);

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

                            utilisateurs.Add(etudiant);
                        }
                    }
                }
            }

            return utilisateurs;
        }
    }
}
