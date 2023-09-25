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
    public partial class Music : Form
    {
        public Music()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string song=lbSong.SelectedItem.ToString();
            lbFavorite.Items.Add(song);
            lbSong.Items.RemoveAt(lbSong.SelectedIndex);
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            while (lbSong.Items.Count > 0)
            {
                string song = lbSong.Items[0].ToString();
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(0);
            }
        }



        private void btnDeselectAll_Click(object sender, EventArgs e)
        {
            while (lbFavorite.Items.Count > 0)
            {
                string song = lbFavorite.Items[0].ToString();
                lbSong.Items.Add(song);
                lbFavorite.Items.RemoveAt(0);
            }
        }

        private void btnDeselect_Click(object sender, EventArgs e)
        {
            string song = lbFavorite.SelectedItem.ToString();
            lbSong.Items.Add(song);
            lbFavorite.Items.RemoveAt(lbFavorite.SelectedIndex);
        }
    }
}
