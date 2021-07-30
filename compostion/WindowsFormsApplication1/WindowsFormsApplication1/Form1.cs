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
            Otomobil oto = new Otomobil();
            oto.KapiSayisi = Convert.ToInt32(kapiSayiTxt.Text);
            oto.Renk = renkTxt.Text;
            oto.MGucu.Tork = Convert.ToInt32(torkTxt.Text);
            oto.MGucu.Mgucu = Convert.ToInt32(mGucuTxt.Text);
            oto.MGucu.Beygir = Convert.ToInt32(beygirTxt.Text);
            listBox1.Items.Add(oto);
        }
    }
}
