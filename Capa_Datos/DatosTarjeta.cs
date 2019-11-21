using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
   public class DatosTarjeta
    {

       //ATRIBUTOS
        private string nombre;
        private int codTarjeta;
        private int codFormaPago;
    public DatosTarjeta(string nombre, int codigoFormaPago){
        this.nombre = nombre;
        this.CodFormaPago = codigoFormaPago;
        
       }
    public DatosTarjeta() { 
    
    
    }
       //GETTERS AND SETTERS
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int CodTarjeta
        {
            get { return codTarjeta; }
            set { codTarjeta = value; }
        }

        public int CodFormaPago
        {
            get { return codFormaPago; }
            set { codFormaPago = value; }
        }
       
       public string agregarTarjeta(DatosTarjeta tarjeta)
       {


           string respuesta = "";
           try
           {
               SqlConnection cn = new SqlConnection(Conexion.conexion);
               cn.Open();
               //abro conexion
               SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_TARJETA");


              
               SqlParameter parNombreTarjeta = ProcAlmacenado.asignarParametros("@nombre", SqlDbType.VarChar,tarjeta.Nombre );
               //le paso al sqlcommand los parametros asignados
               comando.Parameters.Add(parNombreTarjeta);


               SqlParameter parCodFormaPago = ProcAlmacenado.asignarParametros("@cod_forma_pago", SqlDbType.Int, tarjeta.CodFormaPago);
               //le paso al sqlcommand los parametros asignados
               comando.Parameters.Add(parCodFormaPago);

               SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 1);
               //modo mostrar 1
               comando.Parameters.Add(parModo);

               SqlParameter parCodTarjeta = ProcAlmacenado.asignarParametros("@cod_tarjeta", SqlDbType.Int);
               comando.Parameters.Add(parCodTarjeta);

               if (comando.ExecuteNonQuery() == 1)
               {
                   respuesta = "ok";

               }
               else
               {

                   respuesta = "error";
               }
               cn.Close();



              
           }
           catch (Exception ex)
           {
               throw ex;

           }
           return respuesta;
       }



       public DataTable mostrarTarjetas()
       {

           //Modo 5 para DB
           SqlConnection cn = new SqlConnection(Conexion.conexion);
           //le asigno en el constructor el nombre de la tabla
           DataTable dtResult = new DataTable("tarjeta");
           try
           {
               cn.Open();

               SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_TARJETA");
               //Modo 2 MOSTRAR
               SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 2);
               comando.Parameters.Add(parModo);
              
               SqlParameter parCodTarjeta = ProcAlmacenado.asignarParametros("@cod_tarjeta", SqlDbType.Int);
               comando.Parameters.Add(parCodTarjeta);

               //creo el objeto adapter del data provider le paso el sqlcommand
               SqlDataAdapter datosResult = new SqlDataAdapter(comando);
               //los resultados los actualizo en el datatable dtResult
               datosResult.Fill(dtResult);

           }
           catch (Exception ex)
           {
               dtResult = null;
               throw ex;
           }
           return dtResult;
       }
    }
}
