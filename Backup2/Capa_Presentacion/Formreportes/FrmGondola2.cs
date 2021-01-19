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
            rEPORTE_GONDOLA2TableAdapter.Fill(dSGondola2.REPORTE_GONDOLA2, 0, idequipo, 0, 0, 0, 0, 0, "consulta", "");
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
           
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               // this.rEPORTE_GONDOLA2TableAdapter.Fill(this.dSGondola2.REPORTE_GONDOLA2, new System.Nullable<int>(((int)(System.Convert.ChangeType(@idarticuloToolStripTextBox.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(@idequipoToolStripTextBox.Text, typeof(int))))), new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(@precio_unidadToolStripTextBox.Text, typeof(decimal))))), new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(@preciopormayorToolStripTextBox.Text, typeof(decimal))))), new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(@preciopormayor2ToolStripTextBox.Text, typeof(decimal))))), new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(@precio_ofertaToolStripTextBox.Text, typeof(decimal))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(@idcategoriaToolStripTextBox.Text, typeof(int))))), @modoToolStripTextBox.Text, @codigobarraproductoToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
            //    this.rEPORTE_GONDOLA2TableAdapter.Fill(this.dSGondola2.REPORTE_GONDOLA2, new System.Nullable<int>(((int)(System.Convert.ChangeType(@idarticuloToolStripTextBox.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(@idequipoToolStripTextBox.Text, typeof(int))))), new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(@precio_unidadToolStripTextBox.Text, typeof(decimal))))), new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(@preciopormayorToolStripTextBox.Text, typeof(decimal))))), new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(@preciopormayor2ToolStripTextBox.Text, typeof(decimal))))), new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(@precio_ofertaToolStripTextBox.Text, typeof(decimal))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(@idcategoriaToolStripTextBox.Text, typeof(int))))), @modoToolStripTextBox.Text, @codigobarraproductoToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
