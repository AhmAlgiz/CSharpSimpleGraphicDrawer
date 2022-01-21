using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGraphicDrawer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static public FigureParams fig1Params = new FigureParams(1, 2, 3, 0, 2, 0.001);
        private void buttonParams_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        public double parabola (double a, double b, double c, double x)
        {
            return a * x * x + b * x + c;
        }
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            chartGraphic.Series[0].Points.Clear();
            chartGraphic.Series[1].Points.Clear();

            double a = fig1Params.getA();
            double b = fig1Params.getB();
            double c = fig1Params.getC();
            double x1 = fig1Params.getX1();
            double x2 = fig1Params.getX2();
            double eps = fig1Params.e;

            while (x1 <= x2)
            {
                chartGraphic.Series[0].Points.AddXY(x1, parabola(a,b,c,x1));
                x1 += eps;
            }

            x1 = fig1Params.getX1();
            double x = (x2 + x1) / 2;
            while ((x2 - x1) >= fig1Params.e)
            {
                if (parabola(a, b, c, (x + eps)) > parabola(a, b, c, (x - eps)))
                {
                    x2 = x;
                }
                else x1 = x;
                x = (x2 + x1) / 2;
            }                  
            labelExtremumMinValue.Text = x.ToString();
            chartGraphic.Series[1].Points.AddXY(x, parabola(a, b, c, x));

            x1 = fig1Params.getX1();
            x2 = fig1Params.getX2();
            x = (x2 + x1) / 2;
            while ((x2 - x1) >= fig1Params.e)
            {
                if (parabola(a, b, c, (x + eps)) > parabola(a, b, c, (x - eps)))
                {
                    x1 = x;
                }
                else x2 = x;
                x = (x2 + x1) / 2;
            }
            labelExtremumMaxValue.Text = x.ToString();
            chartGraphic.Series[2].Points.AddXY(x, parabola(a, b, c, x));
        }
    }
}
