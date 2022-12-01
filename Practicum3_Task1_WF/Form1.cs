using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicum3_Task1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double f(double x)
        {
            return Math.Cos(2 * x) + Math.Sin(x - 3);
        }

        private void button_Click(object sender, EventArgs e)
        {
            double a, b;

            a = (double)numericUpDownA.Value;
            b = (double)numericUpDownB.Value;

            if (f(a) < f(b)) textBoxRes.Text = $"В точке a, равной {Math.Round(f(a), 2)}, у ф-ии наименьшее значение.";
            else textBoxRes.Text = $"В точке b, равной {Math.Round(f(b), 2)}, у ф-ии наименьшее значение.";
        }
    }
}
