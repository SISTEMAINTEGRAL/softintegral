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
    public partial class FrmListadoPresup : Form
    {
        private int idpresupuesto;
        private bool isCerro = false;
        public FrmListadoPresup()
        {
            InitializeComponent();
        }

        private void ChkCliente_CheckedChanged(object sender, EventArgs e)
        {
            txtIdCliente.Enabled = ChkCliente.Checked;
            btnCliente.Enabled = ChkCliente.Checked;
            LblIdCliente.Enabled = ChkCliente.Checked;
            LblRazonsocial.Enabled = ChkCliente.Checked;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarPorFecha();
        }

        public void buscarPorFecha()
        {
            int codformapago = 0;
            
            dataLista.Rows.Clear();
            try
            {

                

                DataTable data = NegocioVenta.BuscarFechasPresupuesto(dtpFechaIni.Value.ToString("dd/MM/yyyy") + " 00:00:00", dtpFechaFin.Value.ToString("dd/MM/yyyy") + " 23:59:59",
                                                                      'P', txtIdVenta.Text != "" ? Convert.ToInt32(txtIdVenta.Text) : 0, ChkCliente.Checked == true ? Convert.ToInt32(LblIdCliente.Text) : 0);

                foreach (DataRow venta in data.Rows)
                {

                    string estado = venta["estado"].ToString();

                    if (estado.Equals("F"))
                    {
                        estado = "FACTURADO";

                    }
                    else if (estado.Equals("P"))
                    {
                        estado = "PENDIENTE DE APROBACION";
                    }
                    else if (estado.Equals("N"))
                    {
                        estado = "NOTA DE CREDITO";
                    }
                    else if (estado.Equals("A"))
                    {
                        estado = "ANULADO";
                    }
                    else
                    {
                        estado = "PRESUPUESTADO";
                    }
                    dataLista.Rows.Add(venta["idventa"], venta["razon_social"], venta["fecha"], estado , venta["idcliente"],
                        venta["cuit"], venta["total"]);
                }

            }

            catch (Exception ex)
            {
                UtilityFrm.mensajeError("Error Con Base de Datos :" + ex.Message);

            }



        }

        private void btnCliente_Click(object sender, EventArgs e)
        {



            FrmBusquedaAvaCliente cliente = new FrmBusquedaAvaCliente();

            cliente.ShowDialog();
            //si el usuario cierra la ventana isCerro es true, sino si selecciono algun articulo isCerro
            try
            {
                if (cliente.IsCerro)
                {
                    clienteIncorrecto();
                    txtIdCliente.Focus();

                }
                else
                {

                    LblIdCliente.Text = cliente.IdCliente.ToString();
                    LblRazonsocial.Text = cliente.RazonSocial.ToString();
                    

                    
                }

            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("Error al seleccionar un cliente. Causa:" + ex.Message + "cadena:" + ex.StackTrace);
                UtilityFrm.Log oLog = new UtilityFrm.Log();
                oLog.Add(ex.Message + ex.StackTrace);
                clienteIncorrecto();

                btnCliente.Focus();
            }
        }
        public void clienteIncorrecto()
        {
            //cuando el cliente no es encontrado o ingreso incorrecto de los datos

            //deselecciona el combobox de tipo comprobante
            //cbTipoComprobante.SelectedIndex = -1;
            LblIdCliente.Text = "...";
            LblRazonsocial.Text = "...";

            

        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtIdCliente.TextLength > 3 && !IsNumeric(txtIdCliente.Text))
            {


                DGCliente.Visible = true;


                DGCliente.DataSource = NegocioCliente.buscar(txtIdCliente.Text);

                DGCliente.Columns[0].Visible = false;
                DGCliente.Columns[1].Width = 350;
                DGCliente.Columns[2].Visible = false;
                DGCliente.Columns[3].Visible = false;
                DGCliente.Columns[4].Visible = false;
                DGCliente.Columns[5].Visible = false;
                DGCliente.Columns[6].Visible = false;
            }
            else
            {
                DGCliente.Visible = false;
            }
        }
        public bool IsNumeric(string input)
        {
            long test;

            return long.TryParse(input, out test);
        }

        private void txtIdCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Buscar_Cliente(Convert.ToInt32(txtIdCliente.Text));

                }
                catch (Exception ex)
                {
                    UtilityFrm.mensajeError("Error al seleccionar un cliente. Causa:" + ex.Message + "cadena:" + ex.StackTrace);
                    UtilityFrm.Log oLog = new UtilityFrm.Log();
                    oLog.Add(ex.Message + ex.StackTrace);
                    clienteIncorrecto();
                    btnCliente.Focus();

                }


            }
            if (e.KeyCode == Keys.Down && DGCliente.Visible == true)
            {
                DGCliente.Focus();
            }
        }
        public void Buscar_Cliente(int codCliente)
        {
            try
            {
                if (codCliente > 0)
                {
                    DataTable dt;
                    dt = NegocioCliente.buscarCodigoCliente(codCliente.ToString());


                    if (dt.Rows.Count != 0)
                    {
                        DataRow row = dt.Rows[0];
                        string cliente = row["razon_social"].ToString();
                        LblIdCliente.Text = row["idcliente"].ToString();
                        LblRazonsocial.Text = cliente;
                        

                    }
                    else
                    {
                        UtilityFrm.mensajeError("Error No se ha encontrado el Cliente");
                        clienteIncorrecto();
                        btnCliente.Focus();
                    }

                }
                else
                {
                    UtilityFrm.mensajeError("Error No se ha encontrado el Cliente");
                    clienteIncorrecto();
                    btnCliente.Focus();

                }
            }
            catch (Exception ex)
            {

                {
                    // Qué ha sucedido
                    var mensaje = "Error message: " + ex.Message;

                    // Información sobre la excepción interna
                    if (ex.InnerException != null)
                    {
                        mensaje = mensaje + " Inner exception: " + ex.InnerException.Message;
                    }

                    // Dónde ha sucedido
                    mensaje = mensaje + " Stack trace: " + ex.StackTrace;
                    UtilityFrm.Log oLog = new UtilityFrm.Log();
                    oLog.Add(mensaje);
                    UtilityFrm.mensajeError(mensaje);
                }

            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            IsCerro = true;
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //maximizar
            this.btnRestaurar.Visible = true;
            this.btnMaximizar.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //minimiza
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //restaurar
            this.btnRestaurar.Visible = false;
            this.btnMaximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
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
        private void btnCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCerrar.BackColor = Color.Red;
        }
        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(0, 100, 200);
        }
        private void btnRestaurar_MouseMove(object sender, MouseEventArgs e)
        {
            btnRestaurar.BackColor = Color.FromArgb(65, 39, 60);
        }
        private void btnRestaurar_MouseLeave(object sender, EventArgs e)
        {
            btnRestaurar.BackColor = Color.FromArgb(0, 100, 200);
        }
        private void btnMaximizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(65, 39, 60);
        }
        private void btnMaximizar_MouseLeave(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(0, 100, 200);
        }
        private void btnMinimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(65, 39, 60);
        }
        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(0, 100, 200);
        }

        int posY = 0;
        int posX = 0;

        public int Idpresupuesto { get => idpresupuesto; set => idpresupuesto = value; }
        public bool IsCerro { get => isCerro; set => isCerro = value; }

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

        private void FrmListadoPresup_Load(object sender, EventArgs e)
        {
            txtIdCliente.Enabled = ChkCliente.Checked;
            btnCliente.Enabled = ChkCliente.Checked;
            LblIdCliente.Enabled = ChkCliente.Checked;
            LblRazonsocial.Enabled = ChkCliente.Checked;
        }

        private void dataLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idpresupuesto = Convert.ToInt32(this.dataLista.CurrentRow.Cells["codigo"].Value);
            IsCerro = false;
            Close();
        }

        private void dataLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DTDetalleventa.DataSource = NegocioVenta.MostrarDetalle(dataLista.CurrentRow.Cells["Codigo"].Value.ToString());
        }

        private void dataLista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                DTDetalleventa.DataSource = NegocioVenta.MostrarDetalle(dataLista.CurrentRow.Cells["Codigo"].Value.ToString());
            }
        }

        private void dataLista_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            DTDetalleventa.DataSource = NegocioVenta.MostrarDetalle(dataLista.CurrentRow.Cells["Codigo"].Value.ToString());
        }

        private void dataLista_SelectionChanged(object sender, EventArgs e)
        {
            DTDetalleventa.DataSource = NegocioVenta.MostrarDetalle(dataLista.CurrentRow.Cells["Codigo"].Value.ToString());
        }

        private void DGCliente_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                
                
                
                    
                    LblIdCliente.Text = this.DGCliente.CurrentRow.Cells["idcliente"].Value.ToString();
                    LblRazonsocial.Text = this.DGCliente.CurrentRow.Cells["razon_social"].Value.ToString();
                    DGCliente.Visible = false;
                
            }
        }

        private void DGCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LblIdCliente.Text = this.DGCliente.CurrentRow.Cells["idcliente"].Value.ToString();
            LblRazonsocial.Text = this.DGCliente.CurrentRow.Cells["razon_social"].Value.ToString();
            DGCliente.Visible = false;
        }

        private void txtIdCliente_Validated(object sender, EventArgs e)
        {

        }
    }
}
