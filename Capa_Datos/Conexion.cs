using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace Capa_Datos
{
   public class Conexion
    {
     public static string conexion =  ConfigurationManager.ConnectionStrings["string.name"].ConnectionString;
       
        //public static string conexion = "Data Source=LEOX;Initial Catalog=db_ventas;Integrated Security=true";
       //public static string conexion = Properties.Settings.Default.conexioBD;
     public Conexion() {

         addnewstring("los pibes");
     }

       public static void addnewstring(string cadenadeconexion)
       {
           Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
           config.ConnectionStrings.ConnectionStrings.Remove("string.name");
           config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings("string.name", cadenadeconexion));
           config.Save(ConfigurationSaveMode.Modified);
           ConfigurationManager.RefreshSection("connectionStrings");
           conexion = ConfigurationManager.ConnectionStrings["string.name"].ConnectionString;
       }


       public static string getConexion() {


           if (ConfigurationManager.ConnectionStrings["string.name"].ConnectionString != null)
           {
               conexion = ConfigurationManager.ConnectionStrings["string.name"].ConnectionString;
           }
           else {
               conexion = "";
           }
       return conexion;
       }
      
   }
}
