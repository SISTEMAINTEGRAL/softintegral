using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
using System.Data.SqlClient;

namespace Capa_negocio
{
    public class NegocioRemito
    {
        
        public static string ingresarremito(DataTable dt, int codsucursal, string fecha,
            int codcliente,int nroregistro, string transportista,bool entregado , string tipo, string serie)
        {
            //    List<DatosDetalleRemito> detalles = new List<DatosDetalleRemito>();


            //    foreach (DataRow row in dt.Rows)
            //    {
            //        //asigno los valores de los detalle de ventas a cada objeto detalle
            //        DatosDetalleRemito detalle = new DatosDetalleRemito();
            //        detalle.Codsucursal = 1;
            //        detalle.Cantidad = Convert.ToDecimal(row["cantidadparcial"].ToString());
            //        detalle.Idproducto = Convert.ToInt32(row["codigo"].ToString());
            //        detalle.Detalle = row["Detalle"].ToString();
            //        //agrego el item a la lista detalles
            //        detalles.Add(detalle);
            //    }

            //    DatosRemito objremito = new DatosRemito(codsucursal, fecha, codcliente, nroregistro, transportista, entregado, tipo,serie,ref con,ref trans);
            //    return objremito.insertarremito(objremito, detalles, true);
            string caracter = "";
            return caracter;  
        }

        public static DataTable Reporteremito(string varnroremito)
        {
            DatosRemito objremito = new DatosRemito(varnroremito);
            return objremito.reporterecibo(objremito);
        }

       
    }
}
