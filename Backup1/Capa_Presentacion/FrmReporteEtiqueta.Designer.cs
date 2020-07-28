namespace Capa_Presentacion
{
    partial class FrmReporteEtiqueta
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
            this.rvImprimirEtiqueta = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.lblCodigoBarra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rvImprimirEtiqueta
            // 
            this.rvImprimirEtiqueta.ActiveViewIndex = -1;
            this.rvImprimirEtiqueta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rvImprimirEtiqueta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rvImprimirEtiqueta.Cursor = System.Windows.Forms.Cursors.Default;
            this.rvImprimirEtiqueta.Location = new System.Drawing.Point(7, 77);
            this.rvImprimirEtiqueta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rvImprimirEtiqueta.Name = "rvImprimirEtiqueta";
            this.rvImprimirEtiqueta.Size = new System.Drawing.Size(1018, 496);
            this.rvImprimirEtiqueta.TabIndex = 0;
            this.rvImprimirEtiqueta.ToolPanelWidth = 267;
            this.rvImprimirEtiqueta.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBarra.Location = new System.Drawing.Point(7, 34);
            this.txtCodigoBarra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.ReadOnly = true;
            this.txtCodigoBarra.Size = new System.Drawing.Size(423, 27);
            this.txtCodigoBarra.TabIndex = 1;
            // 
            // lblCodigoBarra
            // 
            this.lblCodigoBarra.AutoSize = true;
            this.lblCodigoBarra.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoBarra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoBarra.ForeColor = System.Drawing.Color.White;
            this.lblCodigoBarra.Location = new System.Drawing.Point(4, 6);
            this.lblCodigoBarra.Name = "lblCodigoBarra";
            this.lblCodigoBarra.Size = new System.Drawing.Size(138, 21);
            this.lblCodigoBarra.TabIndex = 2;
            this.lblCodigoBarra.Text = "Codigo de Barra";
            // 
            // FrmReporteEtiqueta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Capa_Presentacion.Properties.Resources.pantallaPrincipal;
            this.ClientSize = new System.Drawing.Size(1038, 578);
            this.Controls.Add(this.lblCodigoBarra);
            this.Controls.Add(this.txtCodigoBarra);
            this.Controls.Add(this.rvImprimirEtiqueta);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmReporteEtiqueta";
            this.Text = "FrmReporteEtiqueta";
            this.Load += new System.EventHandler(this.FrmReporteEtiqueta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private CrystalDecisions.Windows.Forms.CrystalReportViewer rvImprimirEtiqueta;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.Label lblCodigoBarra;

    }
}