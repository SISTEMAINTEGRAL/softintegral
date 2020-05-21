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

namespace Capa_Presentacion.Formreportes
{
    public partial class TicketProforma : Form
    {
        private int idventa;


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

        public TicketProforma(int varidventa)
        {
            InitializeComponent();
            idventa = varidventa;
        }

        public void imprimir()
        {

            DataTable midatatable = new DataTable();
            REPORT_TICKET_PROFORMA miticket;

            try
            {
                switch (NegocioConfigEmpresa.formatoimpproforma)
                {
                    case "TICKET80":
                        {
                            midatatable = NegocioVenta.Reporteventa(idventa);
                            miticket = new Reportes.REPORT_TICKET_PROFORMA();
                            miticket.DataSource = midatatable;

                            miticket.table1.DataSource = midatatable;
                            reportViewer1.Report = miticket;

                            reportViewer1.RefreshReport();
                            break;
                        }
                    case "A4":
                        {
                            break;
                        }
                    case "TICKET56":
                        {
                            break;
                        }
                           
                    default:
                        break;
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
