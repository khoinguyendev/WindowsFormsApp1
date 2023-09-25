using System;
using System.Collections;
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
    public partial class Music2 : Form
    {
        public Music2()
        {
            InitializeComponent();
        }
        public ArrayList GetData()
        {
            ArrayList data = new ArrayList();
            Song song = new Song(001,"Violet","Xạ thủ");
            data.Add(song);

            song = new Song(002, "Joker", "Xạ thủ");
            data.Add(song);

            song = new Song(003, "Tulen", "Pháp sư");
            data.Add(song);
            return data;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Music2_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            listBox1.DataSource = lst;
            listBox1.DisplayMember="Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Song song = (Song)listBox1.SelectedItem;
            string id = song.Id.ToString();
            string name=song.Name.ToString();
            string author=song.Author.ToString();
            listBox2.Items.Add(id+" - "+name+" - "+author);
        }
    }
}
