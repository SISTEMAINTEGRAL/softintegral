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
    public partial class Frmimpnotaventa : Form
    {
        private string tipoimp = "vista";//tipo vista o impresion directa

        public string Tipoimp
        {
            get { return tipoimp; }
            set { tipoimp = value; }
        }

        private int codventa;

        public int Codventa
        {
            get { return codventa; }
            set { codventa = value; }
        }

        public Frmimpnotaventa()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Frmimpnotaventa_Load(object sender, EventArgs e)
        {
            try
            {
                VentasReducida1.SetParameterValue("@idventa", codventa);

                if ("directo" == NegocioConfigEmpresa.confsistema("modoimpventa").ToString ())
                {

                    VentasReducida1.PrintOptions.PrinterName = NegocioConfigEmpresa.impticket != "" ? NegocioConfigEmpresa.impticket : UtilityFrm.GetImpresoraDefecto();
                    VentasReducida1.PrintToPrinter(1, false, 0, 0);
                    this.Close();
                }
                else if (NegocioConfigEmpresa.confsistema("modoimpventa") == "vista")
                {
                    crystalReportViewer1.ReportSource = VentasReducida1;
                }
            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError(ex.Message);
            }
        }
    }
}
