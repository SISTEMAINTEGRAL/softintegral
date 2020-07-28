using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.Formreportes
{
    public partial class FrmGondola2 : Form
    {
        private int idequipo;
        public FrmGondola2(int varidequipo)
        {
            InitializeComponent();
            idequipo = varidequipo;
        }

        private void FrmGondola2_Load(object sender, EventArgs e)
        {
            rEPORTE_GONDOLA2TableAdapter.Fill(dataSet1.REPORTE_GONDOLA2, 0, idequipo, 0, 0, 0, 0, 0, "consulta", "");
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
           
        }
    }
}
