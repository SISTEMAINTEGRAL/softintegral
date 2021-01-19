namespace Capa_Presentacion.Formreportes
{
    partial class FrmGondola
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
            this.dSGondola = new Capa_Presentacion.DataSet.DSGondola();
            this.dSGondolaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEPORTE_GONDOLATableAdapter = new Capa_Presentacion.DataSet.DSGondolaTableAdapters.REPORTE_GONDOLATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSGondola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSGondolaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DGondola";
            reportDataSource1.Value = this.dSGondolaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Presentacion.Reportes.REPORT_GONDOLA.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(807, 569);
            this.reportViewer1.TabIndex = 0;
            // 
            // dSGondola
            // 
            this.dSGondola.DataSetName = "DSGondola";
            this.dSGondola.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSGondolaBindingSource
            // 
            this.dSGondolaBindingSource.DataMember = "REPORTE_GONDOLA";
            this.dSGondolaBindingSource.DataSource = this.dSGondola;
            // 
            // rEPORTE_GONDOLATableAdapter
            // 
            this.rEPORTE_GONDOLATableAdapter.ClearBeforeFill = true;
            // 
            // FrmGondola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 569);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmGondola";
            this.Text = "FrmGondola";
            this.Load += new System.EventHandler(this.FrmGondola_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSGondola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSGondolaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dSGondolaBindingSource;
        private DataSet.DSGondola dSGondola;
        private DataSet.DSGondolaTableAdapters.REPORTE_GONDOLATableAdapter rEPORTE_GONDOLATableAdapter;
    }
}