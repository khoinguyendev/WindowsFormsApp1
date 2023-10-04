using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class NhanSu
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Sex { get; set; }
        public string Khoa{ get; set; }

    public NhanSu(string name, string date,string sex,string khoa)
        {
            Name = name;
            Date = date;
            Sex = sex;
            Khoa = khoa;
        }
    }

}
