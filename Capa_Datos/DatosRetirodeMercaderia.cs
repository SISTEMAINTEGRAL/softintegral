﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Datos;

namespace Capa_Datos
{
  public  class DatosRetirodeMercaderia
    {
        private int norden;
        private DateTime fecha;
        private int codcliente;
        private int idusuario;
        private string tipoorden;
        private string estado;
        private string observacion;
        private bool cambiarstock;
        private int codbeneficiado;
        private int codempresa;

        private bool porcliente;
        private bool porestado;
        private bool portipo;
        private bool porfecha;
        private bool pornorden;
        private bool porventa;
        private string fechaini;
        private string fechafin;
        private string nroremito;
        private int codventa;
        private int tiporetiro;

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

        public bool Porcliente
        {
            get
            {
                return porcliente;
            }

            set
            {
                porcliente = value;
            }
        }

        public bool Porestado
        {
            get
            {
                return porestado;
            }

            set
            {
                porestado = value;
            }
        }

        public bool Portipo
        {
            get
            {
                return portipo;
            }

            set
            {
                portipo = value;
            }
        }

        public bool Porfecha
        {
            get
            {
                return porfecha;
            }

            set
            {
                porfecha = value;
            }
        }

        public string Fechaini
        {
            get
            {
                return fechaini;
            }

            set
            {
                fechaini = value;
            }
        }

        public string Fechafin
        {
            get
            {
                return fechafin;
            }

            set
            {
                fechafin = value;
            }
        }

        public int Codbeneficiado
        {
            get
            {
                return codbeneficiado;
            }

            set
            {
                codbeneficiado = value;
            }
        }

        public string Nroremito
        {
            get
            {
                return nroremito;
            }

            set
            {
                nroremito = value;
            }
        }

        public int Codventa
        {
            get
            {
                return codventa;
            }

            set
            {
                codventa = value;
            }
        }

        public int Tiporetiro
        {
            get
            {
                return tiporetiro;
            }

            set
            {
                tiporetiro = value;
            }
        }

        public DatosRetirodeMercaderia()
        {

        }
        public DatosRetirodeMercaderia(string varestado, int varnroorden, int varcodcliente, string vartipo, int varcodempresa )
        {
            estado = varestado;
            norden = varnroorden;
            codcliente = varcodcliente;
            tipoorden = vartipo;
            codempresa = varcodempresa;
        }
        public DatosRetirodeMercaderia( DateTime varfecha, int varcodcliente, int varidusuario, string vartipoorden, string varestado, string varobservacion, int varcodbeneficiado, int vartiporetiro, int varcodventa)
        {
            fecha = varfecha;
            codcliente = varcodcliente;
            idusuario = varidusuario;
            tipoorden = vartipoorden;
            estado = varestado;
            observacion = varobservacion;
            codbeneficiado = varcodbeneficiado;
            codventa = varcodventa;
            tiporetiro = vartiporetiro;

        }
        public DatosRetirodeMercaderia(int varcodcliente, string varestado, string vartipoorden, string varfechaini, string varfechafin,
                                bool varporcliente, bool varporestado, bool varportipo, bool varporfecha, int vartiporetiro, bool varpororden, int varnorden, bool varporventa, int varcodventa)
        {
            this.codcliente = varcodcliente;
            this.estado = varestado;
            this.tipoorden = vartipoorden;
            this.fechaini = varfechaini;
            this.fechafin = varfechafin;
            this.porcliente = varporcliente;
            this.porestado = varporestado;
            this.portipo = varportipo;
            this.porfecha = varporfecha;
            this.tiporetiro = vartiporetiro;
            this.norden = varnorden;
            this.pornorden = varpororden;
            this.porventa = varporventa;
            this.codventa = varcodventa;

        }
        public string Insertarymodificar(DatosRetirodeMercaderia Ordenpedido, List<DatodetalleRetirodeMercaderia> Detalle, string agregaromodificar = "agregarorden", bool solomodificarestado = true)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            //DatosOrdenpedido objventa = new global::DatosOrdenpedido ();
            
