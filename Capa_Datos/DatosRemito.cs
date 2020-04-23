using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
     public class DatosRemito
    {
        private int codsucursal;
        private string nremito;
        private DateTime fecha;
        private int codcliente;
        private int nroregistro;
        private string transportista;
        private bool entregado;
        private string modo;
        private string estado;
        private string serie;
        private string tipo;
        
        public DatosRemito()
        {
            

        }
        public DatosRemito(int varcodsucursal, DateTime varfecha, int varcodcliente, int varnroregistro, string vartransportista, bool varentregado, string vartipo, string varserie )
        {
            this.codsucursal = varcodsucursal;
            this.fecha = varfecha;
            this.codcliente = varcodcliente;
            this.nroregistro = varnroregistro;
            this.transportista = vartransportista;
            this.entregado = varentregado;
            this.tipo = vartipo;
            this.serie = varserie;
            



        }
        public string insertarremito(DatosRemito remito, List<DatosDetalleRemito> Detalle, ref SqlConnection sqlcon, ref SqlTransaction sqltra, bool distock = true )
        {
            string rpta = "";
            //disminuir stock 
            DatosMovStock objstock = new Capa_Datos.DatosMovStock();
           

            try
            {
                sqlcon.ConnectionString = Conexion.conexion;
                sqlcon.Open();

               


                SqlCommand sqlcmd = ProcAlmacenado.CrearProc(sqlcon, "SP_REMITO", sqltra);

                SqlParameter parnremito = ProcAlmacenado.asignarParametros("@nremito", SqlDbType.NVarChar);
                sqlcmd.Parameters.Add(parnremito);
                parnremito.Size = 100;

                SqlParameter parsucursal = ProcAlmacenado.asignarParametros("@codsucursal", SqlDbType.Int, 1);
                sqlcmd.Parameters.Add(parsucursal);

                SqlParameter parfecha = ProcAlmacenado.asignarParametros("@fecha", SqlDbType.NVarChar, remito.fecha);
                sqlcmd.Parameters.Add(parfecha);

                SqlParameter parcodcliente = ProcAlmacenado.asignarParametros("@codcliente", SqlDbType.Int, remito.codcliente);
                sqlcmd.Parameters.Add(parcodcliente);

                SqlParameter parnroregistro = ProcAlmacenado.asignarParametros("@nroregistro", SqlDbType.Int, remito.nroregistro);
                sqlcmd.Parameters.Add(parnroregistro);

                SqlParameter partransportista = ProcAlmacenado.asignarParametros("@transportista", SqlDbType.NVarChar, remito.transportista);
                sqlcmd.Parameters.Add(partransportista);

                SqlParameter parentregado = ProcAlmacenado.asignarParametros("@entregado", SqlDbType.Bit, remito.entregado);
                sqlcmd.Parameters.Add(parentregado);

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.NVarChar, "agregarremito");
                sqlcmd.Parameters.Add(parModo);

                SqlParameter parestado = ProcAlmacenado.asignarParametros("@estado", SqlDbType.NVarChar, remito.estado);
                sqlcmd.Parameters.Add(parestado);

                SqlParameter parserie = ProcAlmacenado.asignarParametros("@serie", SqlDbType.NVarChar, remito.serie);
                sqlcmd.Parameters.Add(parserie);

                rpta = sqlcmd.ExecuteNonQuery() >= 1 ? "OK" : "No se ingreso el registro";

                if (rpta.Equals("OK"))
                {
                    remito.nremito = sqlcmd.Parameters["@nremito"].Value.ToString();


                    foreach (DatosDetalleRemito  det in Detalle)
                    {
                        
                        rpta = det.insertardetalleremito(det, ref sqlcon, ref sqltra,remito.nremito);
                        if (!rpta.Equals("OK"))
                        {
                            break;
                        }
                        else
                        {
                            //actualizamos el stock
                            if (distock == true && det.Idproducto != 0) { rpta = objstock.Modificarstock(det.Idproducto, det.Cantidad, ref  sqlcon, ref  sqltra,"EGRESO"); }
                            if (!rpta.Equals("ok"))
                            {
                                break;

                            }
                        }

                    }
                }

                if (rpta.Equals("ok") )
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
