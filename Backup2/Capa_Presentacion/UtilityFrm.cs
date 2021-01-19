using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.Odbc;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using Capa_negocio;
using Guna.UI.WinForms;
using System.Drawing;
using XanderUI.Designers;
using System.IO.Ports;
using System.Globalization;
using System.Diagnostics;
using System.IO;
using Tulpep.NotificationWindow;

namespace Capa_Presentacion
{
    public class UtilityFrm
    {
       
        //sobreCargas para limpiar textbox
        public static void limpiarTextbox(TextBox txt1)
        {
            txt1.Text = "";

        }
        public static void limpiarTextbox(TextBox txt1, TextBox txt2)
        {
            txt1.Text = "";
            txt2.Text = "";


        }
        public static void limpiarTextbox(TextBox txt1, TextBox txt2, TextBox txt3)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
        }
        public static void limpiarTextbox(TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
        }
        public static void limpiarTextbox(TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4, TextBox txt5)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
        }
        public static void notificacionpopup(string titulo, string contenidodeltexto, string colorbody = "normal")
        {
            PopupNotifier popup = new PopupNotifier();
            if (colorbody == "normal")
            {
                popup.BodyColor = Color.FromArgb(0, 100, 200);
            }
            if (colorbody == "peligro")
            {
                popup.BodyColor = Color.FromArgb(183,95,77);
            }
            if (colorbody == "precaucion")
            {
                popup.BodyColor = Color.FromArgb(188, 162, 73);
            }
            popup.TitleColor = Color.White;
            popup.ContentColor = Color.White;
            
            popup.TitleText = titulo;
            popup.ContentText = contenidodeltexto;
            popup.Popup();
        }
        public static void limpiarTextbox(TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4, TextBox txt5, TextBox txt6)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
        }

        // sobrecargas de validaciones

        public static bool validarnull(TextBox txt1)
        {
            bool flag = true;
            if (txt1.Text == "")
            {
                flag = false;
            }
            return flag;
        }

        public static bool validarnull(TextBox txt1, TextBox txt2)
        {
            bool flag = true;
            if ((txt1.Text == "") || (txt2.Text == ""))
            {
                flag = false;
            }
            return flag;
        }

        public static bool validarnull(TextBox txt1, TextBox txt2, TextBox txt3)
        {
            bool flag = true;
            if ((txt1.Text == "") || (txt2.Text == "") || (txt3.Text == ""))
            {
                flag = false;
            }
            return flag;
        }

        public static bool validarnull(TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4)
        {
            bool flag = true;
            if ((txt1.Text == "") || (txt2.Text == "") || (txt3.Text == "") || (txt4.Text == ""))
            {
                flag = false;
            }
            return flag;
        }
        //limpiar errores Provider
        /// <summary>
        /// Limpia una caja de texto que esté afectado por algun icono de error
        /// </summary>
        /// <param name="txt1"></param>
        /// <param name="e"></param>
        public static void limpiarErrorProvider(TextBox txt1, ErrorProvider e)
        {


            e.SetError(txt1, "");

        }
        /// <summary>
        ///   Limpia una caja de texto que esté afectado por algun icono de error
        /// </summary>
        /// <param name="txt1"></param>
        /// <param name="txt2"></param>
        /// <param name="e"></param>
        public static void limpiarErrorProvider(TextBox txt1, TextBox txt2, ErrorProvider e)
        {


            e.SetError(txt1, "");
            e.SetError(txt2, "");

        }
        /// <summary>
        ///   Limpia una caja de texto que esté afectado por algun icono de error
        /// </summary>
        /// <param name="txt1"></param>
        /// <param name="txt2"></param>
        /// <param name="txt3"></param>
        /// <param name="e"></param>
        public static void limpiarErrorProvider(TextBox txt1, TextBox txt2, TextBox txt3, ErrorProvider e)
        {


            e.SetError(txt1, "");
            e.SetError(txt2, "");
            e.SetError(txt3, "");
        }
        //mensaje de confirmacion
        public static void mensajeConfirm(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //mensaje de error
        public static void mensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

       

        public static bool mensajeopcionsiono(string mensaje)
        {
            bool siono = true;
            DialogResult dialogResult = MessageBox.Show(mensaje, "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                siono = true;
            }
            else if (dialogResult == DialogResult.No)
            {
                siono = false;
                //do something else
            }
            return siono;
        }

        /// <summary>
        /// Sirve para permitir solo valores numericos y decimales en textbox,el punto convierte en coma
        /// </summary>
        /// <param name="keyPressEventArgs"></param>
        /// <param name="textbox"></param>
        public static void NumDecTeclado(KeyPressEventArgs e, TextBox txt)
        {
            //solo valores numericos

            if (Char.IsDigit(e.KeyChar))
            {

                e.Handled = false;


            }
            else if (e.KeyChar == ',' && !txt.Text.Contains(','))
            {
                e.Handled = false;
                //solo una coma decimal



            }
            else if (e.KeyChar == '.' && !txt.Text.Contains(','))
            {

                e.Handled = true;
                txt.Text += ",";
                //se mueve hasta la ultima posicion
                txt.Select(txt.Text.Length, 0);
            }


            else if (Char.IsControl(e.KeyChar))
            {

                e.Handled = false;
            }

            else
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }


        }
       
        /// <summary>
        /// Permite solo valores numerico en textbox
        /// </summary>
        /// <param name="e"></param>
        /// <param name="txt"></param>
        public static void NumTeclado(KeyPressEventArgs e, TextBox txt)
        {
            if (Char.IsDigit(e.KeyChar))
            {

                e.Handled = false;

            }

            else if (Char.IsControl(e.KeyChar))
            {

                e.Handled = false;
            }

            else
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        public static string GetImpresoraDefecto()
        {
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                PrinterSettings a = new PrinterSettings();
                a.PrinterName = PrinterSettings.InstalledPrinters[i].ToString();
                if (a.IsDefaultPrinter)
                {
                    return PrinterSettings.InstalledPrinters[i].ToString();

                }
            }
            return "";
        }

        public static decimal calcularporcentaje(decimal costo, decimal venta)
        {
            decimal resultado = 0;




            resultado = ((venta - costo) / venta) * 100;
            return resultado;
        }

        public static decimal calcularventa(decimal costo, decimal utilidad, decimal flete = 0, decimal venta = 0)


        {
            //valor1 = costo
            //valor2 = utilidad
            //resultado = venta
            decimal resultado = 0;
            if (costo != 0)
            {
                if (NegocioConfigEmpresa.confsistema("redondear") == "True")
                {
                    resultado = Math.Ceiling(costo * (1 + (utilidad / 100)));
                }
                else
                {
                    resultado = costo * (1 + (utilidad / 100));
                }
                
                
                resultado = costo * (1 + (utilidad / 100));
                if (flete != 0)
                {
                    if ( NegocioConfigEmpresa.confsistema("redondear") == "True")
                    {
                        resultado = Math.Ceiling(resultado * (1 + (flete / 100)));
                    }
                    else
                    {
                        resultado = resultado * (1 + (flete / 100));
                    }
                    

                }
            }
            else
            {
                resultado = venta;
            }
            //ceiling redondea para arriba y floor redondea para abajo 

            return resultado;
        }

        public static decimal calcularpreciocosto(decimal venta, decimal utilidad)
        {

            //valor1 = venta
            //valor2 = utilidad
            decimal resultado = 0;
            if (venta != 0)
            {
                resultado = venta - (venta * (utilidad / 100));
            }

            return resultado;

        }

        public static string formateodecimal(decimal valor, int cantidaddecimales)
        {
            string formateo = "";
            string concatenar = ".";
            for (int i = 0; i < cantidaddecimales; i++)
            {
                concatenar = concatenar + "0";
            }
            formateo = valor.ToString("###,##0" + concatenar);
            return formateo;

        }

        public static string turnosegunhora()
        {

            string hora = "";
            string min = "";
            string turno = "";
            hora = DateTime.Now.Hour.ToString();
            min = DateTime.Now.Minute.ToString();
            if (Convert.ToInt32(hora) >= 8 && Convert.ToInt32(hora) <= 15)
            {
                turno = "MAÑANA";


            }
            if (Convert.ToInt32(hora) >= 15 && Convert.ToInt32(hora) <= 22)
            {
                turno = "TARDE";
                if (Convert.ToInt32(hora) == 15 && Convert.ToInt32(min) == 0)
                {
                    turno = "MAÑANA";
                }

            }
            if (Convert.ToInt32(hora) >= 22 && Convert.ToInt32(hora) <= 7)
            {
                turno = "NOCHE";
                if (Convert.ToInt32(hora) == 22 && Convert.ToInt32(min) == 0)
                {
                    turno = "TARDE";
                }

            }



            return turno;

        }

        public static void importarExcel(DataGridView dgv, String nombreHoja)
        {
            OleDbConnection conn;
            OleDbDataAdapter MyDataAdapter;
            DataTable dt;
            String ruta = "";
            try
            {
                OpenFileDialog openfile1 = new OpenFileDialog();
                openfile1.Filter = "Excel Files |*.xlsx";
                openfile1.Title = "Seleccione el archivo de Excel";
                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openfile1.FileName.Equals("") == false)
                    {
                        ruta = openfile1.FileName;
                    }
                }

                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + ruta + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'");
                MyDataAdapter = new OleDbDataAdapter("Select * from [" + nombreHoja + "$]", conn);
                dt = new DataTable();
                MyDataAdapter.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static void Validar_DatagridPress(object sender, System.Windows.Forms.KeyPressEventArgs e, DataGridView midatagrid, string valor = "")
        {
            //obtener indice de la columna 
            int columna = midatagrid.CurrentCell.ColumnIndex;


            //solo valores numericos

            if (Char.IsDigit(e.KeyChar))
            {

                e.Handled = false;


            }
            else if (e.KeyChar == ',' && !valor.Contains(','))
            {
                e.Handled = false;
                //solo una coma decimal



            }
            else if (e.KeyChar == '.' && !valor.Contains(','))
            {

                e.Handled = true;
                valor += ",";
                //se mueve hasta la ultima posicion
                //valor.Select(valor.Length, 0);
            }


            else if (Char.IsControl(e.KeyChar))
            {

                e.Handled = false;
            }

            else
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
            //if (char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //}

        }
        public static AutoCompleteStringCollection LoadAutoComplete(DataTable dt, string campocoleccion)
        {
            // DataTable dt = NegocioCliente.localidad(Convert.ToInt32(Cbprovincia.SelectedValue));

            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();

            foreach (DataRow row in dt.Rows)
            {

                stringCol.Add(Convert.ToString(row[campocoleccion]));
            }


            return stringCol;
        }

        public static string agregarcodigobarra(string varcodigobarra)
        {
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
                    varcodigobarra = codigoBarra + codigoControl;
                    objart.extraerdatos(0, "porbarra", varcodigobarra);
                    cambiarcodigobarra = true;

                } while (objart.Sindatos == true);
                return varcodigobarra;
            }
            catch (FormatException ex)
            {
                throw;
            }

        }

        public static bool habilitargunaboton(XanderUI.XUISuperButton xuiboton, bool habilitar)
        {
            if (habilitar == true)
            {
                xuiboton.BackgroundColor = Color.FromArgb(52, 144, 247);
                xuiboton.SelectedBackColor = Color.FromArgb(52, 144, 247);
            }
            else
            {
                xuiboton.SelectedBackColor = Color.FromArgb(42, 47, 71);
                xuiboton.BackgroundColor = Color.FromArgb(42, 47, 71);
            }

            xuiboton.Enabled = habilitar;

            return habilitar;
        }
        public static void completarcombobox(ComboBox micombobox, string valordelcombo, string valoramostrar, DataTable midatatable, bool autocompletar = true)
        {
            if (midatatable.Rows.Count != 0)
            {
                micombobox.DataSource = midatatable;
                //valor real de la DB
                micombobox.ValueMember = valordelcombo;
                //lo que se muestra
                micombobox.DisplayMember = valoramostrar;
                if (midatatable.Rows.Count != 0)
                {
                    micombobox.AutoCompleteCustomSource = UtilityFrm.LoadAutoComplete(midatatable, valoramostrar);
                    micombobox.AutoCompleteMode = AutoCompleteMode.Suggest;
                    micombobox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }


            }



        }
        public static void completartextbox(TextBox cajatexto, DataTable midatatable, string valoramostrar)
        {

            cajatexto.AutoCompleteCustomSource = UtilityFrm.LoadAutoComplete(midatatable, valoramostrar);
            cajatexto.AutoCompleteMode = AutoCompleteMode.Suggest;
            cajatexto.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        public static string enletras(string num)
        {
            string res, dec = "";
            Int64 entero;
            int decimales;
            double nro;

            try
            {
                nro = Convert.ToDouble(num);
            }
            catch

            {
                return "";
            }

            entero = Convert.ToInt64(Math.Truncate(nro));
            decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));
            if (decimales > 0)
            {
                dec = " CON " + decimales.ToString() + "/100";
            }

            res = toText(Convert.ToDouble(entero)) + dec;
            return res;
        }

        private static string toText(double value)
        {
            string Num2Text = "";
            value = Math.Truncate(value);
            if (value == 0) Num2Text = "CERO";
            else if (value == 1) Num2Text = "UNO";
            else if (value == 2) Num2Text = "DOS";
            else if (value == 3) Num2Text = "TRES";
            else if (value == 4) Num2Text = "CUATRO";
            else if (value == 5) Num2Text = "CINCO";
            else if (value == 6) Num2Text = "SEIS";
            else if (value == 7) Num2Text = "SIETE";
            else if (value == 8) Num2Text = "OCHO";
            else if (value == 9) Num2Text = "NUEVE";
            else if (value == 10) Num2Text = "DIEZ";
            else if (value == 11) Num2Text = "ONCE";
            else if (value == 12) Num2Text = "DOCE";
            else if (value == 13) Num2Text = "TRECE";
            else if (value == 14) Num2Text = "CATORCE";
            else if (value == 15) Num2Text = "QUINCE";
            else if (value < 20) Num2Text = "DIECI" + toText(value - 10);
            else if (value == 20) Num2Text = "VEINTE";
            else if (value < 30) Num2Text = "VEINTI" + toText(value - 20);
            else if (value == 30) Num2Text = "TREINTA";
            else if (value == 40) Num2Text = "CUARENTA";
            else if (value == 50) Num2Text = "CINCUENTA";
            else if (value == 60) Num2Text = "SESENTA";
            else if (value == 70) Num2Text = "SETENTA";
            else if (value == 80) Num2Text = "OCHENTA";
            else if (value == 90) Num2Text = "NOVENTA";
            else if (value < 100) Num2Text = toText(Math.Truncate(value / 10) * 10) + " Y " + toText(value % 10);
            else if (value == 100) Num2Text = "CIEN";
            else if (value < 200) Num2Text = "CIENTO " + toText(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = toText(Math.Truncate(value / 100)) + "CIENTOS";
            else if (value == 500) Num2Text = "QUINIENTOS";
            else if (value == 700) Num2Text = "SETECIENTOS";
            else if (value == 900) Num2Text = "NOVECIENTOS";
            else if (value < 1000) Num2Text = toText(Math.Truncate(value / 100) * 100) + " " + toText(value % 100);
            else if (value == 1000) Num2Text = "MIL";
            else if (value < 2000) Num2Text = "MIL " + toText(value % 1000);
            else if (value < 1000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0) Num2Text = Num2Text + " " + toText(value % 1000);
            }

            else if (value == 1000000) Num2Text = "UN MILLON";
            else if (value < 2000000) Num2Text = "UN MILLON " + toText(value % 1000000);
            else if (value < 1000000000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000) * 1000000);
            }

            else if (value == 1000000000000) Num2Text = "UN BILLON";
            else if (value < 2000000000000) Num2Text = "UN BILLON " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);

            else
            {
                Num2Text = toText(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            }
            return Num2Text;

        }

        public static string conectarbalanza(SerialPort puertoserie)
        {
            string mensaje = "ok";
            try
            {
                // puertoserie = new SerialPort();
                NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;

                if (!puertoserie.IsOpen)
                {
                    try
                    {
                        puertoserie.BaudRate = 9600;
                        puertoserie.DataBits = 8;
                        puertoserie.Parity = Parity.None;
                        puertoserie.StopBits = StopBits.One;
                        puertoserie.Handshake = Handshake.None;
                        puertoserie.PortName = NegocioConfigEmpresa.balanzapuerto;
                        puertoserie.DtrEnable = false;
                        
                        puertoserie.ReadBufferSize = 1024;
                        puertoserie.WriteBufferSize = 1024;
                        puertoserie.WriteTimeout = 500;

                        puertoserie.Encoding = System.Text.Encoding.Default;
                        puertoserie.Open();
                    }
                    catch (Exception msg)
                    {

                        mensaje = msg.ToString();
                    }
                    
                }
            }
            catch ( Exception msg)
            {

                mensaje = msg.ToString();
            }
            return mensaje;

        }
        public static decimal Leerbalanza(string delimitador)
        {
            try
            {

                string valor = "";
                string valor2 = "";
                decimal valordecimal = 0;
               // string delimitador = "";
                
                  //  delimitador = puertoserie.ReadExisting();

                if (delimitador.Length > 2000)
                {

                }


                valor = GetdigitFromString(delimitador);

                if (valor != "" && valor.Length >= 6)
                {
                    valor2 = valor.Substring(2, 6);
                    // textBox2.Text = valor2.ToString();
                    valordecimal = Convert.ToDecimal(valor2);
                }
                else
                {
                    valordecimal = 0;
                }
               

                //decimal valor = Convert.ToDecimal(textBox2.Text);
                
                return valordecimal;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void desconectarbalanza(SerialPort puertoserie)
        {
            if (puertoserie.IsOpen)
            {
                puertoserie.Close();
            }
            
        }
        // toma solo numeros y puntos
          public  static string GetdigitFromString(string str, bool validarcomas = false)
            {
                try
                {
                
                    int contarpunto = 0;
                    char[] refArray = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.' };
                    char[] inputArray = str.ToCharArray();
                    string ext = string.Empty;
                    foreach (char item in inputArray)
                    {

                        if (validarcomas == false)
                        {
                            if (refArray.Contains(item))
                            {

                                if (item.ToString() == ".")
                                {
                                    ++contarpunto;
                                }
                                if (contarpunto >= 1)
                                {
                                    ext += item.ToString() == "." ? "," : item.ToString();
                                }


                                //else if (contarpunto > 4)
                                //{
                                //    break;
                                //}



                            }

                        }
                        else
                        {
                             ext += item.ToString() == "." ? "," : item.ToString();
                        }
                        
                    }
                    return ext;
                }
                catch (Exception)
                {

                    throw;
                }

          }

        
        /**
*
* @param txtCuit CUIT del EMISOR del comprobante sin guiones
* @param txtCodComp codigo de comprobantes dos digitos
* @param txtPtoVta punto de venta del comprobante 4 digitos
* @param txtCae cae
* @param txtVtoCae vencimiento del cae en formato yyyyMMdd
* @return devuelve el string completo para utilizar en el codigo de barras
*/
        public static String calculoDigitoVerificador(String txtCuit, String txtCodComp,
        String txtPtoVta, String txtCae, String txtVtoCae, bool cae = true, string textoaprocesar = "0")
        {
            int i;
            String cod = "";
            String txtDigito;
            int impares;
            int pares;
            int total;
            int digito;
            String txtCodBarra;
            if (cae == true)
            {
                cod = txtCuit + txtCodComp.Substring(1, 2) + txtPtoVta.PadLeft(4, '0') + txtCae + txtVtoCae;
            }
            else
            {
                cod = textoaprocesar;
            }
            
           // cod = txtCuit  + txtCae + txtVtoCae;
            txtCodBarra = cod;
            char[] inputArray = txtCodBarra.ToCharArray();
            //
            // Ahora analizo la cadena de caracteres:
            // Tengo que sumar todos los caracteres impares y los pares
            pares = 0;
            impares = 0;
            int cont = 1;

            foreach (char item in inputArray)
            {
                if (cont % 2 == 0)
                {
                    
                    pares += Convert.ToInt32(item.ToString());
                }
                else
                {
                    impares += Convert.ToInt32(item.ToString());
                }
                cont++;
            }

          
            impares = 3 * impares;
            total = pares + impares;

            digito = 10 - (total % 10);
            //
            if (digito == 10)
            {
                digito = 0;
            }
            return cod + digito.ToString();
        }
        public static bool controlartextbox(Control control)
        {
            bool enblanco = false;
            ErrorProvider erroricono = new ErrorProvider();
            foreach (var txt  in control.Controls)
            {
                if (txt is TextBox)
                {
                    
                    if (((TextBox)txt).Text.Length == 0 )
                    {
                        erroricono.SetError(((TextBox)txt), "Ingrese un Nombre de Producto");
                        enblanco = true;
                        return enblanco;
                        break;
                    }
                    
                    
                }
               
            }
            return enblanco;
        }
        public static void habilitardesabilitarcontrol(Control control,bool flag)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Enabled = flag;
                }
            }

        }
        public static void recorrerylimpiartextbox(Control control, string inicializarcon)
        {
            foreach (var txt  in control.Controls)
            {
                if (txt is TextBox)
                {
                        ((TextBox)txt).Text = inicializarcon;
                    
                    
                }
            }
        }

        //generar un log en el instalador 
        public static string archivotxtbalanza(DataTable dataproductobalanza, bool balanzamayorista = false)
        {
            string mensaje = "";
            string tipopesable = "";
            try
            {
                string ruta = "";
                ruta = System.AppDomain.CurrentDomain.BaseDirectory + @"Balanza\balanza.txt";
                StreamWriter sw = new StreamWriter(ruta);
                if (dataproductobalanza.Rows.Count != 0)
                {
                    //  DataRow row = dataproductobalanza.Rows[0];

                    // string cliente = row["razon_social"].ToString();

                    foreach (DataRow row in dataproductobalanza.Rows)
                    {
                        if (row["pesable"].ToString() == "True")
                        {
                            tipopesable = "P";
                        }
                        else
                        {
                            tipopesable = "N";
                        }
                        if (balanzamayorista == false)
                        {
                            sw.WriteLine(row["codigo"].ToString() + "@" + row["codigo"].ToString() + "@" + row["nombre"].ToString() + "@" + row["categoria"].ToString() + "@1@1@" + row["precio"].ToString() + "@" + tipopesable + "@1");
                        }
                        else
                        {
                            sw.WriteLine(row["codigo"].ToString() + "@" + row["codigo"].ToString() + "@" + row["nombre"].ToString() + "@" + row["categoria"].ToString() + "@1@1@" +  row["precio"].ToString() + "@" + row["preciopormayor"].ToString() + "@" + tipopesable + "@1");
                        }
                        
                    }

                }



                sw.Close();
            }
            catch (Exception ex)
            {

                mensaje = ex.ToString();
            }

            return mensaje;
        }
        public class Log
        {
            private string Path = "";


            public Log(string Path)
            {
                this.Path = Path;
            }

            public Log()
            {
                this.Path = System.AppDomain.CurrentDomain.BaseDirectory + @"Log\";
            }
            public void Add(string sLog)
            {
                CreateDirectory();
                string nombre = GetNameFile();
                string cadena = "";

                cadena += DateTime.Now + " - " + sLog + Environment.NewLine;

                StreamWriter sw = new StreamWriter(Path + "/" + nombre, true);
                sw.Write(cadena);
                sw.Close();

            }

            #region HELPER
            
            private string GetNameFile()
            {
                string nombre = "";

                nombre = "log_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + ".txt";

                return nombre;
            }

            private void CreateDirectory()
            {
                try
                {
                    if (!Directory.Exists(Path))
                        Directory.CreateDirectory(Path);


                }
                catch (DirectoryNotFoundException ex)
                {
                    throw new Exception(ex.Message);

                }
            }
            #endregion
           

        }

    }
}
