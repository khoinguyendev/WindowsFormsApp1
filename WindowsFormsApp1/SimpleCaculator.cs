using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SimpleCaculator : Form
    {
        decimal workingMemory = 0;
        string opr = "";
        public SimpleCaculator()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn3.Text;
        }

        private void btnEqua_Click(object sender, EventArgs e)
        {
            decimal seconValue=decimal.Parse(txtDisplay.Text);
            if (opr == "+")
            {
               txtDisplay.Text=(workingMemory+seconValue).ToString();
            }
            if (opr == "*")
            {
                txtDisplay.Text = (workingMemory * seconValue).ToString();
            }

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            opr=btnPlus.Text;
            workingMemory=decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            opr = btnMul.Text;
            workingMemory = decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnDot.Text;
        }
    }
}
