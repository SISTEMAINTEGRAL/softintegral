namespace Capa_Presentacion
{
    partial class FrmReporteCaja
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dSCaja = new Capa_Presentacion.DataSet.DSCaja();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSCajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEPORTECAJA1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEPORTE_CAJA1TableAdapter = new Capa_Presentacion.DataSet.DSCajaTableAdapters.REPORTE_CAJA1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCajaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPORTECAJA1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dSCaja
            // 
            this.dSCaja.DataSetName = "DSCaja";
            this.dSCaja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.rEPORTECAJA1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Presentacion.Reportes.ReporteCaja.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(782, 344);
            this.reportViewer1.TabIndex = 0;
            // 
            // dSCajaBindingSource
            // 
            this.dSCajaBindingSource.DataSource = this.dSCaja;
            this.dSCajaBindingSource.Position = 0;
            // 
            // rEPORTECAJA1BindingSource
            // 
            this.rEPORTECAJA1BindingSource.DataMember = "REPORTE_CAJA1";
            this.rEPORTECAJA1BindingSource.DataSource = this.dSCajaBindingSource;
            // 
            // rEPORTE_CAJA1TableAdapter
            // 
            this.rEPORTE_CAJA1TableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 344);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteCaja";
            this.Text = "FrmReporteCaja";
            this.Load += new System.EventHandler(this.FrmReporteCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCajaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPORTECAJA1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet.DSCaja dSCaja;
        private System.Windows.Forms.BindingSource rEPORTECAJA1BindingSource;
        private System.Windows.Forms.BindingSource dSCajaBindingSource;
        private DataSet.DSCajaTableAdapters.REPORTE_CAJA1TableAdapter rEPORTE_CAJA1TableAdapter;
       // private DataSet.DSCajaTableAdapters.REPORTE_CAJATableAdapter rEPORTE_CAJATableAdapter;
    }
}