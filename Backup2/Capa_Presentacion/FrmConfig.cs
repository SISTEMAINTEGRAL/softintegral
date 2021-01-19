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
using System.IO;
using System.Drawing.Imaging;
using System.Configuration;

namespace Capa_Presentacion
{
    public partial class FrmConfig : Form
    {
        private bool datos=false;
        private string iva = "";
        public FrmConfig()
        {
            InitializeComponent();

            
          
        }
        private void FrmConfig_Load(object sender, EventArgs e)
        {
            this.mostrarDatos();
            
           
        }

        

        public AutoCompleteStringCollection mostrarTarjetas()
        {

            DataTable dt = NegocioTarjeta.mostrar();
            AutoCompleteStringCollection autoCompleteStringCol = new AutoCompleteStringCollection();


            foreach (DataRow row in dt.Rows)
            {
                autoCompleteStringCol.Add(row["nombre"].ToString());
            }
            return autoCompleteStringCol;

        }

        private void mostrarDatos()
        {
 
            try
            {
                DataTable dt = NegocioConfigEmpresa.mostrar();
                if (dt.Rows.Count == 1)
                {
                    //si hay datos el boolean datos se pone a true
                    datos = true;
                    foreach (DataRow item in dt.Rows)
                    {
                       txtRazonSocial.Text=item["razon_social"].ToString();
                       txtCuit.Text = item["cuit"].ToString();
                       cbxCondicionFrenteIVA.Text = item["condicion_frente_iva"].ToString();
                        txtTelefono.Text = item["telefono"].ToString();
                        txtDireccion.Text = item["domicilio"].ToString();
                        txtLocalidad.Text = item["localidad"].ToString();
                        txtProvincia.Text = item["provincia"].ToString();
                        string imagen1 = item["logo"].ToString();

                        switch (item["condicion_frente_iva"].ToString())
                        {
                            case "RI":
                                {
                                    cbxCondicionFrenteIVA.Text = "RESPONSABLE INSCRIPTO";
                                    break;
                                }
                            case "MN":
                                {
                                    cbxCondicionFrenteIVA.Text = "MONOTRIBUTISTA";
                                    break;
                                }
                            case "EX":
                                {
                                    cbxCondicionFrenteIVA.Text = "EXCENTO";
                                    break;
                                }

                            default:
                                break;
                        }

                        //if (item["path_backup"].ToString() != null || item["path_backup"].ToString() != "")
                        //{
                        //    txtRuta.Text = item["path_backup"].ToString();
                        //    sincronizarBackup(txtRuta.Text);
                        // }
                        if (item["logo"].ToString() != "" && item["logo"].ToString() != "null")
                       {
                            byte[] imagen = (byte[])(item["logo"]);
                          
                            MemoryStream ms = new MemoryStream(imagen);
                            pbxLogo.Image = Image.FromStream(ms);           
                        }
                       
                    }

                }
                else
                {
                    UtilityFrm.mensajeError("No existen Datos de la Empresa Cargados");
                    
                    this.activarControles();
                }
            
            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("Error: "+ex.Message+" "+ex.StackTrace);
            }
           
        }



      
        public void desactivarControles(){
            txtRazonSocial.ReadOnly = true;
            cbxCondicionFrenteIVA.Enabled = false;
            txtCuit.ReadOnly = true;
            btnAgregarImagen.Enabled = false;
            btnEliminarLogo.Enabled = false;
            
        }
        public void activarControles()
        {
            txtRazonSocial.ReadOnly = false;
            cbxCondicionFrenteIVA.Enabled = true;
            txtCuit.ReadOnly = false;
            btnAgregarImagen.Enabled = true;
            btnEliminarLogo.Enabled = true;
            txtRazonSocial.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Modificar los datos de su empresa? , esto podria ocasionar un cambio al momento de efectuar la venta", "Modificar"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                
                
              
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                
                
                btnGuardar.Enabled = false;
                

                switch (cbxCondicionFrenteIVA.Text)
                {
                    case "RESPONSABLE INSCRIPTO":
                        {
                            iva = "RI";
                            break;
                        }
                    case "MONOTRIBUTISTA":
                        {
                            iva = "MN";
                            break;
                        }
                    case "EXCENTO":
                        {
                            iva = "EX";
                            break;
                        }

                    default:
                        break;
                }

                MemoryStream ms = new MemoryStream();
                long cuit = txtCuit.Text == string.Empty ? 0 : Convert.ToInt64(txtCuit.Text);
                string respuesta;

                if (datos == true)
                {
                    if (pbxLogo.Image != null)
                    {
                        pbxLogo.Image.Save(ms, ImageFormat.Jpeg);

                        respuesta = NegocioConfigEmpresa.modificar(txtRazonSocial.Text, iva, cuit, ms.GetBuffer(),txtLocalidad.Text,txtProvincia.Text,txtDireccion.Text,txtTelefono.Text);
                    }
                    else
                    {
                        respuesta = NegocioConfigEmpresa.modificar(txtRazonSocial.Text, iva, cuit, null, txtLocalidad.Text, txtProvincia.Text, txtDireccion.Text, txtTelefono.Text);


                    }


                    if (respuesta.Equals("ok"))
                    {
                        NegocioConfigEmpresa.emcuit = Convert.ToInt64( txtCuit.Text);
                        NegocioConfigEmpresa.emprovincia = txtProvincia.Text;
                        NegocioConfigEmpresa.emlocalidad = txtLocalidad.Text;
                        NegocioConfigEmpresa.emtelefono = txtTelefono.Text;
                        NegocioConfigEmpresa.emrazonsocial = txtRazonSocial.Text;
                        NegocioConfigEmpresa.emciva = iva;

                        UtilityFrm.mensajeConfirm("Se Agregó Correctamente");
                        datos = true;
                    }
                    else
                    {

                        UtilityFrm.mensajeError(respuesta);
                        
                    }

                }
                else
                {
                    if (pbxLogo.Image != null)
                    {
                        pbxLogo.Image.Save(ms, ImageFormat.Jpeg);

                        respuesta = NegocioConfigEmpresa.agregar(txtRazonSocial.Text, cbxCondicionFrenteIVA.SelectedItem.ToString(), cuit, ms.GetBuffer());

                    }
                    else
                    {
                        respuesta = NegocioConfigEmpresa.agregar(txtRazonSocial.Text, "", cuit, null);


                    }


                    if (respuesta.Equals("ok"))
                    {
                        UtilityFrm.mensajeConfirm("Se Agregó Correctamente");
                        datos = true;
                    }
                    else
                    {

                        UtilityFrm.mensajeError(respuesta);
                      
                    }
                }
            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("Error:"+ex.Message );
            }
           
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string imagen = open.FileName;
                    pbxLogo.Image = Image.FromFile(imagen);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido, "+ex.Message);
            }
        }

        private void btnEliminarLogo_Click(object sender, EventArgs e)
        {
            pbxLogo.Image.Dispose();
            pbxLogo.Image = null;
        }

        private void txtRuta_TextChanged(object sender, EventArgs e)
        {
            if (txtRuta.Text.Length > 0)
            {
                btnSincronizar.Enabled = true;
            }
            else {

               btnSincronizar.Enabled = false;
            
            }
        }
       
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog browser = new FolderBrowserDialog();
                browser.RootFolder = Environment.SpecialFolder.MyComputer;
                string tempPath = "";

                if (browser.ShowDialog() == DialogResult.OK)
                {
                    tempPath = browser.SelectedPath;
                    txtRuta.Text = tempPath; // prints path
                    if (File.Exists(tempPath + "\\backup.bak"))
                    {
                        sincronizarBackup(tempPath + "\\backup.bak");

                    }
                    else {
                        lblSincronizacion.Visible = true;
                        lblSincronizacion.Text = "Nunca";
                    
                    }
            
                }
                else {
                    txtRuta.Text = "";
                
                }
            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("Error al intentar sincronizar: "+ex.Message +" "+ex.StackTrace);
            }
        }
        public void sincronizarBackup(string path) {

            DateTime dt = File.GetLastWriteTime(path);
            lblSincronizacion.Visible = true;
            lblSincronizacion.Text = dt.ToLongDateString() + " a las " + dt.ToShortTimeString() + " hs";
        }
        private void btnSincronizar_Click(object sender, EventArgs e)
        {
            if(txtRuta.Text.Length>0&&txtRuta.Text!=""){
                try
                {
                    string respuesta= NegocioBackup.backupBaseDeDatos(txtRuta.Text);

                    if (respuesta == "ok")
                    {
                        UtilityFrm.mensajeConfirm("El backup se realizó correctamente");
                        sincronizarBackup(txtRuta.Text +"\\backup.bak");
                    }
                    else {
                        UtilityFrm.mensajeError("Error :"+respuesta);
                    
                    }
                }
                catch (Exception ex)
                {

                    UtilityFrm.mensajeError("Error: "+ex.Message+" "+ex.StackTrace);
                }
               
            }

            
        }

        private void cbxTipoTarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGuardarTarjeta_Click(object sender, EventArgs e)
        {

            
        }

        private void txtNombTarjeta_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void txtNombTarjeta_KeyDown(object sender, KeyEventArgs e)
        {
                    }

        private void btnCerrar2_Click(object sender, EventArgs e)
        {

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
            //if (NegocioConfigEmpresa.balanzapuerto != "")
            //{
            //    UtilityFrm.desconectarbalanza(serialPort1);
            //}

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
            btnRestaurar.BackColor = Color.FromArgb(0, 100, 200);
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
    }
}
