using Capa_negocio;
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
    public partial class FrmCambiarPrecioSel : Form
    {
        private Boolean isEnterUtilidad=false;
        public FrmCambiarPrecioSel()
        {
            InitializeComponent();
        }
        public FrmCambiarPrecioSel(DataGridViewSelectedRowCollection filas)
        {
            InitializeComponent();
            foreach (DataGridViewRow fila in filas)
            {
                int idArticulo=Convert.ToInt32(fila.Cells["codigo"].Value);
                DataTable producto= NegocioArticulo.obtenerProductoXIdArticulo(idArticulo);
                    //obtengo el primer registro para poder obtener sus valores 
                DataRow row=producto.Rows[0];
                
                   
                
              
                dgvProductosSeleccionados.Rows.Add(row["idArticulo"],row["Nombre"],row["utilidad"],row["precio_compra"],row["precio"]);    
                //dgvProductosSeleccionados.Rows.Add(fila.Cells["codigo"].Value,
                      //  fila.Cells["producto"].Value,
                        //fila.Cells["precio"].Value );
                
                
            }

        }
        private void FrmCambiarPrecioSel_Load(object sender, EventArgs e)
        {
            this.dgvProductosSeleccionados.Columns["precioCompra"].DefaultCellStyle.Format = String.Format("###,##0.00");
            this.dgvProductosSeleccionados.Columns["precioVenta"].DefaultCellStyle.Format = String.Format("###,##0.00");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtUtilidad.Text == "0"  || txtUtilidad.Text.Length == 0 )
                {
                    //en el caso de que la utilidad sea 0 y esté activado modificar por utilidad
                    UtilityFrm.mensajeError("No se a podido guardar,verifique el campo utilidad si no se encuentra vacio o con valor 0");

                }
                else {
                    //this.dgvProductosSeleccionados.Columns["precioCompra"].DefaultCellStyle.Format = String.Format("###,##0.00");
                    DataTable tablaArticulos = GrillaADataTable(dgvProductosSeleccionados);
                   string respuesta =  NegocioArticulo.editarPrecioMasivo(tablaArticulos);
                

                        if (respuesta.Equals("ok"))
                        {
                        UtilityFrm.mensajeConfirm("Se ha modificado Correctamente");
                        this.Close();
                        }
                        else{
                        
                        UtilityFrm.mensajeError("Ocurrió un error :"+respuesta);
                        }
                } 

            }

            catch (Exception ex)
            {
                UtilityFrm.mensajeError("No se a podido guardar :" + ex.Message);

            }


           
        }


        private void txtUtilidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityFrm.NumDecTeclado(e, txtUtilidad);
            
            
        }

        private void txtUtilidad_TextChanged(object sender, EventArgs e)
        {
            if (txtUtilidad.Text.Length > 0 && txtUtilidad.Text[0] == ',')
            {

                txtUtilidad.Text = "";
            }
        }

        private void txtUtilidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtUtilidad.Text != "0"  && txtUtilidad.Text != "")
            {
                decimal utilidad = Convert.ToDecimal(txtUtilidad.Text);
                decimal precioVenta = 0;
                decimal precioCompra;
              
                Boolean isPrecioCompra = true;
                DataGridView copiaDeGrilla = new DataGridView();
               
               // copiaDeGrilla.Rows.Add( dgvProductosSeleccionados.Rows);
                
                foreach (DataGridViewRow fila in dgvProductosSeleccionados.Rows)
                {
                    //si el precio de compra es 0 sale de la ventana
                    decimal valor = Convert.ToDecimal("0,00");
                    
                    precioCompra = Convert.ToDecimal(fila.Cells["PrecioCompra"].Value);
                    if (precioCompra == (valor))
                    {

                        isPrecioCompra = false;

                        break;
                    }
                    //guardo el precio de venta actual y sumo con el precio de venta nuevo que obtengo de (precioCompra*utilidad)/100
                    precioVenta = Convert.ToDecimal(fila.Cells["PrecioVenta"].Value);
                    precioCompra = Convert.ToDecimal(fila.Cells["PrecioCompra"].Value);
                    precioVenta = Decimal.Round(((precioCompra * utilidad) / 100) + precioVenta,2);

                    decimal ganancia =  Decimal.Round(precioVenta - precioCompra,2);
                    decimal utilidadProducto = (ganancia * 100) / precioCompra;

                    fila.Cells["PrecioVenta"].Value = precioVenta;
                    fila.Cells["Utilidad"].Value = utilidadProducto;
                    //para sacar utilidad se utiliza la siguiente formula...
                    //utilidad= (ganancia*100)/precioCompra
                        //precioCompra$--------------------100%
                        //ganancia$------------------------?%
                       //ganancia= precioVenta-precioCompra 
                }

                //si el ispreciocompra es true sigue la operacion ,caso contrario se cierra
                if (isPrecioCompra == false)
                {
                    UtilityFrm.mensajeError("Error: Alguno de los productos seleccionados no tienen precio de compra asignado, intente nuevamente luego de asignarle");
                    isEnterUtilidad = true;
                    //coloco los valores que tenian antes de asignarle una utilidad
                 
                    //DataTable table = copiarGrillas(dgvProductosSeleccionados);
                    //dgvProductosSeleccionados.Columns.Clear();
                    //dgvProductosSeleccionados.Rows.Clear();
                   // dgvProductosSeleccionados.DataSource = table;
                       // copiaDeGrilla;
                   // dgvProductosSeleccionados.Rows.Add( copiaDeGrilla.Rows);
                    this.Close(); 
                    return;
                
                }
                e.Handled = false;
                
                //se precionó el boton enter
                isEnterUtilidad = true;
                txtUtilidad.Enabled = false;
                btnGuardar.Focus();
               
                
            }
            else if (e.KeyCode == Keys.Enter && txtUtilidad.Text == "" || e.KeyCode == Keys.Enter && txtUtilidad.Text == "0")
            {

                UtilityFrm.mensajeError("Error en el campo utilidad ,no puede ser 0 o estar vacio");
                //se precionó el boton enter
                isEnterUtilidad = true;
            }
          
            
        }

        private void txtUtilidad_Leave(object sender, EventArgs e)
        {
            if (isEnterUtilidad == false && txtUtilidad.Text != "0" && txtUtilidad.Text != "")
            {
                decimal utilidad = Convert.ToDecimal(txtUtilidad.Text);
                decimal precioVenta = 0;
                decimal precioCompra;
              
                Boolean isPrecioCompra = true;
                foreach (DataGridViewRow fila in dgvProductosSeleccionados.Rows)
                {

                    decimal valor = Convert.ToDecimal("0,00");
                    precioCompra = Convert.ToDecimal(fila.Cells["PrecioCompra"].Value);
                    if (precioCompra == (valor))
                    {

                        isPrecioCompra = false;

                        break;
                    }
                    //guardo el precio de venta actual y sumo con el precio de venta nuevo que obtengo de (precioCompra*utilidad)/100
                    precioVenta = Convert.ToDecimal(fila.Cells["PrecioVenta"].Value);
                    precioCompra = Convert.ToDecimal(fila.Cells["PrecioCompra"].Value);
                    precioVenta = Decimal.Round(((precioCompra * utilidad) / 100) + precioVenta, 2);

                    decimal ganancia = Decimal.Round(precioVenta - precioCompra, 2);
                    decimal utilidadProducto = (ganancia * 100) / precioCompra;

                    fila.Cells["PrecioVenta"].Value = precioVenta;
                    fila.Cells["Utilidad"].Value = utilidadProducto;
                }

                //si el ispreciocompra es true sigue la operacion ,caso contrario se cierra
                if (isPrecioCompra == false)
                {
                    UtilityFrm.mensajeError("Error: Alguno de los productos seleccionados no tienen precio de compra asignado, intente nuevamente luego de asignarle");
                    this.Close();
                    return;
                }

                btnGuardar.Focus();
                txtUtilidad.Enabled = false;
            }
            else if (isEnterUtilidad == true)
            {
                //si se presiono la tecla enter significa que no tiene que hacer nada, para no realizar dos veces la misma accion
                isEnterUtilidad = false;
                return;
            }
            else if (txtUtilidad.Text == "" || txtUtilidad.Text == "0")
            {

                UtilityFrm.mensajeError("Error en el campo utilidad ,no puede ser 0 o estar vacio");
            }
        }

       
        //Metodos propios
        public DataTable GrillaADataTable(DataGridView grillaACopiar){

            DataTable table = new DataTable("articulo");
            table.Columns.Add("Codigo");
            table.Columns.Add("Producto");
            table.Columns.Add("Utilidad");
            table.Columns.Add("PrecioCompra");
            table.Columns.Add("PrecioVenta");

                foreach (DataGridViewRow row in grillaACopiar.Rows)
                {
                    table.Rows.Add(row.Cells["Codigo"].Value, row.Cells["Producto"].Value, row.Cells["Utilidad"].Value, row.Cells["PrecioCompra"].Value, row.Cells["PrecioVenta"].Value);
                }
            
            
            return table;
        }

        private void dgvProductosSeleccionados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}
