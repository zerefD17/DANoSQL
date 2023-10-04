namespace WinFormsApp1
{
    partial class FormQLPhongSv
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
            btn_XoaSV = new Button();
            btn_ChuyenPhong = new Button();
            label1 = new Label();
            label2 = new Label();
            cbb_Phong = new ComboBox();
            cbb_PhongTrong = new ComboBox();
            dGV_SinhVien = new DataGridView();
            btm_timPhongTrong = new Button();
            grb_Sv_Hd = new GroupBox();
            rdb_HoaDon = new RadioButton();
            rdb_SV = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dGV_SinhVien).BeginInit();
            grb_Sv_Hd.SuspendLayout();
            SuspendLayout();
            // 
            // btn_XoaSV
            // 
            btn_XoaSV.Location = new Point(392, 86);
            btn_XoaSV.Name = "btn_XoaSV";
            btn_XoaSV.Size = new Size(122, 23);
            btn_XoaSV.TabIndex = 0;
            btn_XoaSV.Text = "Xóa sinh viên";
            btn_XoaSV.UseVisualStyleBackColor = true;
            btn_XoaSV.Click += btn_XoaSV_Click;
            // 
            // btn_ChuyenPhong
            // 
            btn_ChuyenPhong.Location = new Point(531, 86);
            btn_ChuyenPhong.Name = "btn_ChuyenPhong";
            btn_ChuyenPhong.Size = new Size(122, 23);
            btn_ChuyenPhong.TabIndex = 0;
            btn_ChuyenPhong.Text = "Chuyển phòng";
            btn_ChuyenPhong.UseVisualStyleBackColor = true;
            btn_ChuyenPhong.Click += btn_ChuyenPhong_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(531, 9);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 1;
            label2.Text = "Phòng trống";
            // 
            // cbb_Phong
            // 
            cbb_Phong.FormattingEnabled = true;
            cbb_Phong.Location = new Point(69, 17);
            cbb_Phong.Name = "cbb_Phong";
            cbb_Phong.Size = new Size(121, 23);
            cbb_Phong.TabIndex = 2;
            cbb_Phong.SelectedValueChanged += cbb_Phong_SelectedValueChanged;
            // 
            // cbb_PhongTrong
            // 
            cbb_PhongTrong.FormattingEnabled = true;
            cbb_PhongTrong.Location = new Point(531, 35);
            cbb_PhongTrong.Name = "cbb_PhongTrong";
            cbb_PhongTrong.Size = new Size(121, 23);
            cbb_PhongTrong.TabIndex = 2;
            // 
            // dGV_SinhVien
            // 
            dGV_SinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV_SinhVien.Location = new Point(12, 141);
            dGV_SinhVien.Name = "dGV_SinhVien";
            dGV_SinhVien.ReadOnly = true;
            dGV_SinhVien.RowTemplate.Height = 25;
            dGV_SinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGV_SinhVien.Size = new Size(765, 235);
            dGV_SinhVien.TabIndex = 3;
            // 
            // btm_timPhongTrong
            // 
            btm_timPhongTrong.Location = new Point(392, 35);
            btm_timPhongTrong.Name = "btm_timPhongTrong";
            btm_timPhongTrong.Size = new Size(110, 23);
            btm_timPhongTrong.TabIndex = 4;
            btm_timPhongTrong.Text = "Tìm phòng trống";
            btm_timPhongTrong.UseVisualStyleBackColor = true;
            btm_timPhongTrong.Click += btm_timPhongTrong_Click;
            // 
            // grb_Sv_Hd
            // 
            grb_Sv_Hd.Controls.Add(rdb_HoaDon);
            grb_Sv_Hd.Controls.Add(rdb_SV);
            grb_Sv_Hd.Location = new Point(18, 41);
            grb_Sv_Hd.Name = "grb_Sv_Hd";
            grb_Sv_Hd.Size = new Size(264, 93);
            grb_Sv_Hd.TabIndex = 5;
            grb_Sv_Hd.TabStop = false;
            // 
            // rdb_HoaDon
            // 
            rdb_HoaDon.AutoSize = true;
            rdb_HoaDon.Location = new Point(143, 34);
            rdb_HoaDon.Name = "rdb_HoaDon";
            rdb_HoaDon.Size = new Size(71, 19);
            rdb_HoaDon.TabIndex = 1;
            rdb_HoaDon.Text = "Hóa đơn";
            rdb_HoaDon.UseVisualStyleBackColor = true;
            rdb_HoaDon.CheckedChanged += rdb_HoaDon_CheckedChanged;
            // 
            // rdb_SV
            // 
            rdb_SV.AutoSize = true;
            rdb_SV.Checked = true;
            rdb_SV.Location = new Point(6, 34);
            rdb_SV.Name = "rdb_SV";
            rdb_SV.Size = new Size(74, 19);
            rdb_SV.TabIndex = 0;
            rdb_SV.TabStop = true;
            rdb_SV.Text = "Sinh Viên";
            rdb_SV.UseVisualStyleBackColor = true;
            rdb_SV.CheckedChanged += rdb_SV_CheckedChanged;
            // 
            // FormQLPhongSv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grb_Sv_Hd);
            Controls.Add(btm_timPhongTrong);
            Controls.Add(dGV_SinhVien);
            Controls.Add(cbb_PhongTrong);
            Controls.Add(cbb_Phong);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_ChuyenPhong);
            Controls.Add(btn_XoaSV);
            Name = "FormQLPhongSv";
            Text = "FormQLPhongSv";
            Load += FormQLPhongSv_Load;
            ((System.ComponentModel.ISupportInitialize)dGV_SinhVien).EndInit();
            grb_Sv_Hd.ResumeLayout(false);
            grb_Sv_Hd.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_XoaSV;
        private Button btn_ChuyenPhong;
        private Label label1;
        private Label label2;
        private ComboBox cbb_Phong;
        private ComboBox cbb_PhongTrong;
        private DataGridView dGV_SinhVien;
        private Button btm_timPhongTrong;
        private GroupBox grb_Sv_Hd;
        private RadioButton rdb_HoaDon;
        private RadioButton rdb_SV;
    }
}