            try
            {
                sqlcon.ConnectionString = Conexion.conexion;
                sqlcon.Open();

                SqlTransaction sqltra = sqlcon.BeginTransaction();


                SqlCommand sqlcmd = ProcAlmacenado.CrearProc(sqlcon, "SP_RETIRODEMERCADERIA", sqltra);

                SqlParameter parcodsucursal = ProcAlmacenado.asignarParametros("@codsucursal", SqlDbType.Int,1);
                sqlcmd.Parameters.Add(parcodsucursal);

               
                if (agregaromodificar == "agregarorden")
                {
                    SqlParameter parorden = ProcAlmacenado.asignarParametros("@nroorden", SqlDbType.Int);
                    sqlcmd.Parameters.Add(parorden);

                    SqlParameter parfecha = ProcAlmacenado.asignarParametros("@fecha", SqlDbType.DateTime, Ordenpedido.fecha);
                    sqlcmd.Parameters.Add(parfecha);
                }
                if (agregaromodificar == "modificarestado")
                {
                    SqlParameter parfecha = ProcAlmacenado.asignarParametros("@nroorden", SqlDbType.Int, Ordenpedido.norden);
                    sqlcmd.Parameters.Add(parfecha);
                } 
     
                

                SqlParameter parcodcliente = ProcAlmacenado.asignarParametros("@codcliente", SqlDbType.Int, Ordenpedido.codcliente);
                sqlcmd.Parameters.Add(parcodcliente);

                SqlParameter parcodbeneficiario = ProcAlmacenado.asignarParametros("@codbeneficiario", SqlDbType.Int, Ordenpedido.codbeneficiado);
                sqlcmd.Parameters.Add(parcodbeneficiario);
                

                SqlParameter paridusuario = ProcAlmacenado.asignarParametros("@idusuario", SqlDbType.Decimal, Ordenpedido.idusuario);
                sqlcmd.Parameters.Add(paridusuario);

                SqlParameter partipoorden = ProcAlmacenado.asignarParametros("@tipoorden", SqlDbType.NVarChar, Ordenpedido.tipoorden);
                sqlcmd.Parameters.Add(partipoorden);

                SqlParameter parestado = ProcAlmacenado.asignarParametros("@estado", SqlDbType.NVarChar, Ordenpedido.estado);
                sqlcmd.Parameters.Add(parestado);

                SqlParameter parobs = ProcAlmacenado.asignarParametros("@observacion", SqlDbType.NVarChar, Ordenpedido.observacion);
                sqlcmd.Parameters.Add(parobs);

                SqlParameter parcodventa = ProcAlmacenado.asignarParametros("@codventa", SqlDbType.Int, Ordenpedido.codventa);
                sqlcmd.Parameters.Add(parcodventa);

                SqlParameter partiporetiro = ProcAlmacenado.asignarParametros("@TipoRetiro", SqlDbType.Int , Ordenpedido.tiporetiro);
                sqlcmd.Parameters.Add(partiporetiro);

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.NVarChar, agregaromodificar);
                sqlcmd.Parameters.Add(parModo);
                
                

                rpta = sqlcmd.ExecuteNonQuery() >= 1 ? "OK" : "No se ingreso el registro";
                string mododetalleorden = "";
                if (agregaromodificar == "modificarestado")
                {
                    //elimina el detalle para volverlo a cargar
                    mododetalleorden = "eliminar";

                }


