namespace reseau_sociaux
{
    partial class PublicationControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            lblPublication_header = new Label();
            plComment_header = new Panel();
            btnSupprimerPublication = new Button();
            lblPublicationId = new Label();
            pictureBoxPublication_header = new PictureBox();
            plComment_footer = new Panel();
            parrotButtonComment_publication = new ReaLTaiizor.Controls.ParrotButton();
            parrotButtonReaction_publication = new ReaLTaiizor.Controls.ParrotButton();
            pictureBoxPublication_main = new PictureBox();
            plTextPublication = new Panel();
            lblTextPublication = new Label();
            plComment_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPublication_header).BeginInit();
            plComment_footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPublication_main).BeginInit();
            plTextPublication.SuspendLayout();
            SuspendLayout();
            // 
            // lblPublication_header
            // 
            lblPublication_header.AutoSize = true;
            lblPublication_header.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPublication_header.Location = new Point(99, 26);
            lblPublication_header.Name = "lblPublication_header";
            lblPublication_header.Size = new Size(53, 23);
            lblPublication_header.TabIndex = 0;
            lblPublication_header.Text = "label1";
            // 
            // plComment_header
            // 
            plComment_header.Controls.Add(btnSupprimerPublication);
            plComment_header.Controls.Add(lblPublicationId);
            plComment_header.Controls.Add(pictureBoxPublication_header);
            plComment_header.Controls.Add(lblPublication_header);
            plComment_header.Location = new Point(3, 3);
            plComment_header.Name = "plComment_header";
            plComment_header.Size = new Size(473, 70);
            plComment_header.TabIndex = 1;
            // 
            // btnSupprimerPublication
            // 
            btnSupprimerPublication.BackColor = Color.Red;
            btnSupprimerPublication.FlatAppearance.BorderColor = Color.Red;
            btnSupprimerPublication.FlatStyle = FlatStyle.Flat;
            btnSupprimerPublication.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupprimerPublication.ForeColor = SystemColors.ButtonFace;
            btnSupprimerPublication.Location = new Point(426, 18);
            btnSupprimerPublication.Name = "btnSupprimerPublication";
            btnSupprimerPublication.Size = new Size(44, 31);
            btnSupprimerPublication.TabIndex = 3;
            btnSupprimerPublication.Text = "X";
            btnSupprimerPublication.UseVisualStyleBackColor = false;
            btnSupprimerPublication.Visible = false;
            btnSupprimerPublication.Click += btnSupprimerPublication_Click;
            // 
            // lblPublicationId
            // 
            lblPublicationId.AutoSize = true;
            lblPublicationId.Location = new Point(158, 29);
            lblPublicationId.Name = "lblPublicationId";
            lblPublicationId.Size = new Size(50, 20);
            lblPublicationId.TabIndex = 2;
            lblPublicationId.Text = "label1";
            lblPublicationId.Visible = false;
            // 
            // pictureBoxPublication_header
            // 
            pictureBoxPublication_header.Location = new Point(22, 3);
            pictureBoxPublication_header.Name = "pictureBoxPublication_header";
            pictureBoxPublication_header.Size = new Size(60, 60);
            pictureBoxPublication_header.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPublication_header.TabIndex = 1;
            pictureBoxPublication_header.TabStop = false;
            // 
            // plComment_footer
            // 
            plComment_footer.Controls.Add(parrotButtonComment_publication);
            plComment_footer.Controls.Add(parrotButtonReaction_publication);
            plComment_footer.Location = new Point(0, 564);
            plComment_footer.Name = "plComment_footer";
            plComment_footer.Size = new Size(476, 72);
            plComment_footer.TabIndex = 2;
            // 
            // parrotButtonComment_publication
            // 
            parrotButtonComment_publication.BackgroundColor = SystemColors.ButtonFace;
            parrotButtonComment_publication.ButtonImage = Properties.Resources.comment;
            parrotButtonComment_publication.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            parrotButtonComment_publication.ButtonText = "Commantaire";
            parrotButtonComment_publication.ClickBackColor = Color.FromArgb(195, 195, 195);
            parrotButtonComment_publication.ClickTextColor = Color.DodgerBlue;
            parrotButtonComment_publication.CornerRadius = 5;
            parrotButtonComment_publication.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotButtonComment_publication.Horizontal_Alignment = StringAlignment.Center;
            parrotButtonComment_publication.HoverBackgroundColor = Color.Blue;
            parrotButtonComment_publication.HoverTextColor = Color.Azure;
            parrotButtonComment_publication.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButtonComment_publication.Location = new Point(269, 17);
            parrotButtonComment_publication.Name = "parrotButtonComment_publication";
            parrotButtonComment_publication.Size = new Size(185, 48);
            parrotButtonComment_publication.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButtonComment_publication.TabIndex = 1;
            parrotButtonComment_publication.TextColor = Color.FromArgb(64, 64, 64);
            parrotButtonComment_publication.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButtonComment_publication.Vertical_Alignment = StringAlignment.Center;
            parrotButtonComment_publication.Click += parrotButtonComment_publication_Click;
            // 
            // parrotButtonReaction_publication
            // 
            parrotButtonReaction_publication.BackgroundColor = SystemColors.ButtonFace;
            parrotButtonReaction_publication.ButtonImage = Properties.Resources.feedback;
            parrotButtonReaction_publication.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            parrotButtonReaction_publication.ButtonText = "J'aime";
            parrotButtonReaction_publication.ClickBackColor = Color.FromArgb(195, 195, 195);
            parrotButtonReaction_publication.ClickTextColor = Color.DodgerBlue;
            parrotButtonReaction_publication.CornerRadius = 5;
            parrotButtonReaction_publication.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotButtonReaction_publication.Horizontal_Alignment = StringAlignment.Center;
            parrotButtonReaction_publication.HoverBackgroundColor = Color.Blue;
            parrotButtonReaction_publication.HoverTextColor = Color.Azure;
            parrotButtonReaction_publication.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButtonReaction_publication.Location = new Point(37, 17);
            parrotButtonReaction_publication.Name = "parrotButtonReaction_publication";
            parrotButtonReaction_publication.Size = new Size(185, 48);
            parrotButtonReaction_publication.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButtonReaction_publication.TabIndex = 0;
            parrotButtonReaction_publication.TextColor = Color.FromArgb(64, 64, 64);
            parrotButtonReaction_publication.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButtonReaction_publication.Vertical_Alignment = StringAlignment.Center;
            parrotButtonReaction_publication.Click += parrotButtonReaction_publication_Click;
            // 
            // pictureBoxPublication_main
            // 
            pictureBoxPublication_main.BackColor = SystemColors.ButtonShadow;
            pictureBoxPublication_main.Location = new Point(3, 136);
            pictureBoxPublication_main.Name = "pictureBoxPublication_main";
            pictureBoxPublication_main.Size = new Size(468, 422);
            pictureBoxPublication_main.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPublication_main.TabIndex = 3;
            pictureBoxPublication_main.TabStop = false;
            pictureBoxPublication_main.Click += pictureBoxPublication_main_Click;
            // 
            // plTextPublication
            // 
            plTextPublication.Controls.Add(lblTextPublication);
            plTextPublication.Location = new Point(3, 79);
            plTextPublication.Name = "plTextPublication";
            plTextPublication.Size = new Size(650, 58);
            plTextPublication.TabIndex = 4;
            // 
            // lblTextPublication
            // 
            lblTextPublication.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextPublication.Location = new Point(3, 0);
            lblTextPublication.Name = "lblTextPublication";
            lblTextPublication.Size = new Size(470, 54);
            lblTextPublication.TabIndex = 1;
            lblTextPublication.Text = "label1";
            // 
            // PublicationControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(plTextPublication);
            Controls.Add(pictureBoxPublication_main);
            Controls.Add(plComment_footer);
            Controls.Add(plComment_header);
            Name = "PublicationControl";
            Size = new Size(476, 642);
            Load += PublicationControl_Load;
            plComment_header.ResumeLayout(false);
            plComment_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPublication_header).EndInit();
            plComment_footer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxPublication_main).EndInit();
            plTextPublication.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblPublication_header;
        private Panel plComment_header;
        private Panel plComment_footer;
        private PictureBox pictureBoxPublication_main;
        private ReaLTaiizor.Controls.ParrotButton parrotButtonComment_publication;
        private ReaLTaiizor.Controls.ParrotButton parrotButtonReaction_publication;
        private PictureBox pictureBoxPublication_header;
        private Panel plTextPublication;
        private Label lblTextPublication;
        private Label lblPublicationId;
        private Button btnSupprimerPublication;
    }
}
