using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class QLSV : Form
    {
        private bool kiemtra = false;
        private string pathInMyComputer = null;
        private string namePicture = null;
        string destinationFilePath = null;
        List<Student> lst;
        public QLSV()
        {
            InitializeComponent();
        }
        public List<Student> getData()
        {
            List<Student> list = new List<Student>();
            Student std = new Student("2122150050", "Nguyễn Trần Khôi Nguyên","12/01/2001", true,"", "anh5.jpg");
            list.Add(std);
            std=new Student("2122110486", "Ngô Phương Linh", "28/05/2001", false,"TPHCM", "anh6.jpg");
            list.Add(std);
            std = new Student("2122110400", "Nguyễn Thị Linh Phụng", "24/07/2001", false,"Hà Nội" , "anh4.jpg");
            list.Add(std);
            return list;
        }


        private void QLSV_Load(object sender, EventArgs e)
        {
            lst = getData();
            foreach(Student student in lst)
            {
                dgvStudent.Rows.Add(student.Id, student.Name, student.Date, student.Gender,student.Address, student.Picture);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            kiemtra = false;
            if (txbId.Text == "" || txbName.Text == "")
            {
                MessageBox.Show("MSSV và Họ tên không được để trống!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string mssv = txbId.Text;
            foreach(char ch in mssv)
            {
                if (!(char.IsDigit(ch)))
                {
                    MessageBox.Show("Mã sinh viên chỉ chứa chữ số!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            foreach (Student student in lst)
            {
                if (student.Id == txbId.Text)
                {
                    MessageBox.Show("Trùng mã số sinh viên!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            DateTime currentDateTime = DateTime.Now;
            string name = currentDateTime.ToString("yyyyMMddHHmmssfff") + namePicture;
            Student std = new Student(txbId.Text,txbName.Text,dateTimePicker1.Text,ckbGender.Checked,txbAdress.Text,name);
            lst.Add(std);
            dgvStudent.Rows.Add(std.Id, std.Name, std.Date, std.Gender, std.Address, std.Picture);
            destinationFilePath = Path.Combine("../../Images", name);

            // Di chuyển tệp hình ảnh vào thư mục "image"
            File.Copy(pathInMyComputer, destinationFilePath, true);
            
        }

        private void dgvStudent_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            kiemtra = false;
            int index = e.RowIndex;
            txbId.Text = dgvStudent.Rows[index].Cells[0].Value.ToString();
            txbName.Text = dgvStudent.Rows[index].Cells[1].Value.ToString();
            string tam = dgvStudent.Rows[index].Cells[2].Value.ToString();
            string ngay = tam.Substring(0, 2);
            string thang = tam.Substring(3, 2);
            string nam = tam.Substring(6, 4);
            string date = thang + "/" + ngay + "/" + nam;
            if (DateTime.TryParse(date, out DateTime dateValue))
            {
                dateTimePicker1.Value = dateValue;
            }
            else
            {
                MessageBox.Show("Ngày sinh không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ckbGender.Checked = bool.Parse(dgvStudent.Rows[index].Cells[3].Value.ToString());
            txbAdress.Text = dgvStudent.Rows[index].Cells[4].Value.ToString();
            destinationFilePath = Path.Combine("../../Images", dgvStudent.Rows[index].Cells[5].Value.ToString());
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.ImageLocation = destinationFilePath;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dgvStudent.CurrentCell.RowIndex;;
            string mssv = dgvStudent.Rows[index].Cells[0].Value.ToString();
            string path= dgvStudent.Rows[index].Cells[5].Value.ToString();
            File.Delete($"../../Images/{path}");
            dgvStudent.Rows.RemoveAt(index);
            int i = 0;
            foreach (Student student in lst)
            {
                if (student.Id == mssv)
                {
                    lst.RemoveAt(i);
                    break;
                }
                i++;
            }
        }
        private bool IsImageFileExtension(string fileExtension)
        {
            // Danh sách các đuôi tệp hình ảnh hợp lệ
            string[] validExtensions = { ".jpg", ".jpeg", ".png", ".bmp" };
            return validExtensions.Contains(fileExtension);
        }
        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = dlg.FileName;
                string fileExtension = Path.GetExtension(fileName).ToLower();
                if (IsImageFileExtension(fileExtension))
                {
                    pbImage.ImageLocation = fileName;
                }
                else
                {
                    MessageBox.Show("Tệp không phải là hình ảnh hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                pathInMyComputer = fileName;
                namePicture = Path.GetFileName(fileName);
                kiemtra = true;
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            
            bool co = false;
            foreach (Student student in lst)
            {
                if (txbId.Text == student.Id)
                {
                    string name = student.Picture;
                    student.Name = txbName.Text;
                    student.Gender = ckbGender.Checked;
                    student.Date = dateTimePicker1.Text;
                    student.Address = txbAdress.Text;
                    if (kiemtra == true)
                    {
                        string path = student.Picture;
                        File.Delete($"../../Images/{path}");
                        DateTime currentDateTime = DateTime.Now;
                        name = currentDateTime.ToString("yyyyMMddHHmmssfff") + namePicture;
                        destinationFilePath = Path.Combine("../../Images", name);
                        student.Picture = name;
                        File.Copy(pathInMyComputer, destinationFilePath, true);
                    }
                    change_data(name);
                    //int index = dgvStudent.CurrentCell.RowIndex; ;
                    //dgvStudent.Rows[index].Cells[1].Value = txbName.Text;
                    //dgvStudent.Rows[index].Cells[3].Value = dateTimePicker1.Text;
                    //dgvStudent.Rows[index].Cells[2].Value = ckbGender.Checked;
                    //dgvStudent.Rows[index].Cells[4].Value = txbAdress.Text;
                    //dgvStudent.Rows[index].Cells[5].Value= namePicture;
                    ////File.Delete($"../../Images/{path}");
                    MessageBox.Show("Cập nhật thông tin thành công!!");
                    co = true;
                    kiemtra = false;
                    return;
                }
            }
            if (co == false)
            {
                MessageBox.Show("Không tìm thấy sinh viên có mã "+txbId.Text+" để cập nhật thông tin!!");
            }
        }
        private void load_data()
        {
            foreach (Student student in lst)
            {
                dgvStudent.Rows.Add(student.Id, student.Name, student.Date, student.Gender, student.Address, student.Picture);
            }
        }

        private void change_data(string name)
        {
            foreach (DataGridViewRow row in dgvStudent.Rows)
            {
                // Truy cập ô trong cột cụ thể (Column2)
                if (row.Cells["ID"].Value.ToString() == txbId.Text)
                {
                    // Thay đổi thông tin của hàng này, ví dụ thay đổi thông tin cột "Tên" bằng "New Info"
                    row.Cells["NAME"].Value =txbName.Text ;
                    row.Cells["DATE"].Value = dateTimePicker1.Text;
                    row.Cells["GENDER"].Value = ckbGender.Checked;
                    row.Cells["ADDRESS"].Value = txbAdress.Text ;
                    row.Cells["PICTURE"].Value = name;
                    // Thêm các thay đổi khác tại đây nếu cần
                    return;
                }
            }
        }
    }
}
