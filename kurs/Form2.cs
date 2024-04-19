using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurs
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Form3 r = new Form3();
            r.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form4 t = new Form4();
            t.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form4 t = new Form4();
            t.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form4 t = new Form4();
            t.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form4 t = new Form4();
            t.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form4 t = new Form4();
            t.ShowDialog();
        }
    }
}
