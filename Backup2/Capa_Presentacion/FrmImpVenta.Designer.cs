﻿namespace Capa_Presentacion
{
    partial class FrmImpVenta
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
            this.CRVVenta = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.VentasReducida1 = new Capa_Presentacion.Reportes.VentasReducida();
            this.SuspendLayout();
            // 
            // CRVVenta
            // 
            this.CRVVenta.ActiveViewIndex = 0;
            this.CRVVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRVVenta.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRVVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRVVenta.Location = new System.Drawing.Point(0, 0);
            this.CRVVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CRVVenta.Name = "CRVVenta";
            this.CRVVenta.ReportSource = this.VentasReducida1;
            this.CRVVenta.Size = new System.Drawing.Size(1336, 889);
            this.CRVVenta.TabIndex = 0;
            this.CRVVenta.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.CRVVenta.Load += new System.EventHandler(this.CRVVenta_Load);
            // 
            // FrmImpVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 889);
            this.Controls.Add(this.CRVVenta);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmImpVenta";
            this.Text = "FrmImpVenta";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRVVenta;
        private Reportes.NotaDeVenta NotaDeVenta1;
        private Reportes.VentasReducida VentasReducida1;
    }
}