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
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txtTongSV);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(626, 304);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 77);
            panel1.TabIndex = 0;
            // 
            // txtTongSV
            // 
            txtTongSV.AutoSize = true;
            txtTongSV.Dock = DockStyle.Fill;
            txtTongSV.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            txtTongSV.ImageAlign = ContentAlignment.MiddleLeft;
            txtTongSV.Location = new Point(0, 20);
            txtTongSV.Name = "txtTongSV";
            txtTongSV.Size = new Size(33, 37);
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
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "Tổng số sinh viên";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(txtTongDoanhThu);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(29, 29);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 77);
            panel2.TabIndex = 0;
            // 
            // txtTongDoanhThu
            // 
            txtTongDoanhThu.AutoSize = true;
            txtTongDoanhThu.Dock = DockStyle.Fill;
            txtTongDoanhThu.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            txtTongDoanhThu.ImageAlign = ContentAlignment.MiddleLeft;
            txtTongDoanhThu.Location = new Point(0, 20);
            txtTongDoanhThu.Name = "txtTongDoanhThu";
            txtTongDoanhThu.Size = new Size(33, 37);
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
            label4.Size = new Size(133, 20);
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
            panel3.Location = new Point(27, 126);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(232, 77);
            panel3.TabIndex = 0;
            // 
            // txtSoLuongHD
            // 
            txtSoLuongHD.AutoSize = true;
            txtSoLuongHD.Dock = DockStyle.Fill;
            txtSoLuongHD.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoLuongHD.Location = new Point(0, 20);
            txtSoLuongHD.Name = "txtSoLuongHD";
            txtSoLuongHD.Size = new Size(33, 37);
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
            label6.Size = new Size(197, 20);
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
            panel4.Location = new Point(27, 200);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(232, 77);
            panel4.TabIndex = 0;
            // 
            // txtSoLuongHDDaTT
            // 
            txtSoLuongHDDaTT.AutoSize = true;
            txtSoLuongHDDaTT.Dock = DockStyle.Fill;
            txtSoLuongHDDaTT.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoLuongHDDaTT.Location = new Point(0, 20);
            txtSoLuongHDDaTT.Name = "txtSoLuongHDDaTT";
            txtSoLuongHDDaTT.Size = new Size(33, 37);
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
            label8.Size = new Size(103, 20);
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
            panel5.Location = new Point(27, 272);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(232, 77);
            panel5.TabIndex = 0;
            // 
            // txtSoLuongHDChuaTT
            // 
            txtSoLuongHDChuaTT.AutoSize = true;
            txtSoLuongHDChuaTT.Dock = DockStyle.Fill;
            txtSoLuongHDChuaTT.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoLuongHDChuaTT.Location = new Point(0, 20);
            txtSoLuongHDChuaTT.Name = "txtSoLuongHDChuaTT";
            txtSoLuongHDChuaTT.Size = new Size(33, 37);
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
            label10.Size = new Size(118, 20);
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
            panel6.Location = new Point(594, 29);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(238, 75);
            panel6.TabIndex = 0;
            // 
            // txtSSDien
            // 
            txtSSDien.AutoSize = true;
            txtSSDien.Dock = DockStyle.Left;
            txtSSDien.ForeColor = SystemColors.ActiveCaptionText;
            txtSSDien.Location = new Point(33, 20);
            txtSSDien.Name = "txtSSDien";
            txtSSDien.Size = new Size(13, 15);
            txtSSDien.TabIndex = 2;
            txtSSDien.Text = "0";
            // 
            // txtSoDien
            // 
            txtSoDien.AutoSize = true;
            txtSoDien.Dock = DockStyle.Left;
            txtSoDien.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoDien.Location = new Point(0, 20);
            txtSoDien.Name = "txtSoDien";
            txtSoDien.Size = new Size(33, 37);
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
            label12.Size = new Size(195, 20);
            label12.TabIndex = 0;
            label12.Text = "Điện sử dụng tháng này (Ký)";
            label12.Click += label4_Click;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveCaption;
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(txtSSNuoc);
            panel7.Controls.Add(txtSoNuoc);
            panel7.Controls.Add(label14);
            panel7.Location = new Point(594, 128);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(239, 75);
            panel7.TabIndex = 0;
            // 
            // txtSSNuoc
            // 
            txtSSNuoc.AutoSize = true;
            txtSSNuoc.Dock = DockStyle.Left;
            txtSSNuoc.ForeColor = SystemColors.ActiveCaptionText;
            txtSSNuoc.Location = new Point(33, 20);
            txtSSNuoc.Name = "txtSSNuoc";
            txtSSNuoc.Size = new Size(13, 15);
            txtSSNuoc.TabIndex = 2;
            txtSSNuoc.Text = "0";
            // 
            // txtSoNuoc
            // 
            txtSoNuoc.AutoSize = true;
            txtSoNuoc.Dock = DockStyle.Left;
            txtSoNuoc.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoNuoc.Location = new Point(0, 20);
            txtSoNuoc.Name = "txtSoNuoc";
            txtSoNuoc.Size = new Size(33, 37);
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
            label14.Size = new Size(211, 20);
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
            panel8.Location = new Point(404, 305);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(207, 77);
            panel8.TabIndex = 0;
            // 
            // txtTongPhong
            // 
            txtTongPhong.AutoSize = true;
            txtTongPhong.Dock = DockStyle.Fill;
            txtTongPhong.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            txtTongPhong.ImageAlign = ContentAlignment.MiddleLeft;
            txtTongPhong.Location = new Point(0, 20);
            txtTongPhong.Name = "txtTongPhong";
            txtTongPhong.Size = new Size(33, 37);
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
            label5.Size = new Size(109, 20);
            label5.TabIndex = 0;
            label5.Text = "Tổng số phòng";
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 426);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel8);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
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
    }
}