using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace reseau_sociaux
{
    public partial class formMain : Form
    {
        // L'utilisateur actuel avec qui on parle
        private Etudiant? currentChatUser = null;

        public formMain()
        {
            InitializeComponent();
        }

        #region --- INITIALISATION ET CHARGEMENT (Form Load) ---

        private void formMain_Load(object sender, EventArgs e)
        {
            // Initialisation du bouton parametre
            plParameterControl_main.Size = plParameterControl_main.MinimumSize;
            parrotButtonLogout_main.Location = new Point(15, 488);

            // Masquage initial des panneaux
            plUserProfil_main.Visible = false;
            plUpdateProfil_main.Visible = false;
            plUpdatePassword_main.Visible = false;

            // Chargement de la liste des utilisateurs
            ChargerListeUtilisateurs();

            // Configuration du panneau Chat
            plChat_main.Size = plChat_main.MinimumSize;
            plChat_main.Visible = false;

            // Configuration du panneau Publication (Accueil)
            plPublication_main.Size = plPublication_main.MaximumSize;
            plPublication_main.Location = new Point(0, 57);
            plPublication_main.Visible = true;

            // Charger les publications
            ShowPublication();

            // Arrondissement de pictureBoxProfil_main
            pictureBoxMaximize_main.Visible = false;
            System.Drawing.Drawing2D.GraphicsPath path_pictureBoxProfil_main = new System.Drawing.Drawing2D.GraphicsPath();
            path_pictureBoxProfil_main.AddEllipse(0, 0, pictureBoxProfil_main.Width - 1, pictureBoxProfil_main.Height - 1);
            Region rg_pictureBoxProfil_main = new Region(path_pictureBoxProfil_main);
            pictureBoxProfil_main.Region = rg_pictureBoxProfil_main;

            // Arrondissement de pictureBoxImage_profil
            System.Drawing.Drawing2D.GraphicsPath path_pictureBoxImage_profil = new System.Drawing.Drawing2D.GraphicsPath();
            path_pictureBoxImage_profil.AddEllipse(0, 0, pictureBoxProfil_main.Width - 1, pictureBoxProfil_main.Height - 1);
            Region rg_pictureBoxImage_profil = new Region(path_pictureBoxImage_profil);
            pictureBoxImage_profil.Region = rg_pictureBoxImage_profil;

            // Arrondissement de pictureBoxChat_chat
            System.Drawing.Drawing2D.GraphicsPath path_pictureBoxChat_chat = new System.Drawing.Drawing2D.GraphicsPath();
            path_pictureBoxChat_chat.AddEllipse(0, 0, pictureBoxChat_chat.Width - 1, pictureBoxChat_chat.Height - 1);
            Region rg_pictureBoxChat_chat = new Region(path_pictureBoxChat_chat);
            pictureBoxChat_chat.Region = rg_pictureBoxChat_chat;

            // Chargement des données de la session utilisateur
            string fullName = UserSession.CurrentUser.fullName;
            byte[] profileImage = UserSession.CurrentUser.profileImage;
            lblProfil_main.Text = fullName;

            if (profileImage != null)
            {
                using (MemoryStream ms = new MemoryStream(profileImage))
                {
                    pictureBoxProfil_main.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureBoxProfil_main.Image = Properties.Resources.trash_3917772;
            }
        }

        #endregion

        #region --- NAVIGATION MENU PRINCIPAL ---

        private void parrotButtonHome_main_Click(object sender, EventArgs e)
        {
            plPublication_main.Size = plPublication_main.MaximumSize;
            plPublication_main.Location = new Point(0, 57);
            plPublication_main.Visible = true;
        }

        private void parrotButtonChat_main_Click(object sender, EventArgs e)
        {
            plChat_main.Location = new Point(3, 55);
            plChat_main.Size = plChat_main.MaximumSize;
            plChat_main.Visible = true;

            // Masquer les autres panneaux
            plUpdatePassword_main.Visible = false;
            plUserProfil_main.Visible = false;
            plPublication_main.Visible = false;
        }

        private void parrotButtonGroup_main_Click(object sender, EventArgs e)
        {
            using (FormGroupe groupe = new FormGroupe())
            {
                groupe.ShowDialog();
            }
        }

        private void parrotButtonSetting_main_Click(object sender, EventArgs e)
        {
            if (plParameterControl_main.Size == plParameterControl_main.MaximumSize)
            {
                plParameterControl_main.Size = plParameterControl_main.MinimumSize;
                parrotButtonLogout_main.Location = new Point(15, 488);
            }
            else
            {
                plParameterControl_main.Size = plParameterControl_main.MaximumSize;
                parrotButtonLogout_main.Location = new Point(9, 612);
            }
        }

        private void parrotButtonLogout_main_Click(object sender, EventArgs e)
        {
            this.Close();
            formLogin login = new formLogin();
            UserSession.LogOut();
            login.Show();
        }

        #endregion

        #region --- GESTION DES PUBLICATIONS ---

        public async void ShowPublication()
        {
            // Vider le flowLayoutFeed pour éviter les doublons
            flowLayoutFeed.Controls.Clear();

            // Récupérer la liste des publications dans la base
            List<Publication> listes = await Task.Run(() => PublicationRepository.GetAllPublications());

            // Ajouter chaque publication dans le PublicationControl
            foreach (Publication publication in listes)
            {
                PublicationControl control = new PublicationControl();
                control.BindModel(publication);
                flowLayoutFeed.Controls.Add(control);
            }
        }

        private void parrotButtonAddPublication_main_Click(object sender, EventArgs e)
        {
            AddPublication publication = new AddPublication();
            publication.ShowDialog();
        }

        #endregion

        #region --- GESTION DE LA MESSAGERIE ---

        private void ChargerListeUtilisateurs()
        {
            // Vider le FlowLayoutPanel pour ne pas accumuler les doublons
            flowLayoutPanelUsers.Controls.Clear();

            // Récupérer la liste des autres étudiants depuis la base
            List<Etudiant> liste = EtudiantRepository.GetAllOtherUsers(UserSession.CurrentUser.id);

            // Parcourir la liste et créer un UserItemControl par étudiant
            foreach (Etudiant u in liste)
            {
                UserItemControl item = new UserItemControl();

                // Injecter le modèle conceptuel
                item.BindModel(u);

                // Intercepter le clic pour ouvrir la discussion
                item.UserClicked += (sender, e) =>
                {
                    UserItemControl clickedItem = (UserItemControl)sender!;
                    Etudiant destinataire = clickedItem.UserData!;

                    OuvrirConversationAvec(destinataire);
                };

                // Ajouter chaque etudiant au panneau principal
                flowLayoutPanelUsers.Controls.Add(item);
            }
        }

        private void OuvrirConversationAvec(Etudiant destinataire)
        {
            // Met à jour le titre du chat
            this.currentChatUser = destinataire;
            lblChatHeader_chat.Text = destinataire.fullName;

            using (MemoryStream ms = new MemoryStream(destinataire.profileImage))
            {
                pictureBoxChat_chat.Image = Image.FromStream(ms);
            }

            AfficherMessages();
        }

        private void AfficherMessages()
        {
            if (currentChatUser == null) return;

            flowLayoutPanelChat.Controls.Clear();

            // Récupère l'historique
            List<Message> conversation = MessageRepository.GetConversation(UserSession.CurrentUser.id, currentChatUser.id);

            foreach (Message msg in conversation)
            {
                // 1. Création de la bulle
                MessageBubbleControl bubble = new MessageBubbleControl();
                bubble.SetMessage(msg, UserSession.CurrentUser.id);

                // 2. Création du panel container pour chaque bulle
                Panel containerPanel = new Panel();
                containerPanel.Width = flowLayoutPanelChat.ClientSize.Width - 25;
                containerPanel.Height = bubble.Height + 6;
                containerPanel.BackColor = Color.Transparent;

                // 3. Positionnement de la bulle selon l'expéditeur
                bool isMe = (msg.SentFromId == UserSession.CurrentUser.id);

                if (isMe)
                {
                    bubble.Location = new Point(5, 3);
                    bubble.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                }
                else
                {
                    bubble.Location = new Point(containerPanel.Width - bubble.Width - 5, 3);
                    bubble.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                }

                containerPanel.Controls.Add(bubble);
                flowLayoutPanelChat.Controls.Add(containerPanel);
            }

            // Faire défiler automatiquement tout en bas uniquement S'IL Y A au moins un message
            if (flowLayoutPanelChat.Controls.Count > 0)
            {
                flowLayoutPanelChat.ScrollControlIntoView(
                    flowLayoutPanelChat.Controls[flowLayoutPanelChat.Controls.Count - 1]
                );
            }
        }

        private void parrotButtonSend_chat_Click(object sender, EventArgs e)
        {
            if (currentChatUser == null || string.IsNullOrWhiteSpace(txtChat_chat.Text)) return;

            bool succes = MessageRepository.EnvoyerMessage(
                UserSession.CurrentUser.id,
                currentChatUser.id,
                txtChat_chat.Text
            );

            if (succes)
            {
                txtChat_chat.Clear();
                AfficherMessages(); // Rafraîchit le chat
            }
        }

        #endregion

        #region --- GESTION DU PROFIL ET MODIFICATIONS ---

        private void parrotButtonProfil_main_Click(object sender, EventArgs e)
        {
            plUserProfil_main.Size = plUserProfil_main.MaximumSize;
            plUserProfil_main.Location = new Point(95, 41);
            plUserProfil_main.Visible = true;

            textBoxEmail_profil.Text = UserSession.CurrentUser.email;
            textBoxBio_profil.Text = UserSession.CurrentUser.bio;
            textBoxFullname_profil.Text = UserSession.CurrentUser.fullName;

            // Masquer le panneau de publication 
            plPublication_main.Size = plPublication_main.MinimumSize;
            plPublication_main.Location = new Point(0, 57);
            plPublication_main.Visible = false;

            // Masquer les autres panneaux
            plUpdateProfil_main.Size = plUpdateProfil_main.MinimumSize;
            plUpdateProfil_main.Visible = false;
            plChat_main.Visible = false;
        }

        private void parrotButtonExitProfil_profil_Click(object sender, EventArgs e)
        {
            plUserProfil_main.Visible = false;
            plPublication_main.Size = plPublication_main.MaximumSize;
            plPublication_main.Location = new Point(0, 57);
            plPublication_main.Visible = true;
        }

        private void parrotButtonUpdate_profile_Click(object sender, EventArgs e)
        {
            plUpdateProfil_main.Size = plUpdateProfil_main.MaximumSize;
            plUpdateProfil_main.Location = new Point(67, 64);
            plUpdateProfil_main.Visible = true;

            txtBioUpdate_profil.Text = UserSession.CurrentUser.bio;
            txtEmailUpdate_profil.Text = UserSession.CurrentUser.email;
            pictureBoxImage_profil.Image = pictureBoxProfil_main.Image;

            // Masquer le panneau de publication
            plPublication_main.Size = plPublication_main.MinimumSize;
            plPublication_main.Location = new Point(0, 57);
            plPublication_main.Visible = false;

            // Séparer le fullName
            string[] parties = UserSession.CurrentUser.fullName.Trim().Split(new char[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries);
            txtFirstnameUpdate_profil.Text = parties[0];

            if (parties.Length > 1) { txtLastnameUpdate_profil.Text = parties[1]; }

            // Masquer les autres panneaux
            plUpdatePassword_main.Size = plUpdatePassword_main.MinimumSize;
            plUpdatePassword_main.Visible = false;
            plUserProfil_main.Size = plUserProfil_main.MinimumSize;
            plUserProfil_main.Visible = false;
            plChat_main.Visible = false;
        }

        private void parrotButtonImage_profil_Click(object sender, EventArgs e)
        {
            // Création de dialogue pour sélectionner une image
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image (*.jpg; *.png; *.jpeg; *.bmp) | *.jpg; *.png; *.jpeg; *.bmp";
                dialog.Title = "Sélectionner votre photo de profil";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        byte[] bytes = File.ReadAllBytes(dialog.FileName);

                        // Création d'une image à partir du tableau
                        using (MemoryStream ms = new MemoryStream(bytes))
                        {
                            pictureBoxImage_profil.Image = Image.FromStream(ms);
                            UserSession.CurrentUser.profileImage = bytes;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors du chargement de l'image : " + ex.Message);
                    }
                }
            }
        }

        private void parrotButtonUpdate_profil_Click(object sender, EventArgs e)
        {
            UserSession.CurrentUser.email = txtEmailUpdate_profil.Text.Trim();
            UserSession.CurrentUser.bio = txtBioUpdate_profil.Text.Trim();
            UserSession.CurrentUser.fullName = txtFirstnameUpdate_profil.Text.Trim() + " " + txtLastnameUpdate_profil.Text.Trim();

            // Insertion dans la base
            if (EtudiantRepository.UpdateProfile(UserSession.CurrentUser))
            {
                MessageBox.Show("Modification du profil est un succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Rafraîchissement des données changées
                EtudiantRepository.RefreshUpdate(UserSession.CurrentUser);
                using (MemoryStream ms = new MemoryStream(UserSession.CurrentUser.profileImage))
                {
                    pictureBoxProfil_main.Image = Image.FromStream(ms);
                }

                textBoxBio_profil.Text = UserSession.CurrentUser.bio;
                textBoxEmail_profil.Text = UserSession.CurrentUser.email;
                textBoxFullname_profil.Text = UserSession.CurrentUser.fullName;
            }
            else
            {
                MessageBox.Show("Erreur de modification !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void parrotButtonExit_profil_Click(object sender, EventArgs e)
        {
            plUpdateProfil_main.Visible = false;
            plUpdateProfil_main.Size = plUpdateProfil_main.MinimumSize;

            // Pour revenir sur Home
            plPublication_main.Size = plPublication_main.MaximumSize;
            plPublication_main.Location = new Point(0, 57);
            plPublication_main.Visible = true;
        }

        #endregion

        #region --- GESTION DU MOT DE PASSE ---

        private void parrotButtonUpdatePassword_main_Click(object sender, EventArgs e)
        {
            plUpdatePassword_main.Location = new Point(96, 112);
            plUpdatePassword_main.Size = plUpdatePassword_main.MaximumSize;
            plUpdatePassword_main.Visible = true;

            // Masquer les autres panneaux
            plUpdateProfil_main.Size = plUpdateProfil_main.MinimumSize;
            plUpdateProfil_main.Visible = false;
            plUserProfil_main.Size = plUserProfil_main.MinimumSize;
            plUserProfil_main.Visible = false;
            plPublication_main.Size = plPublication_main.MinimumSize;
            plPublication_main.Visible = false;
            plChat_main.Visible = false;
        }

        private void parrotButtonRetourUpdatePassword_profile_Click(object sender, EventArgs e)
        {
            plUpdatePassword_main.Visible = false;
            plUpdatePassword_main.Size = plUpdatePassword_main.MinimumSize;

            // Pour revenir sur Home
            plPublication_main.Size = plPublication_main.MaximumSize;
            plPublication_main.Location = new Point(0, 57);
            plPublication_main.Visible = true;
        }

        private void parrotButtonUpdatePassword_profile_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOldPassword_profile.Text.Trim()) &&
                !string.IsNullOrEmpty(txtNewPassword_profile.Text.Trim()) &&
                !string.IsNullOrEmpty(txtConfirmationPassword_profile.Text.Trim()))
            {
                if (txtOldPassword_profile.Text == UserSession.CurrentUser.password)
                {
                    if (txtNewPassword_profile.Text == txtConfirmationPassword_profile.Text)
                    {
                        UserSession.CurrentUser.password = txtNewPassword_profile.Text.Trim();
                        EtudiantRepository.UpdatePassword(UserSession.CurrentUser);
                    }
                    else
                    {
                        MessageBox.Show("Le nouveau mot de passe et le mot de passe de confirmation ne sont pas identiques !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("L'ancien mot de passe que vous avez saisi est incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void checkBoxUnhidePassword_profile_CheckStateChanged(object sender, EventArgs e)
        {
            txtOldPassword_profile.PasswordChar = checkBoxUnhidePassword_profile.Checked ? '\0' : '*';
            txtNewPassword_profile.PasswordChar = checkBoxUnhidePassword_profile.Checked ? '\0' : '*';
            txtConfirmationPassword_profile.PasswordChar = checkBoxUnhidePassword_profile.Checked ? '\0' : '*';
        }

        #endregion

        #region --- CONTRÔLES DE FENÊTRE & ANIMATION ---

        private void btnExit_main_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxMaximize_main_Click(object sender, EventArgs e)
        {
            pictureBoxMaximize_main.Visible = false;
            pictureBoxMinimize_main.Visible = true;
            pictureBoxProfil_main.Visible = true;
            lblProfil_main.Visible = true;
            timerSize.Start();
        }

        private void pictureBoxMinimize_main_Click(object sender, EventArgs e)
        {
            pictureBoxMaximize_main.Visible = true;
            pictureBoxMinimize_main.Visible = false;
            pictureBoxProfil_main.Visible = false;
            lblProfil_main.Visible = false;
            timerSize.Start();
        }

        private void timerSize_Tick(object sender, EventArgs e)
        {
            if (pictureBoxMaximize_main.Visible == false)
            {
                plContainerControl_main.Width += 5;
                if (plContainerControl_main.Size == plContainerControl_main.MaximumSize)
                {
                    timerSize.Stop();
                }
            }
            else
            {
                plContainerControl_main.Width -= 5;
                if (plContainerControl_main.Size == plContainerControl_main.MinimumSize)
                {
                    timerSize.Stop();
                }
            }
        }

        #endregion

       
    }
}