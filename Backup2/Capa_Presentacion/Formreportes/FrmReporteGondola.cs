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
    public partial class FrmReporteGondola : Form
    {
        private int idequipo;
        public FrmReporteGondola()
        {
            InitializeComponent();
        }
        public FrmReporteGondola(int varidequipo)
        {
            idequipo = varidequipo;
            InitializeComponent();
        }
        private void FrmReporteGondola_Load(object sender, EventArgs e)
        {
            
            DataTable midatatable = new DataTable();
            Report1 reportgondola = new Report1();
            midatatable = NegocioArticulo.consultagondola(NegocioConfigEmpresa.idequipo);
           // reportgondola.list1.DataSource = midatatable;
            reportgondola.DataSource = midatatable;
            reportViewer1.Report = reportgondola;
            reportViewer1.RefreshReport();

        }
    }
}
