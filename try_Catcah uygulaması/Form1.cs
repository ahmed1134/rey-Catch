using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace try_Catcah_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi3 = Convert.ToInt32(textBox3.Text);
            int sayi4 = Convert.ToInt32(textBox4.Text);
            int toplam = sayi3 + sayi4;
            label3.Text = toplam.ToString();
            try
            {
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                int toplama = sayi1 + sayi2;
                label3.Text = toplam.ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("hata var");
            }
        }
    }
}
