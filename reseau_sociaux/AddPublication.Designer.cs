namespace reseau_sociaux
{
    partial class AddPublication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPublication));
            plContainer = new Panel();
            parrotButtonExit = new ReaLTaiizor.Controls.ParrotButton();
            parrotButtonAddImage = new ReaLTaiizor.Controls.ParrotButton();
            pictureBoxPublication = new PictureBox();
            lblPublication = new Label();
            plLegendeContainer = new Panel();
            lblCommentDescriprion = new Label();
            bigTextBoxLegende = new ReaLTaiizor.Controls.BigTextBox();
            parrotButtonSave = new ReaLTaiizor.Controls.ParrotButton();
            errorProvider = new ErrorProvider(components);
            plContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPublication).BeginInit();
            plLegendeContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // plContainer
            // 
            plContainer.BackColor = Color.FromArgb(64, 70, 40);
            plContainer.Controls.Add(parrotButtonExit);
            plContainer.Controls.Add(parrotButtonAddImage);
            plContainer.Controls.Add(pictureBoxPublication);
            plContainer.Controls.Add(lblPublication);
            plContainer.Controls.Add(plLegendeContainer);
            plContainer.Controls.Add(parrotButtonSave);
            plContainer.Location = new Point(1, 3);
            plContainer.Name = "plContainer";
            plContainer.Size = new Size(707, 602);
            plContainer.TabIndex = 0;
            // 
            // parrotButtonExit
            // 
            parrotButtonExit.BackgroundColor = SystemColors.ButtonFace;
            parrotButtonExit.ButtonImage = Properties.Resources.MiArrowLeft;
            parrotButtonExit.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            parrotButtonExit.ButtonText = "Retour";
            parrotButtonExit.ClickBackColor = Color.FromArgb(195, 195, 195);
            parrotButtonExit.ClickTextColor = Color.Red;
            parrotButtonExit.CornerRadius = 5;
            parrotButtonExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotButtonExit.Horizontal_Alignment = StringAlignment.Center;
            parrotButtonExit.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            parrotButtonExit.HoverTextColor = Color.Red;
            parrotButtonExit.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButtonExit.Location = new Point(11, 551);
            parrotButtonExit.Name = "parrotButtonExit";
            parrotButtonExit.Size = new Size(136, 39);
            parrotButtonExit.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButtonExit.TabIndex = 6;
            parrotButtonExit.TextColor = Color.FromArgb(64, 64, 64);
            parrotButtonExit.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButtonExit.Vertical_Alignment = StringAlignment.Center;
            parrotButtonExit.Click += parrotButtonExit_Click;
            // 
            // parrotButtonAddImage
            // 
            parrotButtonAddImage.BackgroundColor = SystemColors.ButtonFace;
            parrotButtonAddImage.ButtonImage = Properties.Resources.MiImage;
            parrotButtonAddImage.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            parrotButtonAddImage.ButtonText = "Ajouter une image";
            parrotButtonAddImage.ClickBackColor = Color.FromArgb(195, 195, 195);
            parrotButtonAddImage.ClickTextColor = Color.DodgerBlue;
            parrotButtonAddImage.CornerRadius = 5;
            parrotButtonAddImage.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotButtonAddImage.Horizontal_Alignment = StringAlignment.Center;
            parrotButtonAddImage.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            parrotButtonAddImage.HoverTextColor = Color.DodgerBlue;
            parrotButtonAddImage.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButtonAddImage.Location = new Point(495, 558);
            parrotButtonAddImage.Name = "parrotButtonAddImage";
            parrotButtonAddImage.Size = new Size(201, 32);
            parrotButtonAddImage.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButtonAddImage.TabIndex = 5;
            parrotButtonAddImage.TextColor = Color.FromArgb(64, 64, 64);
            parrotButtonAddImage.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButtonAddImage.Vertical_Alignment = StringAlignment.Center;
            parrotButtonAddImage.Click += parrotButtonAddImage_Click;
            // 
            // pictureBoxPublication
            // 
            pictureBoxPublication.Location = new Point(3, 49);
            pictureBoxPublication.Name = "pictureBoxPublication";
            pictureBoxPublication.Size = new Size(701, 407);
            pictureBoxPublication.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPublication.TabIndex = 4;
            pictureBoxPublication.TabStop = false;
            // 
            // lblPublication
            // 
            lblPublication.AutoSize = true;
            lblPublication.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPublication.ForeColor = SystemColors.ButtonFace;
            lblPublication.Location = new Point(275, 6);
            lblPublication.Name = "lblPublication";
            lblPublication.Size = new Size(143, 31);
            lblPublication.TabIndex = 3;
            lblPublication.Text = "Publication ";
            // 
            // plLegendeContainer
            // 
            plLegendeContainer.Controls.Add(lblCommentDescriprion);
            plLegendeContainer.Controls.Add(bigTextBoxLegende);
            plLegendeContainer.Location = new Point(3, 462);
            plLegendeContainer.Name = "plLegendeContainer";
            plLegendeContainer.Size = new Size(704, 69);
            plLegendeContainer.TabIndex = 1;
            // 
            // lblCommentDescriprion
            // 
            lblCommentDescriprion.AutoSize = true;
            lblCommentDescriprion.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCommentDescriprion.ForeColor = SystemColors.ButtonFace;
            lblCommentDescriprion.Location = new Point(8, 20);
            lblCommentDescriprion.Name = "lblCommentDescriprion";
            lblCommentDescriprion.Size = new Size(261, 25);
            lblCommentDescriprion.TabIndex = 1;
            lblCommentDescriprion.Text = "Description de la publication :";
            // 
            // bigTextBoxLegende
            // 
            bigTextBoxLegende.BackColor = SystemColors.ButtonFace;
            bigTextBoxLegende.Font = new Font("Tahoma", 11F);
            bigTextBoxLegende.ForeColor = Color.DimGray;
            bigTextBoxLegende.Image = null;
            bigTextBoxLegende.Location = new Point(272, 20);
            bigTextBoxLegende.MaxLength = 32767;
            bigTextBoxLegende.Multiline = false;
            bigTextBoxLegende.Name = "bigTextBoxLegende";
            bigTextBoxLegende.PlaceholderText = "Taper ici pour la description";
            bigTextBoxLegende.ReadOnly = false;
            bigTextBoxLegende.Size = new Size(259, 46);
            bigTextBoxLegende.TabIndex = 0;
            bigTextBoxLegende.TextAlignment = HorizontalAlignment.Left;
            bigTextBoxLegende.UseSystemPasswordChar = false;
            // 
            // parrotButtonSave
            // 
            parrotButtonSave.BackgroundColor = SystemColors.ButtonFace;
            parrotButtonSave.ButtonImage = null;
            parrotButtonSave.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            parrotButtonSave.ButtonText = "Partager";
            parrotButtonSave.ClickBackColor = Color.FromArgb(195, 195, 195);
            parrotButtonSave.ClickTextColor = Color.DodgerBlue;
            parrotButtonSave.CornerRadius = 5;
            parrotButtonSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotButtonSave.Horizontal_Alignment = StringAlignment.Center;
            parrotButtonSave.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            parrotButtonSave.HoverTextColor = Color.DodgerBlue;
            parrotButtonSave.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButtonSave.Location = new Point(242, 558);
            parrotButtonSave.Name = "parrotButtonSave";
            parrotButtonSave.Size = new Size(221, 32);
            parrotButtonSave.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButtonSave.TabIndex = 0;
            parrotButtonSave.TextColor = Color.FromArgb(64, 64, 64);
            parrotButtonSave.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButtonSave.Vertical_Alignment = StringAlignment.Center;
            parrotButtonSave.Click += parrotButtonSave_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            errorProvider.Icon = (Icon)resources.GetObject("errorProvider.Icon");
            // 
            // AddPublication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 605);
            ControlBox = false;
            Controls.Add(plContainer);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(709, 605);
            Name = "AddPublication";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddPublication";
            plContainer.ResumeLayout(false);
            plContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPublication).EndInit();
            plLegendeContainer.ResumeLayout(false);
            plLegendeContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel plContainer;
        private Panel plLegendeContainer;
        private ReaLTaiizor.Controls.BigTextBox bigTextBoxLegende;
        private ReaLTaiizor.Controls.ParrotButton parrotButtonSave;
        private PictureBox pictureBoxPublication;
        private Label lblPublication;
        private Label lblCommentDescriprion;
        private ReaLTaiizor.Controls.ParrotButton parrotButtonAddImage;
        private ReaLTaiizor.Controls.ParrotButton parrotButtonExit;
        private ErrorProvider errorProvider;
    }
}