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
    public partial class Form3 : Form
    {
        Graphics g; 
        public Form3()
        
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
        }

        bool startPaint = false;

        //nullable int for storing Null value 
        int? initX = null;
        int? initY = null;
        bool drawSquare = false;
        bool drawRectangle = false;
        bool drawCircle = false; 

        private void hellpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_Draw_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPaint)
            {
                //Setting the Pen  BackColor and line Width 
                Pen p = new Pen(clr_pen.BackColor, float.Parse(cnv_pensize.Text));
                //Drawing the line 
                g.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                initX = e.X;
                initY = e.Y; 
            }
        }

        private void pnl_Draw_MouseDown(object sender, MouseEventArgs e)
        {
            startPaint = true; 
            if (drawSquare)
            {
                //Use Solid Brush
                SolidBrush sb = new SolidBrush(clr_pen.BackColor);
                g.FillRectangle(sb, e.X, e.Y, int.Parse(textBox1.Text), int.Parse(textBox1.Text));
                startPaint = false;
                drawSquare = false;
            }

            if (drawRectangle)
            {
                SolidBrush sb = new SolidBrush(clr_pen.BackColor);
                g.FillRectangle(sb, e.X, e.Y,2* int.Parse(textBox1.Text), int.Parse(textBox1.Text));
                startPaint = false;
                drawRectangle = false;
            }

            if (drawCircle)
            {
                SolidBrush sb = new SolidBrush(clr_pen.BackColor);
                g.FillEllipse(sb, e.X, e.Y, int.Parse(textBox1.Text), int.Parse(textBox1.Text));
                startPaint = false;
                drawCircle = false;
            }
        }

        private void pnl_Draw_MouseUp(object sender, MouseEventArgs e)
        {
            startPaint = false;
            initX = null;
            initY = null;
        }

        private void btn_setpen_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog()== DialogResult.OK)
            {
                clr_pen.BackColor = c.Color;
            }
        }

        private void clr_canvas_Click(object sender, EventArgs e)
        {
            //Open Color Dialog and Set BackColor clr_pen if user click on OK
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                clr_canvas.BackColor = c.Color;
                panel1.BackColor = c.Color;
            }
        }

        private void sq_Click(object sender, EventArgs e)
        {
            drawSquare = true;
        }

        private void rct_Click(object sender, EventArgs e)
        {
            drawRectangle = true;
        }

        private void circle_Click(object sender, EventArgs e)
        {
            drawCircle = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cnv_pensize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
