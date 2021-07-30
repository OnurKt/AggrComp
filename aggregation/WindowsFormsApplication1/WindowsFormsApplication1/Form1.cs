using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Motor m = new Motor();
            m.Beygir = Convert.ToInt32(beygirTxt.Text);
            m.Mgucu = Convert.ToInt32(mGucuTxt.Text);
            m.Tork = Convert.ToInt32(torkTxt.Text);
            //aggregation
            Otomobil otom = new Otomobil();
            otom.KapiSayisi = Convert.ToInt32(kapiSayiTxt.Text);
            otom.Renk = renkTxt.Text;
            otom.Motoru = m;
            listBox1.Items.Add(otom);

        }
    }
}
