namespace WindowsFormsApp1
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnForm1 = new System.Windows.Forms.Button();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.btnCaculator = new System.Windows.Forms.Button();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.tbnMusic = new System.Windows.Forms.Button();
            this.btnMusic2 = new System.Windows.Forms.Button();
            this.btnQLNS = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnForm1
            // 
            this.btnForm1.Location = new System.Drawing.Point(54, 102);
            this.btnForm1.Name = "btnForm1";
            this.btnForm1.Size = new System.Drawing.Size(77, 38);
            this.btnForm1.TabIndex = 0;
            this.btnForm1.Text = "Form1";
            this.btnForm1.UseVisualStyleBackColor = true;
            this.btnForm1.Click += new System.EventHandler(this.btnForm1_Click);
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(157, 102);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(73, 40);
            this.btnForm2.TabIndex = 1;
            this.btnForm2.Text = "Form2";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // btnCaculator
            // 
            this.btnCaculator.Location = new System.Drawing.Point(257, 103);
            this.btnCaculator.Name = "btnCaculator";
            this.btnCaculator.Size = new System.Drawing.Size(77, 38);
            this.btnCaculator.TabIndex = 2;
            this.btnCaculator.Text = "caulator";
            this.btnCaculator.UseVisualStyleBackColor = true;
            this.btnCaculator.Click += new System.EventHandler(this.btnCaculator_Click);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(368, 103);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(76, 38);
            this.btnTinhTien.TabIndex = 3;
            this.btnTinhTien.Text = "TinhTien";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // tbnMusic
            // 
            this.tbnMusic.Location = new System.Drawing.Point(477, 105);
            this.tbnMusic.Name = "tbnMusic";
            this.tbnMusic.Size = new System.Drawing.Size(73, 36);
            this.tbnMusic.TabIndex = 4;
            this.tbnMusic.Text = "music";
            this.tbnMusic.UseVisualStyleBackColor = true;
            this.tbnMusic.Click += new System.EventHandler(this.tbnMusic_Click);
            // 
            // btnMusic2
            // 
            this.btnMusic2.Location = new System.Drawing.Point(60, 170);
            this.btnMusic2.Name = "btnMusic2";
            this.btnMusic2.Size = new System.Drawing.Size(70, 42);
            this.btnMusic2.TabIndex = 5;
            this.btnMusic2.Text = "music2";
            this.btnMusic2.UseVisualStyleBackColor = true;
            this.btnMusic2.Click += new System.EventHandler(this.btnMusic2_Click);
            // 
            // btnQLNS
            // 
            this.btnQLNS.Location = new System.Drawing.Point(163, 174);
            this.btnQLNS.Name = "btnQLNS";
            this.btnQLNS.Size = new System.Drawing.Size(66, 37);
            this.btnQLNS.TabIndex = 6;
            this.btnQLNS.Text = "QLNS";
            this.btnQLNS.UseVisualStyleBackColor = true;
            this.btnQLNS.Click += new System.EventHandler(this.btnQLNS_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(261, 177);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(72, 34);
            this.btnTimer.TabIndex = 7;
            this.btnTimer.Text = "Timer";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // btnGame
            // 
            this.btnGame.Location = new System.Drawing.Point(372, 178);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(71, 33);
            this.btnGame.TabIndex = 8;
            this.btnGame.Text = "Game";
            this.btnGame.UseVisualStyleBackColor = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.btnQLNS);
            this.Controls.Add(this.btnMusic2);
            this.Controls.Add(this.tbnMusic);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.btnCaculator);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.btnForm1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnForm1;
        private System.Windows.Forms.Button btnForm2;
        private System.Windows.Forms.Button btnCaculator;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button tbnMusic;
        private System.Windows.Forms.Button btnMusic2;
        private System.Windows.Forms.Button btnQLNS;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button btnGame;
    }
}