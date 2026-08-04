using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace reseau_sociaux
{
    public partial class FormGroupe : Form
    {
        // Tous les groupes affichés dans la liste de gauche
        private List<Groupe>? groupes;

        // Le groupe actuellement sélectionné (détail affiché à droite)
        private Groupe? groupeSelectionne;

        // Étudiants encore invitable dans le groupe sélectionné
        private List<Etudiant>? etudiantsInvitable;

        // Membres du groupe sélectionné (même ordre que la ListBox)
        private List<GroupeMembre>? membresCourants;

        public FormGroupe()
        {
            InitializeComponent();
        }

        #region --- CHARGEMENT ET AFFICHAGE ---

        private void FormGroupe_Load(object sender, EventArgs e)
        {
            ChargerGroupes();
        }

        // Recharge la liste des groupes en gardant la sélection actuelle
        private void ChargerGroupes()
        {
            List<Groupe>? liste = GroupeRepository.GetAllGroupes(UserSession.CurrentUser.id);
            ChargerListeGroupes(liste, groupeSelectionne?.GroupeId ?? -1);
        }

        // Affiche la liste des groupes et sélectionne le groupe demandé (idASelectionner)
        private void ChargerListeGroupes(List<Groupe>? liste, int idASelectionner)
        {
            groupes = liste;
            listBoxGroupes.Items.Clear();

            if (liste == null || liste.Count == 0)
            {
                groupeSelectionne = null;
                AfficherDetailsGroupe();
                return;
            }

            int indexVoulu = -1;
            int i = 0;
            foreach (Groupe g in liste)
            {
                listBoxGroupes.Items.Add(FormaterGroupe(g));
                if (g.GroupeId == idASelectionner)
                {
                    indexVoulu = i;
                }
                i++;
            }

            // Choisir le groupe à afficher
            if (indexVoulu >= 0)
            {
                listBoxGroupes.SelectedIndex = indexVoulu;
            }
            else
            {
                listBoxGroupes.SelectedIndex = 0; // premier groupe par défaut
            }
        }

        // "Nom du groupe — X membres"
        private static string FormaterGroupe(Groupe g)
        {
            return string.Format("{0} — {1}", g.Nom, FormaterMembres(g.MembreCount));
        }

        // "1 membre" ou "X membres"
        private static string FormaterMembres(int nombre)
        {
            return nombre > 1
                ? string.Format("{0} membres", nombre)
                : string.Format("{0} membre", nombre);
        }

        private void listBoxGroupes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGroupes.SelectedIndex >= 0 && groupes != null && listBoxGroupes.SelectedIndex < groupes.Count)
            {
                groupeSelectionne = groupes[listBoxGroupes.SelectedIndex];
            }
            else
            {
                groupeSelectionne = null;
            }

            AfficherDetailsGroupe();
        }

        // Affiche les détails du groupe sélectionné dans la partie droite
        private void AfficherDetailsGroupe()
        {
            if (groupeSelectionne == null)
            {
                lblGroupeNom.Text = "Aucun groupe sélectionné";
                lblCreateur.Text = string.Empty;
                lblMembreCount.Text = string.Empty;
                lblMonRole.Visible = false;
                listBoxMembres.Items.Clear();
                membresCourants = null;
                etudiantsInvitable = null;
                comboBoxInviter.Items.Clear();
                AfficherSectionInvitation(false);
                flowLayoutPanelMessages.Controls.Clear();
                AfficherComposer(false);
                AfficherActionsMembre(false, false);
                return;
            }

            Groupe g = groupeSelectionne;

            lblGroupeNom.Text = g.Nom;
            lblCreateur.Text = "Créé par " + g.CreateurNom;
            lblMembreCount.Text = FormaterMembres(g.MembreCount);

            // Son propre rôle s'il est membre du groupe
            if (string.IsNullOrEmpty(g.RoleMoi))
            {
                lblMonRole.Visible = false;
            }
            else
            {
                lblMonRole.Text = "Votre rôle : " + g.RoleMoi;
                lblMonRole.Visible = true;
            }

            // Boutons de gestion selon le rôle :
            //  - un simple membre peut quitter le groupe
            //  - un administrateur peut retirer un membre ou supprimer le groupe
            AfficherActionsMembre(g.RoleMoi == "Administrateur", g.RoleMoi == "Membre");

            ChargerMembres(g.GroupeId);
            ChargerInvitable(g.GroupeId);
            ChargerMessagesGroupe(g.GroupeId);
            AfficherComposer(!string.IsNullOrEmpty(g.RoleMoi));
        }

        private void ChargerMembres(int groupeId)
        {
            listBoxMembres.Items.Clear();

            // Conserve les objets des membres dans le même ordre que la ListBox
            membresCourants = GroupeRepository.GetMembres(groupeId);
            if (membresCourants == null) return;

            foreach (GroupeMembre m in membresCourants)
            {
                listBoxMembres.Items.Add(string.Format("{0} — {1}", m.FullName, m.Role));
            }
        }

        private void ChargerInvitable(int groupeId)
        {
            etudiantsInvitable = GroupeRepository.GetEtudiantsInvitable(groupeId, UserSession.CurrentUser.id);

            comboBoxInviter.Items.Clear();

            if (etudiantsInvitable == null || etudiantsInvitable.Count == 0)
            {
                AfficherSectionInvitation(false);
                return;
            }

            foreach (Etudiant e in etudiantsInvitable)
            {
                comboBoxInviter.Items.Add(e.fullName);
            }

            comboBoxInviter.SelectedIndex = 0;
            AfficherSectionInvitation(true);
        }

        // Masque ou affiche la partie "Inviter un membre"
        private void AfficherSectionInvitation(bool visible)
        {
            plInviterRow.Visible = visible;
        }

        #endregion

        #region --- DISCUSSION DE GROUPE ---

        // Affiche les messages du groupe dans la discussion
        private void ChargerMessagesGroupe(int groupeId)
        {
            flowLayoutPanelMessages.Controls.Clear();

            List<GroupeMessage>? messages = GroupeRepository.GetMessagesGroupe(groupeId);
            if (messages == null || messages.Count == 0) return;

            foreach (GroupeMessage msg in messages)
            {
                GroupMessageBubbleControl bulle = new GroupMessageBubbleControl();
                bulle.SetMessage(msg, UserSession.CurrentUser.id);

                // Suppression d'un message que l'on a envoyé
                bulle.MessageDeleted += (s, e) =>
                {
                    GroupMessageBubbleControl bulleCliquee = (GroupMessageBubbleControl)s!;
                    int messageId = bulleCliquee.MessageId;

                    DialogResult reponse = MessageBox.Show(
                        "Supprimer ce message ?",
                        "Supprimer le message",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (reponse != DialogResult.Yes) return;

                    bool succes = GroupeRepository.SupprimerMessageGroupe(messageId, UserSession.CurrentUser.id);
                    if (!succes)
                    {
                        MessageBox.Show("Erreur lors de la suppression du message.", "Groupe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (groupeSelectionne != null)
                    {
                        ChargerMessagesGroupe(groupeSelectionne.GroupeId);
                    }
                };

                // Panneau conteneur pour aligner la bulle à gauche ou à droite
                Panel conteneur = new Panel();
                conteneur.Width = flowLayoutPanelMessages.ClientSize.Width - 20;
                conteneur.Height = bulle.Height + 6;
                conteneur.BackColor = Color.Transparent;

                bool isMe = (msg.EtudiantId == UserSession.CurrentUser.id);

                if (isMe)
                {
                    bulle.Location = new Point(conteneur.Width - bulle.Width - 5, 3);
                    bulle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                }
                else
                {
                    bulle.Location = new Point(5, 3);
                    bulle.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                }

                conteneur.Controls.Add(bulle);
                flowLayoutPanelMessages.Controls.Add(conteneur);
            }

            // Faire défiler jusqu'au dernier message
            if (flowLayoutPanelMessages.Controls.Count > 0)
            {
                flowLayoutPanelMessages.ScrollControlIntoView(
                    flowLayoutPanelMessages.Controls[flowLayoutPanelMessages.Controls.Count - 1]);
            }
        }

        // Seuls les membres du groupe peuvent écrire dans la discussion
        private void AfficherComposer(bool visible)
        {
            plComposer.Visible = visible;
        }

        private void parrotButtonEnvoyer_Click(object sender, EventArgs e)
        {
            if (groupeSelectionne == null) return;

            string contenu = bigTextBoxMessage.Text.Trim();
            if (string.IsNullOrEmpty(contenu)) return;

            bool succes = GroupeRepository.EnvoyerMessageGroupe(groupeSelectionne.GroupeId, UserSession.CurrentUser.id, contenu);
            if (!succes)
            {
                MessageBox.Show("Erreur lors de l'envoi du message.", "Groupe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bigTextBoxMessage.Text = string.Empty;
            ChargerMessagesGroupe(groupeSelectionne.GroupeId);
        }

        #endregion

        #region --- CRÉATION D'UN GROUPE ---

        private void parrotButtonCreer_Click(object sender, EventArgs e)
        {
            string nom = bigTextBoxNom.Text.Trim();

            if (string.IsNullOrEmpty(nom))
            {
                MessageBox.Show("Veuillez saisir un nom pour le groupe.", "Groupe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool succes = GroupeRepository.CreerGroupe(UserSession.CurrentUser.id, nom);
            if (!succes)
            {
                MessageBox.Show("Erreur lors de la création du groupe.", "Groupe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Le groupe « " + nom + " » a été créé.", "Groupe", MessageBoxButtons.OK, MessageBoxIcon.Information);

            bigTextBoxNom.Text = string.Empty;

            // Recharger la liste puis sélectionner le groupe qui vient d'être créé
            List<Groupe>? liste = GroupeRepository.GetAllGroupes(UserSession.CurrentUser.id);
            int idCree = TrouverDernierGroupeCree(liste, nom);
            ChargerListeGroupes(liste, idCree);
        }

        // Cherche le groupe le plus récent portant ce nom et appartenant à l'utilisateur courant
        private static int TrouverDernierGroupeCree(List<Groupe>? liste, string nom)
        {
            int id = -1;
            if (liste == null) return id;

            foreach (Groupe g in liste)
            {
                if (g.Nom == nom && g.CreateurId == UserSession.CurrentUser.id && g.GroupeId > id)
                {
                    id = g.GroupeId;
                }
            }
            return id;
        }

        #endregion

        #region --- INVITATION DE MEMBRES ---

        private void parrotButtonInviter_Click(object sender, EventArgs e)
        {
            if (groupeSelectionne == null || etudiantsInvitable == null || comboBoxInviter.SelectedIndex < 0)
                return;

            Etudiant etudiant = etudiantsInvitable[comboBoxInviter.SelectedIndex];

            bool succes = GroupeRepository.InviterMembre(groupeSelectionne.GroupeId, etudiant.id);
            if (!succes)
            {
                MessageBox.Show("Erreur lors de l'invitation.", "Groupe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(etudiant.fullName + " a été invité dans le groupe.", "Groupe", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Rafraîchit la liste des groupes, les membres et les personnes invitable
            ChargerGroupes();
        }

        #endregion

        #region --- GESTION DU GROUPE (QUITTER / RETIRER / SUPPRIMER) ---

        // Affiche ou masque les boutons de gestion du groupe selon le rôle
        private void AfficherActionsMembre(bool estAdministrateur, bool estMembre)
        {
            parrotButtonQuitter.Visible = estMembre;
            parrotButtonRetirer.Visible = estAdministrateur;
            parrotButtonSupprimer.Visible = estAdministrateur;
        }

        private void parrotButtonQuitter_Click(object sender, EventArgs e)
        {
            if (groupeSelectionne == null) return;

            DialogResult reponse = MessageBox.Show(
                "Voulez-vous vraiment quitter le groupe « " + groupeSelectionne.Nom + " » ?",
                "Quitter le groupe",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (reponse != DialogResult.Yes) return;

            bool succes = GroupeRepository.QuitterGroupe(groupeSelectionne.GroupeId, UserSession.CurrentUser.id);
            if (!succes)
            {
                MessageBox.Show("Erreur lors du départ du groupe.", "Groupe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Le groupe disparaît de la liste puisqu'on n'en est plus membre
            ChargerGroupes();
        }

        private void parrotButtonRetirer_Click(object sender, EventArgs e)
        {
            if (groupeSelectionne == null) return;

            if (listBoxMembres.SelectedIndex < 0 || membresCourants == null || listBoxMembres.SelectedIndex >= membresCourants.Count)
            {
                MessageBox.Show("Sélectionnez un membre.", "Groupe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GroupeMembre membre = membresCourants[listBoxMembres.SelectedIndex];

            DialogResult reponse = MessageBox.Show(
                "Voulez-vous vraiment retirer " + membre.FullName + " du groupe ?",
                "Retirer le membre",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (reponse != DialogResult.Yes) return;

            bool succes = GroupeRepository.RetirerMembre(groupeSelectionne.GroupeId, membre.EtudiantId);
            if (!succes)
            {
                MessageBox.Show("Erreur lors du retrait du membre.", "Groupe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Rafraîchit la liste des membres, le nombre de membres et la discussion
            ChargerGroupes();
        }

        private void parrotButtonSupprimer_Click(object sender, EventArgs e)
        {
            if (groupeSelectionne == null) return;

            DialogResult reponse = MessageBox.Show(
                "Voulez-vous vraiment supprimer le groupe « " + groupeSelectionne.Nom + " » ?\nCette action est définitive.",
                "Supprimer le groupe",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (reponse != DialogResult.Yes) return;

            bool succes = GroupeRepository.SupprimerGroupe(groupeSelectionne.GroupeId, UserSession.CurrentUser.id);
            if (!succes)
            {
                MessageBox.Show("Erreur lors de la suppression du groupe.", "Groupe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Le groupe disparaît de la liste ; s'il n'en reste aucun, le détail s'efface
            ChargerGroupes();
        }

        #endregion
    }
}
