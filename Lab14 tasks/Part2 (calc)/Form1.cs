using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part2__calc_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double op1 => Convert.ToDouble(Op1.Text);
        private double op2 => Convert.ToDouble(Op2.Text);

        private double res = 0;

        private void Mult_Click(object sender, EventArgs e)
        {
            res = op1 * op2;
            ResBox.Text = res.ToString();
        }

        private void add_Click(object sender, EventArgs e)
        {
            res = op1 + op2;
            ResBox.Text = res.ToString();
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            res = op1 - op2;
            ResBox.Text = res.ToString();
        }

        private void Div_Click(object sender, EventArgs e)
        {
            res = op1/op2;
            ResBox.Text = res.ToString();
        }
    }
}
