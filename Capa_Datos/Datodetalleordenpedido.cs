using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Datos;

namespace Capa_Datos
{
  public  class Datodetalleordenpedido
    {
        private int norden;
        private int idproducto;
        private string detalle;
        private decimal cantidadtotal;
        private decimal cantidadparcial;
        private decimal cantidadactual;
        private string modo;

        public int Norden
        {
            get
            {
                return norden;
            }

            set
            {
                norden = value;
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

        public decimal Cantidadtotal
        {
            get
            {
                return cantidadtotal;
            }

            set
            {
                cantidadtotal = value;
            }
        }

        public decimal Cantidadparcial
        {
            get
            {
                return cantidadparcial;
            }

            set
            {
                cantidadparcial = value;
            }
        }

        public string Modo
        {
            get
            {
                return modo;
            }

            set
            {
                modo = value;
            }
        }

        public decimal Cantidadactual
        {
            get
            {
                return cantidadactual;
            }

            set
            {
                cantidadactual = value;
            }
        }

        public string Insertar(Datodetalleordenpedido Detalle_Pedido, ref SqlConnection sqlcon, ref SqlTransaction sqltra)
        {
            string rpta = "";

            try
            {
                //asigno el procedimiento almacenado y la transaccion al sqlcmd
                SqlCommand sqlcmd = ProcAlmacenado.CrearProc(sqlcon, "SP_ORDENPEDIDODETALLE", sqltra);

                SqlParameter parnorden = ProcAlmacenado.asignarParametros("@norden", SqlDbType.Int, Detalle_Pedido.norden);
                sqlcmd.Parameters.Add(parnorden);

                SqlParameter paridprocucto = ProcAlmacenado.asignarParametros("@idproducto", SqlDbType.Int, Detalle_Pedido.idproducto);
                sqlcmd.Parameters.Add(paridprocucto);

                SqlParameter pardetalle = ProcAlmacenado.asignarParametros("@detalle", SqlDbType.NVarChar, Detalle_Pedido.detalle);
                sqlcmd.Parameters.Add(pardetalle);

                SqlParameter parcantotal = ProcAlmacenado.asignarParametros("@cantidadtotal", SqlDbType.Money, Detalle_Pedido.cantidadtotal);
                sqlcmd.Parameters.Add(parcantotal);

                SqlParameter parcanparcial = ProcAlmacenado.asignarParametros("@cantidadparcial", SqlDbType.Money, Detalle_Pedido.cantidadparcial);
                sqlcmd.Parameters.Add(parcanparcial);
                //ver
                SqlParameter parmodo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.NVarChar, "agregardetalle");
                sqlcmd.Parameters.Add(parmodo);

                
                rpta = sqlcmd.ExecuteNonQuery() >= 1 ? "OK" : "NO se ingreso el registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;
        }
    }
}
