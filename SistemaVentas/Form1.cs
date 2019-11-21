using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace SistemaVentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAbono_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BarcodeWriter br = new BarcodeWriter();
            br.Format = BarcodeFormat.EAN_13;
            Bitmap bm = new Bitmap(br.Write("0000000239417"), 300, 300);
            pictureBox1.Image = bm;

        }
    }
}
