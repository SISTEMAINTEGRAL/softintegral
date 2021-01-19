using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Presentacion.Reportes;
using Capa_negocio;


namespace Capa_Presentacion.Formreportes
{
    public partial class FrmReporteRecibo : Form
    {
        private int codrecibo;
        public FrmReporteRecibo(int varcodrecibo)
        {
            InitializeComponent();
            codrecibo = varcodrecibo;
        }

        private void FrmReporteRecibo_Load(object sender, EventArgs e)
        {
            imprimir();
        }
        public void imprimir()
        {

            DataTable midatatable = new DataTable();
            REPORTE_RECIBO miticket;
            string valorenletra = "";

            try
            {

                midatatable = NegocioCliente.reporterecibo(codrecibo);
                foreach (DataRow row in midatatable.Rows)
                {
                   valorenletra = UtilityFrm.enletras(row["MontoPagado"].ToString());
                }
                   
                miticket = new REPORTE_RECIBO();
                miticket.DataSource = midatatable;
                miticket.txtValorLetra.Value = valorenletra;
               // miticket.table1.DataSource = midatatable;
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
    }
}
