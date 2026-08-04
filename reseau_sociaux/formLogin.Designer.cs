namespace reseau_sociaux
{
    partial class formLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            menuStripLogin = new MenuStrip();
            mstRegister_login = new ToolStripMenuItem();
            mstExit_login = new ToolStripMenuItem();
            plLogin_login = new Panel();
            checkBoxUnhide_login = new CheckBox();
            btnSubmit_login = new Button();
            pictureLogin_login = new PictureBox();
            txtPassword_login = new TextBox();
            txtUserLogin_login = new TextBox();
            lblPassword_login = new Label();
            lblUser_login = new Label();
            lblLogin_login = new Label();
            errorProvider = new ErrorProvider(components);
            menuStripLogin.SuspendLayout();
            plLogin_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogin_login).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // menuStripLogin
            // 
            menuStripLogin.ImageScalingSize = new Size(20, 20);
            menuStripLogin.Items.AddRange(new ToolStripItem[] { mstRegister_login, mstExit_login });
            menuStripLogin.Location = new Point(0, 0);
            menuStripLogin.Name = "menuStripLogin";
            menuStripLogin.Size = new Size(799, 36);
            menuStripLogin.TabIndex = 0;
            // 
            // mstRegister_login
            // 
            mstRegister_login.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mstRegister_login.Name = "mstRegister_login";
            mstRegister_login.Size = new Size(107, 32);
            mstRegister_login.Text = "S'inscrire";
            mstRegister_login.Click += mstRegister_login_Click;
            // 
            // mstExit_login
            // 
            mstExit_login.BackColor = Color.Red;
            mstExit_login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mstExit_login.Name = "mstExit_login";
            mstExit_login.Size = new Size(39, 32);
            mstExit_login.Text = "X";
            mstExit_login.Click += mstExit_login_Click;
            // 
            // plLogin_login
            // 
            plLogin_login.BackColor = Color.FromArgb(64, 70, 40);
            plLogin_login.Controls.Add(checkBoxUnhide_login);
            plLogin_login.Controls.Add(btnSubmit_login);
            plLogin_login.Controls.Add(pictureLogin_login);
            plLogin_login.Controls.Add(txtPassword_login);
            plLogin_login.Controls.Add(txtUserLogin_login);
            plLogin_login.Controls.Add(lblPassword_login);
            plLogin_login.Controls.Add(lblUser_login);
            plLogin_login.Controls.Add(lblLogin_login);
            plLogin_login.Location = new Point(0, 35);
            plLogin_login.Name = "plLogin_login";
            plLogin_login.Size = new Size(799, 445);
            plLogin_login.TabIndex = 1;
            // 
            // checkBoxUnhide_login
            // 
            checkBoxUnhide_login.AutoSize = true;
            checkBoxUnhide_login.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            checkBoxUnhide_login.Location = new Point(631, 257);
            checkBoxUnhide_login.Name = "checkBoxUnhide_login";
            checkBoxUnhide_login.Size = new Size(93, 27);
            checkBoxUnhide_login.TabIndex = 8;
            checkBoxUnhide_login.Text = "Afficher";
            checkBoxUnhide_login.UseVisualStyleBackColor = true;
            checkBoxUnhide_login.CheckStateChanged += checkBoxUnhide_login_CheckStateChanged;
            // 
            // btnSubmit_login
            // 
            btnSubmit_login.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit_login.Location = new Point(386, 318);
            btnSubmit_login.Name = "btnSubmit_login";
            btnSubmit_login.Size = new Size(133, 29);
            btnSubmit_login.TabIndex = 7;
            btnSubmit_login.Text = "Se connecter";
            btnSubmit_login.UseVisualStyleBackColor = true;
            btnSubmit_login.Click += btnSubmit_login_Click;
            // 
            // pictureLogin_login
            // 
            pictureLogin_login.BackgroundImage = (Image)resources.GetObject("pictureLogin_login.BackgroundImage");
            pictureLogin_login.BackgroundImageLayout = ImageLayout.Stretch;
            pictureLogin_login.Location = new Point(51, 144);
            pictureLogin_login.Name = "pictureLogin_login";
            pictureLogin_login.Size = new Size(150, 151);
            pictureLogin_login.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogin_login.TabIndex = 6;
            pictureLogin_login.TabStop = false;
            // 
            // txtPassword_login
            // 
            txtPassword_login.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword_login.Location = new Point(386, 254);
            txtPassword_login.Name = "txtPassword_login";
            txtPassword_login.PasswordChar = '*';
            txtPassword_login.PlaceholderText = "Mot de passe";
            txtPassword_login.Size = new Size(228, 28);
            txtPassword_login.TabIndex = 5;
            // 
            // txtUserLogin_login
            // 
            txtUserLogin_login.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserLogin_login.Location = new Point(386, 184);
            txtUserLogin_login.Name = "txtUserLogin_login";
            txtUserLogin_login.PlaceholderText = "Addresse mail";
            txtUserLogin_login.Size = new Size(228, 28);
            txtUserLogin_login.TabIndex = 4;
            // 
            // lblPassword_login
            // 
            lblPassword_login.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword_login.ForeColor = SystemColors.ControlLightLight;
            lblPassword_login.Location = new Point(207, 241);
            lblPassword_login.Name = "lblPassword_login";
            lblPassword_login.Size = new Size(179, 43);
            lblPassword_login.TabIndex = 3;
            lblPassword_login.Text = "Mot de passe :";
            lblPassword_login.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUser_login
            // 
            lblUser_login.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser_login.ForeColor = SystemColors.ControlLightLight;
            lblUser_login.ImageAlign = ContentAlignment.TopLeft;
            lblUser_login.Location = new Point(207, 173);
            lblUser_login.Name = "lblUser_login";
            lblUser_login.Size = new Size(185, 45);
            lblUser_login.TabIndex = 2;
            lblUser_login.Text = "Identificateur :";
            lblUser_login.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLogin_login
            // 
            lblLogin_login.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin_login.ForeColor = SystemColors.ControlLightLight;
            lblLogin_login.Location = new Point(340, 15);
            lblLogin_login.Name = "lblLogin_login";
            lblLogin_login.Size = new Size(179, 43);
            lblLogin_login.TabIndex = 0;
            lblLogin_login.Text = "Connexion";
            lblLogin_login.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            errorProvider.Icon = (Icon)resources.GetObject("errorProvider.Icon");
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(799, 480);
            Controls.Add(plLogin_login);
            Controls.Add(menuStripLogin);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStripLogin;
            Name = "formLogin";
            StartPosition = FormStartPosition.CenterScreen;
            menuStripLogin.ResumeLayout(false);
            menuStripLogin.PerformLayout();
            plLogin_login.ResumeLayout(false);
            plLogin_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogin_login).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripLogin;
        private ToolStripMenuItem mstRegister_login;
        private Panel plLogin_login;
        private Label lblLogin_login;
        private TextBox txtPassword_login;
        private TextBox txtUserLogin_login;
        private Label lblPassword_login;
        private Label lblUser_login;
        private PictureBox pictureLogin_login;
        private ToolStripMenuItem mstExit_login;
        private Button btnSubmit_login;
        private CheckBox checkBoxUnhide_login;
        private ErrorProvider errorProvider;
    }
}
