using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class FrmReporteCaja : Form
    {
        private int  idcierre;

        public int Idcierre
        {
            get { return idcierre; }
            set { idcierre = value; }
        }
        public FrmReporteCaja()
        {
            InitializeComponent();
        }

        private void FrmReporteCaja_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSCaja.REPORTE_CAJA' Puede moverla o quitarla según sea necesario.
          //  this.rEPORTE_CAJATableAdapter.Fill(this.dSCaja.REPORTE_CAJA,idcierre);
            this.rEPORTE_CAJA1TableAdapter.Fill(this.dSCaja.REPORTE_CAJA1, idcierre);
            this.reportViewer1.RefreshReport();
        }
    }
}
