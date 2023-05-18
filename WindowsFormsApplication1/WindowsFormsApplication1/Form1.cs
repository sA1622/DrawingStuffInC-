using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            /*System.Drawing.Graphics graphicsObj;
            graphicsObj = this.CreateGraphics();
            Pen myPen = new Pen(System.Drawing.Color.Orange,20);
            //Rectangle myRectangle = new Rectangle(20, 20,200,200);
            //graphicsObj.DrawRectangle(myPen,myRectangle);
            for (int i = 1; i <= 100; i++)
            {
                Rectangle myRectangle = new Rectangle(i, 20, i, 200);
                graphicsObj.DrawEllipse(myPen, myRectangle);
                System.Threading.Thread.Sleep(250);
            }*/
            System.Drawing.Graphics graphicsObj;
            graphicsObj = this.CreateGraphics();
            Pen myPen = new Pen(System.Drawing.Color.Blue, 50);
            Point p1 = new Point(200, 200);
            Point p2 = new Point(20, 100);
            graphicsObj.DrawLine(myPen, p2, p1);
        }

        public void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            /*System.Drawing.Graphics graphicsObj;
            graphicsObj = this.CreateGraphics();
            Pen myPen = new Pen(System.Drawing.Color.Orange, 50);
            //Rectangle myRectangle = new Rectangle(20, 20,200,200);
            //graphicsObj.DrawRectangle(myPen,myRectangle);
            for (int i = 1; i <= 50; i++)
            {
                Rectangle myRectangle = new Rectangle(0, 0, i, i);
                graphicsObj.DrawRectangle(myPen, myRectangle);
                Rectangle myRectangle1 = new Rectangle(100, 100, i, i);
                graphicsObj.DrawRectangle(myPen, myRectangle1);
                Rectangle myRectangle2 = new Rectangle(200, 200, i, i);
                graphicsObj.DrawRectangle(myPen, myRectangle2);
                System.Threading.Thread.Sleep(100);
            }
            for (int i = 1; i <= 50; i++)
            {
                Rectangle myRectangle3 = new Rectangle(i, i, i, i);
                graphicsObj.DrawEllipse(myPen, myRectangle3);
            }*/
            System.Drawing.Graphics myGraphics;
            myGraphics = this.CreateGraphics();
            Pen myPen = new Pen(System.Drawing.Color.Blue, 10);
            for (int i = 1; i <= 100; i++)
            {
                Point p1 = new Point(i, 100);
                Point p2 = new Point(100, i);
                //panel1.Invoke(new (MethodInvoker)(()=> panel1.Graphics.DrawLine(myPen, p1, p2)));
                System.Threading.Thread.Sleep(100);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //backgroundWorker1.RunWorkerAsync();
            //timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics myGraphics;
            myGraphics = this.CreateGraphics();
            Pen myPen = new Pen(System.Drawing.Color.Blue, 1);
            int p12 = 100;
            int p21 = 100;
            /*for (int i = 100; i <= 200; i++)
            {
                Point p1 = new Point(i, 0);
                Point p2 = new Point(0, i+300);
                
                e.Graphics.DrawLine(myPen, p1, p2);
                //System.Threading.Thread.Sleep(100);
            }*/
            for (int i = 10; i < 1000; i+=10)
            {
                //double p1_= Math.Cos(i);
                //double p2_ = Math.Sin(i);
                Point p1 = new Point(0, 0);
                Point p2 = new Point(i, 500);
                e.Graphics.DrawLine(myPen, p1, p2);
            }
        }
    }
}
