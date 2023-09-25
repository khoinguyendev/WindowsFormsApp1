namespace WindowsFormsApp1
{
    partial class Form22
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rtxtStatus = new System.Windows.Forms.RichTextBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.grpSex = new System.Windows.Forms.GroupBox();
            this.radWomen = new System.Windows.Forms.RadioButton();
            this.radMan = new System.Windows.Forms.RadioButton();
            this.lbKhoa = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.btnExits = new System.Windows.Forms.Button();
            this.grpSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(46, 57);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(54, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Họ và tên";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(46, 101);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(54, 13);
            this.lbDate.TabIndex = 1;
            this.lbDate.Text = "Ngày sinh";
            this.lbDate.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 20);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(233, 524);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // rtxtStatus
            // 
            this.rtxtStatus.Location = new System.Drawing.Point(120, 264);
            this.rtxtStatus.Name = "rtxtStatus";
            this.rtxtStatus.Size = new System.Drawing.Size(280, 251);
            this.rtxtStatus.TabIndex = 5;
            this.rtxtStatus.Text = "";
            this.rtxtStatus.TextChanged += new System.EventHandler(this.rtxtStatus_TextChanged);
            // 
            // dateTime
            // 
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime.Location = new System.Drawing.Point(120, 99);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(280, 20);
            this.dateTime.TabIndex = 6;
            this.dateTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // grpSex
            // 
            this.grpSex.Controls.Add(this.radWomen);
            this.grpSex.Controls.Add(this.radMan);
            this.grpSex.Location = new System.Drawing.Point(120, 136);
            this.grpSex.Name = "grpSex";
            this.grpSex.Size = new System.Drawing.Size(280, 53);
            this.grpSex.TabIndex = 7;
            this.grpSex.TabStop = false;
            this.grpSex.Text = "Giới tính";
            this.grpSex.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radWomen
            // 
            this.radWomen.AutoSize = true;
            this.radWomen.Location = new System.Drawing.Point(159, 19);
            this.radWomen.Name = "radWomen";
            this.radWomen.Size = new System.Drawing.Size(39, 17);
            this.radWomen.TabIndex = 1;
            this.radWomen.TabStop = true;
            this.radWomen.Text = "Nữ";
            this.radWomen.UseVisualStyleBackColor = true;
            // 
            // radMan
            // 
            this.radMan.AutoSize = true;
            this.radMan.Location = new System.Drawing.Point(60, 19);
            this.radMan.Name = "radMan";
            this.radMan.Size = new System.Drawing.Size(47, 17);
            this.radMan.TabIndex = 0;
            this.radMan.TabStop = true;
            this.radMan.Text = "Nam";
            this.radMan.UseVisualStyleBackColor = true;
            this.radMan.CheckedChanged += new System.EventHandler(this.radMan_CheckedChanged);
            // 
            // lbKhoa
            // 
            this.lbKhoa.AutoSize = true;
            this.lbKhoa.Location = new System.Drawing.Point(46, 214);
            this.lbKhoa.Name = "lbKhoa";
            this.lbKhoa.Size = new System.Drawing.Size(32, 13);
            this.lbKhoa.TabIndex = 8;
            this.lbKhoa.Text = "Khoa";
            this.lbKhoa.Click += new System.EventHandler(this.lbKhoa_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(46, 268);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(55, 13);
            this.lbStatus.TabIndex = 10;
            this.lbStatus.Text = "Trạng thái";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Items.AddRange(new object[] {
            "Công Nghệ Thông Tin",
            "Anh Văn",
            "Tự Động Hóa"});
            this.cbbKhoa.Location = new System.Drawing.Point(120, 211);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(280, 21);
            this.cbbKhoa.TabIndex = 11;
            this.cbbKhoa.Text = "Công Nghệ Thông Tin";
            this.cbbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbKhoa_SelectedIndexChanged);
            // 
            // btnExits
            // 
            this.btnExits.Location = new System.Drawing.Point(325, 524);
            this.btnExits.Name = "btnExits";
            this.btnExits.Size = new System.Drawing.Size(75, 23);
            this.btnExits.TabIndex = 12;
            this.btnExits.Text = "Thoát";
            this.btnExits.UseVisualStyleBackColor = true;
            this.btnExits.Click += new System.EventHandler(this.btnExits_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 561);
            this.Controls.Add(this.btnExits);
            this.Controls.Add(this.cbbKhoa);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbKhoa);
            this.Controls.Add(this.grpSex);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.rtxtStatus);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSex.ResumeLayout(false);
            this.grpSex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox rtxtStatus;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.GroupBox grpSex;
        private System.Windows.Forms.RadioButton radWomen;
        private System.Windows.Forms.RadioButton radMan;
        private System.Windows.Forms.Label lbKhoa;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.Button btnExits;
    }
}

