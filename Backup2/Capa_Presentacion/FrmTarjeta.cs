using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Capa_negocio;
using Capa_Presentacion.DataSet;
using System.Diagnostics;
using Capa_Datos;

namespace Capa_Presentacion
{
    public partial class FrmTarjeta : Form
    {
        //campos
        //en el caso de que guarde una articulo nuevo o editado
        private int opcionvista = 1;
        private int codigoarticulo;
        private Dventa objventa = new Dventa();
        string[] valores;
        public int Codigoarticulo
        {
            get { return codigoarticulo; }
            set { codigoarticulo = value; }
        }
        public int Opcionvista
        {
            get { return opcionvista; }
            set { opcionvista = value; }
        }
        private bool isNuevo, isEditar;

        public FrmTarjeta()
        {
            InitializeComponent();


        }

        public FrmTarjeta(int varopcionvista)
        {
            opcionvista = varopcionvista;

        }
        private void FrmArticulos_Load(object sender, EventArgs e)
        {



            dataLista.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            isEditar = false;
            isNuevo = false;
            this.mostrar();
            mensajesDeAyuda();



            this.tabControl1.SelectedIndex = 0;

            this.txtNombre.Select();

            this.txtNombre.Focus();
            DGCuotaTarjeta.Enabled = false;
            // txtNombre.TextChanged += new EventHandler(txtNombre_TextChanged);



        }


        public void pintarProductoSinStock() {
            decimal stock = 0;
            foreach (DataGridViewRow row in dataLista.Rows)
            {

                stock = Convert.ToDecimal(row.Cells["stock_actual"].Value);
                if (stock < 0) {
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }

        }
        //VENTANA Y PANEL SUPERIOR

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //maximizar
            this.btnRestaurar.Visible = true;
            this.btnMaximizar.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //cierra
            this.Close();
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
            btnRestaurar.BackColor = Color.FromArgb(100, 0, 180);
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

        /*Metodos Propios*/
        public void mostrar()
        {
                        dataLista.DataSource = objventa.Tarjeta(14);

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
               
            }

            catch (Exception ex)
            {
                UtilityFrm.mensajeError("Error Con Base de Datos :" + ex.Message);

            }
            //datasource el origen de los datos 

            //oculto las dos primeras columnas
            this.ocultarColumnas();
            //muestro el total de las categorias
          

        }
        private void buscarcodigo()
        {
            dataLista.DataSource = NegocioArticulo.buscarIdProducto(txtNombre.Text);
            pintarProductoSinStock();
        }
        private void generarCodigoBarra() {

            bool cambiarcodigobarra = false;
            NegocioArticulo objart = new NegocioArticulo();
            string codigoBarra = "";
            try
            {
                do
                {
                    if (cambiarcodigobarra == true)
                    {
                        codigoBarra = Convert.ToString(Convert.ToInt32(codigoBarra) + 1);
                    }
                    else
                    {
                        codigoBarra = NegocioArticulo.obtenerIdArticulo().ToString();
                    }


                    codigoBarra = codigoBarra.PadLeft(12, '0');
                    int codigoControl = NegocioArticulo.calcDigControl(codigoBarra);

                    cambiarcodigobarra = true;

                } while (objart.Sindatos == true);

            }
            catch (FormatException ex)
            {
                UtilityFrm.mensajeError("No se a podido generar codigo Barra:" + ex.Message);
            }
            catch (Exception ex)
            {
                UtilityFrm.mensajeError("Error:" + ex.Message);
            }

        }
        private void BuscarCodigoBarra() {
            try
            {
                this.dataLista.DataSource = NegocioArticulo.buscarCodigoBarra(this.txtNombre.Text);
                pintarProductoSinStock();
            }

            catch (Exception ex)
            {
                UtilityFrm.mensajeError("Error Con Base de Datos :" + ex.Message);

            }
            //datasource el origen de los datos 

            //oculto las dos primeras columnas
            this.ocultarColumnas();
            //muestro el total de las categorias
           

        }
        private void BuscarCategoria()
        {
            try
            {
                this.dataLista.DataSource = NegocioArticulo.buscarCategoria(this.txtNombre.Text);
                pintarProductoSinStock();
            }

            catch (Exception ex)
            {
                UtilityFrm.mensajeError("Error Con Base de Datos :" + ex.Message);

            }
            //datasource el origen de los datos 

            //oculto las dos primeras columnas
            this.ocultarColumnas();
            //muestro el total de las categorias
           

        }
        //muestra en el combobox los resultados cargados en categoria
        private void llenarComboBoxCategoria(ComboBox combo, string valuemember, string displaymember, DataTable midatatable) {
            combo.DataSource = midatatable;
            //valor real de la DB

            combo.ValueMember = valuemember;
            //lo que se muestra
            combo.DisplayMember = displaymember;

        }


