﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_negocio;

namespace Capa_Presentacion
{
    public partial class Frmstockmov : Form
    {
        public Frmstockmov()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            NegocioMovStock objstock = new NegocioMovStock();

            DTStock.DataSource = NegocioMovStock.buscarFecha(TPinicio.Text, TPfin.Text);
        }
    }
}
