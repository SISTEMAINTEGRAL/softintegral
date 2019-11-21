namespace SistemaVentas
{
    partial class SplashScreen
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
            this.pbCargar = new System.Windows.Forms.ProgressBar();
            this.pbxSoftIntegral = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSoftIntegral)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCargar
            // 
            this.pbCargar.Location = new System.Drawing.Point(1, 285);
            this.pbCargar.MarqueeAnimationSpeed = 20;
            this.pbCargar.Name = "pbCargar";
            this.pbCargar.Size = new System.Drawing.Size(474, 23);
            this.pbCargar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbCargar.TabIndex = 1;
            // 
            // pbxSoftIntegral
            // 
            this.pbxSoftIntegral.BackgroundImage = global::SistemaVentas.Properties.Resources.fondo;
            this.pbxSoftIntegral.Image = global::SistemaVentas.Properties.Resources.SoftIntegral;
            this.pbxSoftIntegral.Location = new System.Drawing.Point(-1, -1);
            this.pbxSoftIntegral.Name = "pbxSoftIntegral";
            this.pbxSoftIntegral.Size = new System.Drawing.Size(478, 280);
            this.pbxSoftIntegral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxSoftIntegral.TabIndex = 0;
            this.pbxSoftIntegral.TabStop = false;
            this.pbxSoftIntegral.Click += new System.EventHandler(this.pbxSoftIntegral_Click);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 324);
            this.Controls.Add(this.pbCargar);
            this.Controls.Add(this.pbxSoftIntegral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSoftIntegral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxSoftIntegral;
        private System.Windows.Forms.ProgressBar pbCargar;
    }
}