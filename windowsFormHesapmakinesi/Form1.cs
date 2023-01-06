using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsFormHesapmakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   
        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text); //string ifadeyi double tipine çevirme
            double sayi2 = Convert.ToDouble(textBox2.Text);

            double sonuc = sayi1 + sayi2;

            textBox3.Text = sonuc.ToString(); //double ifadeyi string olarak yazdırma
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text); //string ifadeyi double tipine çevirme
            double sayi2 = Convert.ToDouble(textBox2.Text);

            double sonuc = sayi1 * sayi2;

            textBox3.Text = sonuc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text); //string ifadeyi double tipine çevirme
            double sayi2 = Convert.ToDouble(textBox2.Text);

            if (sayi2 != 0)
            {
                double sonuc = sayi1 / sayi2;
                textBox3.Text = sonuc.ToString();
            }

            else
            {
                MessageBox.Show("Sıfıra bölüm tanımsızdır.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text); //string ifadeyi double tipine çevirme
            double sayi2 = Convert.ToDouble(textBox2.Text);

            double sonuc = sayi1 - sayi2;

            textBox3.Text = sonuc.ToString();
        }
    }
}
