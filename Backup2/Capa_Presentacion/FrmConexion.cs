using Capa_Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Capa_Presentacion
{
    public partial class FrmConexion : Form
    {
        string conexion = "";
        public FrmConexion()
        {
            InitializeComponent();
        }

        private void FrmConexion_Load(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            string [] datasources ;
            string [] basedatos ;
            string [] usuario ;
            string [] contraseña;
            
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement elementos in xmlDoc.DocumentElement)
            {
                if (elementos.Name.Equals("connectionStrings"))
                {
                    foreach (XmlNode nodo  in elementos.ChildNodes)
                    {
                        conexion = nodo.Attributes[1].Value;
                        
                        
                    }

                }

            }
            string[] valores = conexion.Split(';');
            datasources = valores[0].Split('=');
            basedatos = valores[1].Split('=');
            usuario = valores[2].Split('=');
            contraseña = valores[3].Split('=');
            txtServidor.Text = datasources[1].ToString().Trim();
            Txtbasedatos.Text = basedatos[1].ToString().Trim();
            txtUsuario.Text = usuario[1].ToString().Trim();
            txtContraseña.Text = contraseña[1].ToString().Trim();

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardarConexion_Click(object sender, EventArgs e)
        {
            
            try
            {
                conexion = @"Data Source=" + txtServidor.Text + ";Initial Catalog=" + Txtbasedatos.Text + ";user id =" + txtUsuario.Text + ";password =" + txtContraseña.Text;
                Conexion.addnewstring(conexion);
               // XmlDocument xmlDoc = new XmlDocument();

               // xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
               // foreach (XmlElement elementos in xmlDoc.DocumentElement)
               // {
               //     if (elementos.Name.Equals("connectionStrings"))
               //     {
               //         foreach (XmlNode nodo in elementos.ChildNodes)
               //         {
               //             nodo.Attributes[1].Value = conexion;


               //         }

               //     }

               // }
               // xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
               // ConfigurationManager.RefreshSection("connectionString");
               // ConfigurationManager.ConnectionStrings["string.name"].ConnectionString = conexion;
               //string c = ConfigurationManager.ConnectionStrings["string.name"].ConnectionString;
                UtilityFrm.mensajeConfirm("Se actualizo la conexion correctamente");
            }
            catch (Exception ex)
            {
                UtilityFrm.mensajeError(ex.Message);
                
            }

        }
    }
}
