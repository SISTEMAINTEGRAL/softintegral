using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    
   public class Datosgenerales
    {
        private string campo;
        private string tabla;
        private string valor;

        public string Campo
        {
            get
            {
                return campo;
            }

            set
            {
                campo = value;
            }
        }

        public string Tabla
        {
            get
            {
                return tabla;
            }

            set
            {
                tabla = value;
            }
        }

        public string Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public Datosgenerales ()
        {

        }
        public Datosgenerales(string vartabla, string varvalor, string varcampo)
        {
            tabla = vartabla;
            campo = varcampo;
            valor = varvalor;
        }
        public Datosgenerales(string vartabla)
        {
            tabla = vartabla;
        }
        public DataTable selecciondeconsultageneral(Datosgenerales general, string modo = "modoseleccion")
        {
            DataTable dtResult = new DataTable();

            try
            {
                SqlParameter[] dbParams = new SqlParameter[]
                  {
                        ProcAlmacenado2.MakeParam ("@modo",SqlDbType.NVarChar,50,modo),
                        ProcAlmacenado2.MakeParam ("@campo",SqlDbType.NVarChar,300,general.campo),
                        ProcAlmacenado2.MakeParam ("@tabla",SqlDbType.NVarChar,300,general.tabla),
                        ProcAlmacenado2.MakeParam ("@valor",SqlDbType.NVarChar,300,general.valor)

                  };
                dtResult = ProcAlmacenado2.ExecuteDatatable("SP_GENERAL", dbParams);
            }
            catch (Exception)
            {

                throw;
            }
            return dtResult;
        }
    }
}
