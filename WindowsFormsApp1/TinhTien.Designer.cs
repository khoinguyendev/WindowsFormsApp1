namespace WindowsFormsApp1
{
    partial class TinhTien
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpSex = new System.Windows.Forms.GroupBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.ckGiam = new System.Windows.Forms.CheckBox();
            this.txtGiam = new System.Windows.Forms.TextBox();
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(28, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 20);
            this.txtName.TabIndex = 0;
            // 
            // grpSex
            // 
            this.grpSex.Controls.Add(this.radNu);
            this.grpSex.Controls.Add(this.radNam);
            this.grpSex.Location = new System.Drawing.Point(28, 67);
            this.grpSex.Name = "grpSex";
            this.grpSex.Size = new System.Drawing.Size(280, 80);
            this.grpSex.TabIndex = 1;
            this.grpSex.TabStop = false;
            this.grpSex.Text = "Giới tính";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(178, 35);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(39, 17);
            this.radNu.TabIndex = 1;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(32, 35);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(47, 17);
            this.radNam.TabIndex = 0;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // ckGiam
            // 
            this.ckGiam.AutoSize = true;
            this.ckGiam.Location = new System.Drawing.Point(33, 195);
            this.ckGiam.Name = "ckGiam";
            this.ckGiam.Size = new System.Drawing.Size(67, 17);
            this.ckGiam.TabIndex = 2;
            this.ckGiam.Text = "Giảm giá";
            this.ckGiam.UseVisualStyleBackColor = true;
            this.ckGiam.CheckedChanged += new System.EventHandler(this.ckGiam_CheckedChanged);
            // 
            // txtGiam
            // 
            this.txtGiam.Location = new System.Drawing.Point(119, 192);
            this.txtGiam.Name = "txtGiam";
            this.txtGiam.Size = new System.Drawing.Size(189, 20);
            this.txtGiam.TabIndex = 3;
            // 
            // rtxtContent
            // 
            this.rtxtContent.Location = new System.Drawing.Point(28, 256);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(280, 88);
            this.rtxtContent.TabIndex = 4;
            this.rtxtContent.Text = "";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(138, 375);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(77, 30);
            this.btnTinh.TabIndex = 5;
            this.btnTinh.Text = "Tính Tiền";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(232, 375);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 30);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // TinhTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.rtxtContent);
            this.Controls.Add(this.txtGiam);
            this.Controls.Add(this.ckGiam);
            this.Controls.Add(this.grpSex);
            this.Controls.Add(this.txtName);
            this.Name = "TinhTien";
            this.Text = "TinhTien";
            this.grpSex.ResumeLayout(false);
            this.grpSex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpSex;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.CheckBox ckGiam;
        private System.Windows.Forms.TextBox txtGiam;
        private System.Windows.Forms.RichTextBox rtxtContent;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnExit;
    }
}