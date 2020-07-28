using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Presentacion.Reportes;
using Capa_negocio;

namespace Capa_Presentacion.Formreportes
{
    public partial class FrmTicketRemito : Form
    {
        private string nroremito;
        public FrmTicketRemito(string  varnroremito)
        {
            InitializeComponent();
            nroremito = varnroremito;

        }

        private void FrmTicketRemito_Load(object sender, EventArgs e)
        {
            imprimir();
        }
        private void imprimir()
        {
            bool flag = true;
            DataTable midatatable = new DataTable();
            REPORTE_REMITO miticket;
            REPORT_TICKET_REMITO miticket1;
            string valorenletra = "";

            try
            {

                midatatable = NegocioRemito.Reporteremito(nroremito);
                
                // para A4
                miticket = new REPORTE_REMITO();
                // para ticket
                miticket1 = new REPORT_TICKET_REMITO();

               
                miticket.table1.DataSource = midatatable;
                miticket1.table1.DataSource = midatatable;

                miticket.DataSource = midatatable;
                miticket1.DataSource = midatatable;

                switch (NegocioConfigEmpresa.formatoimpremito )
                {
                    case "TICKET56":
                        {
                            if (midatatable.Rows.Count != 0)
                            {
                                DataRow row = midatatable.Rows[0];

                                if (Convert.ToInt32(row["idclientempresa"].ToString()) != 1)
                                {
                                    miticket1.textBox1.Value = row["empresaentrega"].ToString();
                                    miticket1.textBox2.Value = row["cuitempresa"].ToString();
                                    miticket1.textBox3.Value = row["direccionentrega"].ToString();
                                }
                                reportViewer1.Report = miticket1;

                                reportViewer1.RefreshReport();
                            }
                            break;
                        }
                    case "A4":
                        {
                            if (midatatable.Rows.Count != 0)
                            {
                                DataRow row = midatatable.Rows[0];

                                if (Convert.ToInt32(row["idclientempresa"].ToString()) != 1)
                                {
                                    miticket.textBox5.Value = row["empresaentrega"].ToString();
                                    miticket.textBox6.Value = row["cuitempresa"].ToString();
                                    miticket.textBox7.Value = row["direccionentrega"].ToString();


                                }
                                reportViewer1.Report = miticket;

                                reportViewer1.RefreshReport();
                            }
                            break;
                        }
                    default:
                        break;
                }

               
                   
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
