using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Name:" + textBox1.Text + "\n Email:" + textBox2.Text + "\n Phone:" + textBox3.Text + "\n Subject:" + textBox4.Text + "\n University:" + textBox5.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String  name;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            String email;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            String phone; 
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            String subject;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
             String university;
        }
    }
}
