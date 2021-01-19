namespace Capa_Presentacion
{
    partial class Reporteventa
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
            this.REPORTE_VENTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.procedimientoventa = new Capa_Presentacion.DataSet.Procedimientoventa();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.procedimientoventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEPORTEVENTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEPORTE_VENTASTableAdapter = new Capa_Presentacion.DataSet.ProcedimientoventaTableAdapters.REPORTE_VENTASTableAdapter();
            this.rEPORTEVENTASBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.REPORTE_VENTASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedimientoventa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedimientoventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPORTEVENTASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPORTEVENTASBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // REPORTE_VENTASBindingSource
            // 
            this.REPORTE_VENTASBindingSource.DataMember = "REPORTE_VENTAS";
            this.REPORTE_VENTASBindingSource.DataSource = this.procedimientoventa;
            // 
            // procedimientoventa
            // 
            this.procedimientoventa.DataSetName = "Procedimientoventa";
            this.procedimientoventa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.REPORTE_VENTASBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Presentacion.Reportes.Reporteventas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1036, 482);
            this.reportViewer1.TabIndex = 0;
            // 
            // procedimientoventaBindingSource
            // 
            this.procedimientoventaBindingSource.DataSource = this.procedimientoventa;
            this.procedimientoventaBindingSource.Position = 0;
            // 
            // rEPORTEVENTASBindingSource
            // 
            this.rEPORTEVENTASBindingSource.DataMember = "REPORTE_VENTAS";
            this.rEPORTEVENTASBindingSource.DataSource = this.procedimientoventa;
            // 
            // rEPORTE_VENTASTableAdapter
            // 
            this.rEPORTE_VENTASTableAdapter.ClearBeforeFill = true;
            // 
            // rEPORTEVENTASBindingSource1
            // 
            this.rEPORTEVENTASBindingSource1.DataMember = "REPORTE_VENTAS";
            this.rEPORTEVENTASBindingSource1.DataSource = this.procedimientoventaBindingSource;
            // 
            // Reporteventa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 482);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Reporteventa";
            this.Text = "Reporteventa";
            this.Load += new System.EventHandler(this.Reporteventa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.REPORTE_VENTASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedimientoventa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedimientoventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPORTEVENTASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPORTEVENTASBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource procedimientoventaBindingSource;
        private DataSet.Procedimientoventa procedimientoventa;
        private System.Windows.Forms.BindingSource REPORTE_VENTASBindingSource;
        private System.Windows.Forms.BindingSource rEPORTEVENTASBindingSource;
        private DataSet.ProcedimientoventaTableAdapters.REPORTE_VENTASTableAdapter rEPORTE_VENTASTableAdapter;
        private System.Windows.Forms.BindingSource rEPORTEVENTASBindingSource1;
    }
}