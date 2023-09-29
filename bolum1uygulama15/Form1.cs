using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bolum1uygulama15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int etiketFiyat;
            double indirimliFiyat;
            etiketFiyat = Convert.ToInt32(textBox1.Text);
            indirimliFiyat = etiketFiyat - etiketFiyat * 0.10;
            label3.Text = indirimliFiyat.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int etiketFiyat;
            double indirimliFiyat;
            etiketFiyat = Convert.ToInt32(textBox1.Text);
            indirimliFiyat = etiketFiyat - etiketFiyat * 0.20;
            label3.Text = indirimliFiyat.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int etiketFiyat;
            double indirimliFiyat;
            etiketFiyat = Convert.ToInt32(textBox1.Text);
            indirimliFiyat = etiketFiyat - etiketFiyat * 0.30;
            label3.Text = indirimliFiyat.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int etiketFiyat;
            double indirimliFiyat;
            etiketFiyat = Convert.ToInt32(textBox1.Text);
            indirimliFiyat = etiketFiyat - etiketFiyat * 0.40;
            label3.Text = indirimliFiyat.ToString();
        }
    }
}
