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
using System.Data.SqlClient;

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
            cbMarca.Text = NegocioConfigEmpresa.marcafiscal;
            txtPuerto.Text = NegocioConfigEmpresa.puntoventa;
            txtPV.Text = NegocioConfigEmpresa.puntoventa;
            rellenarcombobox(CBImpresoraFacElectronica,CBFacturaElectronica, 1);
            rellenarcombobox(CBImpNotaVenta,CBNotaVenta, 2);
            rellenarcombobox(CBImpRemito,CBRemito,3);

           

        }
        

        private void rellenarcombobox(ComboBox micombo, ComboBox micomboformato, int idareaimpresion)
        {
            //1 FACTURA ELECTRONICA 2 IMPRESORA NOTA DE VENTA 3 IMPRESORA REMITO
            SqlDataReader midatareader;
            foreach (string Impresora in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                micombo.Items.Add(Impresora);
            }

            midatareader = NegocioConfigEmpresa.mostrarformatoimpresora(idareaimpresion);

            if (midatareader.Read() == true)
            {
               micombo.Text = Convert.ToString(midatareader["impresora"]);
               micomboformato.Text =  Convert.ToString(midatareader["formato"]);
            }
            else
            {
                micombo.Text = "Predeterminado";
                micomboformato.Text = "A4";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Negociocomprobantes objcomprobante = new Negociocomprobantes();
            objcomprobante.Cancelardocumento();
        }

        private void txtPuerto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPuerto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            UtilityFrm.NumTeclado(e, txtPuerto);
        }

        private void BtnGuardarC_Click(object sender, EventArgs e)
        {
           string msg = "";
           msg = NegocioConfigEmpresa.actualizarequipofiscal(Convert.ToInt32( txtPuerto.Text == "" ? "0" : txtPuerto.Text),cbMarca.Text,txtPV.Text == "" ? "0": txtPV.Text);
            
            if (msg == "ok")
            {
                UtilityFrm.notificacionpopup("Configuracion", "La nueva configuracion se guardo correctamente");
            }
            else
            {
                UtilityFrm.mensajeError(msg);
            }
        }

        private void txtPV_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityFrm.NumTeclado(e, txtPV);
        }

        private void BtnGuardarFormato_Click(object sender, EventArgs e)
        {
            try
            {

                NegocioConfigEmpresa.actualizarformatoimpresion(CBImpresoraFacElectronica.Text, CBFacturaElectronica.Text, 1);
                NegocioConfigEmpresa.actualizarformatoimpresion(CBImpNotaVenta.Text, CBNotaVenta.Text, 2);
                NegocioConfigEmpresa.actualizarformatoimpresion(CBImpRemito.Text, CBRemito.Text, 3);
                UtilityFrm.notificacionpopup("FORMATO IMPRESION", "La configuracion de impresion se guardo correctamente");

            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError(ex.ToString());
            }
            
        }
    }
}
