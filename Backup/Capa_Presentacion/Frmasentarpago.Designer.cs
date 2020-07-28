namespace Capa_Presentacion
{
    partial class Frmasentarpago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmasentarpago));
            this.panelHorizontal = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pnlSeparacion = new System.Windows.Forms.Panel();
            this.lblCaja = new System.Windows.Forms.Label();
            this.txtSaldoapagar = new System.Windows.Forms.TextBox();
            this.cbFormapago = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAsentarpago = new XanderUI.XUISuperButton();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHorizontal
            // 
            this.panelHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panelHorizontal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHorizontal.Controls.Add(this.btnCerrar);
            this.panelHorizontal.Controls.Add(this.pnlSeparacion);
            this.panelHorizontal.Controls.Add(this.lblCaja);
            this.panelHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHorizontal.Location = new System.Drawing.Point(0, 0);
            this.panelHorizontal.Name = "panelHorizontal";
            this.panelHorizontal.Size = new System.Drawing.Size(671, 37);
            this.panelHorizontal.TabIndex = 77;
            this.panelHorizontal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHorizontal_MouseMove);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.Delete_20px;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.ErrorImage")));
            this.btnCerrar.Location = new System.Drawing.Point(644, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(22, 25);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            this.btnCerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCerrar_MouseMove);
            // 
            // pnlSeparacion
            // 
            this.pnlSeparacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSeparacion.BackColor = System.Drawing.Color.Thistle;
            this.pnlSeparacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSeparacion.Location = new System.Drawing.Point(1, 36);
            this.pnlSeparacion.Name = "pnlSeparacion";
            this.pnlSeparacion.Size = new System.Drawing.Size(669, 2);
            this.pnlSeparacion.TabIndex = 0;
            // 
            // lblCaja
            // 
            this.lblCaja.AutoSize = true;
            this.lblCaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCaja.Location = new System.Drawing.Point(0, 0);
            this.lblCaja.Name = "lblCaja";
            this.lblCaja.Size = new System.Drawing.Size(103, 33);
            this.lblCaja.TabIndex = 3;
            this.lblCaja.Text = "PAGO";
            // 
            // txtSaldoapagar
            // 
            this.txtSaldoapagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaldoapagar.Location = new System.Drawing.Point(196, 122);
            this.txtSaldoapagar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtSaldoapagar.Name = "txtSaldoapagar";
            this.txtSaldoapagar.ReadOnly = true;
            this.txtSaldoapagar.Size = new System.Drawing.Size(163, 35);
            this.txtSaldoapagar.TabIndex = 81;
            this.txtSaldoapagar.Text = "0";
            // 
            // cbFormapago
            // 
            this.cbFormapago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbFormapago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFormapago.FormattingEnabled = true;
            this.cbFormapago.Items.AddRange(new object[] {
            "CONTADO"});
            this.cbFormapago.Location = new System.Drawing.Point(195, 70);
            this.cbFormapago.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cbFormapago.Name = "cbFormapago";
            this.cbFormapago.Size = new System.Drawing.Size(270, 37);
            this.cbFormapago.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 29);
            this.label4.TabIndex = 79;
            this.label4.Text = "Saldo a pagar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 29);
            this.label2.TabIndex = 78;
            this.label2.Text = "Forma de pago :";
            // 
            // btnAsentarpago
            // 
            this.btnAsentarpago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAsentarpago.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.btnAsentarpago.ButtonImage = null;
            this.btnAsentarpago.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnAsentarpago.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnAsentarpago.ButtonText = "Asentar pago";
            this.btnAsentarpago.CornerRadius = 5;
            this.btnAsentarpago.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAsentarpago.HoverBackgroundColor = System.Drawing.Color.IndianRed;
            this.btnAsentarpago.HoverTextColor = System.Drawing.Color.Yellow;
            this.btnAsentarpago.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnAsentarpago.Location = new System.Drawing.Point(62, 232);
            this.btnAsentarpago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAsentarpago.Name = "btnAsentarpago";
            this.btnAsentarpago.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnAsentarpago.SelectedTextColor = System.Drawing.Color.White;
            this.btnAsentarpago.Size = new System.Drawing.Size(224, 63);
            this.btnAsentarpago.SuperSelected = false;
            this.btnAsentarpago.TabIndex = 112;
            this.btnAsentarpago.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnAsentarpago.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAsentarpago.Click += new System.EventHandler(this.btnAsentarpago_Click);
            // 
            // txtPago
            // 
            this.txtPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPago.Location = new System.Drawing.Point(195, 166);
            this.txtPago.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(163, 35);
            this.txtPago.TabIndex = 113;
            this.txtPago.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 114;
            this.label1.Text = "Pago :";
            // 
            // Frmasentarpago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 323);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.btnAsentarpago);
            this.Controls.Add(this.txtSaldoapagar);
            this.Controls.Add(this.cbFormapago);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelHorizontal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frmasentarpago";
            this.Text = "Frmasentarpago";
            this.Load += new System.EventHandler(this.Frmasentarpago_Load);
            this.panelHorizontal.ResumeLayout(false);
            this.panelHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHorizontal;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel pnlSeparacion;
        private System.Windows.Forms.Label lblCaja;
        private System.Windows.Forms.TextBox txtSaldoapagar;
        private System.Windows.Forms.ComboBox cbFormapago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private XanderUI.XUISuperButton btnAsentarpago;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label1;
    }
}