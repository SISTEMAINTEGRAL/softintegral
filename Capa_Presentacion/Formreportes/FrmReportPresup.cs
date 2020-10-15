using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_negocio;
using Capa_Presentacion.Reportes;
using Telerik.Reporting.Processing;
using Telerik.Reporting;
using System.Drawing.Printing;

using Telerik.Reporting.Drawing;

namespace Capa_Presentacion.Formreportes
{
    public partial class FrmReportPresup : Form
    {
        DataTable midatatable = new DataTable();
        private int idventa;
        REPORT_VENTA_A4 miticket2;

        int num;
        
        public FrmReportPresup(int varidventa)
        {
            InitializeComponent();
            idventa = varidventa;
        }
              

       public void imprimir()
        {

            DataTable midatatable = new DataTable();
            REPORT_TICKET_PROFORMA miticket;
            REPORT_TICKET_PROFORMAX58 miticket1;
            REPORT_VENTA_A4 miticket2;
            PrintDocument documento;


            midatatable = NegocioVenta.Reporteventa(idventa);
            try
            {
                miticket2 = new REPORT_VENTA_A4();
                miticket2.DataSource = midatatable;
                reportViewer1.Report = miticket2;
                miticket2.table1.DataSource = midatatable;
                miticket2.textBox40.Value = "PRESUPUESTO";
                miticket2.textBox36.Value = idventa.ToString().PadLeft(8, '0');
                miticket2.textBox37.Value = NegocioConfigEmpresa.puntoventa.PadLeft(5, '0');
                miticket2.textBox50.Visible = false;
                miticket2.textBox51.Visible = false;
                miticket2.textBox14.Visible = false;
                miticket2.textBox15.Visible = false;
                miticket2.textBox57.Visible = false;
                miticket2.textBox58.Visible = false;
                miticket2.textBox59.Visible = false;
                miticket2.textBox60.Visible = false;
                miticket2.textBox48.Value = "DOCUMENTO NO VALIDO COMO FACTURA";
                miticket2.pictureBox1.Visible = false;
                reportViewer1.RefreshReport();
                                             
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FrmReportPresup_Load(object sender, EventArgs e)
        {
            imprimir();
        }
    }
}
