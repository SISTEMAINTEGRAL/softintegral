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
namespace Capa_Presentacion
{
    public partial class FrmClienteCtaCte : Form
    {
        private int codcliente;
        private DataTable midata;
        public FrmClienteCtaCte()
        {
            InitializeComponent();
        }
        public FrmClienteCtaCte(int varcodcliente)
        {
            InitializeComponent();
            this.codcliente = varcodcliente;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(0, 100, 200);
        }

        private void btnCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCerrar.BackColor = Color.Red;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //maximizar
            this.btnRestaurar.Visible = true;
            this.btnMaximizar.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMaximizar_MouseLeave(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(0, 100, 200);
        }

        private void btnMaximizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(65, 39, 60);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(0, 100, 200);
        }

        private void btnMinimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(65, 39, 60);
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //restaurar
            this.btnRestaurar.Visible = false;
            this.btnMaximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnRestaurar_MouseLeave(object sender, EventArgs e)
        {
            btnRestaurar.BackColor = Color.FromArgb(0, 100, 200);
        }

        private void btnRestaurar_MouseMove(object sender, MouseEventArgs e)
        {
            btnRestaurar.BackColor = Color.FromArgb(65, 39, 60);
        }

        private void panelHorizontal_DoubleClick(object sender, EventArgs e)
        {
            if (btnRestaurar.Visible == false || btnMaximizar.Visible == true)
            {
                //maximizar
                this.btnRestaurar.Visible = true;
                this.btnMaximizar.Visible = false;
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {
                //restaurar
                this.btnRestaurar.Visible = false;
                this.btnMaximizar.Visible = true;
                this.WindowState = FormWindowState.Normal;
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

        private void xuiSuperButton2_Click(object sender, EventArgs e)
        {

        }

        private void BtnAsentarpago_Click(object sender, EventArgs e)
        {
            midata = new DataTable();
            
            midata.Columns.Add("Idventa", typeof(int));
            midata.Columns.Add("saldo", typeof(decimal));
            midata.Columns.Add("pagado", typeof(decimal));
            midata.Columns.Add("total", typeof(decimal));
            midata.Columns.Add("estado", typeof(string));

            if (traersaldo () != 0)
            {
                Frmasentarpago objpago = new Frmasentarpago(traersaldo());
                objpago.Midatatable = midata;
                objpago.ShowDialog();
                cargardatatable(objpago.Importe);
                //NegocioCliente.modificarlistactacte(midata);


            }
            else
            {
                UtilityFrm.mensajeError("No hay saldo");
            }
            
        }

        private void FrmClienteCtaCte_Load(object sender, EventArgs e)
        {
            DGListado.DataSource = NegocioCliente.buscarporcodigoctacte(this.codcliente);
        }
        private decimal traersaldo()
        {
            decimal contsaldo = 0;
            foreach (DataGridViewRow row in DGListado.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true && row.Cells["estado"].Value.ToString() == "Pendiente")
                {
                    contsaldo = decimal.Round(contsaldo + Convert.ToDecimal(row.Cells["saldo"].Value), 2);
                    midata.Rows.Add(row.Cells["codventa"].Value, row.Cells["saldo"].Value, row.Cells["pagado"].Value, row.Cells["total"].Value, row.Cells["estado"].Value);
                }
                
            }
            return contsaldo;
        }
        private void cargardatatable(decimal pago)
        {
            decimal recuperar = 0;
            foreach (DataRow row in midata.Rows)
            {
                pago = pago - Convert.ToDecimal(row["saldo"].ToString());
                if (pago >= 0)
                {
                    row["saldo"] = 0;
                    row["pagado"] = row["total"];
                    row["estado"] = "pagado";
                    if (pago == 0)
                    {
                        break;
                    }
                    
                }
                
                if (pago < 0)
                {
                   recuperar =   pago + Convert.ToDecimal(row["saldo"].ToString());
                    row["saldo"] = pago * (-1);
                    row["pagado"] = recuperar;
                    
                }
            }

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DGListado.DataSource = NegocioCliente.buscarporcodigoctacte(this.codcliente);        }
    }
}
