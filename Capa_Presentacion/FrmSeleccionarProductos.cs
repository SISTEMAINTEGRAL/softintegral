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
using System.Data.Common;
namespace Capa_Presentacion
{
    public partial class FrmSeleccionarProductos : Form
    {
        DataGridView datalistaCodigoBarra;
        //para desactivar cuando se termino de seleccionar productos en la grilla
        Button btnSeleccionar;
        public FrmSeleccionarProductos(DataGridView datalista,Button btnSeleccionar)
        {
            InitializeComponent();
            this.datalistaCodigoBarra = datalista;
            datalistaCodigoBarra.AutoGenerateColumns = false;
            this.btnSeleccionar = btnSeleccionar;
        }
        //Metodos Propios
        private void BuscarNombre()
        {
            try
            {
                this.dataLista.DataSource = NegocioArticulo.buscarNombre(this.txtBuscar.Text);
            }

            catch (Exception ex)
            {
                UtilityFrm.mensajeError("Error Con Base de Datos :" + ex.Message);

            }
          
            //muestro el total de las categorias
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.RowCount);

        }
        private void BuscarCodigoBarra()
        {
            try
            {
                this.dataLista.DataSource = NegocioArticulo.buscarCodigoBarra(this.txtBuscar.Text);
            }

            catch (Exception ex)
            {
                UtilityFrm.mensajeError("Error Con Base de Datos :" + ex.Message);

            }
           
            //muestro el total de las categorias
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.RowCount);

        }
        private void BuscarCategoria()
        {
            try
            {
                this.dataLista.DataSource = NegocioArticulo.buscarCategoria(this.txtBuscar.Text);
            }

            catch (Exception ex)
            {
                UtilityFrm.mensajeError("Error Con Base de Datos :" + ex.Message);

            }
          
            //muestro el total de las categorias
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.RowCount);

        }
        public void mostrar()
        {
            try
            {
                this.dataLista.DataSource = NegocioArticulo.mostrar();
            }
            catch (Exception ex)
            {
                UtilityFrm.mensajeError("error con la Base de datos: " + ex.Message);
            }
            //datasource el origen de los datos,muestra las categorias en la grilla

            //muestro el total de las categorias
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.RowCount);

        }

        private void FrmEtiquetaPersonalizada_Load(object sender, EventArgs e)
        {
            this.mostrar();
        }

       

     

        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //se produce un evento cuando hago click en la columna 0 que es eliminar de la lista
                //se comparan el indice de columna de la lista =0 y el indice de la columna del evento=0
                if (e.ColumnIndex == dataLista.Columns[0].Index&&e.RowIndex>=0)
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
                    

                    foreach (DataGridViewRow row in dataLista.Rows)
                    {
                        //DataGridViewCheckBoxCell tilde = (DataGridViewCheckBoxCell)row.Cells[0].Value;

                        if (Convert.ToBoolean(tildado.Value) == true)
                        {
                            btnAgregarAlaLista.Enabled = true;
                            return;
                        }


                    }
                    btnAgregarAlaLista.Enabled = false;
                }
                
            }
            catch (Exception ex)
            {
                UtilityFrm.mensajeError("Has seleccionado una Opcion Incorrecta, el Origen es: " + ex.Message);

            }
        }

        private void chkSeleccionarTodo_CheckedChanged(object sender, EventArgs e)
        {
           
            if (chkSeleccionarTodo.Checked == true)
            {
                foreach (DataGridViewRow row in dataLista.Rows)
                {
                    //tildo todos las filas
                    row.Cells[0].Value = CheckState.Checked;
                }
                this.btnAgregarAlaLista.Enabled = true;
                chkSeleccionarTodo.Text = "Deseleccionar Todos";
            }
            else
            {
                foreach (DataGridViewRow row in dataLista.Rows)
                {
                    //destildo todos las filas
                    row.Cells[0].Value = CheckState.Unchecked;
                }
                this.btnAgregarAlaLista.Enabled = false;
                chkSeleccionarTodo.Text = "Seleccionar Todos";
            }
        }

        private void btnAgregarAlaLista_Click(object sender, EventArgs e)
        {
       
        
            
            foreach (DataGridViewRow fila in dataLista.Rows)
            {
                DataGridViewCheckBoxCell tildado = (DataGridViewCheckBoxCell)fila.Cells[0];
                if (Convert.ToBoolean(tildado.Value) == true)
                {
                    //si esta tildado lo agrego a la lista codigo de barra
                    datalistaCodigoBarra.Rows.Add(fila.Cells["idarticulo"].Value,
                        fila.Cells["codigo"].Value,
                        fila.Cells["nombre"].Value,
                        fila.Cells["categoria"].Value);
                }
            }

            btnSeleccionar.Enabled = false;
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //segun el radiobutton que seleccione buscara
            if (rdbNombre.Checked == true)
            {
                this.BuscarNombre();
                
            }
            else if (rdbCodigoBarra.Checked == true)
            {
                this.BuscarCodigoBarra();
            

            }
            else
            {
                this.BuscarCategoria();
             
            }
        }

      
    }
}
