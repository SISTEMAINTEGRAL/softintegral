﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
   public  class DatosCaja
    {
       static public long  cuentaaperturacaja = 9100001;
       static public long cuentacierrecaja = 9100002;
        private int codformapago;
       private string FechaD;
        private float totaltarjeta;
        private string estadocierre;
       public string FechaD1
       {
           get { return FechaD; }
           set { FechaD = value; }
       }
       private string FechaH;

       public string FechaH1
       {
           get { return FechaH; }
           set { FechaH = value; }
       }

        private string aperturacierre;

        public string Aperturacierre
        {
            get { return aperturacierre; }
            set { aperturacierre = value; }
        }


        private decimal impsistema;

        public decimal Impsistema
        {
            get { return impsistema; }
            set { impsistema = value; }
        }
        private decimal impreal;

        public decimal Impreal
        {
            get { return impreal; }
            set { impreal = value; }
        }
        private long  idcaja;

        public long Idcaja
        {
            get { return idcaja; }
            set { idcaja = value; }
        }
       

        private long codmov;

        public long Codmov
        {
            get { return codmov; }
            set { codmov = value; }
        }
        //@codcuenta,@ingreso,@egreso,@Fecha,@usuario,@idusuario,@turno,@concepto,@comprobante,@estado

        private long idturno;

        public long Idturno
        {
            get { return idturno; }
            set { idturno = value; }
        }
        private long idcierre;

        public long Idcierre
        {
            get { return idcierre; }
            set { idcierre = value; }
        }
        private long codcuenta;

        public long Codcuenta
        {
            get { return codcuenta; }
            set { codcuenta = value; }
        }
        private float ingreso;

        public float Ingreso
        {
            get { return ingreso; }
            set { ingreso = value; }
        }
        private float egreso;

        public float Egreso
        {
            get { return egreso; }
            set { egreso = value; }
        }
        private string usuario;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private int idusuario;

        public int Idusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }
        private string concepto;

        public string Concepto
        {
            get { return concepto; }
            set { concepto = value; }
        }
        private long comprobante;

        public long Comprobante
        {
            get { return comprobante; }
            set { comprobante = value; }
        }
        private bool estado;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private string turno;

        public string Turno
        {
            get { return turno; }
            set { turno = value; }
        }

        private string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public int Codformapago
        {
            get
            {
                return codformapago;
            }

            set
            {
                codformapago = value;
            }
        }

        public float Totaltarjeta
        {
            get
            {
                return totaltarjeta;
            }

            set
            {
                totaltarjeta = value;
            }
        }

        public string Estadocierre { get => estadocierre; set => estadocierre = value; }

        public DataTable metbuscarfecha( string fechah, string fechad, int nrocaja, int modo = 7, long idcierre = 0, long idturno = 0, bool porfecha = true)
        {
            string rpta = "";
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable("fondo_mov_caja");
            try
            {
                cn.Open();

                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_CAJA");

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, modo);
                comando.Parameters.Add(parModo);

                if (porfecha == true)
                {
                    SqlParameter parfecha = ProcAlmacenado.asignarParametros("@FechaD", SqlDbType.DateTime, fechah);
                    comando.Parameters.Add(parfecha);

                    SqlParameter parfecha1 = ProcAlmacenado.asignarParametros("@FechaH", SqlDbType.DateTime, fechad);
                    comando.Parameters.Add(parfecha1);

                    SqlParameter parporfecha = ProcAlmacenado.asignarParametros("@porfecha", SqlDbType.Bit, porfecha);
                    comando.Parameters.Add(parporfecha);



                }



                SqlParameter parnrocaja = ProcAlmacenado.asignarParametros("@id_caja", SqlDbType.Int, nrocaja);
                comando.Parameters.Add(parnrocaja);

                SqlParameter paridcierre = ProcAlmacenado.asignarParametros("@cod_cierre", SqlDbType.Int, idcierre);
                comando.Parameters.Add(paridcierre);

                SqlParameter paridturno = ProcAlmacenado.asignarParametros("@id_turno", SqlDbType.Int, idturno);
                comando.Parameters.Add(paridturno);

                //creo el objeto adapter del data provider le paso el sqlcommand
                SqlDataAdapter datosResult = new SqlDataAdapter(comando);
                //los resultados los actualizo en el datatable dtResult
                datosResult.Fill(dtResult);

                foreach (DataRow lista in dtResult.Rows)
                {
                    string fechahora = "";

                    fechahora = lista["Fecha"].ToString(); ;
                   
                
                }

                
                

            }
            catch (Exception ex)
            {
                dtResult = null;
                rpta = ex.Message;
                //throw ex;
            }
            return dtResult;

             
        }

        public DataTable mostrartipomov(int modo, int tipomov, string ingegr)
        {
            int varmodo = 5;
            string tabla = "fondo_tipomov";
            string rpta = "";
                
            //Modo 5 para DB
            
            if (modo == 6)
            {
                varmodo = 6;
                 tabla = "plancuenta";
                 
            
            }
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable(tabla);
            try
            {
                cn.Open();

                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_CAJA");

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, varmodo );
                comando.Parameters.Add(parModo);
                
                //SqlParameter parCodigo = ProcAlmacenado.asignarParametros("id" , SqlDbType.Int);
                //comando.Parameters.Add(parCodigo);

                if (tipomov != 0)
                {
                    SqlParameter parTipoMov = ProcAlmacenado.asignarParametros("@Tipomovimiento", SqlDbType.Int, tipomov);
                    //le paso al sqlcommand los parametros asignados
                    comando.Parameters.Add(parTipoMov);
                }
                
                if (ingegr != " ")
                {
                    SqlParameter paringegr = ProcAlmacenado.asignarParametros("@Tipoingegr", SqlDbType.Char, ingegr);
                    //le paso al sqlcommand los parametros asignados
                    comando.Parameters.Add(paringegr);
                
                }

                //creo el objeto adapter del data provider le paso el sqlcommand
                SqlDataAdapter datosResult = new SqlDataAdapter(comando);
                //los resultados los actualizo en el datatable dtResult
                datosResult.Fill(dtResult);

            }
            catch (Exception ex)
            {
                dtResult = null;
                rpta = ex.Message;
                //throw ex;
            }
            return dtResult;
        }

        public string agregar(DatosCaja caja)
        {
            //modo 1 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            string respuesta = "";
            try
            {

                cn.Open();
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_CAJA");

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 1);
                comando.Parameters.Add(parModo);

               // SqlParameter parIdMovcaja = ProcAlmacenado.asignarParametros("@id", SqlDbType.Int);
                //le paso al sqlcommand los parametros asignados
               // comando.Parameters.Add(parIdMovcaja);
                //@codcuenta,@ingreso,@egreso,@Fecha,@usuario,@idusuario,@turno,@concepto,@comprobante,@estado
                SqlParameter parCodcuenta = ProcAlmacenado.asignarParametros("@codcuenta", SqlDbType.Int  , caja.codcuenta );
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parCodcuenta);

                SqlParameter parIngreso = ProcAlmacenado.asignarParametros("@ingreso", SqlDbType.Float , caja.ingreso);
                comando.Parameters.Add(parIngreso);

                SqlParameter parEgreso = ProcAlmacenado.asignarParametros("@egreso", SqlDbType.Float, caja.egreso );
                comando.Parameters.Add(parEgreso);

                SqlParameter parFecha = ProcAlmacenado.asignarParametros("@fecha", SqlDbType.DateTime , caja.fecha );
                comando.Parameters.Add(parFecha);

                SqlParameter parUsuario = ProcAlmacenado.asignarParametros("@usuario", SqlDbType.VarChar  , caja.usuario , 100);
                comando.Parameters.Add(parUsuario);

                SqlParameter paridusuario = ProcAlmacenado.asignarParametros("@idusuario", SqlDbType.Int , caja.idusuario );
                comando.Parameters.Add(paridusuario);

                SqlParameter parturno = ProcAlmacenado.asignarParametros("@turno", SqlDbType.VarChar , caja.turno );
                comando.Parameters.Add(parturno);

                SqlParameter parconcepto = ProcAlmacenado.asignarParametros("@concepto", SqlDbType.NVarChar , caja.concepto );
                comando.Parameters.Add(parconcepto );

                SqlParameter parcomprobante = ProcAlmacenado.asignarParametros("@comprobante", SqlDbType.Int, caja.comprobante );
                comando.Parameters.Add(parcomprobante);

                SqlParameter parestado = ProcAlmacenado.asignarParametros("@estado", SqlDbType.Int, caja.estado );
                comando.Parameters.Add(parestado);

                SqlParameter parcaja = ProcAlmacenado.asignarParametros("@id_caja", SqlDbType.Int, caja.idcaja);
                comando.Parameters.Add(parcaja);

                SqlParameter parcodformapago = ProcAlmacenado.asignarParametros("@formapago", SqlDbType.Int, caja.codformapago);
                comando.Parameters.Add(parcodformapago);

                if (comando.ExecuteNonQuery() == 1)
                {
                    respuesta = "ok";

                }
                else
                {

                    respuesta = "error";
                }

            }
            catch (Exception e)
            {
                cn.Close();
                throw;
                
               
            }
            return respuesta;
        }
        public void Extestadoturno(int modo, string fecha, int nrocaja = 1, long idcierre = 0, long idturno = 0)
        {
            try
            {
                string query;
                query = "";
                SqlConnection cn = new SqlConnection(Conexion.conexion);
                cn.Open();

                if (modo == 1)
                {
                                       
                    query = " SELECT top 1 Cod_cierre ,Fecha_Apertura ,Turno ,Total_ingreso ,Total_egreso ,Id_turno ,Imp_sistema ,Imp_real ,Id_Caja ,Id_Usuario ,Fecha_cierre ,Total_Tarjeta ,Estado FROM fondo_cierre where cod_cierre = " + idcierre + " and id_caja = " + nrocaja + " order by id_turno desc";
                
                }
                if (modo == 2)
                {
                    
                        query = " select ISNULL ( sum (Ingreso),0) as ingreso, ISNULL ( sum (Egreso),0) as egreso from fondo_mov_caja where cod_cierre = " + idcierre +  " and id_turno = " + idturno + " and nrocaja = " + nrocaja + " and Codformapago = 1";
                   
                    //not Codcuenta = '9100001' 
                }

               
                //idcierre segun la apertura de fecha 
                if (modo == 4)
                {
                    query = " SELECT TOP 1 cod_mov,Cod_cuenta ,Ingreso ,Egreso ,Fecha,Usuario ,Idusuario ,Turno ,Concepto ,Comprobante ,Estado FROM fondo_mov_caja where cod_cuenta = 9100001 or cod_cuenta = 9100002 and nrocaja = " + nrocaja + " order by cod_mov desc";
                }
                if (modo == 5)
                {
                    query = " select ISNULL ( sum (Ingreso),0) as ingreso, ISNULL ( sum (Egreso),0) as egreso from fondo_mov_caja where Fecha between @fecha +' 00:00:00' and @fecha + ' 23:59:59' and nrocaja = " + nrocaja + "and Codformapago = 2";
                }

                SqlCommand cmd = new SqlCommand(query, cn);
                if (modo == 2 || modo == 5)
                {
                    cmd.Parameters.AddWithValue("@Fecha", Convert.ToString(fecha));
                }
                if (modo == 3)
                {
                    cmd.Parameters.AddWithValue("@id_turno", Convert.ToInt32(turno));
                }


                SqlDataReader reader = cmd.ExecuteReader();

                if (modo == 1)
                {
                    if (reader.Read())
                    {
                        this.estadocierre = Convert.ToString(reader["estado"]);
                        this.idturno = Convert.ToInt64(reader["id_turno"]);
                                                
                    }
                    else
                    {
                        this.estadocierre = "CERRADO";
                        this.idturno = 1;
                    }
                }

                if ((modo == 2) != (modo == 3))
                {
                    if (reader.Read())
                    {

                        this.ingreso = Convert.ToSingle(reader["Ingreso"]);
                        this.egreso = Convert.ToSingle(reader["Egreso"]);

                    }

                }
                if (modo == 5)
                {
                    if (reader.Read())
                    {
                        this.ingreso = Convert.ToSingle(reader["Ingreso"]);
                    }
                    else
                    {
                        this.ingreso = 0;
                    }
                }

                cn.Close();


            }
            catch (Exception e)
            {
                
                
                    throw;
                
            }


        }

        public void Extestadocaja(int modo,string fecha, long turno, bool ingreso = false, int nrocaja = 1, long varidcierre = 0)
        {
            try
            {
                string query;
                query = "";
                SqlConnection cn = new SqlConnection(Conexion.conexion);
                cn.Open();

                if (modo == 1)
                {

                    query = " SELECT TOP 1 cod_mov,Cod_cuenta ,Ingreso ,Egreso ,Fecha,Usuario ,Idusuario ,Turno ,Concepto ,Comprobante ,Estado, idcierre FROM fondo_mov_caja where (cod_cuenta = 9100001 or cod_cuenta = 9100002) and nrocaja = " + nrocaja + " order by cod_mov desc";
                }
                if (modo == 2)
                {
                    if (ingreso == false)
                    {
                        query = " select ISNULL ( sum (Ingreso),0) as ingreso, ISNULL ( sum (Egreso),0) as egreso from fondo_mov_caja where Fecha between @fecha +' 00:00:00' and @fecha + ' 23:59:59' and nrocaja = " + nrocaja + " and Codformapago = 1";
                    }
                    else
                    {
                        query = " select ISNULL ( sum (Ingreso),0) as ingreso, ISNULL ( sum (Egreso),0) as egreso from fondo_mov_caja where Fecha between @fecha +' 00:00:00' and @fecha + ' 23:59:59' and not Cod_cuenta = '9100001' and Codformapago = 1 and nrocaja = " + nrocaja;
                    }
                    //not Codcuenta = '9100001' 
                }

                if (modo == 3)
                {
                    query = " select ISNULL ( sum (Ingreso),0) as ingreso, ISNULL ( sum (Egreso),0) as egreso from fondo_mov_caja where idturno = @id_turno and idcierre = " + varidcierre + " and nrocaja = " + nrocaja + " and Codformapago = 1";

                }
                //idcierre segun la apertura de fecha 
                if (modo == 4)
                {
                    query = " SELECT TOP 1 cod_mov,Cod_cuenta ,Ingreso ,Egreso ,Fecha,Usuario ,Idusuario ,Turno ,Concepto ,Comprobante ,Estado FROM fondo_mov_caja where cod_cuenta = 9100001 or cod_cuenta = 9100002 and nrocaja = " + nrocaja + " order by cod_mov desc";
                }
                if (modo == 5)
                {
                    query = " select ISNULL ( sum (Ingreso),0) as ingreso, ISNULL ( sum (Egreso),0) as egreso from fondo_mov_caja where Fecha between @fecha +' 00:00:00' and @fecha + ' 23:59:59' and nrocaja = " + nrocaja + "and Codformapago = 2";
                }
                
                SqlCommand cmd = new SqlCommand(query, cn);
                if (modo == 2 || modo == 5)
                {
                    cmd.Parameters.AddWithValue("@Fecha", Convert.ToString(fecha));
                }
                if (modo == 3)
                {
                    cmd.Parameters.AddWithValue("@id_turno", Convert.ToInt32(turno));
                }


                SqlDataReader reader = cmd.ExecuteReader();

                if (modo == 1)
                {
                    if (reader.Read())
                    {

                        this.codcuenta = Convert.ToInt32(reader["Cod_cuenta"]);
                        this.fecha = Convert.ToString(reader["Fecha"]);
                        this.codmov = Convert.ToInt32(reader["Cod_mov"]);
                    }

                }

                if ((modo == 2) != (modo == 3) )
                {
                    if (reader.Read())
                    {

                        this.ingreso = Convert.ToSingle(reader["Ingreso"]);
                        this.egreso = Convert.ToSingle(reader["Egreso"]);

                    }

                }
                if (modo == 5)
                {
                    if (reader.Read())
                    {
                        this.ingreso = Convert.ToSingle(reader["Ingreso"]);
                    }
                    else
                    {
                        this.ingreso = 0;
                    }
                }

                cn.Close();

   
            }
            catch (Exception e)
            {
                if (modo == 2 && ingreso == true)
                {
                    this.ingreso = 0;
                    this.egreso = 0;
                }
                else
                {
                    throw;
                }
            }
            
            
        }

        public bool Extcierrecaja(string opcion, int nrocaja, long idcierre = 0)
        {

            string query;
            query = "";
            bool encontrado = true;
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            cn.Open();

            if (opcion == "cod_cierre")
            {
                query = "SELECT TOP 1 " + opcion + " FROM fondo_cierre_caja where id_caja = " + nrocaja + " order by Cod_cierre desc";
            }
            else
            {
                query = "SELECT TOP 1 " + opcion + " FROM fondo_cierre where cod_cierre = " + idcierre + " and id_caja = " + nrocaja + " order by id_turno desc";
            }
            

            //cmd.Parameters.AddWithValue("@id", Convert.ToString  (codArticulo));

            SqlCommand cmd = new SqlCommand(query, cn);
            //cmd.Parameters.AddWithValue("@id", Convert.ToString(codArticulo));
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                if (opcion == "cod_cierre")
                {
                    this.idcierre = Convert.ToInt32(reader[opcion]);
                }
                else
                {
                    this.idturno  = Convert.ToInt32(reader[opcion]);
                }
                
                //this.idcierre = this.idcierre + 1;
            }
            else
            {
                encontrado = false;
                if (opcion == "cod_cierre")
                {
                    this.idcierre = 1;
                }
                else
                {
                    this.idturno = 1;
                }
                
                               
            }
                

            cn.Close();
            return encontrado;

        }
        public string eliminarcaja(DatosCaja  caja)
        {
            //modo 3 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            string respuesta = "";
            try
            {
                cn.Open();
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_CAJA");
                //MODO 3 ELIMINAR
                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 3);
                comando.Parameters.Add(parModo);

                SqlParameter parIdArticulo = ProcAlmacenado.asignarParametros("@codmov", SqlDbType.Int, caja.codmov);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parIdArticulo);


                if (comando.ExecuteNonQuery() == 1)
                {
                    respuesta = "ok";
                }
                else
                {
                    respuesta = "error: no se ha podido eliminar";
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                respuesta = "error conexion: " + ex.Message;
            }
            return respuesta;

        }

        public string agregarcierre(DatosCaja caja)
        {
            //modo 1 para DB
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            string respuesta = "";
            try
            {

                cn.Open();
                //abro conexion
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_CAJA");

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 9);
                comando.Parameters.Add(parModo);
                                

                SqlParameter paraperturacierre = ProcAlmacenado.asignarParametros("@aperturacierre", SqlDbType.NVarChar , caja.aperturacierre);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(paraperturacierre);

                SqlParameter paridusuario = ProcAlmacenado.asignarParametros("@id_usuario", SqlDbType.Int , caja.idusuario);
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(paridusuario);
                
                    
                SqlParameter parCodcierre = ProcAlmacenado.asignarParametros("@cod_cierre", SqlDbType.Int, caja.idcierre );
                //le paso al sqlcommand los parametros asignados
                comando.Parameters.Add(parCodcierre);
                               

                SqlParameter parFecha = ProcAlmacenado.asignarParametros("@fecha", SqlDbType.DateTime, caja.fecha);
                comando.Parameters.Add(parFecha);

                

               
                SqlParameter paridturno = ProcAlmacenado.asignarParametros("@id_turno", SqlDbType.Int , caja.idturno );
                comando.Parameters.Add(paridturno);

                SqlParameter paridcaja = ProcAlmacenado.asignarParametros("@id_caja", SqlDbType.Int, caja.idcaja);
                comando.Parameters.Add(paridcaja);

                SqlParameter parturno = ProcAlmacenado.asignarParametros("@turno", SqlDbType.VarChar, caja.turno);
                comando.Parameters.Add(parturno);


                 if (aperturacierre == "CIERRE" || aperturacierre == "CIERRE TURNO")
                {
                    SqlParameter parIngreso = ProcAlmacenado.asignarParametros("@ingreso", SqlDbType.Float, caja.ingreso);
                    comando.Parameters.Add(parIngreso);

                    SqlParameter parEgreso = ProcAlmacenado.asignarParametros("@egreso", SqlDbType.Float, caja.egreso);
                    comando.Parameters.Add(parEgreso);

                    SqlParameter parimpsistema = ProcAlmacenado.asignarParametros("@imp_sistema", SqlDbType.Decimal, caja.impsistema);
                    comando.Parameters.Add(parimpsistema);

                    SqlParameter parimpreal = ProcAlmacenado.asignarParametros("@imp_real", SqlDbType.Decimal, caja.impreal);
                    comando.Parameters.Add(parimpreal);

                    SqlParameter parTotalTarjeta = ProcAlmacenado.asignarParametros("@total_tarjeta", SqlDbType.Decimal, caja.totaltarjeta);
                    comando.Parameters.Add(parTotalTarjeta);
                }


                if (comando.ExecuteNonQuery() >= 1)
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
        public DataTable metbuscarfechacierre(string fechad, string fechah, int nrocaja, string tipocierre, int idturno, int idcierre )
        {
            string rpta = "";
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            //le asigno en el constructor el nombre de la tabla
            DataTable dtResult = new DataTable("fondo_cierre_caja");
            int modo = 10;
            if (tipocierre == "CAJA")
            {
                modo = 10;
            }
            else if (tipocierre == "TURNO")
            {
                modo = 11;
            }
            try
            {
                cn.Open();

                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_CAJA");


                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, modo);
                comando.Parameters.Add(parModo);

                if (fechad != "")
                {
                    SqlParameter parfecha = ProcAlmacenado.asignarParametros("@FechaD", SqlDbType.DateTime, fechad);
                    comando.Parameters.Add(parfecha);

                    SqlParameter parfecha1 = ProcAlmacenado.asignarParametros("@FechaH", SqlDbType.DateTime, fechah);
                    comando.Parameters.Add(parfecha1);
                }
                

                SqlParameter parnrocaja = ProcAlmacenado.asignarParametros("@id_caja", SqlDbType.Int, nrocaja);
                comando.Parameters.Add(parnrocaja);

                SqlParameter paridturno = ProcAlmacenado.asignarParametros("@id_turno", SqlDbType.Int, idturno);
                comando.Parameters.Add(paridturno);

                SqlParameter parcierre = ProcAlmacenado.asignarParametros("@cod_cierre", SqlDbType.Int, idcierre);
                comando.Parameters.Add(parcierre);




                //creo el objeto adapter del data provider le paso el sqlcommand
                SqlDataAdapter datosResult = new SqlDataAdapter(comando);
                //los resultados los actualizo en el datatable dtResult
                datosResult.Fill(dtResult);

                //foreach (DataRow lista in dtResult.Rows)
                //{
                //    string fechahora = "";

                //    fechahora = lista["Fecha"].ToString(); ;


                //}




            }
            catch (Exception ex)
            {
                dtResult = null;
                rpta = ex.Message;
                //throw ex;
            }
            return dtResult;


        }

        //public DataTable metbuscarfechacierre(string fechah, string fechad, int nrocaja)
        //{
        //    string rpta = "";
        //    SqlConnection cn = new SqlConnection(Conexion.conexion);
        //    //le asigno en el constructor el nombre de la tabla
        //    DataTable dtResult = new DataTable("fondo_mov_caja");
        //    try
        //    {
        //        cn.Open();

        //        SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_CAJA");

        //        SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 11);
        //        comando.Parameters.Add(parModo);

        //        SqlParameter parfecha = ProcAlmacenado.asignarParametros("@FechaD", SqlDbType.DateTime, fechad);
        //        comando.Parameters.Add(parfecha);

        //        SqlParameter parfecha1 = ProcAlmacenado.asignarParametros("@FechaH", SqlDbType.DateTime, fechah);
        //        comando.Parameters.Add(parfecha1);

        //        SqlParameter parnrocaja = ProcAlmacenado.asignarParametros("@id_caja", SqlDbType.Int, nrocaja);
        //        comando.Parameters.Add(parnrocaja);




        //        //creo el objeto adapter del data provider le paso el sqlcommand
        //        SqlDataAdapter datosResult = new SqlDataAdapter(comando);
        //        //los resultados los actualizo en el datatable dtResult
        //        datosResult.Fill(dtResult);

        //        foreach (DataRow lista in dtResult.Rows)
        //        {
        //            string fechahora = "";

        //            fechahora = lista["Fecha"].ToString(); ;


        //        }




        //    }
        //    catch (Exception ex)
        //    {
        //        dtResult = null;
        //        rpta = ex.Message;
        //        //throw ex;
        //    }
        //    return dtResult;


        //}

    }
}
