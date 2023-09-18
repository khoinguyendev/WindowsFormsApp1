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
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            studentList.Add(new Student(txtUser.Text,txtPassword.Text));
            string chss = "";
            foreach (Student student in studentList)
            {
                chss += "user:" + student.Name + "   password:" + student.StudentID + '\n';
            }
            rtxt.Text = chss;
        }
    }
}
