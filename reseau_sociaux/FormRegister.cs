using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using System.IO;
using System.Drawing.Imaging;

namespace reseau_sociaux
{
    public partial class formRegister : Form
    {
        public formRegister()
        {
            InitializeComponent();
        }
        // declaration de variable 
        private string connectionString = "Host=localhost;Database=reseaux_sociaux;Username=postgres;Persist Security Info=True;Password=DannyRandria";


        private void mstLogin_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            formLogin login = new formLogin();
            login.Show();
        }

        private void mstExit_register_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void formRegister_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, pictureBoxRegister_register.Width, pictureBoxRegister_register.Height);
            pictureBoxRegister_register.Region = new Region(path);
        }

        private void parrotButtonImage_register_Click(object sender, EventArgs e)
        {

            //creation de dialogue pour selectionner une image
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                //filtre pour images
                dialog.Filter = "Image (*.jpg; *.png; *.jpeg; *.bmp) | *.jpg; *.png; *.jpeg; *.bmp";
                dialog.Title = " selectionner votre photo de profile";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        byte[] bytes = File.ReadAllBytes(dialog.FileName);
                        //creation d'une image a partir du tableau
                        using (MemoryStream ms = new MemoryStream(bytes))
                        {
                            pictureBoxRegister_register.Image = Image.FromStream(ms);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors du chargement de l'image : " + ex.Message);
                    }
                }
            }
        }

        private void btnRegister_register_Click(object sender, EventArgs e)
        {  
            //Verification du mot de passe
            if(txtPasswordRegister_register.Text.Length < 8)
            {
                errorProvider.SetError(txtPasswordRegister_register, "Le mot de passe doit contenir au moins 8 caractères.m");
                return;
            }
            //verification de l'email
            string email = txtEmail_register.Text.Trim();

            //verification des champs pour l'inscription
            if (!string.IsNullOrWhiteSpace(txtFirstname_register.Text) && !string.IsNullOrWhiteSpace(txtEmail_register.Text) && !string.IsNullOrWhiteSpace(txtPasswordRegister_register.Text) && !string.IsNullOrWhiteSpace(txtPasswordConfrim_register.Text))
            {
                if (email.EndsWith("@gmail.com") || email.EndsWith("@yahoo.com") || email.EndsWith("@hotmail.com"))
                {
                    //verification de la correspondance des mots de passe
                    if (txtPasswordRegister_register.Text.Trim() == txtPasswordConfrim_register.Text.Trim())
                    {
                        string fullname = txtFirstname_register.Text.Trim().ToUpper() + " " + txtLastname_register.Text.Trim();

                        //connection a la base de donnees 
                        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                        {
                            try
                            {
                                connection.Open();
                                string query = "INSERT INTO etudiant (fullname, email, passwordhash, profile_image) VALUES (@fullname, @email, @passwordhash, @profile_image)";
                                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                                {   //changement de l'image en tableau de byte pour l'insertion dans la base de donnees
                                    byte[] image = null;
                                    if (pictureBoxRegister_register.Image != null)
                                    {
                                        using (MemoryStream ms = new MemoryStream())
                                        {
                                            //recuperation de l'image a son format original
                                            var format = pictureBoxRegister_register.Image.RawFormat;

                                            //convertion de l'image en png si le format original n'est pas suppporte
                                            if (format.Guid == System.Drawing.Imaging.ImageFormat.MemoryBmp.Guid)
                                            {
                                                format = System.Drawing.Imaging.ImageFormat.Png;
                                            }
                                            // on sauvegarde le flux dans son format original
                                            pictureBoxRegister_register.Image.Save(ms, format);
                                            //enregistrement de l'image dans un tableau pour l'envoyer vers la base de donnees

                                            image = ms.ToArray();
                                        }
                                    }

                                    // liaison des parametre pour eviter les injections sql 
                                    command.Parameters.AddWithValue("@email", email);
                                    command.Parameters.AddWithValue("@fullname", fullname);
                                    command.Parameters.AddWithValue("@passwordhash", txtPasswordRegister_register.Text);
                                    command.Parameters.AddWithValue("@profile_image", image);
                                    // execution de la commande

                                    command.ExecuteNonQuery();
                                    MessageBox.Show("Inscription reussi", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtEmail_register.Text = "";
                                    txtFirstname_register.Text = "";
                                    txtLastname_register.Text = "";
                                    txtPasswordConfrim_register.Text = "";
                                    txtPasswordRegister_register.Text = "";
                                    pictureBoxRegister_register.Image = Properties.Resources.MiImage;

                                }



                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erreur lors de la connexion à la base de données : " + ex.Message); return;
                            }
                        }
                    }
                    else { MessageBox.Show("Veuillez verifier la correspondance du mot de passe", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("Veuillez entrer un email valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            else { MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void checkBoxUnhide_register_CheckStateChanged(object sender, EventArgs e)
        {
            txtPasswordConfrim_register.PasswordChar = checkBoxUnhide_register.Checked ? '\0' : '*';
            txtPasswordRegister_register.PasswordChar = checkBoxUnhide_register.Checked ? '\0' : '*';
        }

        
    }
}
