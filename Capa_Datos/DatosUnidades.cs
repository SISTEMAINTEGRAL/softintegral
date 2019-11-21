using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Capa_Datos
{
    public class DatosUnidades
    {
        //campos
        private int idUnidad;
        private String nombre;
        
        
        //constructores
        public DatosUnidades() { 
        }
        public DatosUnidades(int idUnidad, string nombre)
        {
            this.idUnidad = idUnidad;
            this.nombre = nombre;

        }
        
        //crud

        public string agregar(DatosUnidades unidades)
        {
             SqlConnection cn = new SqlConnection(Conexion.conexion);
            string respuesta = "";
            try
            {
                    //abro conexion
                    cn.Open();
                    //comando asignando el nombre y la conexion
                    SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_UNIDADES");

                    //modo agregar
                    SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 1);
                    comando.Parameters.Add(parModo);

                    //parametro del idunidad le asigno el nombre,tipo,valor,tamaño
                    SqlParameter parIdUnidad= ProcAlmacenado.asignarParametros("@idunidad", SqlDbType.Int);
                    //le paso al sqlcommand los parametros asignados
                    comando.Parameters.Add(parIdUnidad);

                    //parametro del nombre le asigno el nombre,tipo,valor,tamaño
                    SqlParameter parNombre = ProcAlmacenado.asignarParametros("@nombre", SqlDbType.VarChar, unidades.Nombre, 50);
                    comando.Parameters.Add(parNombre);

                    if (comando.ExecuteNonQuery() == 1)
                    {
                        respuesta = "ok";

                    }
                    else
                    {

                        respuesta = "error";
                    }

               
            }
            catch (Exception ex)
            {
                respuesta = "error conexion: " + ex.Message;
                cn.Close();
            }
            return respuesta;
        }
        public string editar(DatosUnidades unidades)
        {
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            string respuesta = "";
            try
            {
                    cn.Open();

                  //comando asignando el nombre y la conexion
                    SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_UNIDADES");

                    //modo editar
                    SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 2);
                    comando.Parameters.Add(parModo);
                    //parametro del idunidad le asigno el nombre,tipo,valor,tamaño
                    SqlParameter parIdUnidad= ProcAlmacenado.asignarParametros("@idunidad", SqlDbType.Int);
                    //le paso al sqlcommand los parametros asignados
                    comando.Parameters.Add(parIdUnidad);

                    //parametro del nombre le asigno el nombre,tipo,valor,tamaño
                    SqlParameter parNombre = ProcAlmacenado.asignarParametros("@nombre", SqlDbType.VarChar, unidades.Nombre, 50);
                    comando.Parameters.Add(parNombre);
                  

                    if (comando.ExecuteNonQuery() == 1)
                    {
                        respuesta = "ok";
                    }
                    else
                    {
                        respuesta = "error de ingreso";
                    }

            }
            catch (Exception ex)
            {
                respuesta = "error conexion: " + ex.Message;
                cn.Close();
            }
            return respuesta;
        }
        public string eliminar(DatosUnidades unidades)
        {
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            string respuesta = "";
            try
            {
                    cn.Open();
                    //abro conexion
                    SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_UNIDADES");

                    //modo eliminar
                    SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 3);
                    comando.Parameters.Add(parModo);
                    //parametro del idunidad le asigno el nombre,tipo,valor
                    SqlParameter parIdUnidad= ProcAlmacenado.asignarParametros("@idunidad", SqlDbType.Int,unidades.idUnidad);
                    //le paso al sqlcommand los parametros asignados
                    comando.Parameters.Add(parIdUnidad);

                    if (comando.ExecuteNonQuery() == 1)
                    {
                        respuesta = "ok";
                    }
                    else
                    {
                        respuesta = "error: no se ha podido eliminar";
                        cn.Close();
                    }
            }
            catch (Exception ex)
            {
                respuesta = "error conexion: " + ex.Message;

            }
            return respuesta;
        }
        public DataTable buscarTexto(DatosUnidades unidades,string textoBuscar)
        {
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable("unidades");
            try
            {
                //abro conexion
                cn.Open();
                //comando asignando el nombre y la conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_UNIDADES");

                //modo agregar
                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 4);
                comando.Parameters.Add(parModo);

                //parametro del texto a buscar le asigno el nombre,tipo,valor,tamaño
                SqlParameter parBuscarTexto = ProcAlmacenado.asignarParametros("@buscarTexto", SqlDbType.VarChar,textoBuscar, 50);
                comando.Parameters.Add(parBuscarTexto);

                //creo el objeto adapter del data provider le paso el sqlcommand
                 SqlDataAdapter datosResult = new SqlDataAdapter(comando);
                //los resultados los actualizo en el datatable dtResult
                 datosResult.Fill(dtResult);

                }

            
            catch (Exception ex)
            {
                cn.Close();
                dtResult = null;
                throw ex; 
                
            }
            return dtResult;
        }
        public DataTable mostrar()
        {
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable("unidades");
            try
            {
                cn.Open();
                //comando asignando el nombre y la conexion
                SqlCommand comando = new SqlCommand();
                comando.Connection = cn;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_UNIDADES";

                SqlParameter parIdUnidad = ProcAlmacenado.asignarParametros("@idunidad", SqlDbType.Int);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parIdUnidad);

                SqlParameter parametroModo = new SqlParameter();
                parametroModo.SqlDbType = SqlDbType.Int;
                parametroModo.ParameterName = "@modo";
                parametroModo.Value = 5;
                comando.Parameters.Add(parametroModo);

               
                //SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_UNIDADES");

                //    SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 5);
                //    comando.Parameters.Add(parModo);
                //    //creo el objeto adapter del data provider le paso el sqlcommand
                   SqlDataAdapter datosResult = new SqlDataAdapter(comando);
                //    //los resultados los actualizo en el datatable dtResult
                     datosResult.Fill(dtResult);
                
                }
            catch (Exception ex)
            {
                dtResult = null;
                Console.WriteLine(ex.Message);
                
                cn.Close();
            }
            
            return dtResult;
        }
       

        //getters y setters
       
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
       

        public int IdUnidad
        {
            get { return idUnidad; }
            set { idUnidad = value; }
        }

    }
}
