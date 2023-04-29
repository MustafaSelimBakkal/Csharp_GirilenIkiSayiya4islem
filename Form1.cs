using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Topla_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            toplam = sayi1 + sayi2; sayi2 = Convert.ToInt16(textBox2.Text);
            textBox3.Text = toplam.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, carpim;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            carpim = sayi1 * sayi2; sayi2 = Convert.ToInt16(textBox2.Text);
            textBox3.Text = carpim.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            sonuc= sayi1 - sayi2; sayi2 = Convert.ToInt16(textBox2.Text);
            sonuc = sayi1 - sayi2; sayi2 = Convert.ToInt16(textBox2.Text);
            textBox3.Text = sonuc.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            sonuc = sayi1 / sayi2; sayi2 = Convert.ToInt16(textBox2.Text);
            sonuc = sayi1 / sayi2; sayi2 = Convert.ToInt16(textBox2.Text);
            textBox3.Text = sonuc.ToString();

        }
    }
}
