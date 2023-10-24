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
            btnSua = new Button();
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
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dGV_SV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dGV_Phong).BeginInit();
            SuspendLayout();
            // 
            // dGV_SV
            // 
            dGV_SV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV_SV.Location = new Point(14, 424);
            dGV_SV.Name = "dGV_SV";
            dGV_SV.RowHeadersWidth = 51;
            dGV_SV.RowTemplate.Height = 29;
            dGV_SV.Size = new Size(981, 188);
            dGV_SV.TabIndex = 21;
            dGV_SV.CellClick += dataGridView1_CellClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(520, 327);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 22;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(700, 327);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 22;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(171, 56);
            txtID.Name = "txtID";
            txtID.Size = new Size(221, 27);
            txtID.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(171, 329);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(183, 27);
            txtEmail.TabIndex = 18;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(171, 116);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(221, 27);
            txtHoTen.TabIndex = 8;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(171, 255);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(221, 27);
            txtSDT.TabIndex = 17;
            // 
            // dTPNgaySinh
            // 
            dTPNgaySinh.Format = DateTimePickerFormat.Short;
            dTPNgaySinh.Location = new Point(171, 185);
            dTPNgaySinh.Name = "dTPNgaySinh";
            dTPNgaySinh.Size = new Size(221, 27);
            dTPNgaySinh.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 116);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 15;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 185);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 14;
            label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 255);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 13;
            label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 336);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 12;
            label5.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 60);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 16;
            label1.Text = "ID";
            // 
            // dGV_Phong
            // 
            dGV_Phong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV_Phong.Location = new Point(520, 53);
            dGV_Phong.Margin = new Padding(3, 4, 3, 4);
            dGV_Phong.Name = "dGV_Phong";
            dGV_Phong.RowHeadersWidth = 51;
            dGV_Phong.RowTemplate.Height = 25;
            dGV_Phong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGV_Phong.Size = new Size(274, 200);
            dGV_Phong.TabIndex = 24;
            dGV_Phong.CellClick += dGV_Phong_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(870, 39);
            button1.Name = "button1";
            button1.Size = new Size(125, 44);
            button1.TabIndex = 25;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // SinhVienForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 685);
            Controls.Add(button1);
            Controls.Add(dGV_Phong);
            Controls.Add(btnSua);
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
        private Button btnSua;
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
        private Button button1;
    }
}