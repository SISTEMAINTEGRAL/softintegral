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

namespace Capa_Presentacion
{
    public class UtilityFrm
    {
        //sobreCargas para limpiar textbox
        public static void limpiarTextbox(TextBox txt1)
        {
            txt1.Text = "";
            
        }
         public static void limpiarTextbox(TextBox txt1,TextBox txt2)
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
         public static void limpiarTextbox(TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4, TextBox txt5,TextBox txt6)
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
             if ((txt1.Text =="") || (txt2.Text == ""))
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
         public static void limpiarErrorProvider(TextBox txt1,ErrorProvider e)
         {
            
           
             e.SetError(txt1,"");
           
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
         public static void limpiarErrorProvider(TextBox txt1, TextBox txt2,TextBox txt3 ,ErrorProvider e)
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
         public static void NumDecTeclado(KeyPressEventArgs e,TextBox txt)
         { 
         //solo valores numericos

           if (Char.IsDigit(e.KeyChar))
            {
                
                e.Handled = false;
                
               
            }else if(e.KeyChar == ',' && !txt.Text.Contains(',')){
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

        public static string  GetImpresoraDefecto()
        {
         for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                PrinterSettings a = new PrinterSettings();
                a.PrinterName = PrinterSettings.InstalledPrinters[i].ToString();
                if (a.IsDefaultPrinter)
                {
                   return   PrinterSettings.InstalledPrinters[i].ToString();

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

        public static decimal calcularventa (decimal costo, decimal utilidad, decimal flete = 0, decimal venta = 0)
            
            
            {
                //valor1 = costo
                //valor2 = utilidad
                //resultado = venta
               decimal resultado = 0;
               if (costo != 0)
               {
                   resultado = Math.Ceiling(costo * (1 + (utilidad / 100)));
                   if (flete != 0)
                   {
                       resultado = Math.Ceiling(resultado * (1 + (flete / 100)));

                   }
               }
               else
               {
                   resultado = venta;
               }
            //ceiling redondea para arriba y floor redondea para abajo 
                
                return resultado ;
            }

         public static decimal calcularpreciocosto (decimal venta, decimal utilidad) 
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
             for (int i=0;i<cantidaddecimales;i++)
             {
                concatenar = concatenar+"0";
             }
             formateo = valor.ToString("###,##0"+concatenar);
             return formateo;
         
         }

         public static string turnosegunhora()
         {
             
             string hora = "";
             string min = "";
             string turno = "";
             hora = DateTime.Now.Hour.ToString ();
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
         public static void Validar_DatagridPress(object sender, System.Windows.Forms.KeyPressEventArgs e, DataGridView midatagrid,string valor = "")
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

         public static string agregarcodigobarra( string varcodigobarra)
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
            catch  (FormatException ex)
            {
                throw;
            }
           
        }
        
        
    }
}
