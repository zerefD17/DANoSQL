namespace WinFormsApp1
{
    partial class FormThongKe
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            txtTongSV = new Label();
            label1 = new Label();
            panel2 = new Panel();
            txtTongDoanhThu = new Label();
            label4 = new Label();
            panel3 = new Panel();
            txtSoLuongHD = new Label();
            label6 = new Label();
            bindingSource1 = new BindingSource(components);
            panel4 = new Panel();
            txtSoLuongHDDaTT = new Label();
            label8 = new Label();
            panel5 = new Panel();
            txtSoLuongHDChuaTT = new Label();
            label10 = new Label();
            panel6 = new Panel();
            txtSSDien = new Label();
            txtSoDien = new Label();
            label12 = new Label();
            panel7 = new Panel();
            txtSSNuoc = new Label();
            txtSoNuoc = new Label();
            label14 = new Label();
            panel8 = new Panel();
            txtTongPhong = new Label();
            label5 = new Label();
            panel9 = new Panel();
            txtTongDoanhThuThangNay = new Label();
            label3 = new Label();
            panel10 = new Panel();
            txtTongTienChuaThanhToan = new Label();
            label7 = new Label();
            panel11 = new Panel();
            txtSoPhongTrong = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txtTongSV);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(305, 170);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 101);
            panel1.TabIndex = 0;
            // 
            // txtTongSV
            // 
            txtTongSV.AutoSize = true;
            txtTongSV.Dock = DockStyle.Fill;
            txtTongSV.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            txtTongSV.ImageAlign = ContentAlignment.MiddleLeft;
            txtTongSV.Location = new Point(0, 25);
            txtTongSV.Name = "txtTongSV";
            txtTongSV.Size = new Size(40, 46);
            txtTongSV.TabIndex = 1;
            txtTongSV.Text = "0";
            txtTongSV.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageKey = "icons8-student-128 (1).png";
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 0;
            label1.Text = "Tổng số sinh viên";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(txtTongDoanhThu);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(33, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(262, 101);
            panel2.TabIndex = 0;
            // 
            // txtTongDoanhThu
            // 
            txtTongDoanhThu.AutoSize = true;
            txtTongDoanhThu.Dock = DockStyle.Fill;
            txtTongDoanhThu.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            txtTongDoanhThu.ImageAlign = ContentAlignment.MiddleLeft;
            txtTongDoanhThu.Location = new Point(0, 25);
            txtTongDoanhThu.Name = "txtTongDoanhThu";
            txtTongDoanhThu.Size = new Size(40, 46);
            txtTongDoanhThu.TabIndex = 1;
            txtTongDoanhThu.Text = "0";
            txtTongDoanhThu.TextAlign = ContentAlignment.MiddleCenter;
            txtTongDoanhThu.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ImageKey = "icons8-student-128 (1).png";
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(171, 25);
            label4.TabIndex = 0;
            label4.Text = "Tổng số doanh thu";
            label4.Click += label4_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(txtSoLuongHD);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(31, 168);
            panel3.Name = "panel3";
            panel3.Size = new Size(265, 101);
            panel3.TabIndex = 0;
            // 
            // txtSoLuongHD
            // 
            txtSoLuongHD.AutoSize = true;
            txtSoLuongHD.Dock = DockStyle.Fill;
            txtSoLuongHD.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoLuongHD.Location = new Point(0, 25);
            txtSoLuongHD.Name = "txtSoLuongHD";
            txtSoLuongHD.Size = new Size(40, 46);
            txtSoLuongHD.TabIndex = 1;
            txtSoLuongHD.Text = "0";
            txtSoLuongHD.TextAlign = ContentAlignment.MiddleLeft;
            txtSoLuongHD.Click += label3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ImageKey = "icons8-student-128 (1).png";
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(251, 25);
            label6.TabIndex = 0;
            label6.Text = "Số lượng hóa đơn tháng này";
            label6.Click += label4_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(txtSoLuongHDDaTT);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(31, 267);
            panel4.Name = "panel4";
            panel4.Size = new Size(265, 101);
            panel4.TabIndex = 0;
            // 
            // txtSoLuongHDDaTT
            // 
            txtSoLuongHDDaTT.AutoSize = true;
            txtSoLuongHDDaTT.Dock = DockStyle.Fill;
            txtSoLuongHDDaTT.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoLuongHDDaTT.Location = new Point(0, 25);
            txtSoLuongHDDaTT.Name = "txtSoLuongHDDaTT";
            txtSoLuongHDDaTT.Size = new Size(40, 46);
            txtSoLuongHDDaTT.TabIndex = 1;
            txtSoLuongHDDaTT.Text = "0";
            txtSoLuongHDDaTT.TextAlign = ContentAlignment.MiddleLeft;
            txtSoLuongHDDaTT.Click += label3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ActiveCaption;
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ImageKey = "icons8-student-128 (1).png";
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(132, 25);
            label8.TabIndex = 0;
            label8.Text = "Đã thanh toán";
            label8.Click += label4_Click;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(txtSoLuongHDChuaTT);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(31, 363);
            panel5.Name = "panel5";
            panel5.Size = new Size(265, 101);
            panel5.TabIndex = 0;
            // 
            // txtSoLuongHDChuaTT
            // 
            txtSoLuongHDChuaTT.AutoSize = true;
            txtSoLuongHDChuaTT.Dock = DockStyle.Fill;
            txtSoLuongHDChuaTT.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoLuongHDChuaTT.Location = new Point(0, 25);
            txtSoLuongHDChuaTT.Name = "txtSoLuongHDChuaTT";
            txtSoLuongHDChuaTT.Size = new Size(40, 46);
            txtSoLuongHDChuaTT.TabIndex = 1;
            txtSoLuongHDChuaTT.Text = "0";
            txtSoLuongHDChuaTT.TextAlign = ContentAlignment.MiddleLeft;
            txtSoLuongHDChuaTT.Click += label3_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ActiveCaption;
            label10.Dock = DockStyle.Top;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ImageKey = "icons8-student-128 (1).png";
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(153, 25);
            label10.TabIndex = 0;
            label10.Text = "Chưa thanh toán";
            label10.Click += label4_Click;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaption;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(txtSSDien);
            panel6.Controls.Add(txtSoDien);
            panel6.Controls.Add(label12);
            panel6.Location = new Point(602, 168);
            panel6.Name = "panel6";
            panel6.Size = new Size(271, 99);
            panel6.TabIndex = 0;
            panel6.Paint += panel6_Paint;
            // 
            // txtSSDien
            // 
            txtSSDien.AutoSize = true;
            txtSSDien.Dock = DockStyle.Left;
            txtSSDien.ForeColor = SystemColors.ActiveCaptionText;
            txtSSDien.Location = new Point(40, 25);
            txtSSDien.Name = "txtSSDien";
            txtSSDien.Size = new Size(17, 20);
            txtSSDien.TabIndex = 2;
            txtSSDien.Text = "0";
            // 
            // txtSoDien
            // 
            txtSoDien.AutoSize = true;
            txtSoDien.Dock = DockStyle.Left;
            txtSoDien.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoDien.Location = new Point(0, 25);
            txtSoDien.Name = "txtSoDien";
            txtSoDien.Size = new Size(40, 46);
            txtSoDien.TabIndex = 1;
            txtSoDien.Text = "0";
            txtSoDien.TextAlign = ContentAlignment.MiddleLeft;
            txtSoDien.Click += label3_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ActiveCaption;
            label12.Dock = DockStyle.Top;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ImageKey = "icons8-student-128 (1).png";
            label12.Location = new Point(0, 0);
            label12.Name = "label12";
            label12.Size = new Size(246, 25);
            label12.TabIndex = 0;
            label12.Text = "Điện sử dụng tháng này (Kí)";
            label12.Click += label4_Click;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveCaption;
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(txtSSNuoc);
            panel7.Controls.Add(txtSoNuoc);
            panel7.Controls.Add(label14);
            panel7.Location = new Point(602, 265);
            panel7.Name = "panel7";
            panel7.Size = new Size(273, 99);
            panel7.TabIndex = 0;
            // 
            // txtSSNuoc
            // 
            txtSSNuoc.AutoSize = true;
            txtSSNuoc.Dock = DockStyle.Left;
            txtSSNuoc.ForeColor = SystemColors.ActiveCaptionText;
            txtSSNuoc.Location = new Point(40, 25);
            txtSSNuoc.Name = "txtSSNuoc";
            txtSSNuoc.Size = new Size(17, 20);
            txtSSNuoc.TabIndex = 2;
            txtSSNuoc.Text = "0";
            // 
            // txtSoNuoc
            // 
            txtSoNuoc.AutoSize = true;
            txtSoNuoc.Dock = DockStyle.Left;
            txtSoNuoc.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoNuoc.Location = new Point(0, 25);
            txtSoNuoc.Name = "txtSoNuoc";
            txtSoNuoc.Size = new Size(40, 46);
            txtSoNuoc.TabIndex = 1;
            txtSoNuoc.Text = "0";
            txtSoNuoc.TextAlign = ContentAlignment.MiddleLeft;
            txtSoNuoc.Click += label3_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.ActiveCaption;
            label14.Dock = DockStyle.Top;
            label14.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ImageKey = "icons8-student-128 (1).png";
            label14.Location = new Point(0, 0);
            label14.Name = "label14";
            label14.Size = new Size(269, 25);
            label14.TabIndex = 0;
            label14.Text = "Nước sử dụng tháng này(Khối)";
            label14.Click += label4_Click;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ActiveCaption;
            panel8.BorderStyle = BorderStyle.Fixed3D;
            panel8.Controls.Add(txtTongPhong);
            panel8.Controls.Add(label5);
            panel8.Location = new Point(305, 266);
            panel8.Name = "panel8";
            panel8.Size = new Size(291, 99);
            panel8.TabIndex = 0;
            // 
            // txtTongPhong
            // 
            txtTongPhong.AutoSize = true;
            txtTongPhong.Dock = DockStyle.Fill;
            txtTongPhong.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            txtTongPhong.ImageAlign = ContentAlignment.MiddleLeft;
            txtTongPhong.Location = new Point(0, 25);
            txtTongPhong.Name = "txtTongPhong";
            txtTongPhong.Size = new Size(40, 46);
            txtTongPhong.TabIndex = 1;
            txtTongPhong.Text = "0";
            txtTongPhong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ImageKey = "icons8-student-128 (1).png";
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(139, 25);
            label5.TabIndex = 0;
            label5.Text = "Tổng số phòng";
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ActiveCaption;
            panel9.BorderStyle = BorderStyle.Fixed3D;
            panel9.Controls.Add(txtTongDoanhThuThangNay);
            panel9.Controls.Add(label3);
            panel9.Location = new Point(293, 38);
            panel9.Name = "panel9";
            panel9.Size = new Size(303, 101);
            panel9.TabIndex = 1;
            // 
            // txtTongDoanhThuThangNay
            // 
            txtTongDoanhThuThangNay.AutoSize = true;
            txtTongDoanhThuThangNay.Dock = DockStyle.Fill;
            txtTongDoanhThuThangNay.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            txtTongDoanhThuThangNay.ImageAlign = ContentAlignment.MiddleLeft;
            txtTongDoanhThuThangNay.Location = new Point(0, 25);
            txtTongDoanhThuThangNay.Name = "txtTongDoanhThuThangNay";
            txtTongDoanhThuThangNay.Size = new Size(40, 46);
            txtTongDoanhThuThangNay.TabIndex = 1;
            txtTongDoanhThuThangNay.Text = "0";
            txtTongDoanhThuThangNay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ImageKey = "icons8-student-128 (1).png";
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(293, 25);
            label3.TabIndex = 0;
            label3.Text = "Tổng số doanh thu tháng hiện tại";
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.ActiveCaption;
            panel10.BorderStyle = BorderStyle.Fixed3D;
            panel10.Controls.Add(txtTongTienChuaThanhToan);
            panel10.Controls.Add(label7);
            panel10.Location = new Point(594, 38);
            panel10.Name = "panel10";
            panel10.Size = new Size(357, 101);
            panel10.TabIndex = 2;
            // 
            // txtTongTienChuaThanhToan
            // 
            txtTongTienChuaThanhToan.AutoSize = true;
            txtTongTienChuaThanhToan.Dock = DockStyle.Fill;
            txtTongTienChuaThanhToan.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            txtTongTienChuaThanhToan.ImageAlign = ContentAlignment.MiddleLeft;
            txtTongTienChuaThanhToan.Location = new Point(0, 25);
            txtTongTienChuaThanhToan.Name = "txtTongTienChuaThanhToan";
            txtTongTienChuaThanhToan.Size = new Size(40, 46);
            txtTongTienChuaThanhToan.TabIndex = 1;
            txtTongTienChuaThanhToan.Text = "0";
            txtTongTienChuaThanhToan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ImageKey = "icons8-student-128 (1).png";
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(348, 25);
            label7.TabIndex = 0;
            label7.Text = "Tổng số tiền chưa thanh toán tháng này";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel11
            // 
            panel11.BackColor = SystemColors.ActiveCaption;
            panel11.BorderStyle = BorderStyle.Fixed3D;
            panel11.Controls.Add(txtSoPhongTrong);
            panel11.Controls.Add(label9);
            panel11.Location = new Point(305, 363);
            panel11.Name = "panel11";
            panel11.Size = new Size(291, 99);
            panel11.TabIndex = 2;
            // 
            // txtSoPhongTrong
            // 
            txtSoPhongTrong.AutoSize = true;
            txtSoPhongTrong.Dock = DockStyle.Fill;
            txtSoPhongTrong.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoPhongTrong.ImageAlign = ContentAlignment.MiddleLeft;
            txtSoPhongTrong.Location = new Point(0, 25);
            txtSoPhongTrong.Name = "txtSoPhongTrong";
            txtSoPhongTrong.Size = new Size(40, 46);
            txtSoPhongTrong.TabIndex = 1;
            txtSoPhongTrong.Text = "0";
            txtSoPhongTrong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveCaption;
            label9.Dock = DockStyle.Top;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ImageKey = "icons8-student-128 (1).png";
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(190, 25);
            label9.TabIndex = 0;
            label9.Text = "Tổng số phòng trống";
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 568);
            Controls.Add(panel11);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel8);
            Controls.Add(panel1);
            Name = "FormThongKe";
            Text = "FormThongKe";
            Load += FormThongKe_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label txtTongSV;
        private Panel panel2;
        private Label txtTongDoanhThu;
        private Label label4;
        private Panel panel3;
        private Label txtSoLuongHD;
        private Label label6;
        private BindingSource bindingSource1;
        private Panel panel4;
        private Label txtSoLuongHDDaTT;
        private Label label8;
        private Panel panel5;
        private Label txtSoLuongHDChuaTT;
        private Label label10;
        private Panel panel6;
        private Label txtSoDien;
        private Label label12;
        private Panel panel7;
        private Label txtSoNuoc;
        private Label label14;
        private Label txtSSDien;
        private Label txtSSNuoc;
        private Panel panel8;
        private Label txtTongPhong;
        private Label label5;
        private Panel panel9;
        private Label txtTongDoanhThuThangNay;
        private Label label3;
        private Panel panel10;
        private Label txtTongTienChuaThanhToan;
        private Label label7;
        private Panel panel11;
        private Label txtSoPhongTrong;
        private Label label9;
    }
}