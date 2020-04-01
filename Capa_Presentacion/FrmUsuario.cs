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
using Capa_Presentacion.Formreportes;

namespace Capa_Presentacion
{
    public partial class FrmUsuario : Form
    {
        private string ABM;
        private int idusuario;
        public FrmUsuario()
        {
            InitializeComponent();
        }

        
        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            activar(false, true);
            UtilityFrm.limpiarTextbox(txtNombre,txtContraseña,txtConfirmar,txtProducto);
            ABM = "AGREGAR";
           // txtProducto.ReadOnly = false;
            //txtContraseña.ReadOnly = false;
            //txtConfirmar.ReadOnly = false;
            //txtNombre.ReadOnly = false;
           // txtProducto.Enabled = true;
           // txtContraseña.Enabled = true;
           // txtConfirmar.Enabled = true;
            //cbxRoles.Enabled=true;
            //btnGuardar.Enabled = true;
            //btnCancelar.Enabled = true;
            //btnAgregar.Enabled = false;
            //btnBuscar.Enabled=false;
            //btnListar.Enabled=false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            activar(true, false);

            //txtProducto.Enabled = false;
            //txtContraseña.Enabled = false;
            //txtConfirmar.Enabled = false;
            //cbxRoles.Enabled = false;
            //txtConfirmar.Enabled = false;

            //btnGuardar.Enabled = false;
            //btnCancelar.Enabled = false;
            //btnAgregar.Enabled = true;
            //btnBuscar.Enabled = true;
            //btnListar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            NegocioUsuario objusuario = new NegocioUsuario();
            if (ABM == "AGREGAR")
            {
                if (MessageBox.Show("Desea Guardar?", "Guardar"
                   , MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    
                    
                    if (UtilityFrm.validarnull(txtProducto, txtNombre, txtContraseña, txtConfirmar) == true)
                    {
                        if (txtContraseña.Text  == txtConfirmar.Text)
                        {

                            objusuario.agregarusuario(txtProducto.Text, txtNombre.Text, txtContraseña.Text, UtilityFrm.turnosegunhora (), true, checkBox1.Checked, 0);
                        }
                        else
                        {
                            
                            UtilityFrm.mensajeError("La clave no coincide con la confirmación");
                        }

                    }
                    else
                    {
                        UtilityFrm.mensajeError("Algunos valores estan en blanco");
                        
                    }
                    UtilityFrm.mensajeConfirm("Se agrego el usuario correctamente");
                    UtilityFrm.limpiarTextbox(txtProducto,txtNombre,txtContraseña,txtConfirmar); 
                    activar(true, false);
                }
            }

            if (ABM == "ACTUALIZAR")
            {
                

                objusuario.actualizarusuario(txtProducto.Text, txtNombre.Text, txtConfirmar.Text, UtilityFrm.turnosegunhora() , true, checkBox1.Checked, this.idusuario);
                activar(true, false);
            }
           
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            activar(false, true);
            ABM = "ACTUALIZAR";

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmUsuariolista objlista = new FrmUsuariolista();
            objlista.ShowDialog();
            this.idusuario = objlista.Idusuario;
            txtProducto.Text = objlista.Usuario;
            txtNombre.Text = objlista.Nombreusuario;
            txtContraseña.Text = objlista.Clave;
            txtConfirmar.Text = objlista.Clave;
            checkBox1.Checked = objlista.Sa;
            checkBox1.Checked = false;
            if (objlista.Sa == true)
            {
                checkBox1.Checked = true;
            }

        }

        private void activar(bool objeto1,bool objeto2)
        {
            txtProducto.ReadOnly = objeto1;
            txtContraseña.ReadOnly = objeto1;
            txtConfirmar.ReadOnly = objeto1;
            txtNombre.ReadOnly = objeto1;
            btnAgregar.Enabled = objeto1;
            btnBuscar.Enabled = objeto1;
            btnListar.Enabled = objeto1;
            
            cbxRoles.Enabled = objeto2;
            btnGuardar.Enabled = objeto2;
            btnCancelar.Enabled = objeto2;
          
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FrmOrdenPedido pedido = new FrmOrdenPedido();
            pedido.Show();
            //NegocioFElectronica miclase = new Capa_negocio.NegocioFElectronica();
            // miclase.comprobante_electronico(11, 31472915);
            //Application.StartupPath + @"\" + "Certificado"  + @"\" + "certificado.pfx"

            // Frmserviciotecnico  objmasivo = new Frmserviciotecnico();
            //objmasivo.ShowDialog();
            // string algo = UtilityFrm.GetImpresoraDefecto();
        }
    }
}
