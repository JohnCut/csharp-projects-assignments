using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gelirGiderOranlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double gelirKayit = Convert.ToDouble(gelir_tb.Text);
            double giderZ = Convert.ToDouble(giderZ_tb.Text);
            double giderI = Convert.ToDouble(giderI_tb.Text);
            double netAylik = 0;
            double kalanZ = 0;
            double kalanI = 0;
            bool gectiZ = false;
            bool gectiI = false;

        public static double NetAylikHesapla(double x, double y, double z)
        {
            Form1.netAylik =
            return;
        }

    }

        
    }
}
