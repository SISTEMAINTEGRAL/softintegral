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
        private bool confirmarpago ;
        private decimal pagototal;
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

        public bool Confirmarpago
        {
            get
            {
                return confirmarpago;
            }

            set
            {
                confirmarpago = value;
            }
        }

        public decimal Pagototal
        {
            get
            {
                return pagototal;
            }

            set
            {
                pagototal = value;
            }
        }

        public Frmasentarpago()
        {
            InitializeComponent();
        }
        public Frmasentarpago( decimal varpagototal)
        {
            InitializeComponent();
            this.pagototal = varpagototal;
            this.confirmarpago = false;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmasentarpago_Load(object sender, EventArgs e)
        {
            
            txtSaldoapagar.Text = pagototal.ToString();
            cbFormapago.Text = "CONTADO";
            
        }

        private void btnAsentarpago_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal ( txtPago.Text) <= Convert.ToDecimal( txtSaldoapagar.Text) && Convert.ToDecimal(txtPago.Text) >= 0)
            {
                this.importe = Convert.ToDecimal (txtPago.Text);
                confirmarpago = true;
                this.Close();
            }
            
        }

        private void panelHorizontal_MouseMove(object sender, MouseEventArgs e)
        {
            int posY = 0;
            int posX = 0;
            //mientra no se apreta el boton izquierdo del mouse actualiza el valor posX Y posY 
            if (e.Button != MouseButtons.Left)
            {
                posY = e.Y;
                posX = e.X;

            }
            else
            {
                //Left tiene la distancia que hay entre el borde izq y el fondo de la pantalla
                Left = Left + (e.X - posX);
                //top tiene la distancia que hay entre el borde sup y el fondo de la pantalla
                Top = Top + (e.Y - posY);

            }
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(0, 100, 200);
        }

        private void btnCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCerrar.BackColor = Color.Red;
        }

        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityFrm.NumDecTeclado(e, txtPago);
        }
    }
}
