using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    public class TracNghiem
    {
        public string question;
        public string[] answer;
        public TracNghiem(string Question,string[] ansew)
        {
            question = Question;
            answer = ansew;
        }
    }
}
