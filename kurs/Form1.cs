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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            passB.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked) 
            {
                passB.UseSystemPasswordChar = false;
            }
            else
            {
                passB.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (loginB.Text == "Artem" && passB.Text == "123")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Вы ввели неправильный логин или пароль! Проверьте ещё раз");
            }
        }
    }
}
