namespace WinFormsApp1
{
    partial class SinhVienForm
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
            dGV_SV = new DataGridView();
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
            label1 = new Label();
            dGV_Phong = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dGV_SV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dGV_Phong).BeginInit();
            SuspendLayout();
            // 
            // dGV_SV
            // 
            dGV_SV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV_SV.Location = new Point(12, 318);
            dGV_SV.Margin = new Padding(3, 2, 3, 2);
            dGV_SV.Name = "dGV_SV";
            dGV_SV.RowHeadersWidth = 51;
            dGV_SV.RowTemplate.Height = 29;
            dGV_SV.Size = new Size(858, 141);
            dGV_SV.TabIndex = 21;
            dGV_SV.CellClick += dataGridView1_CellClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(800, 72);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(82, 22);
            btnThem.TabIndex = 22;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(800, 115);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(82, 22);
            btnXoa.TabIndex = 22;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(800, 168);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(82, 22);
            btnSua.TabIndex = 22;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Location = new Point(800, 248);
            btnHoaDon.Margin = new Padding(3, 2, 3, 2);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(82, 22);
            btnHoaDon.TabIndex = 22;
            btnHoaDon.Text = "Hóa Đơn";
            btnHoaDon.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            txtID.Location = new Point(150, 42);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(194, 23);
            txtID.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 247);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(161, 23);
            txtEmail.TabIndex = 18;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(150, 87);
            txtHoTen.Margin = new Padding(3, 2, 3, 2);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(194, 23);
            txtHoTen.TabIndex = 8;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(150, 191);
            txtSDT.Margin = new Padding(3, 2, 3, 2);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(194, 23);
            txtSDT.TabIndex = 17;
            // 
            // dTPNgaySinh
            // 
            dTPNgaySinh.Format = DateTimePickerFormat.Short;
            dTPNgaySinh.Location = new Point(150, 139);
            dTPNgaySinh.Margin = new Padding(3, 2, 3, 2);
            dTPNgaySinh.Name = "dTPNgaySinh";
            dTPNgaySinh.Size = new Size(194, 23);
            dTPNgaySinh.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 87);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 15;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 139);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 14;
            label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 191);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 13;
            label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 252);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 12;
            label5.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 45);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 16;
            label1.Text = "ID";
            // 
            // dGV_Phong
            // 
            dGV_Phong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV_Phong.Location = new Point(455, 40);
            dGV_Phong.Name = "dGV_Phong";
            dGV_Phong.RowTemplate.Height = 25;
            dGV_Phong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGV_Phong.Size = new Size(240, 150);
            dGV_Phong.TabIndex = 24;
            dGV_Phong.CellClick += dGV_Phong_CellClick;
            // 
            // SinhVienForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 514);
            Controls.Add(dGV_Phong);
            Controls.Add(btnHoaDon);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(dGV_SV);
            Controls.Add(dTPNgaySinh);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSDT);
            Controls.Add(txtHoTen);
            Controls.Add(txtEmail);
            Controls.Add(txtID);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SinhVienForm";
            Text = "FormSV";
            Load += FormSV_Load;
            ((System.ComponentModel.ISupportInitialize)dGV_SV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dGV_Phong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dGV_SV;
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
        private Label label1;
        private DataGridView dGV_Phong;
    }
}