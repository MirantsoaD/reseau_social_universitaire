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
            tabControlGroupe = new TabControl();
            tabMembres = new TabPage();
            plInviterRow = new Panel();
            lblInviter = new Label();
            comboBoxInviter = new ComboBox();
            parrotButtonInviter = new ReaLTaiizor.Controls.ParrotButton();
            plActionsMembres = new Panel();
            parrotButtonQuitter = new ReaLTaiizor.Controls.ParrotButton();
            parrotButtonRetirer = new ReaLTaiizor.Controls.ParrotButton();
            parrotButtonSupprimer = new ReaLTaiizor.Controls.ParrotButton();
            listBoxMembres = new ListBox();
            tabDiscussion = new TabPage();
            flowLayoutPanelMessages = new FlowLayoutPanel();
            plComposer = new Panel();
            bigTextBoxMessage = new ReaLTaiizor.Controls.BigTextBox();
            parrotButtonEnvoyer = new ReaLTaiizor.Controls.ParrotButton();
            plLeft.SuspendLayout();
            plRight.SuspendLayout();
            tabControlGroupe.SuspendLayout();
            tabMembres.SuspendLayout();
            plInviterRow.SuspendLayout();
            plActionsMembres.SuspendLayout();
            tabDiscussion.SuspendLayout();
            plComposer.SuspendLayout();
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
            plRight.Controls.Add(tabControlGroupe);
            plRight.Controls.Add(lblMonRole);
            plRight.Controls.Add(lblMembreCount);
            plRight.Controls.Add(lblCreateur);
            plRight.Controls.Add(lblGroupeNom);
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
            // tabControlGroupe
            // 
            tabControlGroupe.Controls.Add(tabMembres);
            tabControlGroupe.Controls.Add(tabDiscussion);
            tabControlGroupe.Location = new Point(16, 140);
            tabControlGroupe.Name = "tabControlGroupe";
            tabControlGroupe.SelectedIndex = 0;
            tabControlGroupe.Size = new Size(516, 420);
            tabControlGroupe.TabIndex = 4;
            // 
            // tabMembres
            // 
            tabMembres.Controls.Add(listBoxMembres);
            tabMembres.Controls.Add(plActionsMembres);
            tabMembres.Controls.Add(plInviterRow);
            tabMembres.Location = new Point(4, 29);
            tabMembres.Name = "tabMembres";
            tabMembres.Padding = new Padding(6);
            tabMembres.Size = new Size(508, 387);
            tabMembres.TabIndex = 0;
            tabMembres.Text = "Membres";
            tabMembres.UseVisualStyleBackColor = true;
            // 
            // plInviterRow
            // 
            plInviterRow.Controls.Add(parrotButtonInviter);
            plInviterRow.Controls.Add(comboBoxInviter);
            plInviterRow.Controls.Add(lblInviter);
            plInviterRow.Dock = DockStyle.Bottom;
            plInviterRow.Location = new Point(6, 293);
            plInviterRow.Name = "plInviterRow";
            plInviterRow.Size = new Size(496, 88);
            plInviterRow.TabIndex = 0;
            plInviterRow.Visible = false;
            // 
            // lblInviter
            // 
            lblInviter.AutoSize = true;
            lblInviter.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInviter.ForeColor = Color.FromArgb(64, 64, 64);
            lblInviter.Location = new Point(4, 2);
            lblInviter.Name = "lblInviter";
            lblInviter.Size = new Size(158, 25);
            lblInviter.TabIndex = 0;
            lblInviter.Text = "Inviter un membre";
            // 
            // comboBoxInviter
            // 
            comboBoxInviter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxInviter.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxInviter.FormattingEnabled = true;
            comboBoxInviter.Location = new Point(4, 32);
            comboBoxInviter.Name = "comboBoxInviter";
            comboBoxInviter.Size = new Size(356, 29);
            comboBoxInviter.TabIndex = 1;
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
            parrotButtonInviter.Location = new Point(368, 30);
            parrotButtonInviter.Name = "parrotButtonInviter";
            parrotButtonInviter.Size = new Size(120, 36);
            parrotButtonInviter.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButtonInviter.TabIndex = 2;
            parrotButtonInviter.TextColor = Color.FromArgb(64, 64, 64);
            parrotButtonInviter.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButtonInviter.Vertical_Alignment = StringAlignment.Center;
            parrotButtonInviter.Click += parrotButtonInviter_Click;
            // 
            // plActionsMembres
            // 
            plActionsMembres.Controls.Add(parrotButtonSupprimer);
            plActionsMembres.Controls.Add(parrotButtonRetirer);
            plActionsMembres.Controls.Add(parrotButtonQuitter);
            plActionsMembres.Dock = DockStyle.Bottom;
            plActionsMembres.Location = new Point(6, 233);
            plActionsMembres.Name = "plActionsMembres";
            plActionsMembres.Size = new Size(496, 48);
            plActionsMembres.TabIndex = 1;
            // 
            // parrotButtonQuitter
            // 
            parrotButtonQuitter.BackgroundColor = Color.FromArgb(255, 255, 255);
            parrotButtonQuitter.ButtonImage = null;
            parrotButtonQuitter.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            parrotButtonQuitter.ButtonText = "Quitter le groupe";
            parrotButtonQuitter.ClickBackColor = Color.FromArgb(195, 195, 195);
            parrotButtonQuitter.ClickTextColor = Color.Red;
            parrotButtonQuitter.CornerRadius = 5;
            parrotButtonQuitter.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotButtonQuitter.Horizontal_Alignment = StringAlignment.Center;
            parrotButtonQuitter.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            parrotButtonQuitter.HoverTextColor = Color.Red;
            parrotButtonQuitter.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButtonQuitter.Location = new Point(4, 6);
            parrotButtonQuitter.Name = "parrotButtonQuitter";
            parrotButtonQuitter.Size = new Size(145, 36);
            parrotButtonQuitter.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButtonQuitter.TabIndex = 0;
            parrotButtonQuitter.TextColor = Color.FromArgb(64, 64, 64);
            parrotButtonQuitter.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButtonQuitter.Vertical_Alignment = StringAlignment.Center;
            parrotButtonQuitter.Visible = false;
            parrotButtonQuitter.Click += parrotButtonQuitter_Click;
            // 
            // parrotButtonRetirer
            // 
            parrotButtonRetirer.BackgroundColor = Color.FromArgb(255, 255, 255);
            parrotButtonRetirer.ButtonImage = null;
            parrotButtonRetirer.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            parrotButtonRetirer.ButtonText = "Retirer le membre";
            parrotButtonRetirer.ClickBackColor = Color.FromArgb(195, 195, 195);
            parrotButtonRetirer.ClickTextColor = Color.Red;
            parrotButtonRetirer.CornerRadius = 5;
            parrotButtonRetirer.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotButtonRetirer.Horizontal_Alignment = StringAlignment.Center;
            parrotButtonRetirer.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            parrotButtonRetirer.HoverTextColor = Color.Red;
            parrotButtonRetirer.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButtonRetirer.Location = new Point(155, 6);
            parrotButtonRetirer.Name = "parrotButtonRetirer";
            parrotButtonRetirer.Size = new Size(155, 36);
            parrotButtonRetirer.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButtonRetirer.TabIndex = 1;
            parrotButtonRetirer.TextColor = Color.FromArgb(64, 64, 64);
            parrotButtonRetirer.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButtonRetirer.Vertical_Alignment = StringAlignment.Center;
            parrotButtonRetirer.Visible = false;
            parrotButtonRetirer.Click += parrotButtonRetirer_Click;
            // 
            // parrotButtonSupprimer
            // 
            parrotButtonSupprimer.BackgroundColor = Color.FromArgb(255, 255, 255);
            parrotButtonSupprimer.ButtonImage = null;
            parrotButtonSupprimer.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            parrotButtonSupprimer.ButtonText = "Supprimer le groupe";
            parrotButtonSupprimer.ClickBackColor = Color.FromArgb(195, 195, 195);
            parrotButtonSupprimer.ClickTextColor = Color.Red;
            parrotButtonSupprimer.CornerRadius = 5;
            parrotButtonSupprimer.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotButtonSupprimer.Horizontal_Alignment = StringAlignment.Center;
            parrotButtonSupprimer.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            parrotButtonSupprimer.HoverTextColor = Color.Red;
            parrotButtonSupprimer.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButtonSupprimer.Location = new Point(316, 6);
            parrotButtonSupprimer.Name = "parrotButtonSupprimer";
            parrotButtonSupprimer.Size = new Size(176, 36);
            parrotButtonSupprimer.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButtonSupprimer.TabIndex = 2;
            parrotButtonSupprimer.TextColor = Color.FromArgb(64, 64, 64);
            parrotButtonSupprimer.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButtonSupprimer.Vertical_Alignment = StringAlignment.Center;
            parrotButtonSupprimer.Visible = false;
            parrotButtonSupprimer.Click += parrotButtonSupprimer_Click;
            // 
            // listBoxMembres
            // 
            listBoxMembres.BorderStyle = BorderStyle.FixedSingle;
            listBoxMembres.Dock = DockStyle.Fill;
            listBoxMembres.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxMembres.IntegralHeight = false;
            listBoxMembres.ItemHeight = 22;
            listBoxMembres.Location = new Point(6, 6);
            listBoxMembres.Name = "listBoxMembres";
            listBoxMembres.Size = new Size(496, 281);
            listBoxMembres.TabIndex = 1;
            // 
            // tabDiscussion
            // 
            tabDiscussion.Controls.Add(flowLayoutPanelMessages);
            tabDiscussion.Controls.Add(plComposer);
            tabDiscussion.Location = new Point(4, 29);
            tabDiscussion.Name = "tabDiscussion";
            tabDiscussion.Padding = new Padding(6);
            tabDiscussion.Size = new Size(508, 387);
            tabDiscussion.TabIndex = 1;
            tabDiscussion.Text = "Discussion";
            tabDiscussion.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelMessages
            // 
            flowLayoutPanelMessages.AutoScroll = true;
            flowLayoutPanelMessages.BackColor = Color.White;
            flowLayoutPanelMessages.Dock = DockStyle.Fill;
            flowLayoutPanelMessages.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelMessages.Location = new Point(6, 6);
            flowLayoutPanelMessages.Name = "flowLayoutPanelMessages";
            flowLayoutPanelMessages.Size = new Size(496, 309);
            flowLayoutPanelMessages.TabIndex = 0;
            flowLayoutPanelMessages.WrapContents = false;
            // 
            // plComposer
            // 
            plComposer.Controls.Add(parrotButtonEnvoyer);
            plComposer.Controls.Add(bigTextBoxMessage);
            plComposer.Dock = DockStyle.Bottom;
            plComposer.Location = new Point(6, 315);
            plComposer.Name = "plComposer";
            plComposer.Size = new Size(496, 66);
            plComposer.TabIndex = 1;
            plComposer.Visible = false;
            // 
            // bigTextBoxMessage
            // 
            bigTextBoxMessage.BackColor = Color.White;
            bigTextBoxMessage.Font = new Font("Tahoma", 11F);
            bigTextBoxMessage.ForeColor = Color.DimGray;
            bigTextBoxMessage.Image = null;
            bigTextBoxMessage.Location = new Point(4, 10);
            bigTextBoxMessage.MaxLength = 2000;
            bigTextBoxMessage.Multiline = false;
            bigTextBoxMessage.Name = "bigTextBoxMessage";
            bigTextBoxMessage.PlaceholderText = "Votre message...";
            bigTextBoxMessage.ReadOnly = false;
            bigTextBoxMessage.Size = new Size(368, 46);
            bigTextBoxMessage.TabIndex = 0;
            bigTextBoxMessage.TextAlignment = HorizontalAlignment.Left;
            bigTextBoxMessage.UseSystemPasswordChar = false;
            // 
            // parrotButtonEnvoyer
            // 
            parrotButtonEnvoyer.BackgroundColor = Color.FromArgb(255, 255, 255);
            parrotButtonEnvoyer.ButtonImage = null;
            parrotButtonEnvoyer.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            parrotButtonEnvoyer.ButtonText = "Envoyer";
            parrotButtonEnvoyer.ClickBackColor = Color.FromArgb(195, 195, 195);
            parrotButtonEnvoyer.ClickTextColor = Color.DodgerBlue;
            parrotButtonEnvoyer.CornerRadius = 5;
            parrotButtonEnvoyer.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotButtonEnvoyer.Horizontal_Alignment = StringAlignment.Center;
            parrotButtonEnvoyer.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            parrotButtonEnvoyer.HoverTextColor = Color.DodgerBlue;
            parrotButtonEnvoyer.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButtonEnvoyer.Location = new Point(380, 14);
            parrotButtonEnvoyer.Name = "parrotButtonEnvoyer";
            parrotButtonEnvoyer.Size = new Size(112, 38);
            parrotButtonEnvoyer.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButtonEnvoyer.TabIndex = 1;
            parrotButtonEnvoyer.TextColor = Color.FromArgb(64, 64, 64);
            parrotButtonEnvoyer.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButtonEnvoyer.Vertical_Alignment = StringAlignment.Center;
            parrotButtonEnvoyer.Click += parrotButtonEnvoyer_Click;
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
            tabControlGroupe.ResumeLayout(false);
            tabMembres.ResumeLayout(false);
            plActionsMembres.ResumeLayout(false);
            plInviterRow.ResumeLayout(false);
            plInviterRow.PerformLayout();
            tabDiscussion.ResumeLayout(false);
            plComposer.ResumeLayout(false);
            plComposer.PerformLayout();
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
        private TabControl tabControlGroupe;
        private TabPage tabMembres;
        private Panel plInviterRow;
        private Label lblInviter;
        private ComboBox comboBoxInviter;
        private ReaLTaiizor.Controls.ParrotButton parrotButtonInviter;
        private Panel plActionsMembres;
        private ReaLTaiizor.Controls.ParrotButton parrotButtonQuitter;
        private ReaLTaiizor.Controls.ParrotButton parrotButtonRetirer;
        private ReaLTaiizor.Controls.ParrotButton parrotButtonSupprimer;
        private ListBox listBoxMembres;
        private TabPage tabDiscussion;
        private FlowLayoutPanel flowLayoutPanelMessages;
        private Panel plComposer;
        private ReaLTaiizor.Controls.BigTextBox bigTextBoxMessage;
        private ReaLTaiizor.Controls.ParrotButton parrotButtonEnvoyer;
    }
}