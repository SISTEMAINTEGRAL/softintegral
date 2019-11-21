using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Capa_Datos
{
   public class DatosCategoria
    {
        private int idCategoria;
        private string nombre;
        private string descripcion;
        private string buscarCategoria;

       public DatosCategoria() { }

       public DatosCategoria(string nombre,string descripcion) {

           this.nombre = nombre;
           this.descripcion = descripcion;
       }
       
       //crud
       public string agregar(DatosCategoria categoria)
       {
           //modo 1 para DB
           SqlConnection cn = new SqlConnection(Conexion.conexion);
           string respuesta = "";
           try
           {
              
                   cn.Open();
                   //abro conexion
                   SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_CATEGORIA");

                   SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 1);
                   comando.Parameters.Add(parModo);
                   SqlParameter parIdProveedor= ProcAlmacenado.asignarParametros("@idcategoria", SqlDbType.Int);
                   //le paso al sqlcommand los parametros asignados
                   comando.Parameters.Add(parIdProveedor);

                   SqlParameter parNombre = ProcAlmacenado.asignarParametros("@nombre", SqlDbType.VarChar,categoria.Nombre,50);
                   //le paso al sqlcommand los parametros asignados
                   comando.Parameters.Add(parNombre);

                   SqlParameter parDescripcion = ProcAlmacenado.asignarParametros("@descripcion",SqlDbType.VarChar,categoria.Descripcion,50);
                   comando.Parameters.Add(parDescripcion);
                  
                if(comando.ExecuteNonQuery()==1){
                    respuesta = "ok";
                
                }else{
                    
                    respuesta="error";                
                }
                     
           }
           catch (Exception ex)
           {
               respuesta = "error conexion: " + ex.Message;
               cn.Close();
           }
           return respuesta;
       }
       public string editar(DatosCategoria categoria)
       {
           //modo 2 para DB
           SqlConnection cn = new SqlConnection(Conexion.conexion);
           string respuesta = "";
           try
           {

               cn.Open();
               //abro conexion
               SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_CATEGORIA");

               SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 2);
               comando.Parameters.Add(parModo);

               SqlParameter parIdCategoria = ProcAlmacenado.asignarParametros("@idcategoria", SqlDbType.Int, categoria.IdCategoria);
               //le paso al sqlcommand los parametros asignados
               comando.Parameters.Add(parIdCategoria);

               SqlParameter parNombre = ProcAlmacenado.asignarParametros("@nombre", SqlDbType.VarChar, categoria.Nombre, 50);
               comando.Parameters.Add(parNombre);

               SqlParameter parDescripcion = ProcAlmacenado.asignarParametros("@descripcion", SqlDbType.VarChar, categoria.Descripcion, 50);
               comando.Parameters.Add(parDescripcion);

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

           }
           return respuesta;

       }
       public string eliminar(DatosCategoria categoria)
       {
           //modo 3 para DB
           SqlConnection cn = new SqlConnection(Conexion.conexion);
           string respuesta = "";
           try
           {
                   cn.Open();
                   //abro conexion
                   SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_CATEGORIA");
                   
                   SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 3);
                   comando.Parameters.Add(parModo);

                   SqlParameter parIdCategoria = ProcAlmacenado.asignarParametros("@idcategoria", SqlDbType.Int, categoria.idCategoria);
                   comando.Parameters.Add(parIdCategoria);
                   if (comando.ExecuteNonQuery() == 1)
                   {
                       respuesta = "ok";
                   }
                   else
                   {
                       respuesta = "error: no se ha podido eliminar";
                   }
               
           }
           catch (Exception ex)
           {
               cn.Close();
               respuesta = "error conexion: " + ex.Message;
           }
           return respuesta;

       }
       public DataTable buscarTexto(DatosCategoria categoria)
       {
           //Modo 4 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
           //le asigno en el constructor el nombre de la tabla
           DataTable dtResult = new DataTable("categoria");
           try
           {

               SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_CATEGORIA");
               SqlParameter parBuscarTexto = ProcAlmacenado.asignarParametros("@buscarTexto", SqlDbType.VarChar, categoria.BuscarCategoria, 50);
                   //le paso al comando el parametro
               comando.Parameters.Add(parBuscarTexto);
               //modo buscar
                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 4);
                comando.Parameters.Add(parModo);
                SqlParameter parIdCategoria = ProcAlmacenado.asignarParametros("@idcategoria", SqlDbType.Int);
                comando.Parameters.Add(parIdCategoria);
                //creo el objeto adapter del data provider le paso el sqlcommand
                SqlDataAdapter datosResult = new SqlDataAdapter(comando);
                //los resultados los actualizo en el datatable dtResult
                datosResult.Fill(dtResult);
           }
           catch (Exception ex)
           {
               
               dtResult = null;
               cn.Close();
               //lanzo una excepcion en el caso de problemas con bd
               throw ex;
           }
           return dtResult;
       }
       public DataTable mostrar()
        {
           
           //Modo 5 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable("categoria");
            try
            {
                cn.Open();

                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_CATEGORIA");

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 5);
                comando.Parameters.Add(parModo);
                //Asigno al parametro @idcategoria, aunque no lo use
                SqlParameter parIdCategoria = ProcAlmacenado.asignarParametros("@idcategoria", SqlDbType.Int);
                comando.Parameters.Add(parIdCategoria);

                //creo el objeto adapter del data provider le paso el sqlcommand
                SqlDataAdapter datosResult = new SqlDataAdapter(comando);
                //los resultados los actualizo en el datatable dtResult
                datosResult.Fill(dtResult);

            }
            catch (Exception ex)
            {
                dtResult = null;
                //throw ex;
            }
            return dtResult;
        }
       
       //setter y getter de los campos de la clase
        public string BuscarCategoria
        {
            get { return buscarCategoria; }
            set { buscarCategoria = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
       public string Nombre
       {
           get { return nombre; }
           set { nombre = value; }
       }
       public int IdCategoria
       {
           get { return idCategoria; }
           set { idCategoria = value; }
       }
    }
}
