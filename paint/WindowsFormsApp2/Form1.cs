using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Red, 2);
            g.DrawLine(myPen, 0, 0, 100, 100);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            Point pt1 = new Point(0, 0); //create a point pt1 object
            Point pt2 = new Point(200, 200); //create a point pt2 object
            Rectangle rect1 = new Rectangle(50, 80, 100, 130); // rect1 object
            Graphics g = e.Graphics; // get a reference to Graphics object
            Pen myBlackPen = new Pen(Color.Black, 5); //create a pen object

            // call the DrawLine() method of the graphics object
            g.DrawLine(myBlackPen, pt1, pt2);
            g.DrawLine(myBlackPen, 0, 50, 200, 50);

            // call the DrawEllipse() method of the graphics object
            g.DrawEllipse(myBlackPen, 50, 50, 200, 100);

            // call the DrawRectangle() method of the graphics object
            g.DrawRectangle(myBlackPen, rect1);
            myBlackPen.Dispose();


        }

        private void bitMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm1 = new Form2();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
