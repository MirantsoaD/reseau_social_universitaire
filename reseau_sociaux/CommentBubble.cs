using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace reseau_sociaux
{
    public partial class CommentBubble : UserControl
    {
        //declaration des variables pour stocker l'ID de l'étudiant et l'ID du commentaire
        int EtudiantId;
        int CommentId;
        //creation d'evenement pour la suppression du commentaire
        public event EventHandler CommentDeleted;
        public CommentBubble(Comment comment)
        {
            InitializeComponent();
            EtudiantId = comment.EtudiantId;
            CommentId = comment.CommentaireId;
        }
        public void BindModel(Comment comment)
        {
            //relier tous les controles avec les donnees de publication
            if (comment != null && comment.ImageCommenter != null)
            {
                lblComment.Text = comment.Content;
                lblTime.Text = comment.TimePublished.ToString("dd/MM/yyyy HH:mm");
                using (MemoryStream ms = new MemoryStream(comment.ImageCommenter))
                {
                    pictureBoxUserComment.Image = Image.FromStream(ms);
                }
            }
        }

        private void lblComment_Click(object sender, EventArgs e)
        {
            
            if (EtudiantId == UserSession.CurrentUser.id)
            {   //Donner une couleur différente au commentaire de l'utilisateur connecté
                this.BackColor = Color.AliceBlue;
                lblComment.ForeColor = Color.White;

                //Update le commentaire
                if (MessageBox.Show("Vous voulez supprimer votre commentaire ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CommentDeleted?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private void CommentBubble_Load(object sender, EventArgs e)
        {
            // Arrondissement de l'image
            System.Drawing.Drawing2D.GraphicsPath path_pictureHeader = new System.Drawing.Drawing2D.GraphicsPath();
            path_pictureHeader.AddEllipse(0, 0, pictureBoxUserComment.Width - 1, pictureBoxUserComment.Height - 1);
            Region rg = new Region(path_pictureHeader);
            pictureBoxUserComment.Region = rg;

            if (EtudiantId == UserSession.CurrentUser.id)
            {   //Donner une couleur différente au commentaire de l'utilisateur connecté
                plComment.BackColor = Color.Blue;
                lblComment.ForeColor = Color.White;
            }

            }

    }
}
