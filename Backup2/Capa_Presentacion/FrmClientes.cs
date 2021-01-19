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
    public partial class FrmClientes : Form
    {
        private bool modoshowdialog;
        private int idcliente;
        private DataTable midata;
        bool isEditar = false;
         bool isNuevo = false;
         int posY = 0;
         int posX = 0;
        private decimal totalsaldo;

        public bool Modoshowdialog
        {
            get
            {
                return modoshowdialog;
            }

            set
            {
                modoshowdialog = value;
            }
        }

        public int Idcliente
        {
            get
            {
                return idcliente;
            }

            set
            {
                idcliente = value;
            }
        }

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            cbFormapago.SelectedIndex = 2;
            isEditar = false;
            isNuevo = false;
            this.txtNombre.Focus();
            ocultarColumnas();
            mostrar();
            cbrespiva.DataSource = NegocioCliente.responsabilidadiva();
            cbrespiva.ValueMember = "id";
            //lo que se muestra
            cbrespiva.DisplayMember = "descripcion";
            cbrespiva.SelectedIndex = 3;

            Cbprovincia.DataSource = NegocioCliente.provincia();
            Cbprovincia.ValueMember = "id";
            //lo que se muestra
            Cbprovincia.DisplayMember = "provincia";
            Cbprovincia.SelectedValue = 5;
           


            //Cbprovincia.SelectedIndex  = 4;
           
        }

        //metodos propios
        private void mostrar()
        {
            try
            {
                this.dataLista.DataSource = NegocioCliente.mostrar();
                if (dataLista.Rows.Count != 0)
                {
                    dataLista.Columns["saldo"].DefaultCellStyle.Format = String.Format("$###,##0.00");
                }
            }
            catch (Exception ex)
            {
                UtilityFrm.mensajeError("error con la Base de datos: " + ex.Message);
            }
            //datasource el origen de los datos,muestra las categorias en la grilla

            //oculto las dos primeras columnas
            this.ocultarColumnas();
            //muestro el total de las categorias
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.RowCount);

        }
        private void ocultarColumnas()
        {
            //no muestro la columna eliminar categoria
            this.dataLista.Columns[0].Visible = false;

        }
        private void BuscarNombre()
        {
            try
            {
                if (Chkcodinterno.Checked == true)
                {
                    this.dataLista.DataSource = NegocioCliente.buscar(this.txtNombre.Text,11);
                }
                else
                {
                    this.dataLista.DataSource = NegocioCliente.buscar(this.txtNombre.Text);
                }
                
            }

            catch (Exception ex)
            {
                UtilityFrm.mensajeError("Error Con Base de Datos :" + ex.Message);

            }
            //datasource el origen de los datos 

            //oculto las dos primeras columnas
            this.ocultarColumnas();
            //muestro el total de las categorias
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.RowCount);

        }

        //botones

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
            UtilityFrm.limpiarTextbox(txtDireccion, txtRazonSocial, txtCodigo, txtCuit, txtDocumento);
            UtilityFrm.limpiarTextbox(txtTelefono, txtEmail);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
            UtilityFrm.limpiarTextbox(txtDireccion, txtRazonSocial, txtCodigo, txtCuit, txtDocumento);
            UtilityFrm.limpiarTextbox(txtTelefono, txtEmail);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //limpio textbox
            UtilityFrm.limpiarTextbox(txtDireccion, txtRazonSocial, txtNombre, txtCodigo, txtCuit, txtDocumento);
            UtilityFrm.limpiarTextbox(txtTelefono, txtEmail,TxtCtaCTe);

            habilitarbotones(false, true, false, true);
            cbrespiva.SelectedIndex = 2;
            //habilitar botones
            //this.btnGuardar.Enabled = true;
            //this.btnEditar.Enabled = false;
            //this.btnCancelar.Enabled = true;
            //this.btnNuevo.Enabled = false;


            ////habilitar textbox
            //this.txtDireccion.Enabled = true;
            //this.txtRazonSocial.Enabled = true;
            //this.txtNombre.Enabled = true;
            //this.txtCodigo.Enabled = true;
            //this.txtCuit.Enabled = true;
            //this.txtDocumento.Enabled = true;
            //this.txtTelefono.Enabled = true;
            //this.txtEmail.Enabled = true;
            //this.dtimeFechaNacimiento.Enabled = true;

            this.txtRazonSocial.Focus();
            //isEditar = false;
            //isNuevo = true;
          
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;

            this.txtCodigo.Enabled = false;
            this.txtCuit.Enabled = false;
            this.txtDireccion.Enabled = false;
            this.txtDocumento.Enabled = false;
            this.txtEmail.Enabled = false;
            this.txtRazonSocial.Enabled = false;
            this.txtTelefono.Enabled = false;
            this.dtimeFechaNacimiento.Enabled = false;
            Txtcodinterno.Enabled = false;
            //limpio textbox
            UtilityFrm.limpiarTextbox(txtDireccion, txtRazonSocial, txtNombre, txtCodigo, txtCuit, txtDocumento);
            UtilityFrm.limpiarTextbox(txtTelefono, txtEmail,TxtCtaCTe);
            limpiarformularioctacte();

            isEditar = false;
            isNuevo = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";

                //si el string es nulo o vacio 
                if (String.IsNullOrEmpty(txtRazonSocial.Text))
                {
                    UtilityFrm.mensajeError("El Campo Nombre está incompleto");
                    errorIcono.SetError(txtRazonSocial, "Ingrese un nombre");

                }
                else
                {

                    if (isNuevo == true)
                    {
                        //variables locales para almacenar los datos vacios
                        int telefono = 0;
                        int cuit = 0;
                        int documento = 0;
                        if(txtTelefono.Text==string.Empty){
                            txtTelefono.Text = telefono.ToString();

                        }
                        if (txtCuit.Text == string.Empty)
                        {
                            txtCuit.Text = cuit.ToString();

                        }
                        if (txtDocumento.Text == string.Empty)
                        {
                            txtDocumento.Text = documento.ToString();

                        }

                        respuesta = NegocioCliente.insertar(txtRazonSocial.Text.Trim(), txtDireccion.Text.Trim(), Convert.ToInt64(txtCuit.Text.Trim()), txtTelefono.Text.Trim() != "" ? Convert.ToInt64(txtTelefono.Text.Trim()) : 0, Convert.ToInt64(txtDocumento.Text.Trim()), txtEmail.Text.Trim(), cbrespiva.SelectedValue.ToString(), Convert.ToInt32(Cbprovincia.SelectedValue), Convert.ToInt32(CBlocalidad.SelectedValue),Txtcodinterno.Text,ChkHabilitarctacte.Checked,Convert.ToDecimal(TxtCtaCTe.Text) );

                        if (respuesta.Equals("ok"))
                        {
                            UtilityFrm.mensajeConfirm("Se Agregó Correctamente");
                            this.mostrar();
                        }
                        else
                        {
                            UtilityFrm.mensajeError("No se ha podido guardar: " + respuesta);
                        }


                    }
                    //si se va a editar
                    else if (isEditar == true)
                    {

                        //respuesta = NegocioArticulo.editar(Convert.ToInt32(txtCodigo.Text.Trim()), Convert.ToString(txtNombreConfig.Text.Trim()), txtCodigoBarra.Text.Trim(), Convert.ToString(txtDescripcion.Text.Trim()), Convert.ToInt32(cbxCategoria.SelectedValue));
                        respuesta = NegocioCliente.editar(Convert.ToInt32(txtCodigo.Text.Trim()), txtRazonSocial.Text.Trim(), txtDireccion.Text.Trim(), Convert.ToInt64(txtCuit.Text.Trim()), txtTelefono.Text.Trim() != "" ? Convert.ToInt64(txtTelefono.Text.Trim()) : 0, Convert.ToInt64(txtDocumento.Text.Trim()), txtEmail.Text.Trim(), cbrespiva.SelectedValue.ToString(), Convert.ToInt32(Cbprovincia.SelectedValue), Convert.ToInt32(CBlocalidad.SelectedValue), Txtcodinterno.Text,ChkHabilitarctacte.Checked,Convert.ToDecimal( TxtCtaCTe.Text));

                        if (respuesta.Equals("ok"))
                        {
                            UtilityFrm.mensajeConfirm("Se Editó Correctamente");
                            this.mostrar();


                       }
                        else
                        {
                            UtilityFrm.mensajeError("No se ha podido guardar: " + respuesta);

                        }

                    }
                    else
                    {
                        UtilityFrm.mensajeError("No se ha podido guardar: " + respuesta);

                    }

                    //habilito el codigo para poder editar
                    habilitarbotones(true, false,false,false);
                    UtilityFrm.limpiarTextbox(txtCodigo,
                    txtEmail,txtNombre,txtRazonSocial,txtTelefono,txtCuit);
                    UtilityFrm.limpiarTextbox(txtDireccion);
                    limpiarformularioctacte();
                    this.btnNuevo.Focus();

                }



            }
            catch (Exception ex)
            {
                UtilityFrm.mensajeError("error: " + ex.Message + " ;" + ex.StackTrace);
            }
            isEditar = false;
            isNuevo = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //maximizar
            //this.btnRestaurar.Visible = true;
            //this.btnMaximizar.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            //btnCerrar.BackColor = Color.FromArgb(0, 100, 200);
        }

        private void btnCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            //btnCerrar.BackColor = Color.Red;
        }

        private void btnMaximizar_MouseLeave(object sender, EventArgs e)
        {
           //btnMaximizar.BackColor = Color.FromArgb(0, 100, 200);
        }

        private void btnMaximizar_MouseMove(object sender, MouseEventArgs e)
        {
            //btnMaximizar.BackColor = Color.FromArgb(65, 39, 60);
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //restaurar
            //this.btnRestaurar.Visible = false;
            //this.btnMaximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //minimiza
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            //btnMinimizar.BackColor = Color.FromArgb(0, 100, 200);
        }

        private void btnMinimizar_MouseMove(object sender, MouseEventArgs e)
        {
            //btnMinimizar.BackColor = Color.FromArgb(65, 39, 60);
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

        private void panelHorizontal_DoubleClick(object sender, EventArgs e)
        {
            //if (btnRestaurar.Visible == false || btnMaximizar.Visible == true)
            //{
            //    //maximizar
            //    this.btnRestaurar.Visible = true;
            //    this.btnMaximizar.Visible = false;
            //    this.WindowState = FormWindowState.Maximized;

            //}
            //else
            //{
            //    //restaurar
            //    this.btnRestaurar.Visible = false;
            //    this.btnMaximizar.Visible = true;
            //    this.WindowState = FormWindowState.Normal;
            //}
        }

        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarbotones(false, true, true, false);
        }

        private void habilitarbotones(bool var, bool var1, bool editar, bool nuevo)
        {
            //habilitar botones

            this.btnEditar.Enabled = var;
            this.btnNuevo.Enabled = var;


            //habilitar textbox
            this.btnGuardar.Enabled = var1;
            this.btnCancelar.Enabled = var1;
            this.txtDireccion.Enabled = var1;
            this.txtRazonSocial.Enabled = var1;
            this.txtNombre.Enabled = var1;
            this.txtCodigo.Enabled = var1;
            this.txtCuit.Enabled = var1;
            this.txtDocumento.Enabled = var1;
            this.txtTelefono.Enabled = var1;
            this.txtEmail.Enabled = var1;
            this.cbrespiva.Enabled = var1;
            this.CBlocalidad.Enabled = var1;
            this.Cbprovincia.Enabled = var1;
            this.Txtcodinterno.Enabled = var1;
            this.TxtCtaCTe.Enabled = var1;
            this.ChkHabilitarctacte.Enabled = var1;

            isEditar = editar;
            isNuevo = nuevo;
        
        }

        private void dataLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (modoshowdialog == true)
            {
                idcliente = Convert.ToInt32 ( this.dataLista.CurrentRow.Cells["idcliente"].Value);
                buscarctacte(idcliente);
                this.Close();
            }
            else
            {
                string categoriaiva = "";
                txtCodigo.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["idcliente"].Value);
                LblCodcliente.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["idcliente"].Value);
                txtRazonSocial.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["razon_social"].Value);
                LblRazonSocialCTACTE.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["razon_social"].Value);
                txtCuit.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["cuit"].Value);
                LblCuitCtaCte.Text= Convert.ToString(this.dataLista.CurrentRow.Cells["cuit"].Value);
                txtDireccion.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["direccion"].Value);
                txtTelefono.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["telefono"].Value);
                txtEmail.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["email"].Value);
                txtDocumento.Text = "0";
                categoriaiva = Convert.ToString(this.dataLista.CurrentRow.Cells["responsabilidadiva"].Value);
                LblRespiva.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["responsabilidadiva"].Value);
                Cbprovincia.SelectedValue = Convert.ToInt32(this.dataLista.CurrentRow.Cells["idprovincia"].Value);
                CBlocalidad.SelectedValue = Convert.ToInt32(this.dataLista.CurrentRow.Cells["idlocalidad"].Value);
                idcliente = Convert.ToInt32(this.dataLista.CurrentRow.Cells["idcliente"].Value);
                totalsaldo = Convert.ToDecimal( this.dataLista.CurrentRow.Cells["saldo"].Value.ToString());
                ChkHabilitarctacte.Checked = Convert.ToBoolean(this.dataLista.CurrentRow.Cells["habilitarctacte"].Value);
                TxtCtaCTe.Text = this.dataLista.CurrentRow.Cells["limitedectacte"].Value.ToString();
                TxtSaldoTotal.Text = totalsaldo.ToString("0.00");
                
               
                if (categoriaiva == "CF")
                {
                    cbrespiva.SelectedIndex = 2;
                }
                if (categoriaiva == "EX")
                {
                    cbrespiva.SelectedIndex = 3;
                }
                if (categoriaiva == "RI")
                {
                    cbrespiva.SelectedIndex = 0;
                }

                if (categoriaiva == "MN")
                {
                    cbrespiva.SelectedIndex = 1;
                }


                habilitarbotones(true, false, false, false);
                this.tabControl1.SelectedTab = tabAgregarOcambiar;
                buscarctacte(Convert.ToInt32(this.dataLista.CurrentRow.Cells["idcliente"].Value));
                
                


            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panelHorizontal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtRazonSocial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCuit.Focus();
            }
        }

        private void txtCuit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                txtDireccion.Focus();
            }
        }

        private void txtDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                txtTelefono.Focus();
            }
        }

        private void txtDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDireccion.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbrespiva.Focus();
            }
        }

        private void cbrespiva_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                Cbprovincia.Focus();
            }
        }



        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                txtEmail.Focus();
            }
        }

        private void Cbprovincia_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Cbprovincia.ValueMember  != "")
            {
                CBlocalidad.DataSource = NegocioCliente.localidad(Convert.ToInt32(Cbprovincia.SelectedValue));
                //valor real de la DB
                this.CBlocalidad.ValueMember = "id";
                //lo que se muestra
                this.CBlocalidad.DisplayMember = "localidad";
                CBlocalidad.AutoCompleteCustomSource = LoadAutoComplete(NegocioCliente.localidad(Convert.ToInt32(Cbprovincia.SelectedValue)));
                CBlocalidad.AutoCompleteMode = AutoCompleteMode.Suggest;
                CBlocalidad.AutoCompleteSource = AutoCompleteSource.CustomSource;
               // Cbprovincia.SelectedValue = 429;
            }
            
        }

        public static AutoCompleteStringCollection LoadAutoComplete(DataTable dt)
        {
           // DataTable dt = NegocioCliente.localidad(Convert.ToInt32(Cbprovincia.SelectedValue));

            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();

            foreach (DataRow row in dt.Rows)
            {
                stringCol.Add(Convert.ToString(row["localidad"]));
            }

            return stringCol;
        }

        private void Cbprovincia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CBlocalidad.Focus();
            }
        }

        private void CBlocalidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGuardar.Focus();
            }
        }

        private void btnRestaurar_MouseLeave(object sender, EventArgs e)
        {
            //btnRestaurar.BackColor = Color.FromArgb(0, 100, 200);
        }

        private void btnRestaurar_MouseMove(object sender, MouseEventArgs e)
        {
            //btnRestaurar.BackColor = Color.FromArgb(65, 39, 60);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmClienteCtaCte objctacte = new FrmClienteCtaCte(Convert.ToInt32(txtCodigo.Text) );
            objctacte.ShowDialog();
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                this.BuscarNombre();
                UtilityFrm.limpiarTextbox(txtDireccion, txtRazonSocial, txtCodigo, txtCuit, txtDocumento);
                UtilityFrm.limpiarTextbox(txtTelefono, txtEmail);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void dataLista_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MenuDelete.Visible = true;
            }
            else
            {
                MenuDelete.Visible = false;
            }
            contextMenuStrip1.Show(dataLista, new Point(e.X, e.Y));
        }
        private void MenuDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
        private void limpiarformularioctacte()
        {
            LblCodcliente.Text = "...";
            LblCuitCtaCte.Text = "...";
            LblRazonSocialCTACTE.Text = "...";
            LblRespiva.Text = "...";
            TxtCtaCTe.Text = "0";
            //DGListado.Rows.Clear();
        }
        private void BtnAsentarpago_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            decimal saldo = 0;
            int  codrecibo = 0;
            string mensaje = "";
            
            DataTable datacliente = new DataTable();
            midata = new DataTable();
            Negociocaja objcaja = new Negociocaja();

            midata.Columns.Add("Idventa", typeof(int));
            midata.Columns.Add("saldo", typeof(decimal));
            midata.Columns.Add("pagado", typeof(decimal));
            midata.Columns.Add("total", typeof(decimal));
            midata.Columns.Add("estado", typeof(string));
            midata.Columns.Add("grabar", typeof(string));

            

            if (NegocioConfigEmpresa.confsistema("controlarcaja").ToString() == "True" && objcaja.chequeocaja(this.Name, ref mensaje, NegocioConfigEmpresa.nrocaja) == false)
            {
                UtilityFrm.mensajeError(mensaje);
                return;
            }

            if ( traerpagototal(false) != 0)
            {
                Frmasentarpago objpago = new Frmasentarpago( traerpagototal(true));
                objpago.Midatatable = midata;
                objpago.ShowDialog();
                if (objpago.Confirmarpago == true)
                {
                 cargardatatable(objpago.Importe);
                    //objpago.importe en ves de pagototal
                 respuesta =   NegocioCliente.agregaromodificarrecibo(midata,objpago.Importe, idcliente,NegocioConfigEmpresa.idusuario, ref codrecibo);
                }


                if (respuesta == "ok")
                {
                    if (objcaja.chequeocaja("FrmClientes", ref mensaje,NegocioConfigEmpresa.nrocaja) == true)
                    {
                        respuesta = Negociocaja.insertarmovcaja(1310101, Convert.ToSingle(objpago.Importe), 0, Convert.ToString(DateTime.Now), NegocioConfigEmpresa.usuarioconectado, NegocioConfigEmpresa.idusuario, NegocioConfigEmpresa.turno, "Recibo nro : " + codrecibo.ToString(), codrecibo, true,NegocioConfigEmpresa.nrocaja,1);
                        if (respuesta == "ok")
                        {
                            NegocioCliente.modificarestadocajarecibo(codrecibo);
                        }
                    } 
                    FrmReporteRecibo formrecibo = new Formreportes.FrmReporteRecibo(codrecibo);
                    formrecibo.ShowDialog();
                    UtilityFrm.mensajeConfirm("El pago se guardo con exito");
                    buscarctacte(Convert.ToInt32(txtCodigo.Text == string.Empty ? "0" : txtCodigo.Text));
                    mostrar();
                    datacliente = NegocioCliente.buscarCodigoCliente(LblCodcliente.Text);
                    
                    if (datacliente.Rows.Count != 0)
                    {
                        DataRow row = datacliente.Rows[0];
                        totalsaldo = Convert.ToDecimal( row["saldo"].ToString());
                        TxtSaldoTotal.Text =   totalsaldo.ToString("0.00");
                    }
                       
                    
                }



            }
            else
            {
                UtilityFrm.mensajeError("No hay saldo");
            }
        }
        public void buscarPorFecha(int codcliente)
        {
            int codformapago = 0;
            switch (cbFormapago.Text)
            {
                case "EFECTIVO":
                    {
                        codformapago = 1;
                        break;
                    }
                case "TARJETA":
                    {
                        codformapago = 2;
                        break;
                    }
                case "CTACTE":
                    {
                        codformapago = 3;
                        break;
                    }
                case "MULTIPLESPAGOS":
                    {
                        codformapago = 5;
                        break;
                    }
                default:
                    break;
            }
            DgCliente.Rows.Clear();
            try
            {

                DataTable dt = NegocioVenta.BuscarFechas(dtpFechaIni.Value.ToString("dd/MM/yyyy") + " 00:00:00", dtpFechaFin.Value.ToString("dd/MM/yyyy") + " 23:59:59",
                    'T', true, Factura(),
                     0, "0", codformapago,
                   false, cbFormapago.Text != "TODO" ? true : false, false,false,codcliente);

                foreach (DataRow venta in dt.Rows)
                {

                    string estado = venta["estado"].ToString();
                    
                   

                    if (estado.Equals("F"))
                    {
                        estado = "FACTURADO";

                    }
                    else if (estado.Equals("P"))
                    {
                        estado = "PENDIENTE";
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

                    if (estado != "PRESUPUESTADO")
                    {
                        DgCliente.Rows.Add(venta["idventa"], venta["razon_social"], venta["fecha"], venta["tipo_comprobante"], venta["total"], estado, venta["caja"], venta["idcliente"],
                        venta["cuit"], venta["Nrocomprobante"], venta["factura"], venta["Neto21"], venta["Totaliva21"], venta["Total_Neto105"], venta["Totaliva105"], venta["CAE"],
                        venta["CAE_Fechavencimiento"], venta["enstock"], venta["PAGO"]);
                    }
                   
                    
                }

            }

            catch (Exception ex)
            {
                UtilityFrm.mensajeError("Error Con Base de Datos :" + ex.Message);

            }



        }
        private string Factura()
        {
            string fact = "NOTA DE VENTA";
            


            return fact;


        }

        private decimal traerpagototal(bool cargardatatable)
        {
            decimal contpago = 0;

            

            foreach (DataGridViewRow row in DGListado.Rows)
            {
                
                //tener en cuenta a la hora de checkear colocar el evento CurrentCellDirtyStateChanged para futuros datagridview
                if (Convert.ToBoolean(row.Cells[0].Value) == true && row.Cells["estado"].Value.ToString() == "pendiente")
                {
                    contpago = decimal.Round(contpago + Convert.ToDecimal(row.Cells["saldo"].Value), 2);
                    if (cargardatatable == true)
                    {
                        midata.Rows.Add(row.Cells["codventa"].Value, row.Cells["saldo"].Value, row.Cells["pagado"].Value, row.Cells["total"].Value, row.Cells["estado"].Value, "");
                    }
                    
                }

            }
            return contpago;
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
                   

                }

                if (pago < 0)
                {
                    recuperar = pago + Convert.ToDecimal(row["saldo"].ToString());
                    row["saldo"] = pago * (-1);
                    
                    row["pagado"] =Convert.ToDecimal( row["pagado"]) + recuperar;

                }
                row["grabar"] = "grabar";
                if (pago <= 0)
                {
                    break;
                }
               
            }

        }

        private void BtnBuscarCTACTE_Click(object sender, EventArgs e)
        {
            buscarctacte(Convert.ToInt32(txtCodigo.Text == string.Empty ? "0" : txtCodigo.Text)   );
        }

        private void buscarctacte(int varcodcliente)
        {
            if (varcodcliente != 0)
            {
                DGListado.DataSource = NegocioCliente.buscarporcodigoctacte(varcodcliente);
            }

            DGListado.Columns["saldo"].DefaultCellStyle.Format = String.Format("$###,##0.00");
            DGListado.Columns["pagado"].DefaultCellStyle.Format = String.Format("$###,##0.00");
            DGListado.Columns["total"].DefaultCellStyle.Format = String.Format("$###,##0.00");


        }

        private void DGListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //bool isCellChecked = (bool)DGListado.Rows[e.RowIndex].Cells[0].Value;

            //if (isCellChecked)
            //{
            //    System.Diagnostics.Debug.WriteLine("Fila " + e.RowIndex + " seleccionada");
            //}
        }

        private void DGListado_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DGListado_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DGListado_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            // if (DGListado.Columns[e.ColumnIndex].Name == "chek")
            //{
            //    DataGridViewRow row = DGListado.Rows[e.RowIndex];

            //    //Se selecciona la celda del checkbox
            //    //
            //    DataGridViewCheckBoxCell cellSelecion = row.Cells["chek"] as DataGridViewCheckBoxCell;

            //    //Se valida si esta checkeada
            //    //
            //    if (cellSelecion != null && !(bool)cellSelecion.Value)
            //    {

            //    }
            //}
        }

        private void DGListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DGListado_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (DGListado.IsCurrentCellDirty)
            {
                DGListado.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityFrm.NumDecTeclado(e, txtTelefono);
        }

        private void BtnBuscarCTACTE_Click_1(object sender, EventArgs e)
        {
            buscarPorFecha(Convert.ToInt32( LblCodcliente.Text));
        }

        private void DgCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DTDetalleventa.DataSource = NegocioVenta.MostrarDetalle(DgCliente.CurrentRow.Cells["Codigo"].Value.ToString());
        }

        private void DgCliente_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            DTDetalleventa.DataSource = NegocioVenta.MostrarDetalle(DgCliente.CurrentRow.Cells["Codigo"].Value.ToString());
        }

        private void xuiSuperButton1_Click(object sender, EventArgs e)
        {
            DgRecibos.DataSource = NegocioCliente.BuscarFechasRecibo(DTDesdeRec.Value.ToString("dd/MM/yyyy") + " 00:00:00", DTHastaRec.Value.ToString("dd/MM/yyyy") + " 23:59:59", false, false, idcliente, TxtNroRecibo.Text == "" ? 0 : Convert.ToInt32(TxtNroRecibo.Text));
        }

        private void TxtCtaCTe_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityFrm.NumDecTeclado(e, TxtCtaCTe);
        }

        private void ChkHabilitarctacte_CheckedChanged(object sender, EventArgs e)
        {
            TxtCtaCTe.Enabled = ChkHabilitarctacte.Checked;
        }

        private void DGListado_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataTable dt = NegocioVenta.BuscarIdVenta(Convert.ToInt32( this.DGListado.CurrentRow.Cells["codventa"].Value));
            if (dt.Rows.Count != 0)
            {
                DataRow row = dt.Rows[0];
                DateTime date = Convert.ToDateTime(row["fecha"].ToString());

                FrmDetalleVentas venta = new FrmDetalleVentas(Convert.ToString(row["idventa"]),
                Convert.ToString(row["Razon_social"]),
                date.ToShortDateString(),
                Convert.ToString(row["tipo_comprobante"]),
                estadoventa(Convert.ToString(row["estado"])),
                Convert.ToString(Decimal.Round(Convert.ToDecimal(row["total"]), 2)),
                Convert.ToString(row["idcliente"]),
                Convert.ToString(row["cuit"]),
                Convert.ToString(row["factura"]),
                Convert.ToString(row["pago"]),
                Convert.ToString(row["Multipago"]),"");
                venta.ShowDialog();


            }

        }

        private void DgCliente_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataTable dt = NegocioVenta.BuscarIdVenta(Convert.ToInt32(this.DgCliente.CurrentRow.Cells["codigo"].Value));
            if (dt.Rows.Count != 0)
            {
                DataRow row = dt.Rows[0];
                DateTime date = Convert.ToDateTime(row["fecha"].ToString());

                FrmDetalleVentas venta = new FrmDetalleVentas(Convert.ToString(row["idventa"]),
                Convert.ToString(row["Razon_social"]),
                date.ToShortDateString(),
                Convert.ToString(row["tipo_comprobante"]),
                estadoventa(Convert.ToString(row["estado"])),
                Convert.ToString(Decimal.Round(Convert.ToDecimal(row["total"]), 2)),
                Convert.ToString(row["idcliente"]),
                Convert.ToString(row["cuit"]),
                Convert.ToString(row["factura"]),
                Convert.ToString(row["pago"]),
                Convert.ToString(row["Multipago"]), "");
                venta.ShowDialog();


            }
        }

        private string estadoventa(string estado)
        {
            if (estado.Equals("F"))
            {
                estado = "FACTURADO";

            }
            else if (estado.Equals("P"))
            {
                estado = "PENDIENTE";
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
            return estado;
        }
    }
}
