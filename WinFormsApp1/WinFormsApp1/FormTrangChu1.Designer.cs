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
            panelMenu.Controls.Add(btnThongKe);
            panelMenu.Controls.Add(btnTinhTien);
            panelMenu.Controls.Add(btnPhong);
            panelMenu.Controls.Add(btnHoaDon);
            panelMenu.Controls.Add(btnSinhVien);
            panelMenu.Controls.Add(panelTitle);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(184, 562);
            panelMenu.TabIndex = 0;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.FromArgb(206, 234, 247);
            btnThongKe.Dock = DockStyle.Top;
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnThongKe.Location = new Point(0, 300);
            btnThongKe.Margin = new Padding(3, 2, 3, 2);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(184, 60);
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
            btnTinhTien.Location = new Point(0, 240);
            btnTinhTien.Margin = new Padding(3, 2, 3, 2);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(184, 60);
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
            btnPhong.Location = new Point(0, 180);
            btnPhong.Margin = new Padding(3, 2, 3, 2);
            btnPhong.Name = "btnPhong";
            btnPhong.Size = new Size(184, 60);
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
            btnHoaDon.Location = new Point(0, 120);
            btnHoaDon.Margin = new Padding(3, 2, 3, 2);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(184, 60);
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
            btnSinhVien.Location = new Point(0, 60);
            btnSinhVien.Margin = new Padding(3, 2, 3, 8);
            btnSinhVien.Name = "btnSinhVien";
            btnSinhVien.Size = new Size(184, 60);
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
            panelTitle.Margin = new Padding(3, 2, 3, 2);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(184, 60);
            panelTitle.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(222, 242, 200);
            label1.Location = new Point(2, 18);
            label1.Name = "label1";
            label1.Size = new Size(168, 25);
            label1.TabIndex = 0;
            label1.Text = "Quản lý điện nước";
            label1.Click += label1_Click;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panel1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(184, 0);
            panelMain.Margin = new Padding(3, 2, 3, 2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(938, 562);
            panelMain.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 32, 31);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(txtTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(938, 60);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.FromArgb(125, 130, 184);
            btnClose.Location = new Point(820, 14);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(43, 37);
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
            txtTitle.Location = new Point(310, 14);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(115, 30);
            txtTitle.TabIndex = 0;
            txtTitle.Text = "Trang chủ";
            txtTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormTrangChu1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 562);
            Controls.Add(panelMain);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 2, 3, 2);
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
    }
}