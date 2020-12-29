namespace WindowsFormsApp2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_setpen = new System.Windows.Forms.Button();
            this.clr_pen = new System.Windows.Forms.Button();
            this.clr_canvas = new System.Windows.Forms.Button();
            this.sq = new System.Windows.Forms.Button();
            this.rct = new System.Windows.Forms.Button();
            this.circle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cnv_pensize = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hellpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(67, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 428);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseUp);
            // 
            // btn_setpen
            // 
            this.btn_setpen.Location = new System.Drawing.Point(67, 63);
            this.btn_setpen.Name = "btn_setpen";
            this.btn_setpen.Size = new System.Drawing.Size(131, 48);
            this.btn_setpen.TabIndex = 1;
            this.btn_setpen.Text = "Set Pen";
            this.btn_setpen.UseVisualStyleBackColor = true;
            this.btn_setpen.Click += new System.EventHandler(this.btn_setpen_Click);
            // 
            // clr_pen
            // 
            this.clr_pen.Location = new System.Drawing.Point(258, 63);
            this.clr_pen.Name = "clr_pen";
            this.clr_pen.Size = new System.Drawing.Size(131, 48);
            this.clr_pen.TabIndex = 2;
            this.clr_pen.Text = "Pen Color";
            this.clr_pen.UseVisualStyleBackColor = true;
            this.clr_pen.Click += new System.EventHandler(this.clr_pen_Click);
            // 
            // clr_canvas
            // 
            this.clr_canvas.Location = new System.Drawing.Point(454, 63);
            this.clr_canvas.Name = "clr_canvas";
            this.clr_canvas.Size = new System.Drawing.Size(131, 48);
            this.clr_canvas.TabIndex = 3;
            this.clr_canvas.Text = "Canvas Color";
            this.clr_canvas.UseVisualStyleBackColor = true;
            this.clr_canvas.Click += new System.EventHandler(this.clr_canvas_Click);
            // 
            // sq
            // 
            this.sq.Location = new System.Drawing.Point(67, 141);
            this.sq.Name = "sq";
            this.sq.Size = new System.Drawing.Size(131, 48);
            this.sq.TabIndex = 4;
            this.sq.Text = "Square";
            this.sq.UseVisualStyleBackColor = true;
            this.sq.Click += new System.EventHandler(this.sq_Click);
            // 
            // rct
            // 
            this.rct.Location = new System.Drawing.Point(258, 141);
            this.rct.Name = "rct";
            this.rct.Size = new System.Drawing.Size(131, 48);
            this.rct.TabIndex = 5;
            this.rct.Text = "Rectangle";
            this.rct.UseVisualStyleBackColor = true;
            this.rct.Click += new System.EventHandler(this.rct_Click);
            // 
            // circle
            // 
            this.circle.Location = new System.Drawing.Point(454, 141);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(131, 48);
            this.circle.TabIndex = 6;
            this.circle.Text = "Circle";
            this.circle.UseVisualStyleBackColor = true;
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(638, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 26);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cnv_pensize
            // 
            this.cnv_pensize.FormattingEnabled = true;
            this.cnv_pensize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cnv_pensize.Location = new System.Drawing.Point(663, 83);
            this.cnv_pensize.Name = "cnv_pensize";
            this.cnv_pensize.Size = new System.Drawing.Size(121, 28);
            this.cnv_pensize.TabIndex = 8;
            this.cnv_pensize.SelectedIndexChanged += new System.EventHandler(this.cnv_pensize_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.hellpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 33);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // hellpToolStripMenuItem
            // 
            this.hellpToolStripMenuItem.Name = "hellpToolStripMenuItem";
            this.hellpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.hellpToolStripMenuItem.Text = "Help";
            this.hellpToolStripMenuItem.Click += new System.EventHandler(this.hellpToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 660);
            this.Controls.Add(this.cnv_pensize);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.circle);
            this.Controls.Add(this.rct);
            this.Controls.Add(this.sq);
            this.Controls.Add(this.clr_canvas);
            this.Controls.Add(this.clr_pen);
            this.Controls.Add(this.btn_setpen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_setpen;
        private System.Windows.Forms.Button clr_pen;
        private System.Windows.Forms.Button clr_canvas;
        private System.Windows.Forms.Button sq;
        private System.Windows.Forms.Button rct;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cnv_pensize;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hellpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}