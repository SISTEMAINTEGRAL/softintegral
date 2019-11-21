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
    public partial class FrmCategoria : Form
    {
        //campos
        //en el caso de que guarde una categoria nueva o editada
       private bool isNuevo, isEditar;
      
        public FrmCategoria()
        {

            InitializeComponent();
            //muestro las ayudas del formulario
            
            mensajesDeAyuda();
            btnEliminar.Enabled = false;
            //al inicio limpia textbox
            limpiarTextbox();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            isNuevo = false;
            isEditar = false;

            //Cuando se abre la ventana se llama a mostrar las categorias
            this.mostrar();
            this.txtNombre.Focus();
        }
      
        /* Gestion con Base de Datos */
        private void mostrar()
        {
            try
            {
                this.dataLista.DataSource = NegocioCategoria.mostrar();
            }
            catch (Exception ex)
            {
                UtilityFrm.mensajeError("error con la Base de datos: "+ex.Message);
            }
            //datasource el origen de los datos,muestra las categorias en la grilla
            

            //oculto las dos primeras columnas
            this.ocultarColumnas();
            //muestro el total de las categorias
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.RowCount);

        }
        private void BuscarNombre()
        {
            try
            {
                this.dataLista.DataSource = NegocioCategoria.buscar(this.txtNombre.Text);
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

        /* Gestion parte grafica*/
        //textBox
        private void txtNombreConfig_KeyDown(object sender, KeyEventArgs e)
        {
          
       //comparo el evento pasado como parametro y el enum keys.enter
            if (e.KeyCode==Keys.Enter)
            {
                this.txtDescripcion.Focus();
                //se pasa el control permitiendo eliminar el beep
                e.SuppressKeyPress = true;
            }

        }
        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            //comparo el evento pasado como parametro y el enum keys.enter
            if (e.KeyCode == Keys.Enter)
            {
                this.btnGuardar.Focus();
                //se pasa el control permitiendo eliminar el beep
                e.SuppressKeyPress = true;
            }

        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            //cuando se escribe en el textbox se comienza a buscar en la tabla
            this.BuscarNombre();
        }
        private void limpiarTextbox()
        {
            this.txtDescripcion.Text = "";
            this.txtNombre.Text = "";
            this.txtCodigo.Text = "";
            this.txtNombreConfig.Text = "";
        }
        private void habilitarTextbox()
        {
            this.txtDescripcion.Enabled = true;
            this.txtNombreConfig.Enabled = true;

        }
        private void ocultarColumnas()
        {
            //no muestro la columna eliminar categoria
            this.dataLista.Columns[0].Visible = false;

        }
        private void txtNombreConfig_TextChanged(object sender, EventArgs e)
        {
            errorIcono.Clear();

        }


        //lista de datos
        private void dataLista_DoubleClick(object sender, EventArgs e)
        {
            this.btnNuevo.Enabled = false;
            this.btnEditar.Enabled = true;
            this.btnCancelar.Enabled = true;
            this.txtDescripcion.Enabled = true;
            this.txtNombreConfig.Enabled = true;
            //para editar categoria lleva a la caja de texto de configuracion
            txtCodigo.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["idcategoria"].Value);
            txtNombreConfig.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["nombre"].Value);
            txtDescripcion.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["descripcion"].Value);
            this.tabControl1.SelectedTab = tabAgregarOcambiar;
        }
        private void dataLista_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
        }
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
        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                UtilityFrm.mensajeError("Has seleccionado una Opcion Incorrecta, el Origen es: " + ex.Message);
               
            }
           
        }
        
        //TabControl
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            //si selecciono el tabLista borro los textbox y button
            if (tabControl1.SelectedIndex == 0)
            {
                txtCodigo.Text = string.Empty;
                txtDescripcion.Text = string.Empty;
                txtNombreConfig.Text = string.Empty;
                btnEditar.Enabled = false;
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                txtNombreConfig.Enabled = false;
                txtDescripcion.Enabled = false;
                errorIcono.Clear();
            }
            if (tabControl1.SelectedIndex == 1)
            {
                btnEliminar.Enabled = false;
            }
        }

       
        //mensajes de ayuda
        private void mensajesDeAyuda()
        {

            //mensaje de ayuda en el textbox nombre
            this.ttMensajeAyuda.SetToolTip(this.txtNombre, "Ingrese el nombre de la categoria");
            //mensaje de ayuda del boton buscar
            this.ttMensajeAyuda.SetToolTip(this.btnBuscar, "Buscar por nombre de Categoria");
            //mensaje de ayuda del boton eliminar
            this.ttMensajeAyuda.SetToolTip(this.btnEliminar, "Borrar Categoria");
            //mensaje de ayuda del boton Imprimir
            this.ttMensajeAyuda.SetToolTip(this.btnImprimir, "imprime todas las categorias");
            //mensaje de ayuda del boton editar
            this.ttMensajeAyuda.SetToolTip(this.btnEditar, "Para Editar Ingrese un Codigo de la categoria válida");

        }
 

        //botones
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarTextbox();
            this.btnGuardar.Enabled = true;
            this.btnEditar.Enabled = false;
            this.btnCancelar.Enabled = true;
            this.btnNuevo.Enabled = false;
            this.txtDescripcion.Enabled = true;
            this.txtNombreConfig.Enabled = true;
            this.txtCodigo.Text = string.Empty;
            this.txtNombreConfig.Focus();
            isEditar = false;
            isNuevo = true;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.btnGuardar.Enabled = false;
            this.btnEditar.Enabled = false;
            this.btnCancelar.Enabled = false;
            this.btnNuevo.Enabled = true;
            //habilito el codigo para poder editar
            this.txtCodigo.Enabled = false;
            this.txtNombreConfig.Enabled = false;
            this.txtDescripcion.Enabled = false;
            limpiarTextbox();
            isEditar = false;
            isNuevo = false;
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
                //habilitarTextbox();

               
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
                            if (Convert.ToBoolean( row.Cells[0].Value)) {
                               
                                //le paso el idcategoria para poder eliminarlo
                                respuesta = NegocioCategoria.eliminar(Convert.ToInt32(row.Cells[1].Value));
                                if (respuesta.Equals("ok"))
                                {
                                    UtilityFrm.mensajeConfirm("Se Eliminó: " + row.Cells[2].Value.ToString() + " Correctamente");
                                }
                                else {

                                    UtilityFrm.mensajeError("Error: "+respuesta);
                                }
                                
                            }
                        }
                        

                    }
                    else
                    {
                        /*eliminar una sola categoria*/
                        respuesta =NegocioCategoria.eliminar(Convert.ToInt32(this.dataLista.CurrentRow.Cells[1].Value));
                        if (respuesta.Equals("ok"))
                        {
                            UtilityFrm.mensajeConfirm("Se Eliminó: " +dataLista.CurrentRow.Cells[2].Value.ToString()+ " Correctamente");
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
                UtilityFrm.mensajeError("Error: "+respuesta +", "+ex.Message);
            }


        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                string respuesta = "";

                //si el string es nulo o vacio 
                if (String.IsNullOrEmpty(txtNombreConfig.Text))
                {
                    UtilityFrm.mensajeError("El Campo Nombre está incompleto");
                    errorIcono.SetError(txtNombreConfig, "Ingrese un nombre");

                }
                else
                {

                    //en el caso de no ser nulo, agrego si se está por editar o agregar
                    //si se va a insertar
                    if (isNuevo == true)
                    {
                        respuesta = NegocioCategoria.insertar(txtNombreConfig.Text.Trim(), txtDescripcion.Text.Trim());

                        if (respuesta.Equals("ok"))
                        {
                            UtilityFrm.mensajeConfirm("Se Agregó Correctamente");
                            this.mostrar();
                        }
                       

                    }
                        //si se va a editar
                    else if (isEditar == true)
                    {
                        respuesta = NegocioCategoria.editar(Convert.ToInt32(txtCodigo.Text.Trim()), Convert.ToString(txtNombreConfig.Text.Trim()), Convert.ToString(txtDescripcion.Text.Trim()));

                        if (respuesta.Equals("ok"))
                        {
                           UtilityFrm.mensajeConfirm("Se Editó Correctamente");
                            this.mostrar();
                            

                        }

                    }
                    else{ 
                    UtilityFrm.mensajeError("No se ha podido guardar: " + respuesta);
                    
                    }
                   
                    //habilito el codigo para poder editar
                    btnCancelar.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    errorIcono.Clear();
                    txtDescripcion.Enabled = false;
                    txtNombreConfig.Enabled = false;
                    limpiarTextbox();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            this.BuscarNombre();
            limpiarTextbox();
        }

        
        
        
    }
}