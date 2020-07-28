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

        public FrmConfig()
        {
            InitializeComponent();

            
          
        }
        private void FrmConfig_Load(object sender, EventArgs e)
        {
            this.mostrarDatos();
            this.cargarTarjetas();
           
        }

        public void cargarTarjetas() {


            txtNombTarjeta.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNombTarjeta.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtNombTarjeta.AutoCompleteCustomSource = mostrarTarjetas();

        
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
                       string imagen1 = item["logo"].ToString();


                       if (item["path_backup"].ToString() != null || item["path_backup"].ToString() != "")
                       {
                           txtRuta.Text = item["path_backup"].ToString();
                           sincronizarBackup(txtRuta.Text);
                        }
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
                activarControles();
                btnEditar.Enabled = false;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desactivarControles();
            btnEditar.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                desactivarControles();
                btnEditar.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                MemoryStream ms= new MemoryStream();
                long cuit = txtCuit.Text == string.Empty ? 0 : Convert.ToInt64(txtCuit.Text);
                string respuesta;

                if (datos == true)
                {
                    if (pbxLogo.Image != null)
                    {
                        pbxLogo.Image.Save(ms, ImageFormat.Jpeg);

                        respuesta = NegocioConfigEmpresa.modificar(txtRazonSocial.Text, cbxCondicionFrenteIVA.SelectedItem.ToString(), cuit, ms.GetBuffer());
                    }
                    else
                    {
                        respuesta = NegocioConfigEmpresa.modificar(txtRazonSocial.Text, "", cuit, null);


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
            if(cbxTipoTarjeta.SelectedItem.ToString()!=""){
                txtNombTarjeta.Enabled = true;
            }
        }

        private void btnGuardarTarjeta_Click(object sender, EventArgs e)
        {

            try
            {
                if(txtNombTarjeta.Text!=string.Empty&& cbxTipoTarjeta.SelectedItem.ToString()!=string.Empty){
                    //forma de pago 4 tarjeta de credito - 8 tarjeta de debito
                    int codFormaPago =cbxTipoTarjeta.SelectedItem.ToString()!="Credito"? 4 :8;
                    string respuesta= NegocioTarjeta.insertar(txtNombTarjeta.Text,codFormaPago);
                    if (respuesta == "ok")
                    {

                        UtilityFrm.mensajeConfirm("La tarjeta ha sido agregada correctamente");
                    }
                    else {
                        UtilityFrm.mensajeConfirm("Ha ocurrido un error cuando intentó agregar tarjeta");
                    }
                }
              
            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("Error: "+ex.Message);
            }
            
        }

        private void txtNombTarjeta_TextChanged(object sender, EventArgs e)
        {
            if (txtNombTarjeta.Text.Length > 0)
            {
                btnGuardarTarjeta.Enabled = true;

            }
            else {
                btnGuardarTarjeta.Enabled = false;
            }
           
        }

        private void txtNombTarjeta_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter){
                btnGuardarTarjeta.Focus();
            }
        }

       
    }
}
