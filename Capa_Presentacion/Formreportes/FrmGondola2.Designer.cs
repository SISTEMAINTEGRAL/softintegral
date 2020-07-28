namespace Capa_Presentacion.Formreportes
{
    partial class FrmGondola2
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet1 = new Capa_Presentacion.DataSet1();
            this.rEPORTEGONDOLA2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEPORTE_GONDOLA2TableAdapter = new Capa_Presentacion.DataSet1TableAdapters.REPORTE_GONDOLA2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPORTEGONDOLA2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DGondola";
            reportDataSource1.Value = this.rEPORTEGONDOLA2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Presentacion.Reportes.REPORT_GONDOLA2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(996, 502);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEPORTEGONDOLA2BindingSource
            // 
            this.rEPORTEGONDOLA2BindingSource.DataMember = "REPORTE_GONDOLA2";
            this.rEPORTEGONDOLA2BindingSource.DataSource = this.dataSet1;
            // 
            // rEPORTE_GONDOLA2TableAdapter
            // 
            this.rEPORTE_GONDOLA2TableAdapter.ClearBeforeFill = true;
            // 
            // FrmGondola2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 502);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmGondola2";
            this.Text = "FrmGondola2";
            this.Load += new System.EventHandler(this.FrmGondola2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPORTEGONDOLA2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rEPORTEGONDOLA2BindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.REPORTE_GONDOLA2TableAdapter rEPORTE_GONDOLA2TableAdapter;
    }
}