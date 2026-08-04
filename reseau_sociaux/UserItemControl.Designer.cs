namespace reseau_sociaux
{
    partial class UserItemControl
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
            pictureBoxProfil = new PictureBox();
            lblFullName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfil).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxProfil
            // 
            pictureBoxProfil.Location = new Point(10, 7);
            pictureBoxProfil.Name = "pictureBoxProfil";
            pictureBoxProfil.Size = new Size(50, 50);
            pictureBoxProfil.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProfil.TabIndex = 0;
            pictureBoxProfil.TabStop = false;
            // 
            // lblFullName
            // 
            lblFullName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(70, 7);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(238, 50);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "label1";
            // 
            // UserItemControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblFullName);
            Controls.Add(pictureBoxProfil);
            Name = "UserItemControl";
            Size = new Size(434, 65);
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfil).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxProfil;
        private Label lblFullName;
    }
}
