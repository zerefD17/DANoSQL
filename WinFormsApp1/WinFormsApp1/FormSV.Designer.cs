namespace WinFormsApp1
{
    partial class FormSV
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
            dataGridView1 = new DataGridView();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnHoaDon = new Button();
            txtID = new TextBox();
            txtEmail = new TextBox();
            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            dTPNgaySinh = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            cbxSoPhong = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(63, 430);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(980, 188);
            dataGridView1.TabIndex = 21;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(914, 96);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 22;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(914, 153);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 22;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(914, 224);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 22;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Location = new Point(914, 331);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(94, 29);
            btnHoaDon.TabIndex = 22;
            btnHoaDon.Text = "Hóa Đơn";
            btnHoaDon.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            txtID.Location = new Point(172, 102);
            txtID.Name = "txtID";
            txtID.Size = new Size(221, 27);
            txtID.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(554, 105);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(183, 27);
            txtEmail.TabIndex = 18;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(172, 175);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(221, 27);
            txtHoTen.TabIndex = 8;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(172, 322);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(221, 27);
            txtSDT.TabIndex = 17;
            // 
            // dTPNgaySinh
            // 
            dTPNgaySinh.Format = DateTimePickerFormat.Short;
            dTPNgaySinh.Location = new Point(172, 244);
            dTPNgaySinh.Name = "dTPNgaySinh";
            dTPNgaySinh.Size = new Size(221, 27);
            dTPNgaySinh.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 175);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 15;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 249);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 14;
            label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 322);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 13;
            label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(458, 109);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 12;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(458, 185);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 11;
            label6.Text = "Số Phòng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 105);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 16;
            label1.Text = "ID";
            // 
            // cbxSoPhong
            // 
            cbxSoPhong.FormattingEnabled = true;
            cbxSoPhong.Location = new Point(554, 185);
            cbxSoPhong.Name = "cbxSoPhong";
            cbxSoPhong.Size = new Size(183, 28);
            cbxSoPhong.TabIndex = 23;
            // 
            // FormSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 686);
            Controls.Add(cbxSoPhong);
            Controls.Add(btnHoaDon);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(dataGridView1);
            Controls.Add(dTPNgaySinh);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSDT);
            Controls.Add(txtHoTen);
            Controls.Add(txtEmail);
            Controls.Add(txtID);
            Name = "FormSV";
            Text = "FormSV";
            Load += FormSV_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnHoaDon;
        private TextBox txtID;
        private TextBox txtEmail;
        private TextBox txtHoTen;
        private TextBox txtSDT;
        private DateTimePicker dTPNgaySinh;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label1;
        private ComboBox cbxSoPhong;
    }
}