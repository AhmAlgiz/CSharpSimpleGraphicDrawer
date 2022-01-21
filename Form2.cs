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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBoxA.Text = Form1.fig1Params.getA().ToString();
            textBoxB.Text = Form1.fig1Params.getB().ToString();
            textBoxC.Text = Form1.fig1Params.getC().ToString();
            textBoxX1.Text = Form1.fig1Params.getX1().ToString();
            textBoxX2.Text = Form1.fig1Params.getX2().ToString();
            textBoxE.Text = Form1.fig1Params.e.ToString();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            double temp;
            double.TryParse(textBoxA.Text, out temp);
            Form1.fig1Params.setA(temp);
            double.TryParse(textBoxB.Text, out temp);
            Form1.fig1Params.setB(temp);
            double.TryParse(textBoxC.Text, out temp);
            Form1.fig1Params.setC(temp);
            double.TryParse(textBoxX1.Text, out temp);
            Form1.fig1Params.setX1(temp);
            double.TryParse(textBoxX2.Text, out temp);
            if (temp < Form1.fig1Params.getX1())
            {
                Form1.fig1Params.setX2(Form1.fig1Params.getX1());
                Form1.fig1Params.setX1(temp);
            }
            else Form1.fig1Params.setX2(temp);

            double.TryParse(textBoxE.Text, out temp);
            Form1.fig1Params.e = temp;
            this.Close();
        }
    }
}
