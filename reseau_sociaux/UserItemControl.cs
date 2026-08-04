using System;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace reseau_sociaux
{
    public partial class UserItemControl : UserControl
    {
        //  Empêche le Designer Visual Studio de sérialiser cette propriété
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Etudiant? UserData { get; private set; }

        // Événement déclenché lors du clic sur l'utilisateur (? gère la nullabilité)
        public event EventHandler? UserClicked;

        public UserItemControl()
        {
            InitializeComponent();

            // Attacher l'événement de clic à la carte ainsi qu'à ses éléments enfants
            this.Click += OnItemClick;
            lblFullName.Click += OnItemClick;
            pictureBoxProfil.Click += OnItemClick;
        }

        /// Injecte les données du modèle conceptuel dans le contrôle visuel
        public void BindModel(Etudiant etudiant)
        {
            this.UserData = etudiant;

            //  Mise à jour du nom
            lblFullName.Text = etudiant.fullName;

            // Chargement de l'image de profil si présente
            if (etudiant.profileImage != null && etudiant.profileImage.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(etudiant.profileImage))
                {
                    pictureBoxProfil.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureBoxProfil.Image = null; // on peut assigner un image par defaut assigner une image par défaut
            }

            // Application de la forme arrondie sur le PictureBox
            AppliquerArrondiImage();
        }

        private void AppliquerArrondiImage()
        {
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddEllipse(0, 0, pictureBoxProfil.Width - 1, pictureBoxProfil.Height - 1);
                pictureBoxProfil.Region = new Region(path);
            }
        }

        private void OnItemClick(object? sender, EventArgs e)
        {
            // Déclenche l'événement pour avertir le formulaire parent
            UserClicked?.Invoke(this, e);
        }
    }
}