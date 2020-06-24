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
using Capa_Presentacion.Formreportes;
namespace Capa_Presentacion
{
    public partial class FrmStockRetirodeMercaderia : Form
    {
        int indice = -1;
        int posY = 0;
        int posX = 0;
        private int idcliente = 0;
        private int idempresa = 0;
        private int codventa = 0;
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
            DGListado.DataSource = NegocioRetirodeMercaderia.buscarconcatenacion( idcliente, CBEstado.Text,"" , dtpFechaIni.Value.ToString("dd/MM/yyyy") , dtpFechaFin.Value.ToString("dd/MM/yyyy") ,
                                                                          CHKCliente.Checked, CHKEstado.Checked, CHKTipo.Checked, CHKFecha.Checked,Convert.ToInt32(CbTipopedido.SelectedValue));
            DGDetalle.DataSource = null;


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
            DGDetalle.DataSource = NegocioRetirodeMercaderia.buscarlistadodetalle(Convert.ToInt32 (DGListado.CurrentRow.Cells["orden"].Value) );
            
        }

       
        private void DGListado_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DGListado.Rows.Count > 0)
            {
                //DateTime date = Convert.ToDateTime(this.dataLista.CurrentRow.Cells["fecha"].Value);

                LblNorden.Text = Convert.ToString(DGListado.CurrentRow.Cells["Orden"].Value);
                LblRazonsocial.Text = Convert.ToString(DGListado.CurrentRow.Cells["NombreBeneficiado"].Value);
                LblCuit.Text = Convert.ToString(DGListado.CurrentRow.Cells["cuit"].Value);
                LblEstado.Text = Convert.ToString(DGListado.CurrentRow.Cells["estado"].Value);
                LblTipo.Text = Convert.ToString(DGListado.CurrentRow.Cells["Tipo"].Value) ;
                LblCodcliente.Text = Convert.ToString(DGListado.CurrentRow.Cells["CodEmpresaB"].Value);
                LblEmpresa.Text = Convert.ToString(DGListado.CurrentRow.Cells["Tipo"].Value) == "VENTA" ? NegocioConfigEmpresa.emrazonsocial : Convert.ToString(DGListado.CurrentRow.Cells["razon_social"].Value);
                idempresa = Convert.ToString(DGListado.CurrentRow.Cells["Tipo"].Value) == "VENTA" ? 1 : Convert.ToInt32(DGListado.CurrentRow.Cells["codcliente"].Value);
                cargardetalleretiro(Convert.ToInt32(DGListado.CurrentRow.Cells["Orden"].Value));
                codventa = Convert.ToInt32(DGListado.CurrentRow.Cells["codventa"].Value);


                this.tabControl1.SelectedTab = tabPage1;
                recorreritems(0, 1, false);

                

            }
        }

        private void cargardetalleretiro(int norden)
        {
            if (GDDetalleretiro.Rows.Count != 0)
            {
                GDDetalleretiro.Rows.Clear();
            }
            DataTable midata = new DataTable();
            midata = NegocioRetirodeMercaderia.buscarlistadodetalle(norden);
            if (midata.Rows.Count != 0)
            {
                foreach (DataRow mirow in midata.Rows)
                {
                    GDDetalleretiro.Rows.Add(mirow["idproducto"], mirow["Detalle"], 0, mirow["cantidadparcial"], mirow["cantidadtotal"], mirow["codigo"]);
                }
            }
            else
            {
                UtilityFrm.mensajeError("El numero de orden no corresponde");
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

                if (CHKCambiarcantidad.Checked != true)
                {
                    recorreritems(Convert.ToInt64(Txtitems.Text));
                    Txtitems.Text = "";
                }
                else
                {
                    TXTCantidad.Focus();
                    TXTCantidad.SelectAll();
                }
                    
                
            }
        }
        private void recorreritems(long codigobarra, int numeroincrementado = 1, bool buscaritems = true)
        {
            int contador = -1;
            bool encontrado = false;
            indice = -1;

            foreach (DataGridViewRow row in GDDetalleretiro.Rows)
            {
               contador = contador + 1;
                if (buscaritems == true)
                {
                    if (Convert.ToInt64(row.Cells["codigobarra"].Value) == codigobarra)
                    {
                        encontrado = true;
                        indice = contador;
                        row.Cells["canactual"].Value = Convert.ToString(Convert.ToInt32(row.Cells["canactual"].Value) + numeroincrementado);
                        row.Cells["canparcial"].Value = Convert.ToString(Convert.ToInt32(row.Cells["canparcial"].Value) + numeroincrementado);
                        //GDDetalleretiro.CurrentCell = 1;
                        //row.Selected = true;
                        GDDetalleretiro.CurrentCell = GDDetalleretiro.Rows[row.Index].Cells[0];

                        //Me.dgv.FirstDisplayedScrollingRowIndex = I
                    }

                    if (Convert.ToInt32(row.Cells["canparcial"].Value) > Convert.ToInt32(row.Cells["cantotal"].Value))
                    {
                        UtilityFrm.mensajeError("La cantidad supera al total");
                        row.Cells["canactual"].Value = Convert.ToString(Convert.ToInt32(row.Cells["canactual"].Value) - numeroincrementado);
                        row.Cells["canparcial"].Value = Convert.ToString(Convert.ToInt32(row.Cells["canparcial"].Value) - numeroincrementado);
                    }
                }
               

                if (Convert.ToInt32(row.Cells["canparcial"].Value) == Convert.ToInt32(row.Cells["cantotal"].Value))
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(189, 236, 182);
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
                
            }
            if (encontrado == false && buscaritems == true)
            {
                UtilityFrm.mensajeError("El codigo que esta buscando no pertenece a la planilla");
            }
            Txtitems.SelectAll();
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
                if (Convert.ToDecimal (row.Cells["canparcial"].Value) != Convert.ToDecimal(row.Cells["cantotal"].Value) )
                {
                    cambiarestado = false;
                }
                

                
            }
            return cambiarestado;
        }
        private bool verificarcarga()
        {

            bool cargar = false;
            foreach (DataGridViewRow row in GDDetalleretiro.Rows)
            {
                if (Convert.ToDecimal(row.Cells["canactual"].Value) != 0)
                {
                    cargar = true;
                    break;
                }



            }


            return cargar;

        }
                

         
        private void guardar()
        {
            string varestado = "PENDIENTE";
            string mensaje = "";
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo", typeof(string));
            dt.Columns.Add("Cantidadtotal", typeof(decimal));
            dt.Columns.Add("Detalle", typeof(string));
            dt.Columns.Add("Cantidadparcial", typeof(string));
            dt.Columns.Add("cantidadactual", typeof(string));
            if (recorreritemsparacambioestado () == true)
            {
                varestado = "FINALIZADO";

            }
            mensaje = validacionformulario();
            //primero agrego el remito y despues modifico 
            if (mensaje == "ok")
            {
                foreach (DataGridViewRow fila in GDDetalleretiro.Rows)
                {
                    dt.Rows.Add(fila.Cells["Codigo"].Value, fila.Cells["cantotal"].Value, fila.Cells["Detalle"].Value, fila.Cells["canparcial"].Value, fila.Cells["canactual"].Value);
                }
              
                    string nroremito = "";
                mensaje = NegocioRetirodeMercaderia.modificarcantidad(Convert.ToInt32(LblNorden.Text), varestado, dt, Convert.ToInt32(LblCodcliente.Text), LblTipo.Text, ref nroremito,idempresa);
                    if (mensaje == "ok")
                    {
                    if (varestado == "FINALIZADO" && codventa != 0)
                    {
                        NegocioVenta.actualizarestadostock(codventa, true);
                    }
                        FrmTicketRemito objremito = new Formreportes.FrmTicketRemito(nroremito);
                        objremito.ShowDialog();
                        UtilityFrm.mensajeConfirm("Se genero el remito con exito");
                        limpiarformulario();

                    }
                else
                {
                    UtilityFrm.mensajeError(mensaje);
                }

                }
                else
                {
                    UtilityFrm.mensajeError(mensaje);
                }

           

        }
        private void limpiarformulario()
        {
            GDDetalleretiro.Rows.Clear();
            LblCodcliente.Text = "...";
            LblCuit.Text = "...";
            LblEstado.Text = "...";
            LblNorden.Text = "...";
            LblTipo.Text = "...";
            LblRazonsocial.Text = "...";
            LblEmpresa.Text = "";
           

        }
        private string validacionformulario()
        {
            string validar = "ok";

            

            if (verificarcarga () == false)
            {
                validar = "No se ingreso cantidad actual a cargar";
            }

            if (GDDetalleretiro.RowCount == 0)
            {
                validar = "El Detalle de la mercaderia se encuentra en cero no puede continuar";
            }

            if (LblNorden.Text == "...")
            {
                validar = "La orden no se encuentra cargada"; 
            }
            return validar;
        }
        private void FrmStockRetirodeMercaderia_Load(object sender, EventArgs e)
        {

            CBBuscarportipo.Text = "VENTA";
            CBEstado.Text = "PENDIENTE";
            UtilityFrm.completarcombobox(CbTipopedido, "NroTipo", "Nombre", NegocioRetirodeMercaderia.buscartiporetiro(), true);
            //textBox1.Text = "Introdusca el numero de registro a buscar";
            //textBox1.ForeColor = Color.Gray;


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

        private void Txtitems_TextChanged(object sender, EventArgs e)
        {
            if ((IsNumeric(Txtitems.Text) == true) && (Txtitems.TextLength >= 13))
            {
                //recorreritems(Convert.ToInt64(Txtitems.Text));
                //Txtitems.Text = "";
            }
        }
             public bool IsNumeric(string input)
        {
            long test;

            return long.TryParse(input, out test);
        }

        private void CHKFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaFin.Enabled = CHKFecha.Checked;
            dtpFechaIni.Enabled = CHKFecha.Checked;
        }

        private void CHKEstado_CheckedChanged(object sender, EventArgs e)
        {
            CBEstado.Enabled = CHKEstado.Checked;
        }

        private void CHKTipo_CheckedChanged(object sender, EventArgs e)
        {
            CbTipopedido.Enabled = CHKTipo.Checked;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                Txtitems.Focus();
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                DGListado.DataSource = NegocioRetirodeMercaderia.buscarconcatenacion(idcliente, CBEstado.Text, "", dtpFechaIni.Value.ToString("dd/MM/yyyy"), dtpFechaFin.Value.ToString("dd/MM/yyyy"),
                                                                          CHKCliente.Checked, CHKEstado.Checked, CHKTipo.Checked, CHKFecha.Checked, Convert.ToInt32(CbTipopedido.SelectedValue));
            }
        }

        private void GDDetalleretiro_KeyDown(object sender, KeyEventArgs e)
        {
            int cantidad = 0;
            if (e.KeyCode == Keys.F1)
            {
               cantidad = Convert.ToInt32(this.GDDetalleretiro.CurrentRow.Cells["canparcial"].Value) - Convert.ToInt32 (this.GDDetalleretiro.CurrentRow.Cells["canactual"].Value) ;
                this.GDDetalleretiro.CurrentRow.Cells["canparcial"].Value = cantidad;
                this.GDDetalleretiro.CurrentRow.Cells["canactual"].Value = 0 ;
            }
        }

        private void GDDetalleretiro_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FrmStockRetirodeMercaderia_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        private void cambiartextbox()
        {
            if (CHKCambiarcantidad.Checked == true)
            {
                if (indice < 0)
                {
                    GDDetalleretiro.Rows[GDDetalleretiro.Rows.Count - 1].Cells[3].Selected = true;
                }
                else
                {
                    GDDetalleretiro.Rows[indice].Cells[3].Selected = true;
                }

                //  DGDetalleitems.Rows[DGDetalleitems.CurrentCell.RowIndex].Selected = true;
                Rectangle rec = GDDetalleretiro.GetCellDisplayRectangle(GDDetalleretiro.CurrentCell.ColumnIndex, GDDetalleretiro.CurrentCell.RowIndex, false);
                GDDetalleretiro.Focus();


                TxtcambioDv.Location = new Point(rec.Location.X + GDDetalleretiro.Location.X, rec.Location.Y + GDDetalleretiro.Location.Y);

                TxtcambioDv.Visible = true;
                TxtcambioDv.Text = GDDetalleretiro.CurrentCell.Value.ToString();
                TxtcambioDv.Focus();
            }
            else
            {
                Txtitems.Focus();
            }


        }

        private void TXTCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TXTCantidad.Text != "")
                {
                    recorreritems(Convert.ToInt64(Txtitems.Text), Convert.ToInt32(TXTCantidad.Text));
                    Txtitems.Text = "";
                    TXTCantidad.Text = "0";
                    Txtitems.Focus();
                    CHKCambiarcantidad.Checked = false;
                }
            }
            
        }

        private void CHKCambiarcantidad_CheckedChanged(object sender, EventArgs e)
        {
            TXTCantidad.Enabled = CHKCambiarcantidad.Checked;
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                if (e.KeyCode == Keys.F10)
                {
                    if (CHKCambiarcantidad.Checked == true)
                    {
                        CHKCambiarcantidad.Checked = false;
                    }
                    else
                    {
                        CHKCambiarcantidad.Checked = true;
                    }

                }

            }
        }

        private void CHKCliente_CheckedChanged(object sender, EventArgs e)
        {
            txtIdCliente.Enabled = CHKCliente.Checked;
            BtnBuscarcliente.Enabled = CHKCliente.Checked;
            TxtCuit.Enabled = CHKCliente.Checked;
            TxtRazonsocial.Enabled = CHKCliente.Checked;
            
        }

        private void BtnBuscarcliente_Click(object sender, EventArgs e)
        {
            FrmBusquedaAvaCliente cliente = new FrmBusquedaAvaCliente();

            cliente.ShowDialog();
            if (!cliente.IsCerro)
            {
                TxtRazonsocial.Text = cliente.RazonSocial.ToString();
                TxtCuit.Text = cliente.Cuit.ToString();
                idcliente = Convert.ToInt32(cliente.IdCliente.ToString()) ;
            }
                
        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtIdCliente.TextLength >= 2 && IsNumeric(txtIdCliente.Text) != true)
            {
                DGCliente.Visible = true;
               

                DGCliente.DataSource = NegocioCliente.buscar(txtIdCliente.Text);

                if (DGCliente.Rows.Count != 0)
                {
                    DGCliente.Columns[0].Visible = false;

                    DGCliente.Columns[1].Width = 350;
                    DGCliente.Columns[2].Visible = false;
                    DGCliente.Columns[3].Visible = false;
                    DGCliente.Columns[4].Visible = false;
                    DGCliente.Columns[5].Visible = false;
                    DGCliente.Columns[6].Visible = false;
                }
                
            }
            else if ((IsNumeric(txtIdCliente.Text) == true) && (txtIdCliente.TextLength >= 8))
            {
                DGCliente.Visible = true;

                if (DGCliente.Rows.Count != 0)
                {
                    DGCliente.Columns[0].Visible = false;

                    DGCliente.Columns[1].Width = 350;
                    DGCliente.Columns[2].Visible = false;
                    DGCliente.Columns[3].Visible = false;
                    DGCliente.Columns[4].Visible = false;
                    DGCliente.Columns[5].Visible = false;
                    DGCliente.Columns[6].Visible = false;
                }

                DGCliente.DataSource = NegocioCliente.buscarCodigoCliente(txtIdCliente.Text, 7);
            }
            else
            {
                DGCliente.Visible = false;
            }

        }

        private void txtIdCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && DGCliente.Visible == true)
            {
                //si se preciona la tecla hacia abajo se pasa el foco a la grilla
                DGCliente.Focus();

            }
        }

        private void DGCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarcliente(this.DGCliente.CurrentRow.Cells["idcliente"].Value.ToString());
                DGCliente.Visible = false;
                txtIdCliente.Text = "";
            }
        }

        private void buscarcliente(string codcliente)
        {
            DataTable Tablacliente = new DataTable();
            Tablacliente = NegocioCliente.buscarCodigoCliente(codcliente);

            if (Tablacliente.Rows.Count != 0)
            {
                DataRow row = Tablacliente.Rows[0];
                TxtCuit.Text = row["cuit"].ToString();
                TxtRazonsocial.Text = row["razon_social"].ToString();
                idcliente = Convert.ToInt32(row["idcliente"].ToString()) ;
                //string cliente = row["razon_social"].ToString();
                //cuit = row["cuit"].ToString();
                //riva = row["responsabilidadiva"].ToString();
                //domicilio = row["direccion"].ToString();
            }
            
        }

        private void DGCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            buscarcliente(this.DGCliente.CurrentRow.Cells["idcliente"].Value.ToString());
            txtIdCliente.Text = "";
            DGCliente.Visible = false;
        }

        private void DGListado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
               // DGDetalle.DataSource = NegocioVenta.MostrarDetalle(DGListado.CurrentRow.Cells["orden"].Value.ToString());
            }
        }

        private void DGListado_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //DGDetalle.DataSource = NegocioVenta.MostrarDetalle(DGListado.CurrentRow.Cells["orden"].Value.ToString());
        }

        private void DGListado_SelectionChanged(object sender, EventArgs e)
        {
            DGDetalle.DataSource = NegocioRetirodeMercaderia.buscarlistadodetalle(Convert.ToInt32(DGListado.CurrentRow.Cells["orden"].Value));
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            //textBox1.Text = "";
            //textBox1.ForeColor = Color.Black;
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            DataTable midatatable = new DataTable();
            if (e.KeyCode == Keys.Enter)
            {
                if (CBBuscarportipo.Text == "ADJUDICACION")
                {
                    midatatable = NegocioRetirodeMercaderia.buscarconcatenacion(0, "", "", DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("dd/MM/yyyy"), false, false, false, false, 0, true, Convert.ToInt32(textBox1.Text));
                }    
                    if (CBBuscarportipo.Text == "VENTA")
                    {
                        midatatable = NegocioRetirodeMercaderia.buscarconcatenacion(0, "", "", DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("dd/MM/yyyy"), false, false, false, false, 0, false, 0,true,Convert.ToInt32(textBox1.Text) );
                    }
                if (midatatable.Rows.Count != 0)
                {
                    DataRow row = midatatable.Rows[0];
                    LblNorden.Text = row["Orden"].ToString();
                    LblRazonsocial.Text = row["NombreBeneficiado"].ToString();
                    LblCuit.Text = row["cuit"].ToString();
                    LblEstado.Text = row["estado"].ToString();
                    LblTipo.Text = row["Tipo"].ToString();
                    LblCodcliente.Text = row["CodEmpresaB"].ToString();
                    LblEmpresa.Text = row["Tipo"].ToString() == "VENTA" ? NegocioConfigEmpresa.emrazonsocial : row["razon_social"].ToString();
                    idempresa = row["Tipo"].ToString() == "VENTA" ? 1 : Convert.ToInt32(row["codcliente"].ToString());
                    cargardetalleretiro(Convert.ToInt32(row["Orden"].ToString()));
                    Txtitems.Focus();
                }
                else
                {
                    UtilityFrm.mensajeError("La orden que ingreso es inexistente");
                    textBox1.SelectAll();
                }



            }
        }

        private void DGListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
