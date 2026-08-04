using Npgsql;
using System;
using System.Collections.Generic;

namespace reseau_sociaux
{
    public static class MessageRepository
    {
        
         static string connectionString = "Host=localhost;Database=reseaux_sociaux;Username=postgres;Persist Security Info=True;Password=DannyRandria";
        //  Envoyer un message
        public static bool EnvoyerMessage(int expediteurId, int destinataireId, string contenu, byte[]? media = null)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO message_set (sent_from_id, sent_to_id, content, media) 
                                VALUES (@from, @to, @content, @media);";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@from", expediteurId);
                    cmd.Parameters.AddWithValue("@to", destinataireId);
                    cmd.Parameters.AddWithValue("@content", contenu);
                    cmd.Parameters.AddWithValue("@media", (object?)media ?? DBNull.Value);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        //Charger la conversation complète entre DEUX utilisateurs
        public static List<Message> GetConversation(int user1Id, int user2Id)
        {
            List<Message> messages = new List<Message>();

            using (NpgsqlConnection conn =  new NpgsqlConnection(connectionString))
            {
                conn.Open();
                //récupérer les messages envoyés dans LES DEUX SENS, triés par heure
                string query = @"SELECT message_id, sent_from_id, sent_to_id, content, media, time_sent 
                                FROM message_set 
                                WHERE (sent_from_id = @u1 AND sent_to_id = @u2) 
                                   OR (sent_from_id = @u2 AND sent_to_id = @u1)
                                ORDER BY time_sent ASC;";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@u1", user1Id);
                    cmd.Parameters.AddWithValue("@u2", user2Id);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            messages.Add(new Message
                            {
                                MessageId = Convert.ToInt32(reader["message_id"]),
                                SentFromId = Convert.ToInt32(reader["sent_from_id"]),
                                SentToId = Convert.ToInt32(reader["sent_to_id"]),
                                Content = reader["content"].ToString() ?? "",
                                Media = reader["media"] as byte[],
                                TimeSent = Convert.ToDateTime(reader["time_sent"])
                            });
                        }
                    }
                }
            }

            return messages;
        }
    }
}