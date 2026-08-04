using System;
using System.Drawing;
using System.Windows.Forms;

namespace reseau_sociaux
{
    public partial class MessageBubbleControl : UserControl
    {
        public MessageBubbleControl()
        {
            InitializeComponent();
        }

        public void SetMessage(Message msg, int currentUserId)
        {
            lblContent.Text = msg.Content;
            lblTime.Text = msg.TimeSent.ToString("HH:mm");

            bool isMe = (msg.SentFromId == currentUserId);

            if (isMe)
            {
                // Message ENVOYÉ (Moi) -> Couleur verte/bleue, aligné à droite
                this.BackColor = Color.FromArgb(0, 132, 255); // Bleu style Messenger
                lblContent.ForeColor = Color.White;
                lblTime.ForeColor = Color.LightGray;
            }
            else
            {
                // Message REÇU (L'autre) -> Couleur grise, aligné à gauche
                this.BackColor = Color.FromArgb(230, 230, 230);
                lblContent.ForeColor = Color.Black;
                lblTime.ForeColor = Color.Gray;
            }
        }
    }
}