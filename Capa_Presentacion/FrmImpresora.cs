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


namespace Capa_Presentacion
{
    public partial class FrmImpresora : Form
    {
        public FrmImpresora()
        {
            InitializeComponent();
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            Negociocomprobantes objcomprobante = new Negociocomprobantes();
            string msg = objcomprobante.imprimirxz("X", NegocioConfigEmpresa.marcafiscal);
            if (msg != "ok")
            {
                UtilityFrm.mensajeError(msg);
            }
        }

        private void BtnZ_Click(object sender, EventArgs e)
        {
            Negociocomprobantes objcomprobante = new Negociocomprobantes();
            string msg = objcomprobante.imprimirxz("Z", NegocioConfigEmpresa.marcafiscal);
            if (msg != "ok")
            {
                UtilityFrm.mensajeError(msg);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            Negociocomprobantes objcomprobante = new Negociocomprobantes();
            DateTime desde1 = new DateTime();
            DateTime hasta1 = new DateTime();
            string desde = "";
            string hasta = "";
            browser.RootFolder = Environment.SpecialFolder.MyComputer;
            string tempPath = "";
            if (RbtnFecha.Checked == true)
            {
               desde1 = dtpFechaDesde.Value;
               hasta1 = dtbFechaHasta.Value;
               desde = desde1.ToString("ddMMyy");
               hasta = hasta1.ToString("ddMMyy");
                
            }
            else
            {
                desde = TxtDesde.Text;
                hasta = TxtHasta.Text;

                if (TxtDesde.Text == "" || TxtHasta.Text == "")
                {
                    UtilityFrm.mensajeError("Tiene algunos casilleros en blanco no puede continuar");
                    return;
                }
            }


            if (browser.ShowDialog() == DialogResult.OK)
            {
                string msg = "";
                tempPath = browser.SelectedPath;
                msg =   objcomprobante.Descargarperiodo(NegocioConfigEmpresa.marcafiscal, tempPath, desde,hasta) ;

                if (msg != "ok")
                {
                    UtilityFrm.mensajeError(msg);
                }
                else
                {
                    UtilityFrm.mensajeConfirm("Se a descargado correctamente");
                }
                //}

            }

            
           
        }

        private void RbtnFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtbFechaHasta.Enabled = RbtnFecha.Checked;
            dtpFechaDesde.Enabled = RbtnFecha.Checked;
        }

        private void RbtnZ_CheckedChanged(object sender, EventArgs e)
        {
            TxtDesde.Enabled = RbtnZ.Checked;
            TxtHasta.Enabled = RbtnZ.Checked;
        }

        private void FrmImpresora_Load(object sender, EventArgs e)
        {
            dtbFechaHasta.Enabled = RbtnFecha.Checked;
            dtpFechaDesde.Enabled = RbtnFecha.Checked;
            TxtDesde.Enabled = RbtnZ.Checked;
            TxtHasta.Enabled = RbtnZ.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Negociocomprobantes objcomprobante = new Negociocomprobantes();
            objcomprobante.Cancelardocumento();
        }

    }
}
