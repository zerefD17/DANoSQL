namespace WinFormsApp1
{
    partial class FormTrangChu1
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
            panelMenu = new Panel();
            btnPhucHoi = new Button();
            btnSaoLuu = new Button();
            btnThongKe = new Button();
            btnTinhTien = new Button();
            btnPhong = new Button();
            btnHoaDon = new Button();
            btnSinhVien = new Button();
            panelTitle = new Panel();
            label1 = new Label();
            panelMain = new Panel();
            panel1 = new Panel();
            btnClose = new Button();
            txtTitle = new Label();
            panelMenu.SuspendLayout();
            panelTitle.SuspendLayout();
            panelMain.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(29, 32, 31);
            panelMenu.Controls.Add(btnPhucHoi);
            panelMenu.Controls.Add(btnSaoLuu);
            panelMenu.Controls.Add(btnThongKe);
            panelMenu.Controls.Add(btnTinhTien);
            panelMenu.Controls.Add(btnPhong);
            panelMenu.Controls.Add(btnHoaDon);
            panelMenu.Controls.Add(btnSinhVien);
            panelMenu.Controls.Add(panelTitle);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(210, 749);
            panelMenu.TabIndex = 0;
            // 
            // btnPhucHoi
            // 
            btnPhucHoi.BackColor = Color.FromArgb(206, 234, 247);
            btnPhucHoi.Dock = DockStyle.Top;
            btnPhucHoi.FlatAppearance.BorderSize = 0;
            btnPhucHoi.FlatStyle = FlatStyle.Flat;
            btnPhucHoi.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnPhucHoi.Location = new Point(0, 560);
            btnPhucHoi.Name = "btnPhucHoi";
            btnPhucHoi.Size = new Size(210, 80);
            btnPhucHoi.TabIndex = 7;
            btnPhucHoi.Text = "Phục hồi";
            btnPhucHoi.UseVisualStyleBackColor = false;
            btnPhucHoi.Click += btnPhucHoi_Click;
            // 
            // btnSaoLuu
            // 
            btnSaoLuu.BackColor = Color.FromArgb(206, 234, 247);
            btnSaoLuu.Dock = DockStyle.Top;
            btnSaoLuu.FlatAppearance.BorderSize = 0;
            btnSaoLuu.FlatStyle = FlatStyle.Flat;
            btnSaoLuu.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaoLuu.Location = new Point(0, 480);
            btnSaoLuu.Name = "btnSaoLuu";
            btnSaoLuu.Size = new Size(210, 80);
            btnSaoLuu.TabIndex = 6;
            btnSaoLuu.Text = "Sao Lưu";
            btnSaoLuu.UseVisualStyleBackColor = false;
            btnSaoLuu.Click += btnSaoLuu_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.FromArgb(206, 234, 247);
            btnThongKe.Dock = DockStyle.Top;
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnThongKe.Location = new Point(0, 400);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(210, 80);
            btnThongKe.TabIndex = 5;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnTinhTien
            // 
            btnTinhTien.BackColor = Color.FromArgb(222, 242, 200);
            btnTinhTien.Dock = DockStyle.Top;
            btnTinhTien.FlatAppearance.BorderSize = 0;
            btnTinhTien.FlatStyle = FlatStyle.Flat;
            btnTinhTien.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnTinhTien.Location = new Point(0, 320);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(210, 80);
            btnTinhTien.TabIndex = 4;
            btnTinhTien.Text = "Tính tiền";
            btnTinhTien.UseVisualStyleBackColor = false;
            btnTinhTien.Click += btnTinhTien_Click;
            // 
            // btnPhong
            // 
            btnPhong.BackColor = Color.FromArgb(206, 234, 247);
            btnPhong.Dock = DockStyle.Top;
            btnPhong.FlatAppearance.BorderSize = 0;
            btnPhong.FlatStyle = FlatStyle.Flat;
            btnPhong.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnPhong.Location = new Point(0, 240);
            btnPhong.Name = "btnPhong";
            btnPhong.Size = new Size(210, 80);
            btnPhong.TabIndex = 3;
            btnPhong.Text = "Phòng";
            btnPhong.UseVisualStyleBackColor = false;
            btnPhong.Click += btnPhong_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.BackColor = Color.FromArgb(222, 242, 200);
            btnHoaDon.Dock = DockStyle.Top;
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnHoaDon.Location = new Point(0, 160);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(210, 80);
            btnHoaDon.TabIndex = 2;
            btnHoaDon.Text = "Quản Lý Sinh Viên - Phòng";
            btnHoaDon.UseVisualStyleBackColor = false;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnSinhVien
            // 
            btnSinhVien.BackColor = Color.FromArgb(206, 234, 247);
            btnSinhVien.Dock = DockStyle.Top;
            btnSinhVien.FlatAppearance.BorderSize = 0;
            btnSinhVien.FlatStyle = FlatStyle.Flat;
            btnSinhVien.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnSinhVien.Location = new Point(0, 80);
            btnSinhVien.Margin = new Padding(3, 3, 3, 11);
            btnSinhVien.Name = "btnSinhVien";
            btnSinhVien.Size = new Size(210, 80);
            btnSinhVien.TabIndex = 1;
            btnSinhVien.Text = "Sinh viên";
            btnSinhVien.UseVisualStyleBackColor = false;
            btnSinhVien.Click += btnSinhVien_Click;
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(29, 32, 31);
            panelTitle.Controls.Add(label1);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(210, 80);
            panelTitle.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(222, 242, 200);
            label1.Location = new Point(2, 24);
            label1.Name = "label1";
            label1.Size = new Size(202, 30);
            label1.TabIndex = 0;
            label1.Text = "Quản lý điện nước";
            label1.Click += label1_Click;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panel1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(210, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1072, 749);
            panelMain.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 32, 31);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(txtTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1072, 80);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.FromArgb(125, 130, 184);
            btnClose.Location = new Point(937, 19);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(49, 49);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += button1_Click;
            // 
            // txtTitle
            // 
            txtTitle.AutoSize = true;
            txtTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitle.ForeColor = Color.FromArgb(241, 171, 134);
            txtTitle.Location = new Point(354, 19);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(142, 37);
            txtTitle.TabIndex = 0;
            txtTitle.Text = "Trang chủ";
            txtTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormTrangChu1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 749);
            Controls.Add(panelMain);
            Controls.Add(panelMenu);
            Name = "FormTrangChu1";
            Text = "FormTrangChu";
            Load += FormTrangChu_Load;
            panelMenu.ResumeLayout(false);
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            panelMain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelTitle;
        private Label label1;
        private Button btnSinhVien;
        private Button btnTinhTien;
        private Button btnPhong;
        private Button btnHoaDon;
        private Panel panelMain;
        private Panel panel1;
        private Label txtTitle;
        private Button btnClose;
        private Button btnThongKe;
        private Button btnPhucHoi;
        private Button btnSaoLuu;
    }
}