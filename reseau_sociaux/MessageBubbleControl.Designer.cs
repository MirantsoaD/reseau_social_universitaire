namespace reseau_sociaux
{
    partial class MessageBubbleControl
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
            lblContent = new Label();
            lblTime = new Label();
            SuspendLayout();
            // 
            // lblContent
            // 
            lblContent.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContent.Location = new Point(3, 0);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(426, 54);
            lblContent.TabIndex = 0;
            lblContent.Text = "label1";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(445, 54);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(53, 23);
            lblTime.TabIndex = 1;
            lblTime.Text = "label1";
            // 
            // MessageBubbleControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(lblTime);
            Controls.Add(lblContent);
            Name = "MessageBubbleControl";
            Size = new Size(501, 77);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContent;
        private Label lblTime;
    }
}
