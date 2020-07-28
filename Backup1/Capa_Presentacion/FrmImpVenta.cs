using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_negocio;
namespace Capa_Presentacion
{
    public partial class FrmImpVenta : Form
    {

        private DataTable dt;
        private Decimal totalAPagar;
        private int idCliente;
        public FrmImpVenta()
        {

            InitializeComponent();
           
        }
        public FrmImpVenta(Decimal totalAPagar)
        {

            InitializeComponent();
           this.totalAPagar=totalAPagar;
        }
        public FrmImpVenta( int idCliente)
        {

            InitializeComponent();
           
            this.idCliente = idCliente;
        }
        private void CRVVenta_Load(object sender, EventArgs e)
        {
            try
            {
                //SqlDataAdapter adaptador = new SqlDataAdapter() ;

                //dt = new DataTable();
          
                //dt.Columns.Add("nombre", typeof(String));
                //dt.Columns.Add("cantidad", typeof(Int32));
                //dt.Columns.Add("precio", typeof(decimal));
                
                //dt.Columns.Add("idventa", typeof(Int32));
                //dt.Columns.Add("idcliente", typeof(Int32));
                //dt.Columns.Add("tipo_comprobante", typeof(String));
                //dt.Columns.Add("serie", typeof(Int32));
                //dt.Columns.Add("correlativo", typeof(Int32));
                //dt.TableName = "venta";

                
                 //   dt.Rows.Add( 12,1,"ticket",1234,23);
                //devuelve la ultima venta realizada
                dt = NegocioVenta.NotaDeVenta();
               // String hola=dt.Columns[1].ToString();
               
                NotaDeVenta1.SetDataSource(dt);
                NotaDeVenta1.SetParameterValue("total",totalAPagar);
                    
            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("error "+ex.Message);
            }
        
        
            
        }

        private void NotaDeVenta1_InitReport(object sender, EventArgs e)
        {

        }

       
    }
}
