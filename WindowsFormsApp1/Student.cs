using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public string Picture { get; set; }

        public Student(string id,string name, string date, bool gender,string address, string picture)
        {
            Id = id;
            Name = name;
            Date = date;
            Gender = gender;
            Address = address;
            Picture = picture;
        }
    }
}
