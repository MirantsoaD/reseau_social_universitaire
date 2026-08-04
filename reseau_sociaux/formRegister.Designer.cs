namespace reseau_sociaux
{
    partial class formRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRegister));
            plRegister_register = new Panel();
            parrotButtonImage_register = new ReaLTaiizor.Controls.ParrotButton();
            pictureBoxRegister_register = new PictureBox();
            checkBoxUnhide_register = new CheckBox();
            btnRegister_register = new Button();
            txtPasswordConfrim_register = new TextBox();
            lblPasswordConfirm_register = new Label();
            txtPasswordRegister_register = new TextBox();
            txtEmail_register = new TextBox();
            txtLastname_register = new TextBox();
            lblLastname_register = new Label();
            lblEmail_register = new Label();
            lblPasswordRegister_register = new Label();
            txtFirstname_register = new TextBox();
            lblFirstName_register = new Label();
            menuStripRegister = new MenuStrip();
            mstLogin_register = new ToolStripMenuItem();
            mstExit_register = new ToolStripMenuItem();
            errorProvider = new ErrorProvider(components);
            plRegister_register.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRegister_register).BeginInit();
            menuStripRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // plRegister_register
            // 
            plRegister_register.BackColor = Color.FromArgb(64, 70, 40);
            plRegister_register.Controls.Add(parrotButtonImage_register);
            plRegister_register.Controls.Add(pictureBoxRegister_register);
            plRegister_register.Controls.Add(checkBoxUnhide_register);
            plRegister_register.Controls.Add(btnRegister_register);
            plRegister_register.Controls.Add(txtPasswordConfrim_register);
            plRegister_register.Controls.Add(lblPasswordConfirm_register);
            plRegister_register.Controls.Add(txtPasswordRegister_register);
            plRegister_register.Controls.Add(txtEmail_register);
            plRegister_register.Controls.Add(txtLastname_register);
            plRegister_register.Controls.Add(lblLastname_register);
            plRegister_register.Controls.Add(lblEmail_register);
            plRegister_register.Controls.Add(lblPasswordRegister_register);
            plRegister_register.Controls.Add(txtFirstname_register);
            plRegister_register.Controls.Add(lblFirstName_register);
            plRegister_register.Location = new Point(0, 31);
            plRegister_register.Name = "plRegister_register";
            plRegister_register.Size = new Size(863, 561);
            plRegister_register.TabIndex = 8;
            // 
            // parrotButtonImage_register
            // 
            parrotButtonImage_register.BackgroundColor = Color.FromArgb(255, 255, 255);
            parrotButtonImage_register.ButtonImage = Properties.Resources.MiImage;
            parrotButtonImage_register.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            parrotButtonImage_register.ButtonText = "Ajouter un photo";
            parrotButtonImage_register.ClickBackColor = Color.FromArgb(195, 195, 195);
            parrotButtonImage_register.ClickTextColor = Color.DodgerBlue;
            parrotButtonImage_register.CornerRadius = 5;
            parrotButtonImage_register.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotButtonImage_register.Horizontal_Alignment = StringAlignment.Center;
            parrotButtonImage_register.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            parrotButtonImage_register.HoverTextColor = Color.DodgerBlue;
            parrotButtonImage_register.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButtonImage_register.Location = new Point(586, 438);
            parrotButtonImage_register.Name = "parrotButtonImage_register";
            parrotButtonImage_register.Size = new Size(169, 25);
            parrotButtonImage_register.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButtonImage_register.TabIndex = 18;
            parrotButtonImage_register.TextColor = Color.Black;
            parrotButtonImage_register.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButtonImage_register.Vertical_Alignment = StringAlignment.Center;
            parrotButtonImage_register.Click += parrotButtonImage_register_Click;
            // 
            // pictureBoxRegister_register
            // 
            pictureBoxRegister_register.Image = Properties.Resources.MiImage;
            pictureBoxRegister_register.Location = new Point(355, 24);
            pictureBoxRegister_register.Name = "pictureBoxRegister_register";
            pictureBoxRegister_register.Size = new Size(194, 160);
            pictureBoxRegister_register.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRegister_register.TabIndex = 17;
            pictureBoxRegister_register.TabStop = false;
            // 
            // checkBoxUnhide_register
            // 
            checkBoxUnhide_register.AutoSize = true;
            checkBoxUnhide_register.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            checkBoxUnhide_register.Location = new Point(586, 384);
            checkBoxUnhide_register.Name = "checkBoxUnhide_register";
            checkBoxUnhide_register.Size = new Size(93, 27);
            checkBoxUnhide_register.TabIndex = 16;
            checkBoxUnhide_register.Text = "Afficher";
            checkBoxUnhide_register.UseVisualStyleBackColor = true;
            checkBoxUnhide_register.CheckStateChanged += checkBoxUnhide_register_CheckStateChanged;
            // 
            // btnRegister_register
            // 
            btnRegister_register.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister_register.Location = new Point(355, 478);
            btnRegister_register.Name = "btnRegister_register";
            btnRegister_register.Size = new Size(181, 29);
            btnRegister_register.TabIndex = 15;
            btnRegister_register.Text = "Envoyer";
            btnRegister_register.UseVisualStyleBackColor = true;
            btnRegister_register.Click += btnRegister_register_Click;
            // 
            // txtPasswordConfrim_register
            // 
            txtPasswordConfrim_register.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPasswordConfrim_register.Location = new Point(340, 435);
            txtPasswordConfrim_register.Name = "txtPasswordConfrim_register";
            txtPasswordConfrim_register.PasswordChar = '*';
            txtPasswordConfrim_register.PlaceholderText = "Confrimarion du mot de passe";
            txtPasswordConfrim_register.Size = new Size(231, 28);
            txtPasswordConfrim_register.TabIndex = 13;
            // 
            // lblPasswordConfirm_register
            // 
            lblPasswordConfirm_register.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPasswordConfirm_register.ForeColor = SystemColors.ControlLightLight;
            lblPasswordConfirm_register.Location = new Point(152, 425);
            lblPasswordConfirm_register.Name = "lblPasswordConfirm_register";
            lblPasswordConfirm_register.Size = new Size(182, 43);
            lblPasswordConfirm_register.TabIndex = 12;
            lblPasswordConfirm_register.Text = "Confirmation :";
            lblPasswordConfirm_register.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPasswordRegister_register
            // 
            txtPasswordRegister_register.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPasswordRegister_register.Location = new Point(340, 384);
            txtPasswordRegister_register.Name = "txtPasswordRegister_register";
            txtPasswordRegister_register.PasswordChar = '*';
            txtPasswordRegister_register.PlaceholderText = "Mot de passe";
            txtPasswordRegister_register.Size = new Size(231, 28);
            txtPasswordRegister_register.TabIndex = 11;
            // 
            // txtEmail_register
            // 
            txtEmail_register.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail_register.Location = new Point(340, 329);
            txtEmail_register.Name = "txtEmail_register";
            txtEmail_register.PlaceholderText = "Email";
            txtEmail_register.Size = new Size(231, 28);
            txtEmail_register.TabIndex = 10;
            // 
            // txtLastname_register
            // 
            txtLastname_register.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastname_register.Location = new Point(340, 274);
            txtLastname_register.Name = "txtLastname_register";
            txtLastname_register.PlaceholderText = "Prenom";
            txtLastname_register.Size = new Size(231, 28);
            txtLastname_register.TabIndex = 9;
            // 
            // lblLastname_register
            // 
            lblLastname_register.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastname_register.ForeColor = SystemColors.ControlLightLight;
            lblLastname_register.Location = new Point(167, 264);
            lblLastname_register.Name = "lblLastname_register";
            lblLastname_register.Size = new Size(182, 43);
            lblLastname_register.TabIndex = 8;
            lblLastname_register.Text = "Prenom(s) :";
            lblLastname_register.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmail_register
            // 
            lblEmail_register.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail_register.ForeColor = SystemColors.ControlLightLight;
            lblEmail_register.Location = new Point(248, 319);
            lblEmail_register.Name = "lblEmail_register";
            lblEmail_register.Size = new Size(182, 43);
            lblEmail_register.TabIndex = 7;
            lblEmail_register.Text = "Email :";
            lblEmail_register.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPasswordRegister_register
            // 
            lblPasswordRegister_register.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPasswordRegister_register.ForeColor = SystemColors.ControlLightLight;
            lblPasswordRegister_register.Location = new Point(167, 374);
            lblPasswordRegister_register.Name = "lblPasswordRegister_register";
            lblPasswordRegister_register.Size = new Size(182, 43);
            lblPasswordRegister_register.TabIndex = 6;
            lblPasswordRegister_register.Text = "Mot de passe :";
            lblPasswordRegister_register.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFirstname_register
            // 
            txtFirstname_register.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstname_register.Location = new Point(340, 217);
            txtFirstname_register.Name = "txtFirstname_register";
            txtFirstname_register.PlaceholderText = "Nom";
            txtFirstname_register.Size = new Size(231, 28);
            txtFirstname_register.TabIndex = 5;
            // 
            // lblFirstName_register
            // 
            lblFirstName_register.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName_register.ForeColor = SystemColors.ControlLightLight;
            lblFirstName_register.Location = new Point(258, 207);
            lblFirstName_register.Name = "lblFirstName_register";
            lblFirstName_register.Size = new Size(182, 43);
            lblFirstName_register.TabIndex = 3;
            lblFirstName_register.Text = "Nom :";
            lblFirstName_register.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // menuStripRegister
            // 
            menuStripRegister.ImageScalingSize = new Size(20, 20);
            menuStripRegister.Items.AddRange(new ToolStripItem[] { mstLogin_register, mstExit_register });
            menuStripRegister.Location = new Point(0, 0);
            menuStripRegister.Name = "menuStripRegister";
            menuStripRegister.Size = new Size(863, 36);
            menuStripRegister.TabIndex = 9;
            // 
            // mstLogin_register
            // 
            mstLogin_register.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mstLogin_register.Name = "mstLogin_register";
            mstLogin_register.Size = new Size(144, 32);
            mstLogin_register.Text = "Se connecter";
            mstLogin_register.Click += mstLogin_register_Click;
            // 
            // mstExit_register
            // 
            mstExit_register.BackColor = Color.Red;
            mstExit_register.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mstExit_register.ForeColor = SystemColors.ButtonFace;
            mstExit_register.Name = "mstExit_register";
            mstExit_register.Size = new Size(39, 32);
            mstExit_register.Text = "X";
            mstExit_register.Click += mstExit_register_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            errorProvider.Icon = (Icon)resources.GetObject("errorProvider.Icon");
            // 
            // formRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(863, 591);
            Controls.Add(menuStripRegister);
            Controls.Add(plRegister_register);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += formRegister_Load;
            plRegister_register.ResumeLayout(false);
            plRegister_register.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRegister_register).EndInit();
            menuStripRegister.ResumeLayout(false);
            menuStripRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel plRegister_register;
        private Button btnRegister_register;
        private TextBox txtPasswordConfrim_register;
        private Label lblPasswordConfirm_register;
        private TextBox txtPasswordRegister_register;
        private TextBox txtEmail_register;
        private TextBox txtLastname_register;
        private Label lblLastname_register;
        private Label lblEmail_register;
        private Label lblPasswordRegister_register;
        private TextBox txtFirstname_register;
        private Label lblFirstName_register;
        private MenuStrip menuStripRegister;
        private ToolStripMenuItem mstLogin_register;
        private ToolStripMenuItem mstExit_register;
        private CheckBox checkBoxUnhide_register;
        private PictureBox pictureBoxRegister_register;
        private ReaLTaiizor.Controls.ParrotButton parrotButtonImage_register;
        private ErrorProvider errorProvider;
    }
}