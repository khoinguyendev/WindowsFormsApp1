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
    public partial class Game : Form
    {
        private PictureBox pb = new PictureBox();
        private int xBall = 0;
        private int yBall = 0;
        private int stepSize = 100; // Kích thước bước di chuyển

        public Game()
        {
            InitializeComponent();
            KeyPreview = true; // Để Form nhận sự kiện KeyDown
        }

        private void Game_Load(object sender, EventArgs e)
        {
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(100, 100);
            pb.Location = new Point(xBall, yBall);
            Controls.Add(pb);
            pb.ImageLocation = @"d:\ball.jpg";
        }

        private void Game_KeyDown_1(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (xBall <= 0)
                    {
                        break;
                    }
                    xBall -= stepSize;
                    break;
                case Keys.Right:
                    if (xBall >= this.ClientSize.Width - pb.Width)
                    {
                        break;
                    }
                    xBall += stepSize;
                    break;
                case Keys.Up:
                    if(yBall <= 0)
                    {
                        break;
                    }
                    yBall -= stepSize;
                    break;
                case Keys.Down:
                    if (yBall >= this.ClientSize.Height - pb.Height)
                    {
                        break;
                    }
                    yBall += stepSize;
                    break;
            }

            // Cập nhật vị trí của hình ảnh
            pb.Location = new Point(xBall, yBall);
        }
    }
}
