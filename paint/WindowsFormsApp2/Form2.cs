using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        Bitmap myBitmap;
        Graphics g;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            myBitmap = new Bitmap(640, 480);
            g = Graphics.FromImage(myBitmap); // get the graphics contact so that we can draw on the bitmap
            Pen p = new Pen(Color.Red, 2); //red pen 2 pixels wide
            g.DrawLine(p, 0, 0, 640, 480);

            //put the bitmap on the window
            Graphics windowG = e.Graphics;
            windowG.DrawImageUnscaled(myBitmap, 0, 0);
           
            //for button
            windowG = e.Graphics;
            windowG.DrawImageUnscaled(myBitmap, 0, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myBitmap.Save("C:\\Users\\psbas\\image1.jpg", ImageFormat.Jpeg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap("C:\\Users\\psbas\\image1.jpg");
        }

        private void bitmapFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
