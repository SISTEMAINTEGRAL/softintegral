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
        public Ticketventa(int varidventa)
        {
            InitializeComponent();
            this.idventa = varidventa;
        }

        public void imprimir()
        {
            
            DataTable midatatable = new DataTable();
            REPORT_TICKET miticket;

            try
            {
                
                midatatable = NegocioVenta.Reporteventa(idventa);
                miticket = new Reportes.REPORT_TICKET();
                miticket.DataSource = midatatable;
                 
                miticket.table1.DataSource = midatatable;
                reportViewer1.Report = miticket;
                
                reportViewer1.RefreshReport();
              
                
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
