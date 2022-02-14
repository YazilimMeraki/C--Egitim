using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders20_SezarŞifrelemeAlgoritması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            //Önce değişken tanımladık.
            string veri = "";
            // Textboxtan verileri aldık.
            veri = textBox1.Text;
            // Veri değerini char dizisine ata dedik.
            char[] karakterler = veri.ToCharArray();
            // char eleman dizisi oluşturup.Karakterler dizisini oraya bağladık.
            foreach (char eleman in karakterler)
            {
                textBox2.Text += Convert.ToChar(eleman+3).ToString();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            //Önce değişken tanımladık.
            string sifre = "";
            // Textboxtan verileri aldık.
            sifre = textBox2.Text;
            // Veri değerini char dizisine ata dedik.
            char[] karakterler2 = sifre.ToCharArray();
            // char eleman dizisi oluşturup.Karakterler dizisini oraya bağladık.
            foreach (char eleman2 in karakterler2)
            {
                textBox1.Text += Convert.ToChar(eleman2 - 3).ToString();
            }
        }
    }
}
