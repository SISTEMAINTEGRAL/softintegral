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

namespace Capa_Presentacion.Formreportes
{
    public partial class TicketProforma : Form
    {
        private int idventa;
        private string codigobarraidventa;
        private string opcion ;

        public int Idventa
        {
            get
            {
                return idventa;
            }

            set
            {
                idventa = value;
            }
        }
        public TicketProforma()
        {
            InitializeComponent();
        }

        public TicketProforma(int varidventa, string varopcion = "visor")
        {
            InitializeComponent();
            idventa = varidventa;
            opcion = varopcion;
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
                switch (NegocioConfigEmpresa.formatoimpproforma)
                {
                    case "TICKET80":
                        {
                            
                            miticket = new Reportes.REPORT_TICKET_PROFORMA();
                            miticket.DataSource = midatatable;
                            if (midatatable.Rows.Count != 0)
                            {
                                DataRow row = midatatable.Rows[0];
                               miticket.barcode1.Value= UtilityFrm.calculoDigitoVerificador("", "", "", "", "", false, row["idventa"].ToString());
                            }
                            documento = new PrintDocument();
                            miticket.table1.DataSource = midatatable;
                            reportViewer1.Report = miticket;
                                                
                            break;
                        }
                    case "A4":
                        {

                            miticket2 = new REPORT_VENTA_A4();
                            miticket2.DataSource = midatatable;
                            reportViewer1.Report = miticket2;
                            miticket2.table1.DataSource = midatatable;
                            miticket2.textBox40.Visible = false;
                            miticket2.textBox50.Visible = false;
                            miticket2.textBox51.Visible = false;
                            miticket2.textBox48.Value = "DOCUMENTO NO VALIDO COMO FACTURA";
                            miticket2.pictureBox1.Visible = false;
                            //miticket2.barcode1.Value = valorcodigobarra;

                            break;
                        }
                    case "TICKET56":
                        {
                            
                            miticket1 = new Reportes.REPORT_TICKET_PROFORMAX58();
                            miticket1.DataSource = midatatable;
                            if (midatatable.Rows.Count != 0)
                            {
                                DataRow row = midatatable.Rows[0];
                              //  miticket1.barcode1.Value = UtilityFrm.calculoDigitoVerificador("", "", "", "", "", false, row["idventa"].ToString());
                            }

                            miticket1.table1.DataSource = midatatable;
                            reportViewer1.Report = miticket1;

                           
                            break;
                        }
                           
                    default:
                        break;
                }
                if (opcion == "visor")
                {
                    reportViewer1.RefreshReport();
                }
                else if (opcion == "impresiondirecta")
                {
                    PrinterSettings miprinterseting = new PrinterSettings();
                    ReportProcessor mireportprocesor = new ReportProcessor();
                    if (miprinterseting.IsDefaultPrinter == true)
                    {
                        mireportprocesor.PrintReport(reportViewer1.ReportSource, miprinterseting);
                    }
                    Close();

                }





                // reportViewer1.PrintReport();

                // miticket 
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void TicketProforma_Load(object sender, EventArgs e)
        {
            imprimir();
        }
    }
}
