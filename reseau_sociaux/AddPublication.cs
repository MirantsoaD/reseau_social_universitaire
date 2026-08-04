using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace reseau_sociaux
{
    public partial class AddPublication : Form
    {
        public AddPublication()
        {
            InitializeComponent();
        }

        private void parrotButtonAddImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // Filtrer uniquement les formats d'images
                ofd.Filter = "Images (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Sélectionner une photo pour la publication";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //lit tous les octets du fichier en mémoire
                        byte[] imageBytes = File.ReadAllBytes(ofd.FileName);

                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            //crée l'image à partir du flux
                            using (Image imgOriginale = Image.FromStream(ms))
                            {
                                // Libérer l'ancienne image du PictureBox s'il y en avait déjà une (pour éviter les fuites mémoire)
                                if (pictureBoxPublication.Image != null)
                                {
                                    pictureBoxPublication.Image.Dispose();
                                }

                                //On affecte une COPIE de l'image au PictureBox
                                pictureBoxPublication.Image = new Bitmap(imgOriginale);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Impossible de charger cette image : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void parrotButtonSave_Click(object sender, EventArgs e)
        {
            if(pictureBoxPublication.Image == null)
            {
                errorProvider.SetError(pictureBoxPublication, "Veuillez sélectionner une image pour la publication.");
                MessageBox.Show("Veuillez sélectionner une image pour la publication.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (string.IsNullOrWhiteSpace(bigTextBoxLegende.Text))
                {
                    errorProvider.SetError(bigTextBoxLegende, "Veuillez saisir une légende pour la publication.");
                    return;
                }
                return;
            }
            
            if (PublicationRepository.AddPublication(UserSession.CurrentUser.id, bigTextBoxLegende.Text, PublicationRepository.convertIntoArray(pictureBoxPublication))) 
            {
                errorProvider.Clear();
                MessageBox.Show("Publication ajouter!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //charger la publication apres chaque succes d'enregistrement
                formMain? main = Application.OpenForms.OfType<formMain>().FirstOrDefault();
                if(main != null)
                {
                    main.ShowPublication();
                }
            }
            else { MessageBox.Show("Erreur lors de l'enregistrement"); }
            

        }

        private void parrotButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
