using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class History
    {
        public string operation { get; set; }
        public string id { get; set; }
        public string editingInformation { get; set; }

        public string time { get; set; }

        public History(string Operation,string Id,string EditingInformation,string Time)
        {
            operation = Operation;
            id = Id;
            editingInformation = EditingInformation;
            time = Time;
        }
    }
}
