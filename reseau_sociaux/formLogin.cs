using System;
using System.Drawing.Text;
using Npgsql;

namespace reseau_sociaux
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            
            InitializeComponent();
        }

        private void mstExit_login_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mstRegister_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            formRegister register = new formRegister();
            register.Show();
        }

        private void checkBoxUnhide_login_CheckStateChanged(object sender, EventArgs e)
        {
            txtPassword_login.PasswordChar = checkBoxUnhide_login.Checked ? '\0' : '*';
        }

        private void btnSubmit_login_Click(object sender, EventArgs e)
        {
            Etudiant etudiant = EtudiantRepository.GetByEmail(txtUserLogin_login.Text.Trim());
            if(string.IsNullOrEmpty(txtUserLogin_login.Text) || string.IsNullOrEmpty(txtPassword_login.Text))
            {
                errorProvider.SetError(btnSubmit_login, "Veuillez remplir tous les champs");
                return;
            }
            if (etudiant != null)
            {
                errorProvider.Clear();
                if (etudiant.password == txtPassword_login.Text)
                {
                    // connexion reussi
                    formMain main = new formMain();
                    UserSession.CurrentUser = etudiant;
                    main.Show();
                    MessageBox.Show("Connection reussi","Succes",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtPassword_login.Text = "";
                    txtUserLogin_login.Text = "";
                    txtUserLogin_login.Focus();
                    this.Hide();
                }
                else { MessageBox.Show("L'identificateur ou le mot de passe que vous avez ecrit est incorrect", " erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                errorProvider.Clear();
                MessageBox.Show("L'identificateur ou le mot de passe que vous avez ecrit est incorrect"," erreur", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        
    }
}
