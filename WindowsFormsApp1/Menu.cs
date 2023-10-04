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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
           Form22 obj=new Form22();
            obj.ShowDialog();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form11 obj = new Form11();
            obj.ShowDialog();
        }

        private void btnCaculator_Click(object sender, EventArgs e)
        {
            SimpleCaculator obj = new SimpleCaculator();
            obj.ShowDialog();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {

            TinhTien obj = new TinhTien();
            obj.ShowDialog();
        }

        private void tbnMusic_Click(object sender, EventArgs e)
        {
            Music obj = new Music();
            obj.ShowDialog();
        }

        private void btnMusic2_Click(object sender, EventArgs e)
        {
            Music2 obj = new Music2();
            obj.ShowDialog();
        }

        private void btnQLNS_Click(object sender, EventArgs e)
        {
            QuanLiNhanSu obj = new QuanLiNhanSu();
            obj.ShowDialog();
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            Timer obj = new Timer();
            obj.ShowDialog();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            Game obj = new Game();
            obj.ShowDialog();
        }

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            QLSV obj = new QLSV();
            obj.ShowDialog();
        }
    }
}
