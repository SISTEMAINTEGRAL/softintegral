using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Datos;


    public class Dventa
    {
        private int cuotas;

        public int Cuotas
        {
            get { return cuotas; }
            set { cuotas = value; }
        }

        private decimal importe;

        public decimal Importe
        {
            get { return importe; }
            set { importe = value; }
        }

        private string lote;

        public string Lote
        {
            get { return lote; }
            set { lote = value; }
        }

        private string cupon;

        public string Cupon
        {
            get { return cupon; }
            set { cupon = value; }
        }

        private int codtarjeta;

        public int Codtarjeta
        {
            get { return codtarjeta; }
            set { codtarjeta = value; }
        }

        private int nroterminal;

        public int Nroterminal
        {
            get { return nroterminal; }
            set { nroterminal = value; }
        }

        private int codformapago;

        public int Codformapago
        {
            get { return codformapago; }
            set { codformapago = value; }
        }

        private bool constock;

        public bool Constock
        {
            get { return constock; }
            set { constock = value; }
        }

        private bool concaja;

        public bool Concaja
        {
            get { return concaja; }
            set { concaja = value; }
        }

        private int idventa;

        public int Idventa
        {
            get { return idventa; }
            set { idventa = value; }
        }
        private char estado;

        public char Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        private int idcliente;

        public int Idcliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private string tipo_comprobante;

        public string Tipo_comprobante
        {
            get { return tipo_comprobante; }
            set { tipo_comprobante = value; }
        }
        private string serie;

        public string Serie
        {
            get { return serie; }
            set { serie = value; }
        }
        private string nrocomprobante;

        public string Nrocomprobante
        {
            get { return nrocomprobante; }
            set { nrocomprobante = value; }
        }

       
        private decimal  iva;

        public decimal  Iva
        {
            get { return iva; }
            set { iva = value; }
        }
        private int trabajador;

        public int Trabajador
        {
            get { return trabajador; }
            set { trabajador = value; }
        }

        private string usuario;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private decimal total;

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        private decimal descuento;

        public decimal Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }

        private decimal subtotal;

        public decimal Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }
        
    
   

    public decimal Totalneto
    {
        get
        {
            return totalneto;
        }

        set
        {
            totalneto = value;
        }
    }

    public decimal Precioiva
    {
        get
        {
            return precioiva;
        }

        set
        {
            precioiva = value;
        }
    }

    public string Cae
    {
        get
        {
            return cae;
        }

        set
        {
            cae = value;
        }
    }

    public string Caevencimiento
    {
        get
        {
            return caevencimiento;
        }

        set
        {
            caevencimiento = value;
        }
    }

    public string Numerotipofactura
    {
        get
        {
            return numerotipofactura;
        }

        set
        {
            numerotipofactura = value;
        }
    }

    public int Idequipo
    {
        get
        {
            return idequipo;
        }

        set
        {
            idequipo = value;
        }
    }

    public string Puntoventa
    {
        get
        {
            return puntoventa;
        }

        set
        {
            puntoventa = value;
        }
    }

    public decimal Totalneto105
    {
        get
        {
            return totalneto105;
        }

        set
        {
            totalneto105 = value;
        }
    }

    public decimal Precioiva105
    {
        get
        {
            return precioiva105;
        }

        set
        {
            precioiva105 = value;
        }
    }

    private int idequipo;
    private decimal totalneto;
    private decimal precioiva;
    private string cae;
    private string caevencimiento;
    private string numerotipofactura;
    private string puntoventa;
    private decimal totalneto105;
    private decimal precioiva105;
        public Dventa()
        { }
        public Dventa(int trabajador, int idventa, int idcliente, DateTime fecha, string tipo_comprobante, string serie,string varnrocomprobante, decimal iva)
        {
            this.idventa = idventa;
            this.idcliente = idcliente;
            this.trabajador = trabajador;
            this.fecha = fecha;
            this.tipo_comprobante = tipo_comprobante;
            this.nrocomprobante  = varnrocomprobante;
            this.serie = serie;
            this.iva = iva; 

        }

        public Dventa(char estado,bool concaja,string tipocomprobante)
        {
            this.estado = estado;
            this.concaja = concaja;
            this.tipo_comprobante = tipocomprobante;
          
        }

    public Dventa(int varidventa, int idequipo)
    {
        this.idventa = varidventa;
        this.idequipo = idequipo;
    }

        //Metodo

       

        public string Insertar(Dventa Venta, List <DDetalle_Venta> Detalle, bool distock = false)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            DatosMovStock objstock = new Capa_Datos.DatosMovStock();

            try
            {
                sqlcon.ConnectionString = Conexion.conexion;
                sqlcon.Open();

                SqlTransaction sqltra = sqlcon.BeginTransaction();

                
                SqlCommand sqlcmd = ProcAlmacenado.CrearProc(sqlcon, "SP_VENTA",sqltra);
       
                SqlParameter paridventa = ProcAlmacenado.asignarParametros("@idventa", SqlDbType.Int);
                sqlcmd.Parameters.Add(paridventa);
                
                SqlParameter paridcliente = ProcAlmacenado.asignarParametros("@idcliente", SqlDbType.Int, Venta.idcliente);
                sqlcmd.Parameters.Add(paridcliente);

                SqlParameter parfecha = ProcAlmacenado.asignarParametros("@fecha", SqlDbType.DateTime, Venta.fecha);
                sqlcmd.Parameters.Add(parfecha);

                SqlParameter partipocomprobante = ProcAlmacenado.asignarParametros("@tipo_comprobante", SqlDbType.VarChar, Venta.tipo_comprobante);
                sqlcmd.Parameters.Add(partipocomprobante);

                SqlParameter pariva = ProcAlmacenado.asignarParametros("@iva", SqlDbType.Decimal, Venta.iva);
                sqlcmd.Parameters.Add(pariva);

                SqlParameter parconcaja = ProcAlmacenado.asignarParametros("@concaja", SqlDbType.Bit , Venta.concaja );
                sqlcmd.Parameters.Add(parconcaja);

                SqlParameter parconstock = ProcAlmacenado.asignarParametros("@constock", SqlDbType.Bit, distock);
                sqlcmd.Parameters.Add(parconstock);

                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 1);
                sqlcmd.Parameters.Add(parModo);

                SqlParameter parUsuario = ProcAlmacenado.asignarParametros("@usuario", SqlDbType.NVarChar, Venta.Usuario);
                sqlcmd.Parameters.Add(parUsuario);

                SqlParameter parDescuento = ProcAlmacenado.asignarParametros("@descuento", SqlDbType.Decimal, Venta.descuento);
                sqlcmd.Parameters.Add(parDescuento);

                SqlParameter parTotal = ProcAlmacenado.asignarParametros("@total", SqlDbType.Decimal, Venta.total);
                sqlcmd.Parameters.Add(parTotal);

                SqlParameter parSubtotal = ProcAlmacenado.asignarParametros("@subtotal", SqlDbType.Decimal, Venta.subtotal);
                sqlcmd.Parameters.Add(parSubtotal);

                SqlParameter parEstado = ProcAlmacenado.asignarParametros("@estado", SqlDbType.Char, Venta.estado);
                sqlcmd.Parameters.Add(parEstado);

                SqlParameter parNroterminal = ProcAlmacenado.asignarParametros("@nroterminal", SqlDbType.Int, Venta.nroterminal);
                sqlcmd.Parameters.Add(parNroterminal);

                SqlParameter parCodtarjeta = ProcAlmacenado.asignarParametros("@Codigotarjeta", SqlDbType.Int, Venta.codtarjeta);
                sqlcmd.Parameters.Add(parCodtarjeta);

                SqlParameter parCupon = ProcAlmacenado.asignarParametros("@cupon", SqlDbType.NVarChar, Venta.cupon);
                sqlcmd.Parameters.Add(parCupon);

                SqlParameter parLote = ProcAlmacenado.asignarParametros("@lote", SqlDbType.NVarChar, Venta.lote);
               sqlcmd.Parameters.Add(parLote);

                SqlParameter parImportecuota = ProcAlmacenado.asignarParametros("@importe", SqlDbType.Decimal, Venta.importe);
                sqlcmd.Parameters.Add(parImportecuota);

                SqlParameter parCuota = ProcAlmacenado.asignarParametros("@cuota", SqlDbType.Int, Venta.cuotas);
                sqlcmd.Parameters.Add(parCuota);

                SqlParameter parFormapago = ProcAlmacenado.asignarParametros("@codformapago", SqlDbType.Int, Venta.codformapago);
                sqlcmd.Parameters.Add(parFormapago);

                SqlParameter parNrocomprobante = ProcAlmacenado.asignarParametros("@nrocomprobante", SqlDbType.NVarChar, Venta.nrocomprobante);
                sqlcmd.Parameters.Add(parNrocomprobante);

            SqlParameter parTotalneto = ProcAlmacenado.asignarParametros("@totalneto", SqlDbType.Decimal, Venta.totalneto);
            sqlcmd.Parameters.Add(parTotalneto);
            SqlParameter parPrecioiva = ProcAlmacenado.asignarParametros("@precioiva", SqlDbType.Decimal, Venta.precioiva);
            sqlcmd.Parameters.Add(parPrecioiva);
            SqlParameter parcae = ProcAlmacenado.asignarParametros("@cae", SqlDbType.NVarChar, Venta.cae );
            sqlcmd.Parameters.Add(parcae);
            SqlParameter parcaefechavto = ProcAlmacenado.asignarParametros("@caefechavencimiento", SqlDbType.NVarChar, Venta.caevencimiento);
            sqlcmd.Parameters.Add(parcaefechavto);
            
            SqlParameter partipofactura = ProcAlmacenado.asignarParametros("@tipofactura", SqlDbType.NVarChar, Venta.numerotipofactura);
            sqlcmd.Parameters.Add(partipofactura);

            SqlParameter parpuntoventa = ProcAlmacenado.asignarParametros("@puntoventa", SqlDbType.NVarChar, Venta.puntoventa);
            sqlcmd.Parameters.Add(parpuntoventa);

            SqlParameter parneto105 = ProcAlmacenado.asignarParametros("@totalneto105", SqlDbType.Decimal, Venta.Totalneto105);
            sqlcmd.Parameters.Add(parneto105);

            SqlParameter pariva105= ProcAlmacenado.asignarParametros("@precioiva105", SqlDbType.Decimal, Venta.Precioiva105);
            sqlcmd.Parameters.Add(pariva105);

            rpta = sqlcmd.ExecuteNonQuery () >= 1 ? "OK" : "No se ingreso el registro";

                if (rpta.Equals("OK"))
                {
                    Venta.Idventa   = Convert.ToInt32(sqlcmd.Parameters["@idventa"].Value);
                
                    
                    foreach (DDetalle_Venta det in Detalle)
                    {
                        det.Idventa = Venta.idventa;
                        rpta = det.Insertar(det, ref sqlcon, ref sqltra);
                        if (!rpta.Equals("OK"))
                        {
                            break;
                        }
                        else
                        {
                            //actualizamos el stock
                            if (distock == true && det.Idarticulo != 0) { rpta = objstock.Modificarstock(det.Idarticulo, det.Cantidad,ref sqlcon,ref sqltra,"egreso"); }  
                            if (!rpta.Equals("OK") && !rpta.Equals("ok"))
                            {
                                break;

                            }
                        }

                    }

                if (Venta.codformapago == 3)
                {
                    DatosCliente objcliente = new DatosCliente(ref sqlcon, ref sqltra,Venta.idcliente,Venta.idventa ,Venta.total,Venta.total,0,"pendiente","ingresarctacte");
                    objcliente.agregaromodificarctacte(objcliente, "ingresarctacte");
                }
            }

                if (rpta.Equals("OK") || rpta.Equals("ok"))
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

        public string Eliminar(Dventa venta)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.conexion;
                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "speliminar_venta";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paridventa = ProcAlmacenado.asignarParametros("@idventa", SqlDbType.Int, venta.idventa);
                sqlcmd.Parameters.Add(paridventa);

                rpta = sqlcmd.ExecuteNonQuery() == 1 ? "OK" : "No se anulo registro";
            
            }
            catch
            {
                
            }
            return rpta;
        }

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("venta");
            SqlConnection cn = new SqlConnection(Conexion.conexion);

            try
            {
                cn.Open();

                SqlCommand sqlcmd = ProcAlmacenado.CrearProc(cn, "SP_VENTA");
                //Modo 4 Mostrar
                SqlParameter parModo = ProcAlmacenado.asignarParametros("modo", SqlDbType.Int, 4);
                sqlcmd.Parameters.Add(parModo);


                SqlDataAdapter sqldat = new SqlDataAdapter(sqlcmd);
                sqldat.Fill(DtResultado );
            }
            catch (Exception ex)
            {
                DtResultado = null;
                throw ex;
            }
            return DtResultado;
        }

        public DataTable mostrarRanking5Productos()
        {
            DataTable DtResultado = new DataTable("venta");
            SqlConnection cn = new SqlConnection(Conexion.conexion);

            try
            {
                cn.Open();

                SqlCommand sqlcmd = ProcAlmacenado.CrearProc(cn, "SP_VENTA");
                //Modo 7 Mostrar
                SqlParameter parModo = ProcAlmacenado.asignarParametros("modo", SqlDbType.Int, 7);
                sqlcmd.Parameters.Add(parModo);


                SqlDataAdapter sqldat = new SqlDataAdapter(sqlcmd);
                sqldat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
                throw ex;
            }
            return DtResultado;
        }

        public DataTable  BuscarFechas(string TextoBuscar, string TextoBuscar2)
        {
            DataTable DtResultado = new DataTable("venta");
            SqlConnection sqlcon = new SqlConnection(Conexion.conexion);
            try
            {


                SqlCommand sqlcmd = ProcAlmacenado.CrearProc(sqlcon, "SP_VENTA");

                //modo 2 para la busqueda
                SqlParameter parModo = ProcAlmacenado.asignarParametros("modo", SqlDbType.Int,2);
                sqlcmd.Parameters.Add( parModo);

                SqlParameter partextobuscar = ProcAlmacenado.asignarParametros("textobuscar", SqlDbType.VarChar, TextoBuscar );
                sqlcmd.Parameters.Add(partextobuscar);

                SqlParameter partextobuscar2 = ProcAlmacenado.asignarParametros("textobuscar2", SqlDbType.VarChar, TextoBuscar2 );
                sqlcmd.Parameters.Add(partextobuscar2);

                SqlParameter parEstado = ProcAlmacenado.asignarParametros("estado", SqlDbType.VarChar, this.estado);
                sqlcmd.Parameters.Add(parEstado);

                SqlParameter parConcaja = ProcAlmacenado.asignarParametros("concaja", SqlDbType.Bit, this.concaja);
                sqlcmd.Parameters.Add(parConcaja);

                SqlParameter parTipocomprobante = ProcAlmacenado.asignarParametros("tipo_comprobante",SqlDbType.NVarChar, this.tipo_comprobante);
                sqlcmd.Parameters.Add(parTipocomprobante);


                SqlDataAdapter sqldat = new SqlDataAdapter(sqlcmd);
                sqldat.Fill(DtResultado);

            }
            catch (Exception ex)
            { 
               DtResultado = null ;
               sqlcon.Close();
               //lanzo una excepcion en el caso de problemas con bd
               throw ex;
            }

            return DtResultado;
        }
        public DataTable MostrarDetalle(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("detalle_venta");
            SqlConnection sqlcon = new SqlConnection(Conexion.conexion);
            try
            {


                SqlCommand sqlcmd = ProcAlmacenado.CrearProc(sqlcon, "SP_DETALLEVENTA");

                SqlParameter partextobuscar = ProcAlmacenado.asignarParametros("@textobuscar", SqlDbType.VarChar, TextoBuscar );
                sqlcmd.Parameters.Add(partextobuscar);

 
                //modo 2 mostrar
                SqlParameter parModo = ProcAlmacenado.asignarParametros("@modo", SqlDbType.Int, 2);
                sqlcmd.Parameters.Add(parModo);

                SqlDataAdapter sqldat = new SqlDataAdapter(sqlcmd);
                sqldat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return DtResultado; 
        }

        //extrae todos los datos de la ultima venta realizada
        public DataTable notaDeVenta()
        {
            DataTable dtResultado = new DataTable("venta");

              SqlConnection cn = new SqlConnection(Conexion.conexion);
            try
            {
                cn.Open();
              
               SqlCommand comando= ProcAlmacenado.CrearProc(cn, "SP_VENTA");
                //Modo 5 nota de venta
                SqlParameter parModo =ProcAlmacenado.asignarParametros("modo", SqlDbType.Int,2);
                comando.Parameters.Add(parModo);

                SqlParameter paridVenta = ProcAlmacenado.asignarParametros("idventa", SqlDbType.Int);
                comando.Parameters.Add(paridVenta);

                SqlDataAdapter datosResult = new SqlDataAdapter(comando);
                //los resultados los actualizo en el datatable dtResult
                datosResult.Fill(dtResultado);
                cn.Close();
            }
            catch (Exception ex)
            {
                dtResultado = null;
                cn.Close();
                //lanzo una excepcion en el caso de problemas con bd
                throw ex;
            }
            return dtResultado;
        }

        public string CambiarEstadoVenta(Dventa venta, int mod = 6)
        {
            string resultado="";
           

            try
            {
                SqlConnection cn = new SqlConnection(Conexion.conexion);
                cn.Open();
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_VENTA");

                //modo 6
                SqlParameter parModo= ProcAlmacenado.asignarParametros("modo",SqlDbType.Int,mod);
                comando.Parameters.Add(parModo);

                SqlParameter parIdVenta = ProcAlmacenado.asignarParametros("idventa", SqlDbType.Int,venta.Idventa);
                comando.Parameters.Add(parIdVenta);

                if (mod == 6)
                {
                    SqlParameter parEstado = ProcAlmacenado.asignarParametros("estado", SqlDbType.VarChar, venta.Estado);
                    comando.Parameters.Add(parEstado);
                    SqlParameter parComprobante = ProcAlmacenado.asignarParametros("nrocomprobante", SqlDbType.VarChar, venta.nrocomprobante);
                    comando.Parameters.Add(parComprobante);

                }
                else
                {
                    SqlParameter parCaja = ProcAlmacenado.asignarParametros("concaja", SqlDbType.Bit, venta.concaja);
                    comando.Parameters.Add(parCaja);
                    SqlParameter parStock = ProcAlmacenado.asignarParametros("constock", SqlDbType.Bit, venta.constock);
                    comando.Parameters.Add(parStock);

                }

                resultado = comando.ExecuteNonQuery() == 1 ? "ok" : "Error";

            }
            catch (Exception ex)
            {
               
                resultado = "Error: " + ex.Message;
            }

            return resultado;
        }
        public DataTable Tarjeta(int modo = 9, int codigotarjeta = 0)
        {
            try
            {
                 SqlConnection cn = new SqlConnection(Conexion.conexion);
                 DataTable midata = new DataTable();
                cn.Open();
                SqlCommand comando = ProcAlmacenado.CrearProc(cn, "SP_VENTA");
                
                SqlParameter parModo = ProcAlmacenado.asignarParametros("modo", SqlDbType.Int, modo);
                comando.Parameters.Add(parModo);

                SqlParameter parcodigo = ProcAlmacenado.asignarParametros("Codigotarjeta", SqlDbType.Int, codigotarjeta);
                comando.Parameters.Add(parcodigo);

                SqlDataAdapter datosResult = new SqlDataAdapter(comando);
                //los resultados los actualizo en el datatable dtResult
                
                datosResult.Fill (midata);
                cn.Close();
                return midata;
            }
            catch (Exception)
            {
                
                throw;
            }
        
        }
    public DataTable reporteventa(Dventa parventa)
    {
        try
        {
            SqlConnection cn = new SqlConnection(Conexion.conexion);
            DataTable midata = new DataTable();
            cn.Open();
            SqlCommand comando = ProcAlmacenado.CrearProc(cn, "REPORTE_VENTAS");

            SqlParameter parVenta = ProcAlmacenado.asignarParametros("@idventa", SqlDbType.Int, parventa.idventa);
            comando.Parameters.Add(parVenta);

            SqlParameter parPuntoventa = ProcAlmacenado.asignarParametros("@idequipo", SqlDbType.Int, parventa.idequipo);
            comando.Parameters.Add(parPuntoventa);

            SqlDataAdapter datosResult = new SqlDataAdapter(comando);
            //los resultados los actualizo en el datatable dtResult

            datosResult.Fill(midata);
            cn.Close();
            return midata;
        }
        catch (Exception)
        {

            throw;
        }

    }
   
    }   



