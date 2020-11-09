using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        float x;
        float y;
        String Operation;
        String result;
        float r;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
                textBox2.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
                textBox2.Text += "0";
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (Operation == "+")
            {
                y = float.Parse(textBox1.Text);
                r = x + y;
                result = result + "+"+ textBox1.Text;
               
            }
            if (Operation == "-")
            {
                y = float.Parse(textBox1.Text);
                r = x - y;
            }
            if (Operation == "X")
            {
                y = float.Parse(textBox1.Text);
                r = x * y;
            }
            if (this.Operation == "/")
            {
                y = float.Parse(textBox1.Text);
                if (y == 0)
                {
                    MessageBox.Show("Cannot divide by 0. The result becomes infinite");
                }
                r = x / y;
            }
            result = r.ToString();
            textBox1.Text = result;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
                textBox2.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
                textBox2.Text += "3";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
                textBox2.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
                textBox2.Text += "1";
            }
           


        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
                textBox2.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
                textBox2.Text += "2";
            }
           

            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
                textBox2.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
                textBox2.Text += "4";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
                textBox2.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
                textBox2.Text += "5";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
                textBox2.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
                textBox2.Text += "6";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
                textBox2.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
                textBox2.Text += "7";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
                textBox2.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
                textBox2.Text += "8";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
                textBox2.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
                textBox2.Text += "9";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            x = float.Parse(textBox1.Text);
            textBox1.Text = "0";
            textBox1.Clear();
            Operation = "+";

            textBox2.Text = (textBox2.Text) + Operation;
           
            
        }

        private void button12_Click(object sender, EventArgs e)
        {

            x = float.Parse(textBox1.Text);
            textBox1.Text = "0";
            textBox1.Clear();
            Operation = "-";
            textBox2.Text = (textBox2.Text) + Operation;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            x = float.Parse(textBox1.Text);
            textBox1.Text = "0";
            textBox1.Clear();
            Operation = "X";

            textBox2.Text = (textBox2.Text) + Operation;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = float.Parse(textBox1.Text);
            textBox1.Text = "0";
            textBox1.Clear();
            Operation = "/";

            textBox2.Text = (textBox2.Text) + Operation;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Times new Roman", 22); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
            Operation = ".";

            textBox2.Text = (textBox2.Text) + Operation;

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            double val = double.Parse(textBox1.Text);
            double sqr = val* val;
            String ans = "" + sqr;
            textBox1.Text = ans;
            Operation = "²";
            textBox2.Text = (textBox2.Text) + Operation;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double val = double.Parse(textBox1.Text);
            double sqrt = Math.Sqrt(val);
            String ans = "" + sqrt;
            textBox1.Text = ans;
            Operation = "√";
            textBox2.Text =  Operation+ (textBox2.Text);
            
        }
    }
}
