using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part1__prime_numb_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Check_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(NumbBox.Text);
            string res = "";
            bool flag = false;

            int m = number / 2;
            for (int i = 2; i <= m; i++)
            {
                if (number % i == 0)
                {
                    res = "NOT PRIME";
                    flag = true;
                    break;
                }
            }

            if (flag == false)
                res = "PRIME";

            ResBox.Text = res;
        }
    }
}
