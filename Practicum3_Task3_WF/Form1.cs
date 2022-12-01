using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicum3_Task3_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static void f(double x, out double y)
        {
            if (Math.Abs(x) <= 0.1) y = Math.Pow(x, 3) - 1;
            else if (Math.Abs(x) > 0.1 && Math.Abs(x) <= 0.2) y = 0.2 * x - 0.1;
            else y = Math.Pow(x, 3) + 0.1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = (double)numericUpDownA.Value;
            double b = (double)numericUpDownB.Value;
            double h = (double)numericUpDownH.Value;

            richTextBoxRes.Clear();
            for (double i = a; i <= b; i += h)
            {
                f(i, out double y);
                richTextBoxRes.Text += $"f({i}) = {y}";
                richTextBoxRes.Text += "\n";
            }
        }
    }
}
