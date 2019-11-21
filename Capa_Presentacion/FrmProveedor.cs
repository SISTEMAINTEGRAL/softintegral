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
    public partial class FrmProveedor : Form
    {
        /// <summary>
        /// sirve para identificar cuando se guarda el proveedor, si hay que editar o agregar
        /// </summary>
        bool isEditar = false;
        bool isNuevo = false;
        private int opcionvista;
        private int codigoproveedor;

        public int Codigoproveedor
        {
            get { return codigoproveedor; }
            set { codigoproveedor = value; }
        }
        public int Opcionvista
        {
            get { return opcionvista; }
            set { opcionvista = value; }
        }

        public FrmProveedor()
        {
            
            InitializeComponent();
           
        }
        public FrmProveedor(int opcion = 1)
        {
            opcionvista = opcion;
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {

            Cbprovincia.DataSource = NegocioCliente.provincia();
            Cbprovincia.ValueMember = "id";
            Cbprovincia.DisplayMember = "provincia";
            Cbprovincia.SelectedValue = 5;

            isEditar = false;
            isNuevo = false;
            this.txtNombre.Focus();
            ocultarColumnas();
            mostrar();
        }

        /*Metodos Propios*/
        private void mostrar()
        {
            try
            {
                this.dataLista.DataSource = NegocioProveedor.mostrar();
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
                this.dataLista.DataSource = NegocioProveedor.buscar(this.txtNombre.Text);
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
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //limpio textbox
            UtilityFrm.limpiarTextbox(txtDireccion, txtRazonSocial, txtNombre, txtCodigo, txtCuit, txtDocumento);
            UtilityFrm.limpiarTextbox(txtTelefono, txtEmail);

            habilitaronobotones(false, true,false,true);

            ////habilitar botones
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


            this.txtRazonSocial.Focus();
            //isEditar = false;
            //isNuevo = true;
            
        }
        private void habilitaronobotones(bool var, bool var1,bool editar, bool nuevo)
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
            this.Cbprovincia.Enabled = var1;
            this.CBlocalidad.Enabled = var1;

            isEditar = editar;
            isNuevo = nuevo;

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
            //limpio textbox
            UtilityFrm.limpiarTextbox(txtDireccion, txtRazonSocial, txtNombre, txtCodigo, txtCuit, txtDocumento);
            UtilityFrm.limpiarTextbox(txtTelefono, txtEmail);
            isEditar = false;
            isNuevo = false;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
            UtilityFrm.limpiarTextbox(txtDireccion, txtRazonSocial, txtCodigo, txtCuit, txtDocumento);
            UtilityFrm.limpiarTextbox(txtTelefono, txtEmail);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Editar?", "Editar"
               , MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                this.btnNuevo.Enabled = false;
                this.btnCancelar.Enabled = true;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                isEditar = true;
                isNuevo = false;


            }
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
                    errorIcono.SetError(txtRazonSocial, "Ingrese un nombre o Razon Social");

                }
                else
                {

                    if (isNuevo == true)
                    {
                        if (txtTelefono.Text.Length == 0)
                        {
                            txtTelefono.Text = "0";

                        }
                        if (txtCuit.Text.Length==0)
                        {
                            txtCuit.Text = "0";
                        }

                        
                         if (txtDocumento.Text.Length== 0)
                        {
                        
                         txtDocumento.Text = "0";
                        }
                         respuesta = NegocioProveedor.insertar(txtRazonSocial.Text.Trim(), txtDireccion.Text.Trim(), Convert.ToInt64(txtCuit.Text.Trim()), Convert.ToInt64(txtTelefono.Text.Trim()), Convert.ToInt64(txtDocumento.Text.Trim()), txtEmail.Text.Trim(), Convert.ToInt32(Cbprovincia.SelectedValue),Convert.ToInt32 (CBlocalidad.SelectedValue));

                        

                        if (respuesta.Equals("ok"))
                        {
                            UtilityFrm.mensajeConfirm("Se Agregó Correctamente");
                            this.mostrar();
                            isEditar = false;
                            isNuevo = false;

                            //habilito el codigo para poder editar
                            btnCancelar.Enabled = false;
                            btnGuardar.Enabled = false;
                            btnNuevo.Enabled = true;
                            errorIcono.Clear();
                            this.txtCodigo.Enabled = false;
                            this.txtCuit.Enabled = false;
                            this.txtDireccion.Enabled = false;
                            this.txtDocumento.Enabled = false;
                            this.txtEmail.Enabled = false;
                            this.txtRazonSocial.Enabled = false;
                            this.txtTelefono.Enabled = false;
                            UtilityFrm.limpiarTextbox(txtDireccion, txtRazonSocial, txtNombre, txtCodigo, txtCuit, txtDocumento);
                            UtilityFrm.limpiarTextbox(txtTelefono, txtEmail);
                            this.btnNuevo.Focus();
                        }
                        else
                        {
                            UtilityFrm.mensajeError("No se ha podido guardar: " + respuesta);
                        }


                    }
                    //si se va a editar
                    else if (isEditar == true)
                    {

                        respuesta = NegocioProveedor.editar(Convert.ToInt32(txtCodigo.Text.Trim()), txtRazonSocial.Text.Trim(), txtDireccion.Text.Trim(), Convert.ToInt64(txtCuit.Text.Trim()), Convert.ToInt64(txtTelefono.Text.Trim()), Convert.ToInt64(txtDocumento.Text.Trim()), txtEmail.Text.Trim(), Convert.ToInt32(Cbprovincia.SelectedValue), Convert.ToInt32(CBlocalidad.SelectedValue));

                        if (respuesta.Equals("ok"))
                        {
                            UtilityFrm.mensajeConfirm("Se Editó Correctamente");
                            this.mostrar();
                            isEditar = false;
                            isNuevo = false;

                            //habilito el codigo para poder editar
                            btnCancelar.Enabled = false;
                            btnGuardar.Enabled = false;
                            btnNuevo.Enabled = true;
                            errorIcono.Clear();
                            this.txtCodigo.Enabled = false;
                            this.txtCuit.Enabled = false;
                            this.txtDireccion.Enabled = false;
                            this.txtDocumento.Enabled = false;
                            this.txtEmail.Enabled = false;
                            this.txtRazonSocial.Enabled = false;
                            this.txtTelefono.Enabled = false;
                            UtilityFrm.limpiarTextbox(txtDireccion, txtRazonSocial, txtNombre, txtCodigo, txtCuit, txtDocumento);
                            UtilityFrm.limpiarTextbox(txtTelefono, txtEmail);
                            this.btnNuevo.Focus();

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

                    

                }



            }
            catch (Exception ex)
            {
                UtilityFrm.mensajeError("error : ingrese solo numeros" + ex.Message + " ;" + ex.StackTrace);
            }
           
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            try
            {

                //si la respuesta es si elimina la fila actual
                if (MessageBox.Show("Seguro que desea Eliminar?", "Eliminar"
                   , MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    /*eliminar varias categoria*/
                    if (chkEliminar.Checked == true)
                    {
                        foreach (DataGridViewRow row in dataLista.Rows)
                        {
                            //Si la fila esta marcada lo elimina
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {

                                //le paso el idcategoria para poder eliminarlo
                                respuesta = NegocioProveedor.eliminar(Convert.ToInt32(row.Cells[1].Value));
                                if (respuesta.Equals("ok"))
                                {
                                    UtilityFrm.mensajeConfirm(row.Cells[2].Value.ToString() + " Se Eliminó Correctamente");
                                }
                                else
                                {

                                    UtilityFrm.mensajeError("Error: " + respuesta);
                                }

                            }
                        }


                    }
                    else
                    {
                        /*eliminar una sola categoria*/
                        respuesta = NegocioProveedor.eliminar(Convert.ToInt32(this.dataLista.CurrentRow.Cells[1].Value));
                        if (respuesta.Equals("ok"))
                        {
                            UtilityFrm.mensajeConfirm(dataLista.CurrentRow.Cells[2].Value.ToString() + " se eliminó correctamente");
                        }
                        else
                        {

                            UtilityFrm.mensajeError("Error: " + respuesta);
                        }


                    }
                    mostrar();
                }
                //desabilito el checkbox y el boton eliminar
                chkEliminar.Checked = false;
                btnEliminar.Enabled = false;
            }
            catch (Exception ex)
            {
                UtilityFrm.mensajeError("Error: " + respuesta + ", " + ex.Message);
            }

        }

        //textBox
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
            UtilityFrm.limpiarTextbox(txtDireccion, txtRazonSocial, txtCodigo, txtCuit, txtDocumento);
            UtilityFrm.limpiarTextbox(txtTelefono, txtEmail);
        }
        
        //checkbox
        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked == true)
            {
                this.dataLista.Columns[0].Visible = true;

            }
            else
            {
                this.dataLista.Columns[0].Visible = false;
            }
        }

        //lista datagridview
        private void dataLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
        }
        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //se produce un evento cuando hago click en la columna 0 que es eliminar de la lista
            //se comparan el indice de columna de la lista =0 y el indice de la columna del evento=0
            if (e.ColumnIndex == dataLista.Columns[0].Index)
            {
                //creo una datagridviewrow para guarda los datos de la fila actual
                DataGridViewRow fila = dataLista.Rows[e.RowIndex];
                //creo un checkboxcell para obtener el checkbox seleccionado
                DataGridViewCheckBoxCell tildado = (DataGridViewCheckBoxCell)fila.Cells[0];


                if (Convert.ToBoolean(tildado.Value) == true)
                {
                    //si el valor de tildado es null es true y se desactiva 
                    tildado.Value = CheckState.Unchecked;

                }
                else
                {
                    //caso contrario se activa
                    tildado.Value = CheckState.Checked;
                }

            }
        }

        private void txtRazonSocial_KeyDown(object sender, KeyEventArgs e)
        {

            //comparo el evento pasado como parametro y el enum keys.enter
            if (e.KeyCode == Keys.Enter)
            {
                this.txtCuit.Focus();
                //se pasa el control permitiendo eliminar el beep
                e.SuppressKeyPress = true;
            }

        }

        private void txtCuit_KeyDown(object sender, KeyEventArgs e)
        {
            //comparo el evento pasado como parametro y el enum keys.enter
            if (e.KeyCode == Keys.Enter)
            {
                this.txtDocumento.Focus();
                //se pasa el control permitiendo eliminar el beep
                e.SuppressKeyPress = true;
            }
        }

        private void txtDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            //comparo el evento pasado como parametro y el enum keys.enter
            if (e.KeyCode == Keys.Enter)
            {
                this.txtDireccion.Focus();
                //se pasa el control permitiendo eliminar el beep
                e.SuppressKeyPress = true;
            }
        }

        private void txtDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            //comparo el evento pasado como parametro y el enum keys.enter
            if (e.KeyCode == Keys.Enter)
            {
                this.txtTelefono.Focus();
                //se pasa el control permitiendo eliminar el beep
                e.SuppressKeyPress = true;
            }
        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            //comparo el evento pasado como parametro y el enum keys.enter
            if (e.KeyCode == Keys.Enter)
            {
                this.txtEmail.Focus();
                //se pasa el control permitiendo eliminar el beep
                e.SuppressKeyPress = true;
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            //comparo el evento pasado como parametro y el enum keys.enter
            if (e.KeyCode == Keys.Enter)
            {
                this.btnGuardar.Focus();
                //se pasa el control permitiendo eliminar el beep
                e.SuppressKeyPress = true;
            }
        }

        private void dataLista_DoubleClick(object sender, EventArgs e)
        {
            if (opcionvista == 1)
            {
                habilitaronobotones(false, true, true, false);
                txtCodigo.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["idproveedor"].Value);
                txtRazonSocial.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["razon_social"].Value);
                txtCuit.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["cuit"].Value);
                txtDireccion.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["direccion"].Value);
                txtTelefono.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["telefono"].Value);
                txtEmail.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["email"].Value);
                txtDocumento.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["num_documento"].Value);
                Cbprovincia.SelectedValue = Convert.ToInt32(this.dataLista.CurrentRow.Cells["idprovincia"].Value);
                CBlocalidad.SelectedValue = Convert.ToInt32(this.dataLista.CurrentRow.Cells["idlocalidad"].Value);
                
                this.tabControl1.SelectedTab = tabAgregarOcambiar;
            }
            else if (opcionvista == 2)
            {
                codigoproveedor = Convert.ToInt32(this.dataLista.CurrentRow.Cells["idproveedor"].Value);
                this.Close();
            }
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {

        }

        private void Cbprovincia_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Cbprovincia.ValueMember != "")
            {
                CBlocalidad.DataSource = NegocioCliente.localidad(Convert.ToInt32(Cbprovincia.SelectedValue));
                //valor real de la DB
                this.CBlocalidad.ValueMember = "id";
                //lo que se muestra
                this.CBlocalidad.DisplayMember = "localidad";
                CBlocalidad.AutoCompleteCustomSource = UtilityFrm.LoadAutoComplete(NegocioCliente.localidad(Convert.ToInt32(Cbprovincia.SelectedValue)));
                CBlocalidad.AutoCompleteMode = AutoCompleteMode.Suggest;
                CBlocalidad.AutoCompleteSource = AutoCompleteSource.CustomSource;
                // Cbprovincia.SelectedValue = 429;
            }
        }

       
       
        
    }
}
