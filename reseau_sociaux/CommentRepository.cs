using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Npgsql;

namespace reseau_sociaux
{
    public static class CommentRepository
    {
        public static string connectionString = "Host=localhost;Database=reseaux_sociaux;Username=postgres;Persist Security Info=True;Password=DannyRandria"; 
        public static void AddComment( int SenderId, int PublicationId,string Content )
        {
            using(NpgsqlConnection connection = new NpgsqlConnection(connectionString)) 
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO commentaire(etudiant_id,publication_id,content) VALUES (@SenderId,@PublicationId,@Content)";
                    using (NpgsqlCommand command = new NpgsqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@SenderId", SenderId);
                        command.Parameters.AddWithValue("@PublicationId", PublicationId);
                        command.Parameters.AddWithValue("@Content", Content);
                        command.ExecuteNonQuery();
                    }
                }catch(Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        public static List<Comment> GetAllComment( int PublicationdId) 
        {
            List<Comment> comments = new List<Comment>();
            using(NpgsqlConnection connection = new NpgsqlConnection(connectionString)) 
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT
                                    c.commentaire_id,
                                    c.publication_id,
                                    c.etudiant_id,
                                    c.content,
                                    c.time_published AS time_published,
                                    e.profile_image As profile_image
                                    FROM commentaire c JOIN etudiant e ON c.etudiant_id = e.id  WHERE publication_id = @publication_id ORDER BY c.time_published DESC";
                    using(NpgsqlCommand command = new NpgsqlCommand(query,connection)) 
                    {
                        command.Parameters.AddWithValue("@publication_id", PublicationdId);
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while(reader.Read()) 
                            {
                                Comment comment = new Comment();
                                comment.CommentaireId = Convert.ToInt32(reader["commentaire_id"]);
                                comment.PublicationId = Convert.ToInt32(reader["publication_id"]);
                                comment.EtudiantId = Convert.ToInt32(reader["etudiant_id"]);
                                comment.Content = Convert.ToString(reader["content"]);
                                comment.TimePublished = Convert.ToDateTime(reader["time_published"]);
                                comment.ImageCommenter = (byte[])reader["profile_image"]!;
                                comments.Add(comment);
                            }
                        }
                    }
                    {

                    };
                }catch(Exception ex) { MessageBox.Show(ex.Message); return null; }
            }return comments;
        }
        public static void UpdateComment(int CommentId, string Content)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE commentaire SET content = @Content WHERE commentaire_id = @CommentId";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Content", Content);
                        command.Parameters.AddWithValue("@CommentId", CommentId);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
