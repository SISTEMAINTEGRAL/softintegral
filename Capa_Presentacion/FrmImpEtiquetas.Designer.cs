namespace Capa_Presentacion
{
    partial class FrmImpEtiquetas
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
            this.vistaReporte = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ReporteEtiqueta1 = new Capa_Presentacion.Reportes.ReporteEtiqueta();
            this.SuspendLayout();
            // 
            // vistaReporte
            // 
            this.vistaReporte.ActiveViewIndex = 0;
            this.vistaReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vistaReporte.Cursor = System.Windows.Forms.Cursors.Default;
            this.vistaReporte.DisplayStatusBar = false;
            this.vistaReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vistaReporte.Location = new System.Drawing.Point(0, 0);
            this.vistaReporte.Name = "vistaReporte";
            this.vistaReporte.ReportSource = this.ReporteEtiqueta1;
            this.vistaReporte.Size = new System.Drawing.Size(835, 459);
            this.vistaReporte.TabIndex = 0;
            this.vistaReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.vistaReporte.Load += new System.EventHandler(this.vistaReporte_Load);
            // 
            // FrmImpEtiquetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 459);
            this.Controls.Add(this.vistaReporte);
            this.Name = "FrmImpEtiquetas";
            this.Text = "FrmEtiquetas";
            this.Load += new System.EventHandler(this.FrmEtiquetas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer vistaReporte;
        private Reportes.ReporteEtiqueta ReporteEtiqueta1;
    }
}