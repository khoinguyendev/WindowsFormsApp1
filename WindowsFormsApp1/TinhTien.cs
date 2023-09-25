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
    public partial class TinhTien : Form
    {
        public TinhTien()
        {
            InitializeComponent();
            txtGiam.Enabled = false;
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            string ho = "";
            string giamgia = "0";
            if (radNam.Checked == true)
            {
                ho = "Ông";
            }
            else
            {
                ho = "Bà";
            }
            if(ckGiam.Checked == true)
            {
                giamgia=txtGiam.Text;
            }
            rtxtContent.Text =ho +" " +txtName.Text + " được giảm " + giamgia + "%";
        }

        private void ckGiam_CheckedChanged(object sender, EventArgs e)
        {
            if (ckGiam.Checked == true)
            {
                txtGiam.Enabled = true;
            }
            else
            {
                txtGiam.Enabled = false;
            }
        }
    }
}
