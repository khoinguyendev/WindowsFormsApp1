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
    public partial class FormTracNghiem : Form
    {
        private string ma;
        private string ten;
        private string ngaysinh;
        private string noisinh;
        private string gioitinh;
        private string diachi;
        public FormTracNghiem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ma = txtId.Text;
            ten = txtName.Text;
            ngaysinh = txtDate.Text;
            noisinh = txtHometow.Text;
            gioitinh = cbGender.Text;
            diachi = txtAddress.Text;
            FormTN1 obj = new FormTN1(ma,ten,ngaysinh,noisinh,gioitinh,diachi);
            obj.ShowDialog();
        }
    }
}
