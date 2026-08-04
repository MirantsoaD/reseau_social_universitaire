namespace reseau_sociaux
{
    partial class FormGroupe
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
            plLeft = new Panel();
            lblSectionCreer = new Label();
            bigTextBoxNom = new ReaLTaiizor.Controls.BigTextBox();
            bigTextBoxDescription = new ReaLTaiizor.Controls.BigTextBox();
            parrotButtonCreer = new ReaLTaiizor.Controls.ParrotButton();
            lblMesGroupes = new Label();
            listBoxGroupes = new ListBox();
            plRight = new Panel();
            lblGroupeNom = new Label();
            lblCreateur = new Label();
            lblMembreCount = new Label();
            lblMonRole = new Label();
            lblMembres = new Label();
            listBoxMembres = new ListBox();
            lblInviter = new Label();
            comboBoxInviter = new ComboBox();
            parrotButtonInviter = new ReaLTaiizor.Controls.ParrotButton();
            plLeft.SuspendLayout();
            plRight.SuspendLayout();
            SuspendLayout();
            // 
            // plLeft
            // 
            plLeft.BackColor = Color.White;
            plLeft.Controls.Add(lblSectionCreer);
            plLeft.Controls.Add(bigTextBoxNom);
            plLeft.Controls.Add(bigTextBoxDescription);
            plLeft.Controls.Add(parrotButtonCreer);
            plLeft.Controls.Add(lblMesGroupes);
            plLeft.Controls.Add(listBoxGroupes);
            plLeft.Location = new Point(12, 12);
            plLeft.Name = "plLeft";
            plLeft.Size = new Size(316, 576);
            plLeft.TabIndex = 0;
            // 
            // lblSectionCreer
            // 
            lblSectionCreer.AutoSize = true;
            lblSectionCreer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSectionCreer.ForeColor = Color.FromArgb(64, 64, 64);
            lblSectionCreer.Location = new Point(16, 14);
            lblSectionCreer.Name = "lblSectionCreer";
            lblSectionCreer.Size = new Size(146, 28);
            lblSectionCreer.TabIndex = 0;
            lblSectionCreer.Text = "Créer un groupe";
            // 
            // bigTextBoxNom
            // 
            bigTextBoxNom.BackColor = Color.White;
            bigTextBoxNom.Font = new Font("Tahoma", 11F);
            bigTextBoxNom.ForeColor = Color.DimGray;
            bigTextBoxNom.Image = null;
            bigTextBoxNom.Location = new Point(16, 50);
            bigTextBoxNom.MaxLength = 100;
            bigTextBoxNom.Multiline = false;
            bigTextBoxNom.Name = "bigTextBoxNom";
            bigTextBoxNom.PlaceholderText = "Nom du groupe";
            bigTextBoxNom.ReadOnly = false;
            bigTextBoxNom.Size = new Size(284, 46);
            bigTextBoxNom.TabIndex = 1;
            bigTextBoxNom.TextAlignment = HorizontalAlignment.Left;
            bigTextBoxNom.UseSystemPasswordChar = false;
            // 
            // bigTextBoxDescription
            // 
            bigTextBoxDescription.BackColor = Color.White;
            bigTextBoxDescription.Font = new Font("Tahoma", 11F);
            bigTextBoxDescription.ForeColor = Color.DimGray;
            bigTextBoxDescription.Image = null;
            bigTextBoxDescription.Location = new Point(16, 104);
            bigTextBoxDescription.MaxLength = 500;
            bigTextBoxDescription.Multiline = true;
            bigTextBoxDescription.Name = "bigTextBoxDescription";
            bigTextBoxDescription.PlaceholderText = "Description (facultatif)";
            bigTextBoxDescription.ReadOnly = false;
            bigTextBoxDescription.Size = new Size(284, 66);
            bigTextBoxDescription.TabIndex = 2;
            bigTextBoxDescription.TextAlignment = HorizontalAlignment.Left;
            bigTextBoxDescription.UseSystemPasswordChar = false;
            // 
            // parrotButtonCreer
            // 
            parrotButtonCreer.BackgroundColor = Color.FromArgb(255, 255, 255);
            parrotButtonCreer.ButtonImage = null;
            parrotButtonCreer.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            parrotButtonCreer.ButtonText = "Créer le groupe";
            parrotButtonCreer.ClickBackColor = Color.FromArgb(195, 195, 195);
            parrotButtonCreer.ClickTextColor = Color.DodgerBlue;
            parrotButtonCreer.CornerRadius = 5;
            parrotButtonCreer.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotButtonCreer.Horizontal_Alignment = StringAlignment.Center;
            parrotButtonCreer.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            parrotButtonCreer.HoverTextColor = Color.DodgerBlue;
            parrotButtonCreer.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButtonCreer.Location = new Point(16, 186);
            parrotButtonCreer.Name = "parrotButtonCreer";
            parrotButtonCreer.Size = new Size(160, 36);
            parrotButtonCreer.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButtonCreer.TabIndex = 3;
            parrotButtonCreer.TextColor = Color.FromArgb(64, 64, 64);
            parrotButtonCreer.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButtonCreer.Vertical_Alignment = StringAlignment.Center;
            parrotButtonCreer.Click += parrotButtonCreer_Click;
            // 
            // lblMesGroupes
            // 
            lblMesGroupes.AutoSize = true;
            lblMesGroupes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMesGroupes.ForeColor = Color.FromArgb(64, 64, 64);
            lblMesGroupes.Location = new Point(16, 244);
            lblMesGroupes.Name = "lblMesGroupes";
            lblMesGroupes.Size = new Size(106, 28);
            lblMesGroupes.TabIndex = 4;
            lblMesGroupes.Text = "Mes Groupes";
            // 
            // listBoxGroupes
            // 
            listBoxGroupes.BorderStyle = BorderStyle.FixedSingle;
            listBoxGroupes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxGroupes.IntegralHeight = false;
            listBoxGroupes.ItemHeight = 22;
            listBoxGroupes.Location = new Point(16, 280);
            listBoxGroupes.Name = "listBoxGroupes";
            listBoxGroupes.Size = new Size(284, 280);
            listBoxGroupes.TabIndex = 5;
            listBoxGroupes.SelectedIndexChanged += listBoxGroupes_SelectedIndexChanged;
            // 
            // plRight
            // 
            plRight.BackColor = Color.White;
            plRight.Controls.Add(lblGroupeNom);
            plRight.Controls.Add(lblCreateur);
            plRight.Controls.Add(lblMembreCount);
            plRight.Controls.Add(lblMonRole);
            plRight.Controls.Add(lblMembres);
            plRight.Controls.Add(listBoxMembres);
            plRight.Controls.Add(lblInviter);
            plRight.Controls.Add(comboBoxInviter);
            plRight.Controls.Add(parrotButtonInviter);
            plRight.Location = new Point(340, 12);
            plRight.Name = "plRight";
            plRight.Size = new Size(548, 576);
            plRight.TabIndex = 1;
            // 
            // lblGroupeNom
            // 
            lblGroupeNom.AutoEllipsis = true;
            lblGroupeNom.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGroupeNom.ForeColor = Color.FromArgb(30, 132, 73);
            lblGroupeNom.Location = new Point(16, 14);
            lblGroupeNom.Name = "lblGroupeNom";
            lblGroupeNom.Size = new Size(516, 34);
            lblGroupeNom.TabIndex = 0;
            lblGroupeNom.Text = "Aucun groupe sélectionné";
            lblGroupeNom.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCreateur
            // 
            lblCreateur.AutoSize = true;
            lblCreateur.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCreateur.ForeColor = Color.FromArgb(64, 64, 64);
            lblCreateur.Location = new Point(16, 54);
            lblCreateur.Name = "lblCreateur";
            lblCreateur.Size = new Size(100, 25);
            lblCreateur.TabIndex = 1;
            lblCreateur.Text = "Créé par ...";
            // 
            // lblMembreCount
            // 
            lblMembreCount.AutoSize = true;
            lblMembreCount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMembreCount.ForeColor = Color.FromArgb(64, 64, 64);
            lblMembreCount.Location = new Point(16, 80);
            lblMembreCount.Name = "lblMembreCount";
            lblMembreCount.Size = new Size(100, 25);
            lblMembreCount.TabIndex = 2;
            lblMembreCount.Text = "0 membre";
            // 
            // lblMonRole
            // 
            lblMonRole.AutoSize = true;
            lblMonRole.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonRole.ForeColor = Color.DodgerBlue;
            lblMonRole.Location = new Point(16, 106);
            lblMonRole.Name = "lblMonRole";
            lblMonRole.Size = new Size(100, 25);
            lblMonRole.TabIndex = 3;
            lblMonRole.Text = "Votre rôle : ...";
            lblMonRole.Visible = false;
            // 
            // lblMembres
            // 
            lblMembres.AutoSize = true;
            lblMembres.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMembres.ForeColor = Color.FromArgb(64, 64, 64);
            lblMembres.Location = new Point(16, 136);
            lblMembres.Name = "lblMembres";
            lblMembres.Size = new Size(83, 25);
            lblMembres.TabIndex = 4;
            lblMembres.Text = "Membres";
            // 
            // listBoxMembres
            // 
            listBoxMembres.BorderStyle = BorderStyle.FixedSingle;
            listBoxMembres.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxMembres.IntegralHeight = false;
            listBoxMembres.ItemHeight = 22;
            listBoxMembres.Location = new Point(16, 166);
            listBoxMembres.Name = "listBoxMembres";
            listBoxMembres.Size = new Size(516, 296);
            listBoxMembres.TabIndex = 5;
            // 
            // lblInviter
            // 
            lblInviter.AutoSize = true;
            lblInviter.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInviter.ForeColor = Color.FromArgb(64, 64, 64);
            lblInviter.Location = new Point(16, 476);
            lblInviter.Name = "lblInviter";
            lblInviter.Size = new Size(158, 25);
            lblInviter.TabIndex = 6;
            lblInviter.Text = "Inviter un membre";
            lblInviter.Visible = false;
            // 
            // comboBoxInviter
            // 
            comboBoxInviter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxInviter.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxInviter.FormattingEnabled = true;
            comboBoxInviter.Location = new Point(16, 508);
            comboBoxInviter.Name = "comboBoxInviter";
            comboBoxInviter.Size = new Size(356, 29);
            comboBoxInviter.TabIndex = 7;
            comboBoxInviter.Visible = false;
            // 
            // parrotButtonInviter
            // 
            parrotButtonInviter.BackgroundColor = Color.FromArgb(255, 255, 255);
            parrotButtonInviter.ButtonImage = null;
            parrotButtonInviter.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            parrotButtonInviter.ButtonText = "Inviter";
            parrotButtonInviter.ClickBackColor = Color.FromArgb(195, 195, 195);
            parrotButtonInviter.ClickTextColor = Color.DodgerBlue;
            parrotButtonInviter.CornerRadius = 5;
            parrotButtonInviter.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotButtonInviter.Horizontal_Alignment = StringAlignment.Center;
            parrotButtonInviter.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            parrotButtonInviter.HoverTextColor = Color.DodgerBlue;
            parrotButtonInviter.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButtonInviter.Location = new Point(380, 506);
            parrotButtonInviter.Name = "parrotButtonInviter";
            parrotButtonInviter.Size = new Size(120, 36);
            parrotButtonInviter.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButtonInviter.TabIndex = 8;
            parrotButtonInviter.TextColor = Color.FromArgb(64, 64, 64);
            parrotButtonInviter.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButtonInviter.Vertical_Alignment = StringAlignment.Center;
            parrotButtonInviter.Visible = false;
            parrotButtonInviter.Click += parrotButtonInviter_Click;
            // 
            // FormGroupe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(900, 600);
            Controls.Add(plRight);
            Controls.Add(plLeft);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(900, 600);
            Name = "FormGroupe";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Groupes";
            Load += FormGroupe_Load;
            plLeft.ResumeLayout(false);
            plLeft.PerformLayout();
            plRight.ResumeLayout(false);
            plRight.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel plLeft;
        private Label lblSectionCreer;
        private ReaLTaiizor.Controls.BigTextBox bigTextBoxNom;
        private ReaLTaiizor.Controls.BigTextBox bigTextBoxDescription;
        private ReaLTaiizor.Controls.ParrotButton parrotButtonCreer;
        private Label lblMesGroupes;
        private ListBox listBoxGroupes;
        private Panel plRight;
        private Label lblGroupeNom;
        private Label lblCreateur;
        private Label lblMembreCount;
        private Label lblMonRole;
        private Label lblMembres;
        private ListBox listBoxMembres;
        private Label lblInviter;
        private ComboBox comboBoxInviter;
        private ReaLTaiizor.Controls.ParrotButton parrotButtonInviter;
    }
}