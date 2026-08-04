using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace reseau_sociaux
{
    public partial class FormCommentaire : Form
    {   //Declaration des variable necessaire pour le formulaire
        private string publicationId;
        public FormCommentaire(string PublicationId)
        {
            InitializeComponent();
            this.publicationId = PublicationId;
        }

        private void parrotButtonExitComment_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayComment()
        {
            // Récupérer l'ID de la publication à partir du label
            int PublicationId = int.Parse(publicationId);
            // Récupérer les commentaires pour la publication
            List<Comment> comments = CommentRepository.GetAllComment(PublicationId);
            // Vider le panel avant d'ajouter les nouveaux commentaires
            flowLayoutPanelComment.Controls.Clear();
            // Ajouter chaque commentaire au panel
            foreach (var comment in comments)
            {
                CommentBubble commentBubble = new CommentBubble(comment);
                commentBubble.BindModel(comment);
                commentBubble.CommentDeleted += (sender, e) =>
                {
                    CommentRepository.UpdateComment(comment.CommentaireId, "Commentaire Supprimé");
                    DisplayComment();
                };
                flowLayoutPanelComment.Controls.Add(commentBubble);
            }
        }

        private void parrotButtonSendComment_Click(object sender, EventArgs e)
        {   if(string.IsNullOrWhiteSpace(bigTextBoxComment.Text))
            {
                errorProvider.SetError(bigTextBoxComment, "Le commentaire ne peut pas être vide.");
                return;
            }
            CommentRepository.AddComment(UserSession.CurrentUser.id, int.Parse(publicationId), bigTextBoxComment.Text);
            DisplayComment();
            bigTextBoxComment.Text = string.Empty;
            errorProvider.Clear();
        }

        private void FormCommentaire_Load(object sender, EventArgs e)
        {
            DisplayComment();
        }
    }
}
