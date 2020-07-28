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
    public partial class FrmCodigoBarraExistente : Form
    {
        private string codigoDeBarra;
        private bool isCerro;

       
      
        public FrmCodigoBarraExistente()
        {
            InitializeComponent();
            isCerro = false;
        }
        public FrmCodigoBarraExistente(string codigo)
        {
            InitializeComponent();
            isCerro = false;
            txtCodigoBarra.Text = codigo;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            isCerro = true;
            this.Close();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int digControl=0;
            string codigoBarra=string.Empty;
            if (txtCodigoBarra.Text.Count() == 0 || txtCodigoBarra.Text.Count() < 13)
            {

               UtilityFrm.mensajeError("No existe ningún codigo de barra con 13 dígitos");
               errorIcono.SetError(txtCodigoBarra, "Ingrese un codigo de barra de 13 dígitos");
           }
           else if (txtCodigoBarra.Text.Count()==13)
           {
              digControl= NegocioArticulo.calcDigControl(txtCodigoBarra.Text.Trim());
               
               //comparo el digito de control con la funcion calcDigControl, con el dig 13 ingresado por el usuario
              if (digControl ==int.Parse( txtCodigoBarra.Text[12].ToString()))
              {

                  UtilityFrm.mensajeConfirm("Se cambió Codigo de Barra correctamente");
                  this.Close();
              }
              else {
                  if (MessageBox.Show("No es correcto el codigo de barra, Desea arreglarlo?", "Codigo de barra"
              , MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                  {
                      codigoBarra = txtCodigoBarra.Text;
                      codigoBarra= codigoBarra.Remove(12)+digControl;
                      txtCodigoBarra.Text = codigoBarra;
                      this.CodigoDeBarra = codigoBarra;
                      UtilityFrm.mensajeConfirm("Se cambió Codigo de Barra correctamente el codigo nuevo es: "+codigoBarra );
                      this.Close();
                      this.IsCerro = false;
                  }
              
              }
               
           }
        }

        private void txtCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityFrm.NumTeclado(e, txtCodigoBarra);
             
        }


       
        private void txtCodigoBarra_TextChanged(object sender, EventArgs e)
        {
            if(txtCodigoBarra.Text.Count()==13){
                btnVerificar.Focus();
            
            }
        }

        //Propiedades
        public string CodigoDeBarra
        {
            get { return codigoDeBarra; }
            set { codigoDeBarra = value; }
        }
        public bool IsCerro
        {
            get { return isCerro; }
            set { isCerro = value; }
        }

        private void FrmCodigoBarraExistente_Load(object sender, EventArgs e)
        {
            isCerro = true;
        }
    }
}
