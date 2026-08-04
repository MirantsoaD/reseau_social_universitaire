using System;
using System.Drawing;
using System.Windows.Forms;

namespace reseau_sociaux
{
    public partial class GroupMessageBubbleControl : UserControl
    {
        // Événement déclenché quand l'utilisateur demande la suppression du message
        public event EventHandler? MessageDeleted;

        // Identifiant du message affiché par cette bulle
        public int MessageId { get; set; }

        public GroupMessageBubbleControl()
        {
            InitializeComponent();
        }

        // Remplit la bulle avec le message et applique le style selon l'expéditeur
        public void SetMessage(GroupeMessage msg, int currentUserId)
        {
            MessageId = msg.MessageId;

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
                btnSupprimerMsg.Visible = true;
                btnSupprimerMsg.ForeColor = Color.White;
            }
            else
            {
                // Message REÇU (Un autre membre) -> Gris, texte noir
                this.BackColor = Color.FromArgb(230, 230, 230);
                lblSender.ForeColor = Color.FromArgb(0, 102, 204);
                lblContent.ForeColor = Color.Black;
                lblTime.ForeColor = Color.Gray;
                btnSupprimerMsg.Visible = false;
            }

            AjusterTaille();
        }

        private void btnSupprimerMsg_Click(object sender, EventArgs e)
        {
            MessageDeleted?.Invoke(this, EventArgs.Empty);
        }

        // Recalcule la hauteur de la bulle pour que le texte soit entièrement visible
        private void AjusterTaille()
        {
            const int largeurBulle = 340;
            const int marge = 10;

            this.Width = largeurBulle;

            // Bouton de suppression en haut à droite
            btnSupprimerMsg.Location = new Point(largeurBulle - btnSupprimerMsg.Width - 6, 4);

            // Le nom de l'expéditeur ne doit pas passer sous le bouton
            lblSender.MaximumSize = new Size(largeurBulle - btnSupprimerMsg.Width - 26, 23);
            lblSender.AutoEllipsis = true;

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
