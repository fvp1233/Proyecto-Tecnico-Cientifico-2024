namespace PTC2024.View.Dashboard
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pnlAsideMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.imgH2Clogo = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlAsideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgH2Clogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAsideMenu
            // 
            this.pnlAsideMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAsideMenu.BackgroundImage")));
            this.pnlAsideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAsideMenu.Controls.Add(this.imgH2Clogo);
            this.pnlAsideMenu.GradientBottomLeft = System.Drawing.Color.Black;
            this.pnlAsideMenu.GradientBottomRight = System.Drawing.Color.Black;
            this.pnlAsideMenu.GradientTopLeft = System.Drawing.Color.Black;
            this.pnlAsideMenu.GradientTopRight = System.Drawing.Color.Black;
            this.pnlAsideMenu.Location = new System.Drawing.Point(0, -1);
            this.pnlAsideMenu.Name = "pnlAsideMenu";
            this.pnlAsideMenu.Quality = 10;
            this.pnlAsideMenu.Size = new System.Drawing.Size(135, 450);
            this.pnlAsideMenu.TabIndex = 0;
            // 
            // imgH2Clogo
            // 
            this.imgH2Clogo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.imgH2Clogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgH2Clogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgH2Clogo.ErrorImage")));
            this.imgH2Clogo.Image = ((System.Drawing.Image)(resources.GetObject("imgH2Clogo.Image")));
            this.imgH2Clogo.ImageActive = null;
            this.imgH2Clogo.Location = new System.Drawing.Point(27, 13);
            this.imgH2Clogo.Name = "imgH2Clogo";
            this.imgH2Clogo.Size = new System.Drawing.Size(71, 71);
            this.imgH2Clogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgH2Clogo.TabIndex = 1;
            this.imgH2Clogo.TabStop = false;
            this.imgH2Clogo.Zoom = 10;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAsideMenu);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.pnlAsideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgH2Clogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnlAsideMenu;
        private Bunifu.Framework.UI.BunifuImageButton imgH2Clogo;
    }
}