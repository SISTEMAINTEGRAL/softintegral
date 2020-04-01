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
  public  class DatosOrdenpedido
    {
        private int norden;
        private DateTime fecha;
        private int codcliente;
        private int idusuario;
        private string tipoorden;
        private string estado;
        private string observacion;
        private bool cambiarstock;

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

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public int Codcliente
        {
            get
            {
                return codcliente;
            }

            set
            {
                codcliente = value;
            }
        }

        public int Idusuario
        {
            get
            {
                return idusuario;
            }

            set
            {
                idusuario = value;
            }
        }

        public string Tipoorden
        {
            get
            {
                return tipoorden;
            }

            set
            {
                tipoorden = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public string Observacion
        {
            get
            {
                return observacion;
            }

            set
            {
                observacion = value;
            }
        }
        public DatosOrdenpedido(string varestado, int varnroorden)
        {
            estado = varestado;
            norden = varnroorden;
        }
        public DatosOrdenpedido( DateTime varfecha, int varcodcliente, int varidusuario, string vartipoorden, string varestado, string varobservacion)
        {
            fecha = varfecha;
            codcliente = varcodcliente;
            idusuario = varidusuario;
            tipoorden = vartipoorden;
            estado = varestado;
            observacion = varobservacion;
        }
        public string Insertar(DatosOrdenpedido Ordenpedido, List<Datodetalleordenpedido> Detalle)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            //DatosOrdenpedido objventa = new global::DatosOrdenpedido ();
            
            try
            {
                sqlcon.ConnectionString = Conexion.conexion;
                sqlcon.Open();

                SqlTransaction sqltra = sqlcon.BeginTransaction();


                SqlCommand sqlcmd = ProcAlmacenado.CrearProc(sqlcon, "SP_ORDENPEDIDO", sqltra);

                SqlParameter parcodsucursal = ProcAlmacenado.asignarParametros("@codsucursal", SqlDbType.Int,1);
                sqlcmd.Parameters.Add(parcodsucursal);

                SqlParameter parorden = ProcAlmacenado.asignarParametros("@nroorden", SqlDbType.Int);
                sqlcmd.Parameters.Add(parorden);

                SqlParameter parfecha = ProcAlmacenado.asignarParametros("@fecha", SqlDbType.DateTime, Ordenpedido.fecha);
                sqlcmd.Parameters.Add(parfecha);

                SqlParameter parcodcliente = ProcAlmacenado.asignarParametros("@codcliente", SqlDbType.Int, Ordenpedido.codcliente);
                sqlcmd.Parameters.Add(parcodcliente);

                SqlParameter paridusuario = ProcAlmacenado.asignarParametros("@idusuario", SqlDbType.Decimal, Ordenpedido.idusuario);
                sqlcmd.Parameters.Add(paridusuario);

                SqlParameter partipoorden = ProcAlmacenado.asignarParametros("@tipoorden", SqlDbType.NVarChar, Ordenpedido.tipoorden);
                sqlcmd.Parameters.Add(partipoorden);

                SqlParameter parestado = ProcAlmacenado.asignarParametros("@estado", SqlDbType.NVarChar, Ordenpedido.estado);
                sqlcmd.Parameters.Add(parestado);

                SqlParameter parobs = ProcAlmacenado.asignarParametros("@observacion", SqlDbType.NVarChar, Ordenpedido.observacion);
                sqlcmd.Parameters.Add(parobs);

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.NVarChar, "agregarorden");
                sqlcmd.Parameters.Add(parModo);

                
                rpta = sqlcmd.ExecuteNonQuery() >= 1 ? "OK" : "No se ingreso el registro";

                if (rpta.Equals("OK"))
                {
                    Ordenpedido.norden = Convert.ToInt32(sqlcmd.Parameters["@nroorden"].Value);


                    foreach (Datodetalleordenpedido det in Detalle)
                    {
                        det.Norden = Ordenpedido.norden;
                        rpta = det.Insertar(det, ref sqlcon, ref sqltra);
                        if (!rpta.Equals("OK"))
                        {
                            break;
                        }
                        

                    }
                }

                if (rpta.Equals("OK"))
                {
                    sqltra.Commit();
                }
                else
                {
                    sqltra.Rollback();
                }

            }
            catch (Exception e)
            {
                rpta = e.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return rpta;
        }

        public string Modificar(DatosOrdenpedido Ordenpedido, List<Datodetalleordenpedido> Detalle)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            Dventa objventa = new global::Dventa();

            try
            {
                sqlcon.ConnectionString = Conexion.conexion;
                sqlcon.Open();

                SqlTransaction sqltra = sqlcon.BeginTransaction();


                SqlCommand sqlcmd = ProcAlmacenado.CrearProc(sqlcon, "SP_ORDENPEDIDO", sqltra);

                SqlParameter parcodsucursal = ProcAlmacenado.asignarParametros("@codsucursal", SqlDbType.Int, 1);
                sqlcmd.Parameters.Add(parcodsucursal);

                SqlParameter parorden = ProcAlmacenado.asignarParametros("@nroorden", SqlDbType.Int, Ordenpedido.norden);
                sqlcmd.Parameters.Add(parorden);
                      

                SqlParameter parestado = ProcAlmacenado.asignarParametros("@estado", SqlDbType.NVarChar, Ordenpedido.estado);
                sqlcmd.Parameters.Add(parestado);
                               

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.NVarChar, "cambiarestado");
                sqlcmd.Parameters.Add(parModo);


                rpta = sqlcmd.ExecuteNonQuery() >= 1 ? "OK" : "No se ingreso el registro";

                if (rpta.Equals("OK"))
                {
                    Ordenpedido.norden = Convert.ToInt32(sqlcmd.Parameters["@nroorden"].Value);


                    foreach (Datodetalleordenpedido det in Detalle)
                    {
                        det.Norden = Ordenpedido.norden;
                        rpta = det.Insertar(det, ref sqlcon, ref sqltra);
                        if (!rpta.Equals("OK"))
                        {
                            break;
                        }
                        else
                        {
                            //actualizamos el stock
                            if (det.Idproducto != 0) { rpta = objventa.DisminuirStock(det.Idproducto, det.Cantidadactual); }
                            if (!rpta.Equals("OK"))
                            {
                                break;

                            }
                        }

                    }
                }

                if (rpta.Equals("OK"))
                {
                    sqltra.Commit();
                }
                else
                {
                    sqltra.Rollback();
                }

            }
            catch (Exception e)
            {
                rpta = e.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return rpta;
        }
    }
}
