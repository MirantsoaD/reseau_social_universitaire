namespace reseau_sociaux
{
    partial class CommentBubble
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
            pictureBoxUserComment = new PictureBox();
            lblComment = new Label();
            plComment = new Panel();
            lblTime = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUserComment).BeginInit();
            plComment.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxUserComment
            // 
            pictureBoxUserComment.Location = new Point(23, 17);
            pictureBoxUserComment.Name = "pictureBoxUserComment";
            pictureBoxUserComment.Size = new Size(60, 62);
            pictureBoxUserComment.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUserComment.TabIndex = 0;
            pictureBoxUserComment.TabStop = false;
            // 
            // lblComment
            // 
            lblComment.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComment.Location = new Point(101, 17);
            lblComment.Name = "lblComment";
            lblComment.Size = new Size(524, 54);
            lblComment.TabIndex = 1;
            lblComment.Text = "Commentaire";
            lblComment.Click += lblComment_Click;
            // 
            // plComment
            // 
            plComment.BackColor = SystemColors.ControlLight;
            plComment.Controls.Add(lblTime);
            plComment.Controls.Add(pictureBoxUserComment);
            plComment.Controls.Add(lblComment);
            plComment.Location = new Point(0, 0);
            plComment.Name = "plComment";
            plComment.Size = new Size(637, 95);
            plComment.TabIndex = 2;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.ForeColor = SystemColors.ActiveCaption;
            lblTime.Location = new Point(462, 71);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(50, 20);
            lblTime.TabIndex = 2;
            lblTime.Text = "label1";
            // 
            // CommentBubble
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            Controls.Add(plComment);
            Name = "CommentBubble";
            Size = new Size(637, 95);
            Load += CommentBubble_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxUserComment).EndInit();
            plComment.ResumeLayout(false);
            plComment.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxUserComment;
        private Label lblComment;
        private Panel plComment;
        private Label lblTime;
    }
}
