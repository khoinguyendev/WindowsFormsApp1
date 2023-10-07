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
    public partial class HistoryFrom : Form
    {
        List<History> lst;
        public HistoryFrom(List<History> Lst)
        {
            InitializeComponent();
            lst = Lst;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HistoryFrom_Load(object sender, EventArgs e)
        {
            foreach(History s in lst)
            {
                dataGridView1.Rows.Add(s.operation,s.id,s.editingInformation,s.time);
            }
        }
    }
}
