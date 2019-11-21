using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Capa_Presentacion.Reportes;
using Capa_Presentacion;

using CrystalDecisions.CrystalReports.Engine;
namespace Capa_Presentacion
{
    public partial class FrmReporteEtiqueta : Form
    {
        ReportDocument reporte = new ReportDocument();
        
        string codigoBarra;
        
        public FrmReporteEtiqueta(string codigoBarra)
        {
            InitializeComponent();
            this.codigoBarra = codigoBarra;
           
        }

        private void FrmReporteEtiqueta_Load(object sender, EventArgs e)
        {
            //DataTable datos = new DataTable("CodigoDeBarra");
            //datos.Columns.Add("Nombre", typeof(int));
            //datos.Columns.Add("CodigoBarra", typeof(string));
            //datos.Rows.Add(codigoBarra);
             CrystalReport1 barra = new CrystalReport1();
            barra.SetParameterValue(0, codigoBarra);
            
            //reporte.Load("");
            //reporte.SetDataSource(datos);
            rvImprimirEtiqueta.ReportSource = barra;
           
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
