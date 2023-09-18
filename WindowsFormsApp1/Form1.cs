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
    
    public partial class Form1 : Form
    {
        List<Student> studentList = new List<Student>();
        public Form1()
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
            studentList.Add(new Student(txtName.Text, dateTime.Value.ToShortDateString(), gioitinh, cbbKhoa.Text));
            string data = "";
            int stt = 1;
            foreach (Student student in studentList)
            {
                data += stt + ". " + student.Name + "\n" +
                        "\t-Ngày sinh: " + student.Date+ "\n" +
                        "\t-Giới tính: " + student.Sex + "\n" +
                        "\t-Khoa: " + student.Khoa + "\n";
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
