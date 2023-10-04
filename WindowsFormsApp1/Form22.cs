using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form22 : Form
    {
        List<NhanSu> nhansuList = new List<NhanSu>();
        public Form22()
        {
            InitializeComponent();
            radWomen.Checked=true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string gioitinh;
            if (radMan.Checked)
            {
                gioitinh = radMan.Text;
            }
            else
            {
                gioitinh=radWomen.Text;
            }
            nhansuList.Add(new NhanSu(txtName.Text, dateTime.Value.ToShortDateString(), gioitinh, cbbKhoa.Text));
            string data = "";
            int stt = 1;
            foreach (NhanSu nhansu in nhansuList)
            {
                data += stt + ". " + nhansu.Name + "\n" +
                        "\t-Ngày sinh: " + nhansu.Date+ "\n" +
                        "\t-Giới tính: " + nhansu.Sex + "\n" +
                        "\t-Khoa: " + nhansu.Khoa + "\n";
                stt++;
            }
            rtxtStatus.Text = data;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbKhoa_Click(object sender, EventArgs e)
        {

        }

        private void rtxtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void radMan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExits_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