                    if ((rpta.Equals("OK")) && (solomodificarestado == false || agregaromodificar == "agregarorden"))
                {
                    Ordenpedido.norden = Convert.ToInt32(sqlcmd.Parameters["@nroorden"].Value);

                    List<DatosDetalleRemito> Detalleremito = new List<DatosDetalleRemito>();
                    foreach (DatodetalleRetirodeMercaderia det in Detalle)
                    {
                        
                        det.Norden = Ordenpedido.norden;
                        rpta = det.insertaromodificar(det, ref sqlcon, ref sqltra, mododetalleorden == "eliminar" ? "modificar" : "agregar");
                        if (mododetalleorden == "eliminar")
                        {
                            mododetalleorden = "agregar";
                        }
                        if (!rpta.Equals("OK"))
                        {
                            break;
                        }
                        if (det.Cantidadactual > 0)
                        {
                            DatosDetalleRemito remitodet = new Capa_Datos.DatosDetalleRemito();
                            remitodet.Idproducto = det.Idproducto;
                            remitodet.Detalle = det.Detalle;
                            remitodet.Cantidad = det.Cantidadactual;
                            
                            Detalleremito.Add(remitodet);
                        }

                    }
                    if (agregaromodificar == "modificarestado")
                    {
                        DatosRemito objremito = new DatosRemito(1, DateTime.Now, Ordenpedido.codcliente, Ordenpedido.norden, "", true, Ordenpedido.tipoorden, "0001",Ordenpedido.codempresa);
                      rpta =  objremito.insertarremito(objremito, Detalleremito, ref sqlcon, ref sqltra, true);
                        nroremito = objremito.Nremito;
                    }
                    
                }
                    //ver
                if (rpta.Equals("ok") || rpta.Equals("OK") )
                {
                    if (sqlcon.State == ConnectionState.Open)
                    {
                        sqltra.Commit();
                    }
                    
                }
                else 
                {
                    if (sqlcon.State == ConnectionState.Open)
                    {
                        sqltra.Rollback();
                    }
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

       

        public DataTable Busquedaconcatenada(DatosRetirodeMercaderia Dorden)
        {
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            DataTable dtResult = new DataTable("orden");

            try
            {
                SqlParameter[] dbParams = new SqlParameter[]
                   {
                        ProcAlmacenado2.MakeParam ("@modo",SqlDbType.NVarChar,50,"consultarordenconcatenado"),
                        ProcAlmacenado2.MakeParam ("@codcliente",SqlDbType.Int,0,Dorden.codcliente),
                        ProcAlmacenado2.MakeParam ("@estado",SqlDbType.NVarChar,50,Dorden.estado),
                        ProcAlmacenado2.MakeParam ("@tipoorden",SqlDbType.NVarChar,50,Dorden.tipoorden),
                        ProcAlmacenado2.MakeParam ("@fechaini",SqlDbType.DateTime,0,Dorden.fechaini),
                        ProcAlmacenado2.MakeParam ("@fechafin",SqlDbType.DateTime,0,Dorden.fechafin),
                        ProcAlmacenado2.MakeParam ("@porcliente",SqlDbType.Bit,0,Dorden.porcliente),
                        ProcAlmacenado2.MakeParam ("@porestado",SqlDbType.Bit,0,Dorden.porestado),
                        ProcAlmacenado2.MakeParam ("@portipo",SqlDbType.Bit,0,Dorden.portipo),
                        ProcAlmacenado2.MakeParam ("@porfecha",SqlDbType.Bit,0,Dorden.porfecha),
                        ProcAlmacenado2.MakeParam ("@TipoRetiro",SqlDbType.Int,0,Dorden.tiporetiro ),
                        ProcAlmacenado2.MakeParam ("@pororden",SqlDbType.Bit,0,Dorden.pornorden ),
                        ProcAlmacenado2.MakeParam ("@nroorden",SqlDbType.Int,0,Dorden.norden ),
                        ProcAlmacenado2.MakeParam ("@codventa",SqlDbType.Int,0,Dorden.codventa),
                        ProcAlmacenado2.MakeParam ("@porventa",SqlDbType.Bit,0,Dorden.porventa ),
                        //@TipoRetiro
                        

                   };
                dtResult = ProcAlmacenado2.ExecuteDatatable("SP_RETIRODEMERCADERIA", dbParams);
            }
            catch (Exception)
            {

                throw;

            }

            return dtResult;
        }

        public DataTable Busquedatipo()
        {
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            DataTable dtResult = new DataTable("orden");

            try
            {
                SqlParameter[] dbParams = new SqlParameter[]
                   {
                        ProcAlmacenado2.MakeParam ("@modo",SqlDbType.NVarChar,50,"buscartiporetiro")
                        


                   };
                dtResult = ProcAlmacenado2.ExecuteDatatable("SP_RETIRODEMERCADERIA", dbParams);
            }
            catch (Exception)
            {

                throw;

            }

            return dtResult;
        }
    }
}
