using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class DatosBackup
    {
        public string generarBackup(string ruta)
        {


            string respuesta = "";
            try
            {
                SqlConnection cn = new SqlConnection(Conexion.conexion);
                cn.Open();
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_BACKUP");


                
                SqlParameter parPath = ProcAlmacenado.asignarParametros("@path", SqlDbType.VarChar, ruta );
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parPath);


                comando.ExecuteNonQuery();
                
                    respuesta = "ok";

                
            
                cn.Close();
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return respuesta;
        }
    }
}
