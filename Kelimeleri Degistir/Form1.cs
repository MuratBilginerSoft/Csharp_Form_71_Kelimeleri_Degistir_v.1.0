using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kelimeleri_Degistir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;

            string aranan = textBox2.Text;

            string değişecek = textBox3.Text;

            bool x = metin.Contains(aranan);

            if (x)
            {
                metin = metin.Replace(aranan, değişecek);
                textBox1.Text = metin;
            }
        }
    }
}
