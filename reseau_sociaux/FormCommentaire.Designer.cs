namespace reseau_sociaux
{
    partial class FormCommentaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCommentaire));
            flowLayoutPanelComment = new FlowLayoutPanel();
            parrotButtonSendComment = new ReaLTaiizor.Controls.ParrotButton();
            bigTextBoxComment = new ReaLTaiizor.Controls.BigTextBox();
            parrotButtonExitComment = new ReaLTaiizor.Controls.ParrotButton();
            errorProvider = new ErrorProvider(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelComment
            // 
            flowLayoutPanelComment.AutoScroll = true;
            flowLayoutPanelComment.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelComment.Location = new Point(2, 75);
            flowLayoutPanelComment.Name = "flowLayoutPanelComment";
            flowLayoutPanelComment.Size = new Size(620, 368);
            flowLayoutPanelComment.TabIndex = 0;
            flowLayoutPanelComment.WrapContents = false;
            // 
            // parrotButtonSendComment
            // 
            parrotButtonSendComment.BackgroundColor = Color.FromArgb(255, 255, 255);
            parrotButtonSendComment.ButtonImage = Properties.Resources.paper_plane_3917436;
            parrotButtonSendComment.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            parrotButtonSendComment.ButtonText = "Envoyer";
            parrotButtonSendComment.ClickBackColor = Color.FromArgb(195, 195, 195);
            parrotButtonSendComment.ClickTextColor = Color.DodgerBlue;
            parrotButtonSendComment.CornerRadius = 5;
            parrotButtonSendComment.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotButtonSendComment.Horizontal_Alignment = StringAlignment.Center;
            parrotButtonSendComment.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            parrotButtonSendComment.HoverTextColor = Color.DodgerBlue;
            parrotButtonSendComment.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButtonSendComment.Location = new Point(253, 529);
            parrotButtonSendComment.Name = "parrotButtonSendComment";
            parrotButtonSendComment.Size = new Size(164, 29);
            parrotButtonSendComment.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButtonSendComment.TabIndex = 1;
            parrotButtonSendComment.TextColor = Color.FromArgb(64, 64, 64);
            parrotButtonSendComment.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButtonSendComment.Vertical_Alignment = StringAlignment.Center;
            parrotButtonSendComment.Click += parrotButtonSendComment_Click;
            // 
            // bigTextBoxComment
            // 
            bigTextBoxComment.BackColor = Color.Transparent;
            bigTextBoxComment.Font = new Font("Tahoma", 11F);
            bigTextBoxComment.ForeColor = Color.DimGray;
            bigTextBoxComment.Image = null;
            bigTextBoxComment.Location = new Point(92, 462);
            bigTextBoxComment.MaxLength = 32767;
            bigTextBoxComment.Multiline = false;
            bigTextBoxComment.Name = "bigTextBoxComment";
            bigTextBoxComment.PlaceholderText = "Ecriver ici pour commenter";
            bigTextBoxComment.ReadOnly = false;
            bigTextBoxComment.Size = new Size(463, 46);
            bigTextBoxComment.TabIndex = 2;
            bigTextBoxComment.TextAlignment = HorizontalAlignment.Left;
            bigTextBoxComment.UseSystemPasswordChar = false;
            // 
            // parrotButtonExitComment
            // 
            parrotButtonExitComment.BackgroundColor = Color.FromArgb(255, 255, 255);
            parrotButtonExitComment.ButtonImage = Properties.Resources.MiArrowLeft;
            parrotButtonExitComment.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            parrotButtonExitComment.ButtonText = "Retour";
            parrotButtonExitComment.ClickBackColor = Color.FromArgb(195, 195, 195);
            parrotButtonExitComment.ClickTextColor = Color.Red;
            parrotButtonExitComment.CornerRadius = 5;
            parrotButtonExitComment.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotButtonExitComment.Horizontal_Alignment = StringAlignment.Center;
            parrotButtonExitComment.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            parrotButtonExitComment.HoverTextColor = Color.Red;
            parrotButtonExitComment.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButtonExitComment.Location = new Point(12, 12);
            parrotButtonExitComment.Name = "parrotButtonExitComment";
            parrotButtonExitComment.Size = new Size(101, 35);
            parrotButtonExitComment.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButtonExitComment.TabIndex = 3;
            parrotButtonExitComment.TextColor = Color.FromArgb(64, 64, 64);
            parrotButtonExitComment.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButtonExitComment.Vertical_Alignment = StringAlignment.Center;
            parrotButtonExitComment.Click += parrotButtonExitComment_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            errorProvider.Icon = (Icon)resources.GetObject("errorProvider.Icon");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(253, 19);
            label1.Name = "label1";
            label1.Size = new Size(135, 28);
            label1.TabIndex = 0;
            label1.Text = "Commentaire";
            // 
            // FormCommentaire
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 70, 40);
            ClientSize = new Size(623, 581);
            Controls.Add(label1);
            Controls.Add(parrotButtonExitComment);
            Controls.Add(bigTextBoxComment);
            Controls.Add(parrotButtonSendComment);
            Controls.Add(flowLayoutPanelComment);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCommentaire";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormCommentaire";
            Load += FormCommentaire_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelComment;
        private ReaLTaiizor.Controls.ParrotButton parrotButtonSendComment;
        private ReaLTaiizor.Controls.BigTextBox bigTextBoxComment;
        private ReaLTaiizor.Controls.ParrotButton parrotButtonExitComment;
        private ErrorProvider errorProvider;
        private Label label1;
    }
}