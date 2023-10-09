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
    public partial class FormTN1 : Form
    {
        private string ma;
        private string ten;
        private string ngaysinh;
        private string noisinh;
        private string gioitinh;
        private string diachi;
        public FormTN1(string m,string t,string ngs,string n,string g,string d)
        {
            InitializeComponent();
            ma = m;
            ten = t;
            ngaysinh = ngs;
            noisinh = n;
            gioitinh = g;
            diachi = d;
        }

        private void FormTN1_Load(object sender, EventArgs e)
        {
            label2.Text = ma;
            label4.Text = ten;
            label6.Text = ngaysinh;
        }
    }
}
