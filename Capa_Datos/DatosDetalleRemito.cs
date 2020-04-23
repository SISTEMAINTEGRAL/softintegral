using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
   public class DatosDetalleRemito
    {
        private int codsucursal;
        private string nremito;
        private int idproducto;
        private string detalle;
        private decimal  cantidad;

        public int Codsucursal
        {
            get
            {
                return codsucursal;
            }

            set
            {
                codsucursal = value;
            }
        }

        public string Nremito
        {
            get
            {
                return nremito;
            }

            set
            {
                nremito = value;
            }
        }

        public int Idproducto
        {
            get
            {
                return idproducto;
            }

            set
            {
                idproducto = value;
            }
        }

        public string Detalle
        {
            get
            {
                return detalle;
            }

            set
            {
                detalle = value;
            }
        }

        public decimal Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public string insertardetalleremito(DatosDetalleRemito Detalle_Remito, ref SqlConnection sqlcon, ref SqlTransaction sqltra, string varnremito)
        {
            string rpta = "";

            try
            {
                //asigno el procedimiento almacenado y la transaccion al sqlcmd
                SqlCommand sqlcmd = ProcAlmacenado.CrearProc(sqlcon, "SP_REMITO", sqltra);

                

                SqlParameter parcodsucursal = ProcAlmacenado.asignarParametros("@codsucursal", SqlDbType.Int, Detalle_Remito.codsucursal);
                sqlcmd.Parameters.Add(parcodsucursal);

                SqlParameter parremito = ProcAlmacenado.asignarParametros("@nremito", SqlDbType.NVarChar, varnremito);
                sqlcmd.Parameters.Add(parremito);

                SqlParameter paridproducto = ProcAlmacenado.asignarParametros("@idproducto", SqlDbType.Int, Detalle_Remito.idproducto);
                sqlcmd.Parameters.Add(paridproducto);

                SqlParameter pardetalle = ProcAlmacenado.asignarParametros("@detalle", SqlDbType.NVarChar, Detalle_Remito.detalle);
                sqlcmd.Parameters.Add(pardetalle);

                SqlParameter parcantidad = ProcAlmacenado.asignarParametros("@cantidad", SqlDbType.Int, Detalle_Remito.cantidad);
                sqlcmd.Parameters.Add(parcantidad);

                SqlParameter parmodo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.NVarChar, "agregardetalleremito");
                sqlcmd.Parameters.Add(parmodo);
                

                rpta = sqlcmd.ExecuteNonQuery() == 1 ? "OK" : "NO se ingreso el registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;
        }
    }
}
