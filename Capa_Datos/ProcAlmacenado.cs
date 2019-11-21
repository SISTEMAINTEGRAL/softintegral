using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Capa_Datos
{
    public static class ProcAlmacenado
    {
        public static SqlCommand CrearProc(SqlConnection conexion,string nombreProc) {
            SqlCommand comando = new SqlCommand();
            //El nombre del procedimiento almacenado es SPINSERTAR_CATEGORIA
            comando.CommandText = nombreProc;
            //comandtype tipo enumerado especifica el tipo de comando
            comando.CommandType = CommandType.StoredProcedure;
            //le paso la conexion al comando del procedimiento almacenado
            comando.Connection = conexion;

            return comando;
        
        
        }
        /// <summary>
        /// Crear Procedimiento almacenado pasandole conexion,nombreProc,Y Trasaccion
        /// </summary>
        /// <param name="conexion"></param>
        /// <param name="nombreProc"></param>
        /// <returns>SqlCommand</returns>
        public static SqlCommand CrearProc(SqlConnection conexion, string nombreProc,SqlTransaction transaccion)
        {
            SqlCommand comando = new SqlCommand();
            //El nombre del procedimiento almacenado es SPINSERTAR_CATEGORIA
            comando.CommandText = nombreProc;
            //comandtype tipo enumerado especifica el tipo de comando
            comando.CommandType = CommandType.StoredProcedure;
            //le paso la conexion al comando del procedimiento almacenado
            comando.Connection = conexion;
            //le paso la transaccion
            comando.Transaction = transaccion;
            return comando;


        }

        public static SqlCommand CrearTransaccion(SqlConnection conexion, SqlTransaction transaccion)
        {
            SqlCommand comando = new SqlCommand();
            //le paso la conexion al comando del procedimiento almacenado
            comando.Connection = conexion;
            //le paso la transaccion
            comando.Transaction = transaccion;
            return comando;

        }


        //si el parametro no tiene tamaño es un parametro de salida(direction output)
        /// <summary>
        /// Para parametro de salida ,Sirve para valores(OUTPUT)
        /// </summary>
        /// <param name="nombreParametro"></param>
        /// <param name="tipoParametro"></param>
        /// <param name="valor"></param>
        /// <returns>"SqlParameter"</returns>
        public static SqlParameter asignarParametros(string nombreParametro,SqlDbType tipoParametro) {

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombreParametro;
            parametro.SqlDbType = tipoParametro;
            parametro.Direction = ParameterDirection.Output;
            return parametro;
        }


        //si el parametro tiene tamaño es de entrada
        /// <summary>
        /// para parametros de entrada
        /// </summary>
        /// <param name="nombreParametro"></param>
        /// <param name="tipoParametro"></param>
        /// <param name="valor"></param>
        /// <param name="tamaño"></param>
        /// <returns>"SqlParameter"</returns>
        public static SqlParameter asignarParametros(string nombreParametro, SqlDbType tipoParametro, Object valor,int tamaño)
        {


            SqlParameter parametro = new SqlParameter(nombreParametro, valor);
            parametro.SqlDbType = tipoParametro;
            parametro.Size = tamaño;
            return parametro;
        }
        /// <summary>
        /// Para parametros de entrada
        /// </summary>
        /// <param name="nombreParametro"></param>
        /// <param name="tipoParametro"></param>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static SqlParameter asignarParametros(string nombreParametro, SqlDbType tipoParametro, Object valor)
        {

            SqlParameter parametro = new SqlParameter(nombreParametro, valor);
            parametro.SqlDbType = tipoParametro;
            return parametro;
        }
    }
}
