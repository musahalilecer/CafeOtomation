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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 doner = new Form2();
            doner.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 icecekler = new Form3();
            icecekler.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 tatlilar = new Form4();
            tatlilar.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int hesap = Form2.hesapD + Form3.hesapT;
            textBox3.Text = hesap.ToString();
        }
    }
}
