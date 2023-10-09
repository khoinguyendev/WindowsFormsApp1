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
        List<TracNghiem> lst;
        private int vt = 0;
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
            lst = getData();
            TracNghiem n=lst[vt];
            label7.Text = n.question;
            RadioButton[] radioButtons = new RadioButton[] { radioButton1, radioButton2, radioButton3, radioButton4 };
            for (int i = 0; i <= 3; i++)
            {
                radioButtons[i].Text = n.answer[i];
            }
        }
        public List<TracNghiem> getData()
        {
            List<TracNghiem> list = new List<TracNghiem>();
            string[] answers = new string[] { "2", "3", "4", "5" };
            TracNghiem std = new TracNghiem("1+1 bằng mấy", answers);
            list.Add(std);
            answers = new string[] { "4", "6", "8", "10" };
            std = new TracNghiem("2+2 bằng mấy", answers);
            list.Add(std);
            return list;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            vt++;
            if (vt >= lst.Count)
            {
                vt--;
                return;
            }
            TracNghiem n = lst[vt];
            label7.Text = n.question;
            RadioButton[] radioButtons = new RadioButton[] { radioButton1, radioButton2, radioButton3, radioButton4 };
            for (int i = 0; i <= 3; i++)
            {
                radioButtons[i].Text = n.answer[i];
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            vt--;
            if (vt <0)
            {
                vt++;
                return;
            }
            TracNghiem n = lst[vt];
            label7.Text = n.question;
            RadioButton[] radioButtons = new RadioButton[] { radioButton1, radioButton2, radioButton3, radioButton4 };
            for (int i = 0; i <= 3; i++)
            {
                radioButtons[i].Text = n.answer[i];
            }
        }
    }
}
