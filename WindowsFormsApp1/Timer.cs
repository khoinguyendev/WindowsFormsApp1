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
    public partial class Timer : Form
    {
        internal int Interval;
        internal System.Windows.Forms.Timer Tick;
        int second = 0;
        int phut = 0;
        int gio = 0;
        public Timer()
        {
            InitializeComponent();
            lbDisplay.Text = "00:00:00";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmStopwatch.Interval = 1000;
            tmStopwatch.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmStopwatch.Stop();
        }

        private void tmStopwatch_Tick(object sender, EventArgs e)
        {
            second++;
            if (second > 59)
            {
                phut++;
                second = 0;
            }
            if (phut > 59)
            {
                gio++;
                phut = 0;
            }
            lbDisplay.Text = ingio(gio) + ":" + inphut(phut) + ":" + ingiay(second);
        }

        private string ingiay(int s) {
            string a = "00";
            if(s <10)
            {
                a="0"+s.ToString();
            }
            else
            {
                a=s.ToString();
            }

            return a;
        }
        private string inphut(int s)
        {
            string a = "00";
            if (s < 10)
            {
                a = "0" + s.ToString();
            }
            else
            {
                a = s.ToString();
            }

            return a;
        }
        private string ingio(int s)
        {
            string a = "00";
            if (s < 10)
            {
                a = "0" + s.ToString();
            }
            else
            {
                a = s.ToString();
            }

            return a;
        }

        private void lbDisplay_Click(object sender, EventArgs e)
        {

        }

        private void Timer_Load(object sender, EventArgs e)
        {

        }
    }
}
