namespace reseau_sociaux
{
    partial class GroupMessageBubbleControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
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
            lblSender = new Label();
            lblContent = new Label();
            lblTime = new Label();
            SuspendLayout();
            // 
            // lblSender
            // 
            lblSender.AutoSize = true;
            lblSender.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSender.Location = new Point(10, 4);
            lblSender.Name = "lblSender";
            lblSender.Size = new Size(50, 23);
            lblSender.TabIndex = 0;
            lblSender.Text = "Nom";
            // 
            // lblContent
            // 
            lblContent.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContent.Location = new Point(10, 26);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(320, 40);
            lblContent.TabIndex = 1;
            lblContent.Text = "Message";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.Gray;
            lblTime.Location = new Point(280, 70);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(40, 20);
            lblTime.TabIndex = 2;
            lblTime.Text = "12:34";
            // 
            // GroupMessageBubbleControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 230, 230);
            Controls.Add(lblTime);
            Controls.Add(lblContent);
            Controls.Add(lblSender);
            Name = "GroupMessageBubbleControl";
            Size = new Size(340, 100);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSender;
        private Label lblContent;
        private Label lblTime;
    }
}
