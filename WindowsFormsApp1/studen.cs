using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Student
    {
        public string Name { get; set; }
        public string StudentID { get; set; }
        public double Score { get; set; }

        public Student(string name, string studentID)
        {
            Name = name;
            StudentID = studentID;
        }
    }

}
