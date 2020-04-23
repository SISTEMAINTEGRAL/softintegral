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
    public partial class FrmStockRetirodeMercaderia : Form
    {
        int posY = 0;
        int posX = 0;
        public FrmStockRetirodeMercaderia()
        {
            InitializeComponent();
            // StartPosition was set to FormStartPosition.Manual in the properties window.
            //Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            //int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            //int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            //this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            //this.Size = new Size(w, h);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DGListado.DataSource = NegocioOrdenpedido.buscarconcatenacion( Convert.ToInt32 (txtIdCliente.Text == "" ? "0" : txtIdCliente.Text ), CBEstado.Text, CbTipopedido.Text, dtpFechaIni.Value.ToString("dd/MM/yyyy") , dtpFechaFin.Value.ToString("dd/MM/yyyy") ,
                                                                          CHKCliente.Checked, CHKEstado.Checked, CHKTipo.Checked, CHKFecha.Checked);
            
        }

        private void panelHorizontal_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //cierra
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //maximizar
            this.btnRestaurar.Visible = true;
            this.btnMaximizar.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //restaurar
            this.btnRestaurar.Visible = false;
            this.btnMaximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //minimiza
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(0, 100, 200);
        }

        private void btnCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCerrar.BackColor = Color.Red;
        }

        private void btnMaximizar_MouseLeave(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(0, 100, 200);
        }

        private void btnMaximizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(65, 39, 60);
        }

        private void btnRestaurar_MouseLeave(object sender, EventArgs e)
        {
            btnRestaurar.BackColor = Color.FromArgb(0, 100, 200);
        }

        private void btnRestaurar_MouseMove(object sender, MouseEventArgs e)
        {
            btnRestaurar.BackColor = Color.FromArgb(65, 39, 60);
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(0, 100, 200);
        }

        private void btnMinimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(65, 39, 60);
        }

        private void DGListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DGDetalle.DataSource = NegocioOrdenpedido.buscarlistadodetalle(Convert.ToInt32 (DGListado.CurrentRow.Cells["orden"].Value) );
        }

        private void DGListado_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DGListado.Rows.Count > 0)
            {
                //DateTime date = Convert.ToDateTime(this.dataLista.CurrentRow.Cells["fecha"].Value);
                LblNorden.Text = Convert.ToString(DGListado.CurrentRow.Cells["Orden"].Value);
                LblRazonsocial.Text = Convert.ToString(DGListado.CurrentRow.Cells["razon_social"].Value);
                LblCuit.Text = Convert.ToString(DGListado.CurrentRow.Cells["cuit"].Value);
                LblEstado.Text = Convert.ToString(DGListado.CurrentRow.Cells["estado"].Value);
                LblTipo.Text = Convert.ToString(DGListado.CurrentRow.Cells["Tipo"].Value);
                LblCodcliente.Text = Convert.ToString(DGListado.CurrentRow.Cells["codcliente"].Value);
                cargardetalleretiro(Convert.ToInt32(DGListado.CurrentRow.Cells["Orden"].Value));
                this.tabControl1.SelectedTab = tabPage1;

                

            }
        }

        private void cargardetalleretiro(int norden)
        {
            if (GDDetalleretiro.Rows.Count != 0)
            {
                GDDetalleretiro.Rows.Clear();
            }
            DataTable midata = new DataTable();
            midata = NegocioOrdenpedido.buscarlistadodetalle(norden);
            foreach (DataRow mirow in midata.Rows)
            {
                GDDetalleretiro.Rows.Add(mirow ["idproducto"], mirow["Detalle"], 0, mirow["cantidadparcial"], mirow["cantidadtotal"], mirow["codigo"]);
            }

        }

        private void panelHorizontal_Move(object sender, EventArgs e)
        {

        }

        private void panelHorizontal_MouseMove(object sender, MouseEventArgs e)
        {
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

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                
                    recorreritems(Convert.ToInt32 (Txtitems.Text) );
                
            }
        }
        private void recorreritems(int codigobarra, int numeroincrementado = 1)
        {
            foreach (DataGridViewRow row in GDDetalleretiro.Rows)
            {
                if (Convert.ToInt64 (row.Cells["codigobarra"].Value)  == codigobarra)
                {
                    row.Cells["canactual"].Value = Convert.ToString(Convert.ToInt32(row.Cells["canactual"].Value) + numeroincrementado );
                    row.Cells["canparcial"].Value = Convert.ToString(Convert.ToInt32(row.Cells["canparcial"].Value) + numeroincrementado);
                }
                if (Convert.ToInt32(row.Cells["canparcial"].Value) > Convert.ToInt32(row.Cells["cantotal"].Value))
                {
                    UtilityFrm.mensajeError("La cantidad supera al total");
                    row.Cells["canactual"].Value = Convert.ToString(Convert.ToInt32(row.Cells["canactual"].Value) - numeroincrementado);
                    row.Cells["canparcial"].Value = Convert.ToString(Convert.ToInt32(row.Cells["canparcial"].Value) - numeroincrementado);
                }
                
            }
        }

        private void xuiSuperButton2_Click(object sender, EventArgs e)
        {
            guardar();
        }
        private bool recorreritemsparacambioestado()
        {
            bool cambiarestado = true;
            foreach (DataGridViewRow row in GDDetalleretiro.Rows)
            {
                if (row.Cells["canparcial"].Value != row.Cells["cantotal"].Value)
                {
                    cambiarestado = false;
                }
                
            }
                

            return cambiarestado;
        }
        private void guardar()
        {
            string varestado = "pendiente";
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo", typeof(string));
            dt.Columns.Add("Cantidadtotal", typeof(decimal));
            dt.Columns.Add("Detalle", typeof(string));
            dt.Columns.Add("Cantidadparcial", typeof(string));
            dt.Columns.Add("cantidadactual", typeof(string));
            if (recorreritemsparacambioestado () == true)
            {
                varestado = "finalizado";
            }

            foreach (DataGridViewRow fila in GDDetalleretiro.Rows)
            {
                dt.Rows.Add(fila.Cells["Codigo"].Value, fila.Cells["cantotal"].Value, fila.Cells["Detalle"].Value, fila.Cells["canparcial"].Value, fila.Cells["canactual"].Value);
            }
            //primero agrego el remito y despues modifico 
            if (NegocioOrdenpedido.modificarcantidad( Convert.ToInt32 (LblNorden.Text),varestado,dt,Convert.ToInt32 (LblCodcliente.Text), LblTipo.Text ) == "OK")
            {
               
            }
        }

        private void FrmStockRetirodeMercaderia_Load(object sender, EventArgs e)
        {
            
        



    }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            //maximizar
            this.btnRestaurar.Visible = true;
            this.btnMaximizar.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            //minimiza
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            //restaurar
            this.btnRestaurar.Visible = false;
            this.btnMaximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnCerrar_MouseLeave_1(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(0, 100, 200);
        }

        private void btnCerrar_MouseMove_1(object sender, MouseEventArgs e)
        {
            btnCerrar.BackColor = Color.Red;
        }

        private void btnMaximizar_MouseLeave_1(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(0, 100, 200);
        }

        private void btnMaximizar_MouseMove_1(object sender, MouseEventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(65, 39, 60);
        }

        private void btnRestaurar_MouseLeave_1(object sender, EventArgs e)
        {
            btnRestaurar.BackColor = Color.FromArgb(0, 100, 200);
        }

        private void btnRestaurar_MouseMove_1(object sender, MouseEventArgs e)
        {
            btnRestaurar.BackColor = Color.FromArgb(65, 39, 60);
        }

        private void btnMinimizar_MouseLeave_1(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(0, 100, 200);
        }

        private void btnMinimizar_MouseMove_1(object sender, MouseEventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(65, 39, 60);
        }

        private void panelHorizontal_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panelHorizontal_DoubleClick_1(object sender, EventArgs e)
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

        private void panelHorizontal_MouseMove_1(object sender, MouseEventArgs e)
        {
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
    }
}
