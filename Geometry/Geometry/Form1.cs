using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Pen pen;
        public Form1()
        {
            InitializeComponent();
            graphics = pictureBox1.CreateGraphics();
            pen = new Pen(Color.Red, 3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            float X = -1;
            float Y = -1;
            graphics.DrawLine(new Pen(Color.Black, 1), pictureBox1.Width / 2, 0,
                pictureBox1.Width / 2, pictureBox1.Height);
            graphics.DrawLine(new Pen(Color.Black, 1),0, pictureBox1.Height / 2,
                pictureBox1.Width, pictureBox1.Height/2);
            for (int x = -10; x <=10 ; x++)
            {
                float y = x * x*10;
                if (X == -1)
                    X = pictureBox1.Width / 2 + x;
                if(Y==-1)
                    Y = pictureBox1.Height / 2 - y;
                graphics.DrawLine(pen, X, Y, pictureBox1.Width / 2 + x*10, pictureBox1.Height / 2 - y);
                X = pictureBox1.Width / 2+x*10;
                Y = pictureBox1.Height / 2-y;
                //graphics.DrawEllipse(pen,pictureBox1.Width/2+ x, pictureBox1.Height / 2 - y, 2, 2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            float X = -1;
            float Y = -1;
            graphics.DrawLine(new Pen(Color.Black, 1), pictureBox1.Width / 2, 0,
                pictureBox1.Width / 2, pictureBox1.Height);
            graphics.DrawLine(new Pen(Color.Black, 1), 0, pictureBox1.Height / 2,
                pictureBox1.Width, pictureBox1.Height / 2);
            for (int x = -10; x <= 10; x++)
            {
                float y = (float)Math.Sin(x) * 10;
                if (X == -1)
                    X = pictureBox1.Width / 2 + x * 10;
                if (Y == -1)
                    Y = pictureBox1.Height / 2 - y;
                graphics.DrawLine(pen, X, Y, pictureBox1.Width / 2 + x * 10, pictureBox1.Height / 2 - y);
                X = pictureBox1.Width / 2 + x * 10;
                Y = pictureBox1.Height / 2 - y;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            int r = 100;
            float X = -1;
            float Y = -1;
            graphics.DrawLine(new Pen(Color.Black, 1), pictureBox1.Width / 2, 0,
                pictureBox1.Width / 2, pictureBox1.Height);
            graphics.DrawLine(new Pen(Color.Black, 1), 0, pictureBox1.Height / 2,
                pictureBox1.Width, pictureBox1.Height / 2);
            for (int x = -100; x <= 100; x++)
            {
                float y = (float)Math.Sqrt(r*r-x*x);
                if (X == -1)
                    X = pictureBox1.Width / 2 + x;
                if (Y == -1)
                    Y = pictureBox1.Height / 2 - y;
                graphics.DrawLine(pen, X, Y, pictureBox1.Width / 2 + x, pictureBox1.Height / 2 - y);
                X = pictureBox1.Width / 2 + x;
                Y = pictureBox1.Height / 2 - y;
            }
            X = -1;
            Y = -1;
            for (int x = -100; x <= 100; x++)
            {
                float y = (float)Math.Sqrt(r*r-x*x);
                if (X == -1)
                    X = pictureBox1.Width / 2 + x;
                if (Y == -1)
                    Y = pictureBox1.Height / 2 + y;
                graphics.DrawLine(pen, X, Y, pictureBox1.Width / 2 + x, pictureBox1.Height / 2 + y);
                X = pictureBox1.Width / 2 + x;
                Y = pictureBox1.Height / 2 + y;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            float X = -1;
            float Y = -1;
            graphics.DrawLine(new Pen(Color.Black, 1), pictureBox1.Width / 2, 0,
                pictureBox1.Width / 2, pictureBox1.Height);
            graphics.DrawLine(new Pen(Color.Black, 1), 0, pictureBox1.Height / 2,
                pictureBox1.Width, pictureBox1.Height / 2);
            for (int x = -10; x <= 10; x++)
            {
                float y = x * 10;
                if (X == -1)
                    X = pictureBox1.Width / 2 + x *10;
                if (Y == -1)
                    Y = pictureBox1.Height / 2 - y;
                graphics.DrawLine(pen, X, Y, pictureBox1.Width / 2 + x * 10, pictureBox1.Height / 2 - y);
                X = pictureBox1.Width / 2 + x * 10;
                Y = pictureBox1.Height / 2 - y;
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            float X = -1;
            float Y = -1;
            graphics.DrawLine(new Pen(Color.Black, 1), pictureBox1.Width / 2, 0,
                pictureBox1.Width / 2, pictureBox1.Height);
            graphics.DrawLine(new Pen(Color.Black, 1), 0, pictureBox1.Height / 2,
                pictureBox1.Width, pictureBox1.Height / 2);
            for (float x = -10; x <= 10; x+=0.1f)
            {
                float y = x * x * x * 20;
                if (X == -1)
                    X = pictureBox1.Width / 2 + x * 20;
                if (Y == -1)
                    Y = pictureBox1.Height / 2 - y;
                graphics.DrawLine(pen, X, Y, pictureBox1.Width / 2 + x * 20, pictureBox1.Height / 2 - y);
                X = pictureBox1.Width / 2 + x * 20;
                Y = pictureBox1.Height / 2 - y;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            float X = -1;
            float Y = -1;
            graphics.DrawLine(new Pen(Color.Black, 1), pictureBox1.Width / 2, 0,
                pictureBox1.Width / 2, pictureBox1.Height);
            graphics.DrawLine(new Pen(Color.Black, 1), 0, pictureBox1.Height / 2,
                pictureBox1.Width, pictureBox1.Height / 2);
            for (int x = -10; x <= 10; x++)
            {
                if(x==0)
                {
                    X = - 1;
                    Y = -1;
                }
                if(x!=0)
                {
                    float y = 1.0f/x;
                    if (X == -1)
                        X = pictureBox1.Width / 2 + x * 20;
                    if (Y == -1)
                        Y = pictureBox1.Height / 2 - y * 100;
                    graphics.DrawLine(pen, X, Y, pictureBox1.Width / 2 + x * 20, pictureBox1.Height / 2 - y *100);
                    X = pictureBox1.Width / 2 + x * 20;
                    Y = pictureBox1.Height / 2 - y * 100;
                }
            }
        }
    }
}
