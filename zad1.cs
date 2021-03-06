using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private System.Drawing.Graphics g;
        private System.Drawing.Pen pen = new System.Drawing.Pen(Color.Red, 1);
        Point[] points = new Point[300];

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            double alfa = 0;
            double dalfa = (2 * Math.PI) / 300;
            for (int i = 0; i < 300; i++)
            {
                double x = 150 * Math.Cos(alfa) + 200;
                double y = 150 * Math.Sin(alfa) + 200;
                points[i] = new Point((int)x, (int)y);
                alfa += dalfa;
            }

            g.DrawLines(pen, points);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            double alfa = 0;
            for (int i = 0; i < 300; i++)
            {
                double x = 150 * Math.Cos(alfa * i) + 150;
                double y = 150 * Math.Sin(alfa * i) + 150;
                points[i] = new Point((int)x, (int)y);
                alfa = 3.6 * (360 / 100);
            }
            g.DrawLines(pen, points);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            button1_Click(sender, e);
            double r = 150;
            double r2 = 100;
            double alfa = 2 * (Math.PI) / 100;


            for (int k = 0; k <= 5; k++)
            {
                if (r != r2)
                {

                    for (int i = 0; i < 100; i++)
                    {
                        g.DrawLine(pen, (float)(r * Math.Cos(alfa * i) + 200),
                            (float)(r2 * Math.Sin(alfa * i) + 200),
                            (float)(r * Math.Cos(alfa * (i + 1)) + 200),
                            (float)(r2 * Math.Sin(alfa * (i + 1))) + 200);

                        for (int j = 0; j < 100; j++)
                        {
                            g.DrawLine(pen, (float)(r2 * Math.Cos(alfa * j) + 200),
                            (float)(r * Math.Sin(alfa * j) + 200),
                            (float)(r2 * Math.Cos(alfa * (j + 1)) + 200),
                            (float)(r * Math.Sin(alfa * (j + 1))) + 200);
                        }

                    }
                }
                r = r2;
                r2 = 50;

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            button1_Click(sender, e);
            double r = 150;
            double alfa = (2 * Math.PI) / 100;
            int n = 7;
            int nn = n * 100;
            double rr = r / nn;
            double rb;

            for (int j = 1; j < nn; j++)
            {
                rb = rr * j;
                g.DrawLine(pen, 
                    (float)(rb * Math.Cos(alfa * j) + 200),
                    (float)(rb * Math.Sin(alfa * j) + 200),
                    (float)(rb * Math.Cos(alfa * (j + 1)) + 200),
                 (float)(rb * Math.Sin(alfa * (j + 1)) + 200));
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            button1_Click(sender, e);
            double r = 150;
            double alfa = 0;
            double dalfa = (2 * Math.PI) / 100;
            int n = 4;
            int nn = n * 100;
            double rr = r / nn;
            double rb;

            for (int i = 1; i < n; i++)
            {
                alfa = alfa + (2 * Math.PI) / 3;

                for (int j = 1; j < nn; j++)
                {
                    rb = rr * j;
                    g.DrawLine(pen, 
                        (float)(rb * Math.Cos(alfa + dalfa * j) + 200),
                        (float)(rb * Math.Sin(alfa + dalfa * j) + 200),
                        (float)(rb * Math.Cos(alfa + dalfa * (j + 1)) + 200),
                        (float)(rb * Math.Sin(alfa + dalfa * (j + 1)) + 200));
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            double r = 200;
            double alfa = 0;
            double dalfa = (2 * Math.PI) / 200;
            for (int j = 0; j < 20; j++)
            {

                for (int i = 0; i < 300; i++)
                {
                    double x = r * Math.Cos(alfa) + 200;
                    double y = r * Math.Sin(alfa) + 200;
                    points[i] = new Point((int)x, (int)y);
                    alfa += dalfa;
                }

                g.DrawLines(pen, points);
                r = r - 20;
            }


            r = 200;

            for (int i = 0; i < 200; i += 10)
            {
                for (int j = 0; j < 200; j += 10)
                {
                    g.DrawLine(pen, 
                        (float)(r * Math.Cos(dalfa * i) + 200),
                        (float)(r * Math.Sin(dalfa * i) + 200),
                        (float)(r * Math.Cos(dalfa * (j + 10)) + 200),
                        (float)(r * Math.Sin(dalfa * (j + 10)) + 200));
                }
            }

        }
    }
 }