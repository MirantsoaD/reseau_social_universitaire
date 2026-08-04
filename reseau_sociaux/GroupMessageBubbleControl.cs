using System;
using System.Drawing;
using System.Windows.Forms;

namespace reseau_sociaux
{
    public partial class GroupMessageBubbleControl : UserControl
    {
        public GroupMessageBubbleControl()
        {
            InitializeComponent();
        }

        // Remplit la bulle avec le message et applique le style selon l'expéditeur
        public void SetMessage(GroupeMessage msg, int currentUserId)
        {
            lblSender.Text = msg.FullName;
            lblContent.Text = msg.Content;
            lblTime.Text = msg.TimeSent.ToString("HH:mm");

            bool isMe = (msg.EtudiantId == currentUserId);

            if (isMe)
            {
                // Message ENVOYÉ (Moi) -> Bleu, texte blanc
                this.BackColor = Color.FromArgb(0, 132, 255);
                lblSender.ForeColor = Color.White;
                lblContent.ForeColor = Color.White;
                lblTime.ForeColor = Color.LightGray;
            }
            else
            {
                // Message REÇU (Un autre membre) -> Gris, texte noir
                this.BackColor = Color.FromArgb(230, 230, 230);
                lblSender.ForeColor = Color.FromArgb(0, 102, 204);
                lblContent.ForeColor = Color.Black;
                lblTime.ForeColor = Color.Gray;
            }

            AjusterTaille();
        }

        // Recalcule la hauteur de la bulle pour que le texte soit entièrement visible
        private void AjusterTaille()
        {
            const int largeurBulle = 340;
            const int marge = 10;

            this.Width = largeurBulle;

            int largeurTexte = largeurBulle - (2 * marge);

            // Hauteur du texte avec retour à la ligne
            Size tailleTexte = TextRenderer.MeasureText(
                lblContent.Text,
                lblContent.Font,
                new Size(largeurTexte, 0),
                TextFormatFlags.WordBreak);

            lblContent.SetBounds(marge, 26, largeurTexte, tailleTexte.Height);

            // Positionne l'heure en bas à droite du contenu
            int largeurHeure = TextRenderer.MeasureText(lblTime.Text, lblTime.Font).Width;
            lblTime.Location = new Point(largeurBulle - largeurHeure - marge, lblContent.Bottom + 3);

            this.Height = lblContent.Bottom + lblTime.Height + marge;
        }
    }
}
