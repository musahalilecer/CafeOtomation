using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form3 : Form
    {
        int c1, c2 = 0;
        public Form3()
        {
            InitializeComponent();
        }
        public static int hesapT = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            hesapT += 35;
            textBox5.Text = hesapT.ToString();
            c2++;
            label3.Text = c2.ToString();
            textBox5.Text = hesapT.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (c1 > 0)
            {
                c1--;
                label4.Text= c1.ToString();
                hesapT -= 25;
                textBox5.Text = hesapT.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (c2 > 0)
            {
                c2--;
                label3.Text = c2.ToString();
                hesapT -= 35;
                textBox5.Text = hesapT.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Text = "Siparis Verildi";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hesapT += 25;
            textBox5.Text= hesapT.ToString();
            c1++;
            label4.Text = c1.ToString();
            textBox5.Text = hesapT.ToString();
        }
    }
}
