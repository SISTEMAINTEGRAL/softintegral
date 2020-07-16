using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
using Capa_negocio;
using Capa_Presentacion.Reportes;
using Telerik.Reporting.Processing;
using Telerik.Reporting;

namespace Capa_Presentacion.Formreportes
{
    public partial class Ticketventa : Form
    {
        private int idventa;
        private string valorcodigobarra;
        private string valorventa;
        private string opcionimpresion;
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
        public Ticketventa()
        {
            InitializeComponent();
        }
        public Ticketventa(int varidventa, string varopcionimpresion = "visor")
        {
            InitializeComponent();
            this.idventa = varidventa;
            opcionimpresion = varopcionimpresion;
        }

        public void imprimir()
        {
            
            DataTable midatatable = new DataTable();
            REPORT_TICKET miticket;
            REPORT_TICKETX58 miticket1;
            REPORT_VENTA_A4 miticket2;
            midatatable = NegocioVenta.Reporteventa(idventa);

            if (midatatable.Rows.Count != 0)
            {
                DataRow row = midatatable.Rows[0];
                //valorcodigobarra = UtilityFrm.calculoDigitoVerificador("012","34","5","678","90");
                valorcodigobarra = UtilityFrm.calculoDigitoVerificador(row["cuit"].ToString(), row["tipofactura"].ToString(), row["puntoventa"].ToString(), row["CAE"].ToString(), row["CAE_fechavencimiento"].ToString());
                valorventa = UtilityFrm.calculoDigitoVerificador("", "","", "", "",false, row["idventa"].ToString());
            }


                try
            {
               

                switch (NegocioConfigEmpresa.formatoimpfactelectronica)
                {
                   case "TICKET80" :
                   {
                            
                            miticket = new Reportes.REPORT_TICKET();
                            miticket.DataSource = midatatable;

                            miticket.table1.DataSource = midatatable;
                            reportViewer1.Report = miticket;
                            miticket.barcode1.Value = valorcodigobarra;
                           // miticket.barcode2.Value = valorventa;
                            // miticket.barcode2.Value = valorventa;
                            
                            break;  
                   }
                    case "TICKET56" :
                        {
                            miticket1 = new REPORT_TICKETX58();
                            miticket1.DataSource = midatatable;
                            reportViewer1.Report = miticket1;
                            miticket1.table1.DataSource = midatatable;
                            miticket1.barcode1.Value = valorcodigobarra;
                            
                            break;
                        }
                    case "A4":
                        {
                            miticket2 = new REPORT_VENTA_A4();
                            miticket2.DataSource = midatatable;
                            reportViewer1.Report = miticket2;
                            miticket2.table1.DataSource = midatatable;
                            miticket2.barcode1.Value = valorcodigobarra;
                            
                            break;
                        }
                    default:
                        break;
                }
                if (opcionimpresion == "visor")
                {
                    reportViewer1.RefreshReport();
                }
                else if (opcionimpresion == "impresiondirecta")
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

        private void Ticketventa_Load(object sender, EventArgs e)
        {
            imprimir();
        }
    }
}
