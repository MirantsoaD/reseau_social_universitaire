using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace reseau_sociaux
{
    public partial class PublicationControl : UserControl
    {
        public PublicationControl()
        {
            InitializeComponent();

        }
        //Etat de reaction
        int reaction = 0;
        int AuthorId;

        private void PublicationControl_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path_pictureHeader = new System.Drawing.Drawing2D.GraphicsPath();
            path_pictureHeader.AddEllipse(0, 0, pictureBoxPublication_header.Width - 1, pictureBoxPublication_header.Height - 1);
            Region rg = new Region(path_pictureHeader);
            pictureBoxPublication_header.Region = rg;
        }

        public void BindModel(Publication publication)
        {
            //relier tous les controles avec les donnees de publication
            if (publication.AuthorFullName != null && publication.AuthorProfileImage != null)
            {
                lblPublication_header.Text = publication.AuthorFullName;
                lblPublicationId.Text = publication.PublicationId.ToString();
                this.AuthorId = publication.EtudiantId;
                using (MemoryStream ms = new MemoryStream(publication.AuthorProfileImage))
                {
                    pictureBoxPublication_header.Image = Image.FromStream(ms);
                }
            }
            if (publication != null && publication.ImageData.Length > 0)
            {
                lblTextPublication.Text = publication.Legende;
                using (MemoryStream ms = new MemoryStream(publication.ImageData))
                {
                    pictureBoxPublication_main.Image = Image.FromStream(ms);
                }

            }
        }

        private void parrotButtonReaction_publication_Click(object sender, EventArgs e)
        {
            if (reaction == 0)
            {
                parrotButtonReaction_publication.BackgroundColor = Color.Blue;
                parrotButtonReaction_publication.TextColor = Color.White;
                reaction = 1;
            }
            else
            {
                parrotButtonReaction_publication.BackgroundColor = Color.White;
                parrotButtonReaction_publication.TextColor = Color.Black;
                reaction = 0;
            }
        }

        private void parrotButtonComment_publication_Click(object sender, EventArgs e)
        {
            // ouvrir un boite de commentaire
            FormCommentaire comment = new FormCommentaire(lblPublicationId.Text);
            comment.ShowDialog();
        }

        private void pictureBoxPublication_main_Click(object sender, EventArgs e)
        {
            if(UserSession.CurrentUser.id == this.AuthorId) 
            {
                btnSupprimerPublication.Visible = true;
            }
        }

        private void btnSupprimerPublication_Click(object sender, EventArgs e)
        {
            //Supprimer la publication
            if (MessageBox.Show("Voulez vous supprimer cette publication ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Publication publication = new Publication();
                publication.PublicationId = int.Parse(lblPublicationId.Text);
                if (PublicationRepository.DeletePublication(int.Parse(lblPublicationId.Text)))
                {
                    MessageBox.Show("Publication supprimée avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la suppression de la publication", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { btnSupprimerPublication.Visible = false; }
        }
    }
}
