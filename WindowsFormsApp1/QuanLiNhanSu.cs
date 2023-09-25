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
    public partial class QuanLiNhanSu : Form
    {
        public QuanLiNhanSu()
        {
            InitializeComponent();
        }

        private void btnFIle_Click(object sender, EventArgs e)
        {
            //pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            //pbImage.ImageLocation = @"D:\download.jpg";


            pbImage.SizeMode=PictureBoxSizeMode.StretchImage;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open Image";
            ofd.Filter = "JPEG files (*.jpg)|*.jpg";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pbImage.ImageLocation=ofd.FileName;
            }
        }
    }
}
