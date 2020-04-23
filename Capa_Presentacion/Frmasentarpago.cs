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
    public partial class Frmasentarpago : Form
    {
        private decimal importe; 
        private decimal saldoapagar;
        private DataTable midatatable;

        public DataTable Midatatable
        {
            get
            {
                return midatatable;
            }

            set
            {
                midatatable = value;
            }
        }

        public decimal Importe
        {
            get
            {
                return importe;
            }

            set
            {
                importe = value;
            }
        }

        public Frmasentarpago()
        {
            InitializeComponent();
        }
        public Frmasentarpago( decimal varsaldoapagar)
        {
            
            this.saldoapagar = varsaldoapagar;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmasentarpago_Load(object sender, EventArgs e)
        {
            
            txtSaldoapagar.Text = saldoapagar.ToString();
            cbFormapago.Text = "CONTADO";
            this.importe = Convert.ToInt32(txtPago.Text) ;
        }

        private void btnAsentarpago_Click(object sender, EventArgs e)
        {

        }
    }
}
