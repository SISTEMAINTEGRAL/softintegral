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
            
            //mensajesDeAyuda();
            //btnEliminar.Enabled = false;
            //al inicio limpia textbox
            limpiarTextbox();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            //cargarcombobox();
            isNuevo = false;
            isEditar = false;

            //Cuando se abre la ventana se llama a mostrar las categorias
            this.mostrar();
            //this.txtNombre.Focus();
        }
      
        /* Gestion con Base de Datos */
        private void mostrar()
        {
            try
            {
                this.dataLista.DataSource = NegocioCategoria.mostrar();
                DGSubcategoria.Rows.Clear();
            }
            catch (Exception ex)
            {
                UtilityFrm.mensajeError("error con la Base de datos: "+ex.Message);
            }
            //datasource el origen de los datos,muestra las categorias en la grilla
            

            //oculto las dos primeras columnas
            this.ocultarColumnas();
            //muestro el total de las categorias
            //lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.RowCount);

        }
        private void BuscarNombre()
        {
            

        }

        /* Gestion parte grafica*/
        //textBox
        private void txtNombreConfig_KeyDown(object sender, KeyEventArgs e)
        {
          
       //comparo el evento pasado como parametro y el enum keys.enter
            if (e.KeyCode==Keys.Enter)
            {
                //this.txtDescripcion.Focus();
                //se pasa el control permitiendo eliminar el beep
                e.SuppressKeyPress = true;
            }

        }
        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            //comparo el evento pasado como parametro y el enum keys.enter
            if (e.KeyCode == Keys.Enter)
            {
                //this.btnGuardar.Focus();
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
            //this.txtDescripcion.Text = "";
            //this.txtNombre.Text = "";
            this.txtCodigoCategoria.Text = "";
            this.txtNombreCategoria.Text = "";
        }
        private void habilitarTextbox()
        {
            //this.txtDescripcion.Enabled = true;
            this.txtNombreCategoria.Enabled = true;

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
           
        }
        private void dataLista_Click(object sender, EventArgs e)
        {
           
        }
        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            
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
           
        }

       
        //mensajes de ayuda
       
 

        //botones
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarTextbox();
            //habilitarbotones(true, false,"nuevo");
            

            this.txtCodigoCategoria.Text = string.Empty;
        }
       
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //habilitarbotones(false, true,"cancelar");
            
            limpiarTextbox();
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Editar?", "Editar"
                 , MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                //habilitarbotones(true, false,"editar");
               
                //habilitarTextbox();

               
            }
        }
      
        private void btnEliminar_Click(object sender, EventArgs e)
        {
           


        }
        private void btnGuardar_Click(object sender, EventArgs e)
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

        private void rCategoria_CheckedChanged(object sender, EventArgs e)
        {
             

        }

        private void rsubcategoria_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rsubcategoria_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void rcategoria_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void CHKCategoria_CheckedChanged(object sender, EventArgs e)
        {
            //CBCategoriaBuscar.Enabled = CHKCategoria.Checked;
        }

        private void dataLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           DGSubcategoria.DataSource = NegocioCategoria.buscar("" , Convert.ToInt32(dataLista.CurrentRow.Cells["idcategoria"].Value))   ;
            txtCodigoCategoria.Text = dataLista.CurrentRow.Cells["idcategoria"].Value.ToString();
            txtNombreCategoria.Text = dataLista.CurrentRow.Cells["Nombre"].Value.ToString();
        }

        private void DGSubcategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoSubcategoria.Text = DGSubcategoria.CurrentRow.Cells["idsubcategoria"].Value.ToString();
            txtNombreSubcategoria.Text = DGSubcategoria.CurrentRow.Cells["Nombre"].Value.ToString();
        }

        private void BtnAgregarcategoria_Click(object sender, EventArgs e)
        {
            if (txtNombreCategoria.Text != "")
            {
                NegocioCategoria.insertar(txtNombreCategoria.Text, "", 0);
                this.mostrar();
            }
            else
            {
                UtilityFrm.mensajeError("ingrese un nombre para la nueva categoria");
                txtNombreCategoria.Focus();
            }
             
        }

        private void BtnEditarCategoria_Click(object sender, EventArgs e)
        {
            if ((txtCodigoCategoria.Text != "") && (txtNombreCategoria.Text!= ""))
            {
                NegocioCategoria.editar(Convert.ToInt32(dataLista.CurrentRow.Cells["idcategoria"].Value), txtNombreCategoria.Text, "", 0);
                dataLista.CurrentRow.Cells["nombre"].Value = txtNombreCategoria.Text;
            }
        }

        private void BtnAgregarSubcategoria_Click(object sender, EventArgs e)
        {
            NegocioCategoria.insertar(txtNombreSubcategoria.Text, "", Convert.ToInt32(dataLista.CurrentRow.Cells["idcategoria"].Value));
            DGSubcategoria.DataSource = NegocioCategoria.buscar("", Convert.ToInt32(dataLista.CurrentRow.Cells["idcategoria"].Value));
        }

        private void BtnEditarSubcategoria_Click(object sender, EventArgs e)
        {
            NegocioCategoria.editar(Convert.ToInt32(dataLista.CurrentRow.Cells["idcategoria"].Value), txtNombreSubcategoria.Text, "", Convert.ToInt32(DGSubcategoria.CurrentRow.Cells["idsubcategoria"].Value));
            DGSubcategoria.CurrentRow.Cells["nombre"].Value = txtNombreSubcategoria.Text;
        }

        private void BtnAgregarcategoria_Click_1(object sender, EventArgs e)
        {

        }

        private void panelHorizontal_DoubleClick(object sender, EventArgs e)
        {
           
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            this.BuscarNombre();
            limpiarTextbox();
        }

        
        
        
    }
}