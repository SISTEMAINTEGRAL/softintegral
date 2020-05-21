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
  public class NegocioRetirodeMercaderia
    {
        public static string insertar(DateTime fecha,int codcliente,int idusuario,string tipoorden, string estado, string observacion, DataTable midata, int codbeneficiado, int tiporetiro , int codventa = 0)
        {
            List<DatodetalleRetirodeMercaderia> detalles = new List<DatodetalleRetirodeMercaderia>();


            foreach (DataRow row in midata.Rows)
            {
                //asigno los valores de los detalle de ventas a cada objeto detalle
                DatodetalleRetirodeMercaderia detalle = new DatodetalleRetirodeMercaderia();
                detalle.Idproducto = Convert.ToInt32(row["codigo"].ToString());
                detalle.Cantidadparcial  = Convert.ToDecimal(row["cantidadparcial"].ToString());
                detalle.Cantidadtotal  = Convert.ToDecimal(row["cantidadtotal"].ToString());
                detalle.Detalle = row["detalle"].ToString();
                
                
                //agrego el item a la lista detalles
                detalles.Add(detalle);
            }

            DatosRetirodeMercaderia miorden = new DatosRetirodeMercaderia(fecha,codcliente,idusuario,tipoorden,estado,observacion, codbeneficiado,tiporetiro,codventa);
            miorden.Insertarymodificar(miorden, detalles);
            string msg = "";
           return msg;
        }

        public static string modificarcantidad(int nroorden, string estado, DataTable midata,int codcliente, string tipo, ref string nroremito, int codempresa = 1)
        {
            List<DatodetalleRetirodeMercaderia> detalles = new List<DatodetalleRetirodeMercaderia>();


            foreach (DataRow row in midata.Rows)
            {
                //asigno los valores de los detalle de ventas a cada objeto detalle
                DatodetalleRetirodeMercaderia detalle = new DatodetalleRetirodeMercaderia();
                detalle.Idproducto = Convert.ToInt32(row["codigo"].ToString());
                detalle.Cantidadparcial = Convert.ToDecimal(row["cantidadparcial"].ToString());
                detalle.Cantidadtotal = Convert.ToDecimal(row["cantidadtotal"].ToString());
                detalle.Cantidadactual = Convert.ToDecimal(row["cantidadactual"].ToString());
                detalle.Detalle = row["detalle"].ToString();
                detalle.Norden = nroorden;

                //agrego el item a la lista detalles
                detalles.Add(detalle);
            }

            DatosRetirodeMercaderia miorden = new DatosRetirodeMercaderia(estado,nroorden,codcliente,tipo,codempresa) ;
            
            string msg = miorden.Insertarymodificar(miorden, detalles, "modificarestado", false); ;
            nroremito = miorden.Nroremito;
            return msg;

        }

        public static DataTable buscarconcatenacion(int varcodcliente, string varestado,string  vartipoorden,string varfechaini,string varfechafin, bool varporcliente, bool varporestado, bool varportipo, bool varporfecha, int vartiporetiro, bool varpororden = false, int varnorden = 0, bool varporventa = false, int varcodventa =0)
        {
            DatosRetirodeMercaderia Dorden = new DatosRetirodeMercaderia(varcodcliente, varestado, vartipoorden, varfechaini, varfechafin, varporcliente, varporestado, varportipo, varporfecha, vartiporetiro,varpororden,varnorden,varporventa,varcodventa);
            return Dorden.Busquedaconcatenada(Dorden);
                 

        }

        public static DataTable buscarlistadodetalle(int norden)
        {
            DatodetalleRetirodeMercaderia  objorden = new DatodetalleRetirodeMercaderia(norden);
            return objorden.consultadetalla(objorden);
        }

        public static string eliminardetalle(int norden)
        {
            DatodetalleRetirodeMercaderia objorden = new DatodetalleRetirodeMercaderia(norden);
            return objorden.eliminardetalle(objorden);
        }

        public static DataTable buscartiporetiro()
        {
            DatosRetirodeMercaderia objretiro = new DatosRetirodeMercaderia();
            return objretiro.Busquedatipo();
        }

        
    }
}
