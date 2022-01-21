using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGraphicDrawer
{
    public class FigureParams
    {
        private double a = 1;
        private double b = 1;
        private double c = 1;
        private double x1 = -1;
        private double x2 = 1;
        public double e { get; set; }

        public FigureParams()
        {
            this.e = 0.001;
        }
        public FigureParams(double a, double b, double c, double x1, double x2, double e)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.x1 = x1;
            this.x2 = x2;
            this.e = e;
        }
        public void setA(double value)
        {
            this.a = value;
        }
        public double getA()
        {
            return a;
        }
        public void setB(double value)
        {
            this.b = value;
        }
        public double getB()
        {
            return b;
        }
        public void setC(double value)
        {
            this.c = value;
        }
        public double getC()
        {
            return c;
        }
        public void setX1(double value)
        {
            this.x1 = value;
        }
        public double getX1()
        {
            return x1;
        }
        public void setX2(double value)
        {
            this.x2 = value;
        }
        public double getX2()
        {
            return x2;
        }

    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