        //mensajes de ayuda
        private void mensajesDeAyuda()
        {

            //mensaje de ayuda en el textbox nombre
            this.ttMensajeAyuda.SetToolTip(this.txtNombre, "Ingrese el producto que desea buscar,(F1) para limpiar");
            //mensaje de ayuda en el textbox nombre
            this.ttMensajeAyuda.SetToolTip(this.TxtMarca, "Ingrese el nombre del producto");
            //mensaje de ayuda en el textbox nombre

            //mensaje de ayuda del boton buscar
           

           
        }

        /*EVENTOS*/
        //textBox
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void buscar()
        {

            dataLista.DataSource = objventa.Tarjeta(14);

        }
        /*Botones*/
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            inicializartextbox();
            habilitarcontroles(false, true, true);
            rellenargridcuotas(0);
            
            isEditar = false;
            isNuevo = true;
            generarCodigoBarra();
            
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitarcontroles(true, false);
            UtilityFrm.recorrerylimpiartextbox(xuiCustomGroupbox2, "");
            
            inicializartextbox();
            

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
               // DGCuotaTarjeta.Rows.Clear();
                string respuesta = "";
                //if (String.IsNullOrEmpty(txtPrecio.Text))
                //{

                //}
                //si el string es nulo o vacio 

                if (controlargroupbox() == true)
                {
                    UtilityFrm.mensajeError("Hay Campos sin completar,rellene y vuelva a intentarlo");

                    //if(txtNombreConfig.Text.Length==0){ errorIcono.SetError(txtNombreConfig, "Ingrese un Nombre de Producto");}
                    //if (txtPrecio.Text.Length == 0) { errorIcono.SetError(txtPrecio, "Ingrese un Precio"); }
                    //if (txtCantInicial.Text.Length == 0) { errorIcono.SetError(txtCantInicial, "Ingrese una Cantidad Inicial"); }    


                }
                else
                {

                    if (isNuevo == true)
                    {
                        objventa.Nombretarjeta = TxtMarca.Text + "-" + TxtEntidadEmisora.Text;
                        
                        respuesta = objventa.agregarymodificartarjeta(objventa, GrillaAList(DGCuotaTarjeta), "agregartarjeta");
                        if (respuesta.Equals("ok"))
                        {
                            UtilityFrm.mensajeConfirm("Se Agregó Correctamente");
                            this.mostrar();
                            isEditar = false;
                            isNuevo = false;
                            UtilityFrm.limpiarErrorProvider( TxtMarca, errorIcono);
                        }



                    }
                    //si se va a editar
                    else if (isEditar == true)
                    {
                        objventa.Nombretarjeta = TxtMarca.Text + "-" + TxtEntidadEmisora.Text;
                        
                      respuesta =  objventa.agregarymodificartarjeta(objventa,  GrillaAList(DGCuotaTarjeta),"modificartarjeta");
                        

                        


                        if (respuesta.Equals("ok"))
                        {
                            UtilityFrm.mensajeConfirm("Se Editó Correctamente");
                            this.mostrar();
                            isEditar = false;
                            isNuevo = false;

                        }


                    }
                    else
                    {
                        UtilityFrm.mensajeError("No se ha podido guardar: " + respuesta);

                    }

                    //habilito el codigo para poder editar
                    habilitarcontroles(true, false);
                   
                    UtilityFrm.recorrerylimpiartextbox(xuiCustomGroupbox2, "0");
                    DGCuotaTarjeta.Rows.Clear();
                    inicializartextbox();
                    UtilityFrm.limpiarErrorProvider( TxtMarca, errorIcono);
                    this.btnNuevo.Focus();

                }



            }
            catch (Exception ex)
            {
                UtilityFrm.mensajeError("error: " + ex.Message + " ;" + ex.StackTrace);
                isEditar = false;
                isNuevo = false;
            }


        }

        
        private bool controlargroupbox()
        {
            if (UtilityFrm.controlartextbox(xuiCustomGroupbox2))
            {
                return true;
            }
            
            return false;
        }
        private void habilitarodesabilitartextbox(bool flag)
        {
          //  UtilityFrm.habilitardesabilitarcontrol(xuiCustomGroupbox1,flag);
            UtilityFrm.habilitardesabilitarcontrol(xuiCustomGroupbox2, flag);
           // UtilityFrm.habilitardesabilitarcontrol(xuiCustomGroupbox3, flag);
          //  UtilityFrm.habilitardesabilitarcontrol(grpboxCategoria, flag);
           // UtilityFrm.habilitardesabilitarcontrol(xuiCustomGroupbox4, flag);
            
        }
        private void inicializartextbox()
        {
           
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Editar?", "Editar"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                habilitarcontroles(false, true);
                
            }
        }

        private void habilitarcontroles(bool var1, bool var2, bool habcantinicial = false)
        {
            //this.btnNuevo.loke = var1;
            
            btnNuevo.Enabled = var1;
            isNuevo = var1;
            this.btnEditar.Enabled = var1;
            

            isEditar = var2;
            this.btnCancelar.Enabled = var2;
            this.btnGuardar.Enabled = var2;
            DGCuotaTarjeta.Enabled = var2;
            
            habilitarodesabilitartextbox(var2);
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            

        }       
      
        
        //checkBox
        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
          
           
        }

        //TabControl
        private void tabControl1_Selected_1(object sender, TabControlEventArgs e)
        {
            //si selecciono el tabLista borro los textbox y button
            if (tabControl1.SelectedIndex == 0)
            {
               
                TxtMarca.Text = string.Empty;
                
                btnEditar.Enabled = false;
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                
                TxtMarca.Enabled = false;
                errorIcono.Clear();

                this.txtNombre.Select();

                this.txtNombre.Focus();
            }
            if (tabControl1.SelectedIndex == 1)
            {
               
            }
        }
       
        //lista de datos
        private void dataLista_DoubleClick(object sender, EventArgs e)
        {
            


                this.btnNuevo.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = true;
                string temporal = string.Empty;
                //para editar categoria lleva a la caja de texto de configuracion


                objventa.Codtarjeta = Convert.ToInt32(this.dataLista.CurrentRow.Cells["codigo"].Value);
               
                objventa.Cantcuotastar = Convert.ToInt32(this.dataLista.CurrentRow.Cells["Cant_Cuotas"].Value);
                objventa.Nombretarjeta = Convert.ToString(this.dataLista.CurrentRow.Cells["Descripcion"].Value);

               
               
                 valores =  objventa.Nombretarjeta.Split ('-');
                TxtMarca.Text = valores[0];
                if (valores.Length == 2)
                {
                    TxtEntidadEmisora.Text = valores[1];
                }

                rellenargridcuotas(objventa.Codtarjeta);
                this.tabControl1.SelectedTab = tabConfiguracion;

        }

        private void rellenargridcuotas(int codigotarjeta)
        {
            DataTable midatatable = new DataTable();
            DGCuotaTarjeta.Rows.Clear();
            if (codigotarjeta != 0)
            {
                midatatable = NegocioVenta.tarjeta(10, Convert.ToInt32(codigotarjeta));
                foreach (DataRow fila in midatatable.Rows)
                {
                    DGCuotaTarjeta.Rows.Add(fila["cuota"].ToString(), fila["porcentaje"].ToString());


                }
            }
            else
            {
                for (int i = 1; i <= 12; i++)
                {
                    DGCuotaTarjeta.Rows.Add(i, 0);
                }
            }
            

            
        }
        private void dataLista_Click_1(object sender, EventArgs e)
        {
            
        }
        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {	        
            //se produce un evento cuando hago click en la columna 0 que es eliminar de la lista
            //se comparan el indice de columna de la lista =0 y el indice de la columna del evento=0
                if (e.ColumnIndex == dataLista.Columns[0].Index && e.RowIndex>= 0)
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

        private void txtCodigoBarra_KeyDown(object sender, KeyEventArgs e)
        {
            //comparo el evento pasado como parametro y el enum keys.enter
            if (e.KeyCode == Keys.Enter)
            {
                this.TxtMarca.Focus();
                //se pasa el control permitiendo eliminar el beep
                e.SuppressKeyPress = true;
            }
        }

        
             

        private void tabConfiguracion_Click(object sender, EventArgs e)
        {
            this.btnNuevo.Focus();
        }

        private void tabConfiguracion_MouseClick(object sender, MouseEventArgs e)
        {
            this.btnNuevo.Focus();
        }


        
        

        
        private void btnGenerar_Click(object sender, EventArgs e)
        {
                 
              
            
              

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
            FrmImpArticulo impArt = new FrmImpArticulo(dataLista);
            impArt.ShowDialog();
            
        }


       

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCantInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtCodigoBarra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantInicial_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNombreConfig_TextChanged(object sender, EventArgs e)
        {
            UtilityFrm.limpiarErrorProvider(TxtMarca, errorIcono);
            if (TxtMarca.Text.Length == 0)
            {
                errorIcono.SetError(TxtMarca, "Es necesario un nombre de producto");
            }
        }

        private void rdbNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void rdbCodigoBarra_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void rbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            //comparo el evento pasado como parametro y el enum keys.enter
            if (e.KeyCode == Keys.Enter)
            {
               
                //se pasa el control permitiendo eliminar el beep
                e.SuppressKeyPress = true;
            }
        }

        private void FrmArticulos_KeyDown(object sender, KeyEventArgs e)
        {
            //comparo el evento pasado como parametro y el enum keys.enter
            if (e.KeyCode == Keys.F1)
           {
                this.txtNombre.Focus();
                txtNombre.Text = "";
               
            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                //pasa a la lista el foco 
                dataLista.Focus();

            }
            if (e.KeyCode == Keys.Down)
            {
                //pasa a la lista el foco 
                dataLista.Focus();

            }
            if (e.KeyCode == Keys.Enter)
            {


                //se pasa el control permitiendo eliminar el beep
                e.SuppressKeyPress = true;


                try
                {
                    buscar();
                    //txtNombreProducto.Focus();
                }
                catch (Exception ex)
                {

                    UtilityFrm.mensajeError("Error: " + ex.Message);
                }

            }
        }
        public bool IsNumeric(string input)
        {
            long test;

            return long.TryParse(input, out test);
        }
        private void txtCantInicial_KeyDown(object sender, KeyEventArgs e)
        {
            //comparo el evento pasado como parametro y el enum keys.enter
            if (e.KeyCode == Keys.Enter)
            {
                //this.btnGuardar.Focus();
               
                //se pasa el control permitiendo eliminar el beep
                e.SuppressKeyPress = true;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelHorizontal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxPesable_KeyDown(object sender, KeyEventArgs e)
        {
            //comparo el evento pasado como parametro y el enum keys.enter
            if (e.KeyCode == Keys.Enter)
            {
                this.btnGuardar.Focus();

                //se pasa el control permitiendo eliminar el beep
                e.SuppressKeyPress = true;
            }
        }

        private void tabLista_Click(object sender, EventArgs e)
        {

        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.FileName = "Listado de productos de " + DateTime.Now.ToString("dd-MM-yyyy");
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo =
                        (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                    hoja_trabajo.Cells.Rows[1].Font.Bold = true;
                    hoja_trabajo.Cells.Rows[1].Font.Size = 15;
                    hoja_trabajo.Cells[1, 1] = "Listado de productos : " + DateTime.Now;


                    hoja_trabajo.Range[hoja_trabajo.Cells[1, 1], hoja_trabajo.Cells[1, 10]].Merge();


                    if (dataLista.Rows.Count > 0)
                    {
                        //le paso el formato adecuado para los valores decimales pasando desde la fila 3 hasta datalista.rows.count+1 osea hasta el ultimo elemento
                        hoja_trabajo.Range[hoja_trabajo.Cells[3, 6], hoja_trabajo.Cells[dataLista.Rows.Count + 2, 7]].NumberFormat = "0,00";

                        hoja_trabajo.Range[hoja_trabajo.Cells[3, 8], hoja_trabajo.Cells[dataLista.Rows.Count + 2, 8]].NumberFormat = "0,00";
                        hoja_trabajo.Range[hoja_trabajo.Cells[3, 9], hoja_trabajo.Cells[dataLista.Rows.Count + 2, 9]].NumberFormat = "0,00";
                        hoja_trabajo.Range[hoja_trabajo.Cells[3, 10], hoja_trabajo.Cells[dataLista.Rows.Count + 2, 10]].NumberFormat = "0,00";
                    }
                    //Recorremos el DataGridView rellenando la hoja de trabajo
                    for (int i = 1; i < dataLista.Columns.Count; i++)
                    {

                        hoja_trabajo.Cells[2, i] = dataLista.Columns[i].Name;
                    }


                    for (int i = 0; i < dataLista.Rows.Count - 1; i++)
                    {

                        hoja_trabajo.Cells[i + 3, 1] = dataLista.Rows[i].Cells["idarticulo"].Value.ToString();
                        hoja_trabajo.Cells[i + 3, 2] = dataLista.Rows[i].Cells["codigo"].Value.ToString();
                        hoja_trabajo.Cells[i + 3, 3] = dataLista.Rows[i].Cells["nombre"].Value.ToString();
                        hoja_trabajo.Cells[i + 3, 4] = dataLista.Rows[i].Cells["descripcion"].Value.ToString();
                        hoja_trabajo.Cells[i + 3, 5] = dataLista.Rows[i].Cells["idcategoria"].Value.ToString();
                        hoja_trabajo.Cells[i + 3, 6] = dataLista.Rows[i].Cells["categoria"].Value.ToString();
                        hoja_trabajo.Cells[i + 3, 7] = dataLista.Rows[i].Cells["stock_actual"].Value;
                        hoja_trabajo.Cells[i + 3, 8] = dataLista.Rows[i].Cells["utilidad"].Value;
                        hoja_trabajo.Cells[i + 3, 9] = dataLista.Rows[i].Cells["precio_compra"].Value;
                        hoja_trabajo.Cells[i + 3, 10] =dataLista.Rows[i].Cells["precio"].Value;
        
                    }


         
                   

                    //ajustar el tamaño de las celdas deacuerdo al tamaño de las columnas agregadas
                    hoja_trabajo.Cells.Columns.AutoFit();
                    //guardo el archivo con la ruta del archivo
                    libros_trabajo.SaveAs(fichero.FileName,
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                    if (MessageBox.Show("Desea abrir el Excel ?", "Abrir Excel"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        Process.Start(fichero.FileName);
                    }

                }
            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("Error: " + ex.Message);
            }

        }

        private void chkDescripcion_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chkcategoria_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        

        private void txtUtilidad_Click(object sender, EventArgs e)
        {
           
        }

        private void Txtflete_Click(object sender, EventArgs e)
        {
           
        }

        private void txtPrecio_Click(object sender, EventArgs e)
        {
           
        }

        private void TxtPcompra_Leave(object sender, EventArgs e)
        {
           

        }

        private void TxtPcompra_KeyDown(object sender, KeyEventArgs e)
        {
                   }

        private void txtUtilidad_Leave(object sender, EventArgs e)
        {
           
        }


        private void calcularventa(decimal compra, decimal utilidad, decimal flete, decimal precio)
        {
           
        }
        private void calcularpreciomayorista1(decimal compra, decimal utilidad, decimal precio)
        {
           
            
        }

        private void calcularpreciomayorista2(decimal compra, decimal utilidad, decimal precio)
        {
            

        }
        private void calcularprecio_oferta(decimal compra, decimal utilidad, decimal precio)
        {
            

        }
        private void calcularcosto(decimal compra, decimal utilidad, decimal flete, decimal precio)
        { 
            
        }

        private void txtUtilidad_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Txtflete_Leave(object sender, EventArgs e)
        {
            
        }

        private void Txtflete_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void TxtPcompra_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtPcompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtUtilidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void dataLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //textBox1.Text = decimal.Round(Convert.ToDecimal(this.dataLista.CurrentRow.Cells["Precio"].Value), 2).ToString();

        }

        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            
             }

        private void txtPreciopormayor_Click(object sender, EventArgs e)
        {
            

        }

        private void txtCantidadpormayor_Click(object sender, EventArgs e)
        {
            
        }

        private void grpboxCategoria_Enter(object sender, EventArgs e)
        {

        }

        private void CHKFecha_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtPrecio2_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtCantidad2_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtCantidadBulto_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtCodigobarraBulto_Click(object sender, EventArgs e)
        {
            
        }

        private void txtUtilidadX6_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtPreciopormayor_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtCantidadpormayor_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxtUtilidadXCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxtPrecio2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxtCantidad2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxtUtilidadOferta_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtPrecioOferta_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtUtilidadX6_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtPreciopormayor_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtUtilidadX6_Leave(object sender, EventArgs e)
        {
            
            
        }

        private void txtPreciopormayor_Leave(object sender, EventArgs e)
        {
            
            
        }

        private void TxtUtilidadXCaja_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void TxtUtilidadXCaja_Leave(object sender, EventArgs e)
        {
            
            
            
        }

        private void TxtPrecio2_Leave(object sender, EventArgs e)
        {
            
            
            
        }

        private void TxtPrecio2_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void TxtUtilidadOferta_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtPrecioOferta_Leave(object sender, EventArgs e)
        {
            
            
            
        }

        private void txtPrecioOferta_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void Txtflete_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void BtnCargarcuota_Click(object sender, EventArgs e)
        {
            
            DGCuotaTarjeta.Rows.Clear();
            armargrilla();

        }
        private void armargrilla ()
        {
           
            

        }

        public List<Dventa> GrillaAList(DataGridView grillaACopiar)
        {
            List<Dventa> venta = new List<Dventa>();

           foreach (DataGridViewRow row in grillaACopiar.Rows)
            {
                Dventa ventas = new Dventa();
                ventas.Cuotas = Convert.ToInt32( row.Cells[0].Value);
                ventas.Porcentaje = Convert.ToDecimal(row.Cells[1].Value) ;
                venta.Add(ventas);               
            }


            return venta;
        }

    }
}
