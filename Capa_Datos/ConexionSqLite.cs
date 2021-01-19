using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using MySql.Data.MySqlClient;

namespace Capa_Datos
{
    class ConexionSQLITE
    {
        public static string cadenaconexion = "Data source = c:/DBVENTASQLITE/DBVENTA.s3db; version=3";

        public static string cadenaconexionmysql = "Server=vps-1868326-x.dattaweb.com;Database=DBVENTA; Uid=cristian;Pwd=*Cristian1234;";

        public void ExecuteQuery(string txtquery)
        {
            SQLiteConnection cadenaconexion = new SQLiteConnection(ConexionSQLITE.cadenaconexion);
            //MySqlConnection cadenaconexion = new MySqlConnection(ConexionSQLITE.cadenaconexionmysql);
            cadenaconexion.Open();
          //  MySqlCommand sql_cmd = cadenaconexion.CreateCommand();

            SQLiteCommand sql_cmd = cadenaconexion.CreateCommand();
            sql_cmd.CommandText = txtquery;
            sql_cmd.ExecuteNonQuery();
            cadenaconexion.Close();


        }
    }

    class ConexionMYSQL
    {
        //public static string cadenaconexion = "Data source = c:/DBVENTASQLITE/DBVENTA.s3db; version=3";

        public static string cadenaconexionmysql = "Server=vps-1868326-x.dattaweb.com;Database=DBVENTA; Uid=cristian;Pwd=*Cristian1234;";

        public void ExecuteQuery(string txtquery)
        {
           // SQLiteConnection cadenaconexion = new SQLiteConnection(ConexionSQLITE.cadenaconexion);
            MySqlConnection cadenaconexion = new MySqlConnection(ConexionSQLITE.cadenaconexionmysql);
            cadenaconexion.Open();
            MySqlCommand sql_cmd = cadenaconexion.CreateCommand();

            
            
            sql_cmd.CommandText = txtquery;
            sql_cmd.ExecuteNonQuery();
            cadenaconexion.Close();


        }
    }
}

