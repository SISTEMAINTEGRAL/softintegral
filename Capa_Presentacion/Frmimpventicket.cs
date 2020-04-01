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
using  CrystalDecisions.CrystalReports;
using  CrystalDecisions.CrystalReports.Engine;
using  CrystalDecisions.ReportSource;
using  CrystalDecisions.Shared;
using CrystalDecisions.Windows;
using System.Drawing.Printing;
using System.Data.Odbc;
using System.Configuration;

namespace Capa_Presentacion
{
    public partial class Frmimpventicket : Form
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

        public object VentasTicket1 { get; private set; }

        public Frmimpventicket()
        {
            InitializeComponent();
        }

        private void Frmimpventicket_Load(object sender, EventArgs e)
        {
             
          //  ReportDocument reportprint = new ReportDocument();
            //PrinterSettings ps = new PrinterSettings ();
            //ps.PrinterName = "Generic / Text Only (Copiar 2)";
            //Boolean impresoravalida = ps.IsValid;
            //PageSettings pg = new PageSettings ();
           // ps.Copies = 1;
          //  VentasTicket1.Load (Application.StartupPath.Replace("D:\\PROYECTO SOFTINTEGRAL\\Sistema de ventas (Ultimo)\\Sistema de ventas\\Capa_Presentacion\\Reportes","VentasTicket.rpt"));
             
            // reportprint.SetDataSource ( VentasTicket1);
            //reportprint.PrintToPrinter(ps, pg, false);
            
            try
            {
               // VentasTicket1.SetParameterValue("@idventa", codventa);
                
                if ("directo" == NegocioConfigEmpresa.confsistema("modoimpventa"))
                {
                  //  PrintDocument imprimirdirecto = new PrintDocument();
                  //  VentasTicket1.PrintOptions.PrinterName = NegocioConfigEmpresa.impticket != "" ? NegocioConfigEmpresa.impticket : UtilityFrm.GetImpresoraDefecto();
                    //VentasTicket1.PrintToPrinter(1, false, 0, 0);
                    this.Close();
                }
                else if (NegocioConfigEmpresa.confsistema("modoimpventa") == "vista")
                {
                   // crystalReportViewer1.ReportSource = VentasTicket1;
                }
            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError(ex.Message);
            }
           
            
            

      
}

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
        //iConnectionInfo.Type = ConnectionInfoType.SQL;
            

        //ireport.Load("H:\jalcalde\informe1.rpt")
        

         //Me.CrystalReportViewer1.ReportSource = ireport

            

         



        }
    }

