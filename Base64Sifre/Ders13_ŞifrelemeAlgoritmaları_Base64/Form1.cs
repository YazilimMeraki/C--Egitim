using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders13_ŞifrelemeAlgoritmaları_Base64
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Şifleme için
        private void button1_Click(object sender, EventArgs e)
        {
            // Base 64 8 bitlik dizileri 64 bite çevirir.
            string anametin = textBox1.Text;
            // Byte dizisi oluşturdul. ASCIIEndocing formatı her karakterin bilgisayar karşılığıdır.
            // Anametni byte olarak al komutu verdik.
            byte[] veridizimi = ASCIIEncoding.ASCII.GetBytes(anametin);
            // Veridizimi adlı diziyi base64string formatına çevirdik.
            string şifrelimetin = Convert.ToBase64String(veridizimi);
            // Textbox a şifreli metni yazdırdık.
            textBox2.Text = şifrelimetin;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Şifreyi çözmek için.
            // Metni eşleştirdik.
            string metinçöz = textBox2.Text;
            // Byte dizisi oluşturduk ve base64stringten metincözü dönüştürdük.
            byte[] veridizimcözülen = Convert.FromBase64String(metinçöz);
            // Anametin2 yi ASSCI deb get string'e dönüştürdük.
            string anametin2 = ASCIIEncoding.ASCII.GetString(veridizimcözülen);
            // Metni yazdırdık.
            textBox1.Text = anametin2;

        }
    }
}
