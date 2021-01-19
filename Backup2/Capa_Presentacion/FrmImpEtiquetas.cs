using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
namespace Capa_Presentacion
{
    public partial class FrmImpEtiquetas : Form
    {
        string nombreArticulo;
        string codigoBarra;
        int codigo;
        int cantidadDeEtiquetas;
        DataTable dt;
        
        ReportDocument reporte = new ReportDocument();
        public FrmImpEtiquetas(string nombreArticulo,string codigoBarra,int cantidadDeEtiquetas, int codigo)
        {
            InitializeComponent();
            this.nombreArticulo = nombreArticulo;
            this.codigoBarra = codigoBarra;
            this.cantidadDeEtiquetas = cantidadDeEtiquetas;
            this.codigo = codigo;
        }

        private void FrmEtiquetas_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("nombreArt", typeof(string));
            dt.Columns.Add("codigoBarra", typeof(string));
            dt.Columns.Add("CodigoArt", typeof(int));
            dt.TableName = "CodigoDeBarra";
            for (int i = 0; i < cantidadDeEtiquetas; i++)
            {
                dt.Rows.Add(nombreArticulo, codigoBarra,codigo);
            }

            //reporte.Load(@"C:\Users\LEOX\Documents\Visual Studio 2012\Projects\Sistema de ventas\Capa_Presentacion\Reportes\ReporteEtiqueta.rpt");
            //reporte.Load(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            ReporteEtiqueta1.SetDataSource(dt);
            //reporte.SetDataSource(dt);
            vistaReporte.ReportSource=ReporteEtiqueta1;

        }

        private void vistaReporte_Load(object sender, EventArgs e)
        {

        }
    }
}
