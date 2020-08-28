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
            this.dSGondola2 = new Capa_Presentacion.DataSet.DSGondola2();
            this.dSGondola2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEPORTEGONDOLA2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEPORTE_GONDOLA2TableAdapter = new Capa_Presentacion.DataSet.DSGondola2TableAdapters.REPORTE_GONDOLA2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSGondola2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSGondola2BindingSource)).BeginInit();
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
            // dSGondola2
            // 
            this.dSGondola2.DataSetName = "DSGondola2";
            this.dSGondola2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSGondola2BindingSource
            // 
            this.dSGondola2BindingSource.DataSource = this.dSGondola2;
            this.dSGondola2BindingSource.Position = 0;
            // 
            // rEPORTEGONDOLA2BindingSource
            // 
            this.rEPORTEGONDOLA2BindingSource.DataMember = "REPORTE_GONDOLA2";
            this.rEPORTEGONDOLA2BindingSource.DataSource = this.dSGondola2BindingSource;
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
            ((System.ComponentModel.ISupportInitialize)(this.dSGondola2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSGondola2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPORTEGONDOLA2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rEPORTEGONDOLA2BindingSource;
        private System.Windows.Forms.BindingSource dSGondola2BindingSource;
        private DataSet.DSGondola2 dSGondola2;
        private DataSet.DSGondola2TableAdapters.REPORTE_GONDOLA2TableAdapter rEPORTE_GONDOLA2TableAdapter;
    }
}