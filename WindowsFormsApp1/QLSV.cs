﻿using System;
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
        string pathInProject = null;
        List<Student> lst;
        List<History> lstHistory=new List<History>();
        public QLSV()
        {
            InitializeComponent();
            string imagePath = "../../Images/search.png";

            // Tạo hình ảnh từ đường dẫn
            Image image = Image.FromFile(imagePath);

            // Đặt hình ảnh làm nền cho nút
            btnSearch.BackgroundImage = image;
            btnSearch.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public List<Student> getData()
        {
            List<Student> list = new List<Student>();
            Student std = new Student("2122150050", "Nguyễn Trần Khôi Nguyên","12/01/2001", true,"", "anh5.jpg");
            list.Add(std);
            std=new Student("2122110486", "Ngô Phương Linh", "28/05/2001", false,"TPHCM", "anh9.jpg");
            list.Add(std);
            std = new Student("2122110400", "Nguyễn Anh", "24/07/2001", false,"Hà Nội" , "anh7.jpg");
            list.Add(std);
            std = new Student("2122110401", "Thải Lân", "24/07/2001", false, "China", "anh8.jpg");
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
            string name = "";
            DateTime currentDateTime = DateTime.Now;
            if (pathInMyComputer != null)
            {
                name = currentDateTime.ToString("yyyyMMddHHmmssfff") + namePicture;
                pathInProject = Path.Combine("../../Images", name);
                // Di chuyển tệp hình ảnh vào thư mục "image"
                File.Copy(pathInMyComputer, pathInProject, true);
            }
            if (kiemtra == false)
            {
                name = "";
            }
            Student std = new Student(txbId.Text,txbName.Text,dateTimePicker1.Text,ckbGender.Checked,txbAdress.Text,name);
            lst.Add(std);
            dgvStudent.Rows.Add(std.Id, std.Name, std.Date, std.Gender, std.Address, std.Picture);


            //Them vao history
            string g = gender(ckbGender.Checked);
            History h = new History("THÊM", txbId.Text, "Tên: " + txbName.Text + ",  Ngày sinh: " + dateTimePicker1.Text+ ",  Địa chỉ: " + txbAdress.Text+",  Giới tính: "+g,currentDateTime.ToString("dd/MM/yyyy  HH:mm:ss"));
            lstHistory.Add(h);
            kiemtra = false;
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
            if (dgvStudent.Rows[index].Cells[5].Value.ToString() == "")
                pbImage.ImageLocation = null;
            else
            {
                pathInProject = Path.Combine("../../Images", dgvStudent.Rows[index].Cells[5].Value.ToString());
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pbImage.ImageLocation = pathInProject;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(kq==DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudent.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int index = dgvStudent.CurrentCell.RowIndex;;
            string mssv = dgvStudent.Rows[index].Cells[0].Value.ToString();
            string name = dgvStudent.Rows[index].Cells[1].Value.ToString();
            string date = dgvStudent.Rows[index].Cells[2].Value.ToString();
            string address= dgvStudent.Rows[index].Cells[4].Value.ToString();
            bool kt = bool.Parse(dgvStudent.Rows[index].Cells[3].Value.ToString());
            string gioitinh = gender(kt);
            string path= dgvStudent.Rows[index].Cells[5].Value.ToString();
            if(path!="")
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
            DateTime time = DateTime.Now;
            History h = new History("XÓA", mssv, "Tên: " + name + ",  Ngày sinh: " + date + ",  Địa chỉ: " + txbAdress.Text + ",  Giới tính: " + gioitinh, time.ToString("dd/MM/yyyy  HH:mm:ss"));
            lstHistory.Add(h);
        }
        private bool KiemTraDuoi(string duoiHinhAnh)
        {
            // Danh sách các đuôi tệp hình ảnh hợp lệ
            string[] s = { ".jpg", ".jpeg", ".png", ".bmp" };
            return s.Contains(duoiHinhAnh);
        }
        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            kiemtra = false;
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string duongDanHinhAnh = dlg.FileName;
                string duoiHinhAnh = Path.GetExtension(duongDanHinhAnh).ToLower();
                if (KiemTraDuoi(duoiHinhAnh))
                {
                   

                    FileInfo fileInfo = new FileInfo(duongDanHinhAnh);
                    long fileSizeInBytes = fileInfo.Length;
                    long fileSizeInMB = fileSizeInBytes / (1024 * 1024); // Chuyển đổi sang MB

                    if (fileSizeInMB > 4)
                    {
                        MessageBox.Show("Kích thước tệp quá lớn (lớn hơn 4 MB). Vui lòng chọn một tệp nhỏ hơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        pbImage.ImageLocation = duongDanHinhAnh;
                        pathInMyComputer = duongDanHinhAnh;
                        namePicture = Path.GetFileName(duongDanHinhAnh);
                        kiemtra = true;
                    }
                }
                else
                {
                    MessageBox.Show("Tệp không phải là hình ảnh hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            int index = dgvStudent.CurrentCell.RowIndex;
            string mssv = dgvStudent.Rows[index].Cells[0].Value.ToString();
            if (mssv != txbId.Text)
            {
                MessageBox.Show("Không đúng Mã Số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool co = false;
            int vt = 0;
            foreach (Student student in lst)
            {
                
                if (txbId.Text == student.Id)
                {

                    string s = ChinhSua(vt, txbName.Text, dateTimePicker1.Text,ckbGender.Checked,txbAdress.Text,namePicture);
                    if (s == "")
                    {
                        MessageBox.Show("Không có gì để cập nhật!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    string name = student.Picture;
                    student.Name = txbName.Text;
                    student.Gender = ckbGender.Checked;
                    student.Date = dateTimePicker1.Text;
                    student.Address = txbAdress.Text;
                    if (kiemtra == true)
                    {
                        string path = student.Picture;
                        if(path!="")
                            File.Delete($"../../Images/{path}");
                        DateTime currentDateTime = DateTime.Now;
                        name = currentDateTime.ToString("yyyyMMddHHmmssfff") + namePicture;
                        pathInProject = Path.Combine("../../Images", name);
                        student.Picture = name;
                        File.Copy(pathInMyComputer, pathInProject, true);
                    }
                    change_data(name);
                    MessageBox.Show("Cập nhật thông tin thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    co = true;
                    pathInMyComputer = null;

                    //thêm vào lịch sử
                    DateTime time = DateTime.Now;
                    History h = new History("SỬA", txbId.Text, s, time.ToString("dd/MM/yyyy  HH:mm:ss"));
                    lstHistory.Add(h);
                    return;
                }
                vt++;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txbSearch.Text.Trim().ToLower(); // Lấy từ khóa tìm kiếm và chuẩn hóa nó
            string select = cbSelect.Text;
            string key = null;
            switch (select)
            {
                case "MSSV":
                    key = "ID";
                    break;
                case "Địa chỉ":
                    key = "ADDRESS";
                    break;
                case "Tên":
                    key = "NAME";
                    break;
            }
            // Lặp qua các hàng trong DataGridView và ẩn các hàng không chứa từ khóa tìm kiếm
            foreach (DataGridViewRow row in dgvStudent.Rows)
            {
                bool rowVisible = false; // Mặc định, ẩn hàng
                string kq=row.Cells[key].Value.ToString().Trim().ToLower();
                if(kq.Contains(keyword))
                {
                    rowVisible = true; // Nếu có bất kỳ ô nào chứa từ khóa, hiển thị hàng
                }
                row.Visible = rowVisible;
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryFrom obj = new HistoryFrom(lstHistory);
            obj.ShowDialog();
        }

        private string ChinhSua(int vt,string name,string ngaysinh,bool gioitinh,string diachi,string hinhanh)
        {
            string s = "";
            if (lst[vt].Name != name)
                s += $"Tên:{lst[vt].Name} --> {name}\n";
            if (lst[vt].Date !=ngaysinh)
                s += $", Ngày sinh:{lst[vt].Date} --> {ngaysinh}\n";
            if(lst[vt].Gender!=gioitinh)
                s += $", Giới tính:{gender(lst[vt].Gender)} -->  {gender(gioitinh)}\n";
            if (lst[vt].Address != diachi)
                s += $", Địa chỉ:{lst[vt].Address} --> {diachi}\n";
            if(kiemtra==true)
            {
                if (lst[vt].Picture != hinhanh && namePicture != null)
                    s += $", Hình ảnh:{lst[vt].Picture} --> {hinhanh}\n";
            }
            return s;
        }
        private  string gender(bool b)
        {
            string s = "Nam";
            if (b == false)
                s = "Nữ";
            return s;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbId.Text = "";
            txbName.Text = "";
            ckbGender.Checked=false;
            dateTimePicker1.Text="01/01/2001";
            txbAdress.Text="";
            pbImage.ImageLocation = "";
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo người dùng đã chọn một hàng hợp lệ (không phải tiêu đề)
            {
                dgvStudent.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
