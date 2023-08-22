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
    public partial class Form2 : Form
    {
        //   int hesapD = 0;
        int c1=0,c2=0,c3=0,c4=0;
        public Form2()
        {
            InitializeComponent();
        }
        public static int hesapD = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            hesapD += 25;
            textBox6.Text = hesapD.ToString();
            c1++;
            label5.Text = c1.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (c1 > 0)
            {
                hesapD -= 25;
                textBox6.Text = hesapD.ToString();
                c1--;
                label5.Text = c1.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (c2 > 0)
            {
                hesapD -= 45;
                textBox6.Text = hesapD.ToString();
                c2--;
                label6.Text = c2.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (c3 > 0)
            {
                hesapD -= 35;
                textBox6.Text = hesapD.ToString();
                c3--;
                label7.Text = c3.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (c4 > 0)
            {
                hesapD -= 40;
                textBox6.Text = hesapD.ToString();
                c4--;
                label8.Text = c4.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox7.Text = "Sipariş Verildi";
            textBox6.Text = hesapD.ToString();
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            hesapD += 45;
            textBox6.Text = hesapD.ToString();
            c2++;
            label6.Text = c2.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hesapD += 35;
            textBox6.Text = hesapD.ToString();
            c3++;
            label7.Text = c3.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hesapD += 40;
            textBox6.Text = hesapD.ToString();
            c4++;
            label8.Text = c4.ToString();
        }
    }
}
