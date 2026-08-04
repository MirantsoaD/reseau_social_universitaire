using Npgsql;
using System;
using System.Collections.Generic;

namespace reseau_sociaux
{
    public static class PublicationRepository
    {
        private static string connectionString = "Host=localhost;Database=reseaux_sociaux;Username=postgres;Persist Security Info=True;Password=DannyRandria";

        //Ajoute une nouvelle publication dans la base de données
        public static bool AddPublication(int etudiantId, string legende, byte[]? imageData)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try 
                {
                    conn.Open();
                    string query = @"INSERT INTO publication_post (etudiant_id, legende, image_data) 
                                VALUES (@etudiantId, @legende, @imageData);";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@etudiantId", etudiantId);
                        cmd.Parameters.AddWithValue("@legende", (object?)legende ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@imageData", (object?)imageData ?? DBNull.Value);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }catch(Exception ex) { MessageBox.Show(ex.Message); return false; }
            }
        }
        //Récupère toutes les publications avec les informations de leur auteur
        public static List<Publication> GetAllPublications()
        {
            List<Publication> publications = new List<Publication>();

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                // Jointure entre publication et etudiant pour récupérer le nom et la photo de l'auteur
                string query = @"SELECT 
                                    p.publication_id,
                                    p.etudiant_id,
                                    p.legende,
                                    p.image_data,
                                    p.time_published,
                                    e.fullname AS author_name,
                                    e.profile_image AS author_image
                                FROM publication_post p
                                JOIN etudiant e ON p.etudiant_id = e.id
                                ORDER BY p.time_published DESC;";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Publication pub = new Publication
                            {
                                PublicationId = Convert.ToInt32(reader["publication_id"]),
                                EtudiantId = Convert.ToInt32(reader["etudiant_id"]),
                                AuthorFullName = reader["author_name"].ToString() ?? "",
                                AuthorProfileImage = reader["author_image"] as byte[],
                                Legende = reader["legende"] != DBNull.Value ? reader["legende"].ToString() ?? "" : "",
                                ImageData = reader["image_data"] as byte[],
                                TimePublished = Convert.ToDateTime(reader["time_published"])
                            };

                            publications.Add(pub);
                        }
                    }
                }
            }

            return publications;
        }
        public static byte[]? convertIntoArray(PictureBox pictureBox) 
        {
            if(pictureBox == null) { return null; } 
            using(MemoryStream ms = new MemoryStream()) 
            {
                pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        //Supprime une publication par son ID
        public static bool DeletePublication(int publicationId)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM publication_post WHERE publication_id = @publicationId;";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@publicationId", publicationId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }
    }
}