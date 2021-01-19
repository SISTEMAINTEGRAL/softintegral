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
    public partial class Reporteventa : Form
    {
        public Reporteventa()
        {
            InitializeComponent();
        }

        private int idventa;

        public int Idventa
        {
            get { return idventa; }
            set { idventa = value; }
        }
        private void Reporteventa_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.rEPORTE_VENTASTableAdapter.Fill(this.procedimientoventa.REPORTE_VENTAS,idventa);
            this.reportViewer1.RefreshReport();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               // this.rEPORTE_VENTASTableAdapter.Fill(this.procedimientoventa.REPORTE_VENTAS, new System.Nullable<int>(((int)(System.Convert.ChangeType(idventaToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void idventaToolStripTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
