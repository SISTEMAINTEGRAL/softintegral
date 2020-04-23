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
        public Datodetalleordenpedido(int varorden)
        {
            this.norden = varorden;
        }
        public Datodetalleordenpedido()
        { }
        public string insertaromodificar(Datodetalleordenpedido Detalle_Pedido, ref SqlConnection sqlcon, ref SqlTransaction sqltra, string agregaromodificar = "agregar")
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
                SqlParameter parmodo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.NVarChar, "agregaromodificardetalle");
                sqlcmd.Parameters.Add(parmodo);

                SqlParameter paropcargaromodificar = ProcAlmacenado.asignarParametros("@opagregaromodificar", SqlDbType.NVarChar, agregaromodificar);
                sqlcmd.Parameters.Add(paropcargaromodificar);

                rpta = sqlcmd.ExecuteNonQuery() >= 1 ? "OK" : "NO se ingreso el registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;
        }
        public DataTable consultadetalla(Datodetalleordenpedido detalle)
        {
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            DataTable dtResult = new DataTable("ordendetalle");

            try
            {
                SqlParameter[] dbParams = new SqlParameter[]
                   {
                        ProcAlmacenado2.MakeParam ("@modo",SqlDbType.NVarChar,50,"consulta"),
                        ProcAlmacenado2.MakeParam ("@norden",SqlDbType.Int,0,detalle.norden)


                   };
                dtResult = ProcAlmacenado2.ExecuteDatatable("SP_ORDENPEDIDODETALLE", dbParams);
            }
            catch (Exception)
            {

                throw;

            }

            return dtResult;
        }

        public string eliminardetalle(Datodetalleordenpedido detalle)
        {
            //modo 3 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            string respuesta = "";
            try
            {
                cn.Open();
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_ORDENPEDIDODETALLE");
                //MODO 3 ELIMINAR
                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.NVarChar, "eliminardetalle");
                comando.Parameters.Add(parModo);

                SqlParameter parnorden = ProcAlmacenado.asignarParametros("@norden", SqlDbType.Int, detalle.norden);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parnorden);


                if (comando.ExecuteNonQuery() == 1)
                {
                    respuesta = "ok";
                }
                else
                {
                    respuesta = "error: no se ha podido eliminar";
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                respuesta = "error conexion: " + ex.Message;
            }
            return respuesta;
            string lo = "";
            return lo;
        }
    }
}
