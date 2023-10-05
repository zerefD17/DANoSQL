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
            btn_XoaSV.Location = new Point(448, 115);
            btn_XoaSV.Margin = new Padding(3, 4, 3, 4);
            btn_XoaSV.Name = "btn_XoaSV";
            btn_XoaSV.Size = new Size(139, 31);
            btn_XoaSV.TabIndex = 0;
            btn_XoaSV.Text = "Xóa sinh viên";
            btn_XoaSV.UseVisualStyleBackColor = true;
            btn_XoaSV.Click += btn_XoaSV_Click;
            // 
            // btn_ChuyenPhong
            // 
            btn_ChuyenPhong.Location = new Point(607, 115);
            btn_ChuyenPhong.Margin = new Padding(3, 4, 3, 4);
            btn_ChuyenPhong.Name = "btn_ChuyenPhong";
            btn_ChuyenPhong.Size = new Size(139, 31);
            btn_ChuyenPhong.TabIndex = 0;
            btn_ChuyenPhong.Text = "Chuyển phòng";
            btn_ChuyenPhong.UseVisualStyleBackColor = true;
            btn_ChuyenPhong.Click += btn_ChuyenPhong_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 27);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 1;
            label1.Text = "Phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(607, 12);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "Phòng trống";
            // 
            // cbb_Phong
            // 
            cbb_Phong.FormattingEnabled = true;
            cbb_Phong.Location = new Point(79, 23);
            cbb_Phong.Margin = new Padding(3, 4, 3, 4);
            cbb_Phong.Name = "cbb_Phong";
            cbb_Phong.Size = new Size(138, 28);
            cbb_Phong.TabIndex = 2;
            cbb_Phong.SelectedValueChanged += cbb_Phong_SelectedValueChanged;
            // 
            // cbb_PhongTrong
            // 
            cbb_PhongTrong.FormattingEnabled = true;
            cbb_PhongTrong.Location = new Point(607, 47);
            cbb_PhongTrong.Margin = new Padding(3, 4, 3, 4);
            cbb_PhongTrong.Name = "cbb_PhongTrong";
            cbb_PhongTrong.Size = new Size(138, 28);
            cbb_PhongTrong.TabIndex = 2;
            // 
            // dGV_SinhVien
            // 
            dGV_SinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV_SinhVien.Location = new Point(14, 188);
            dGV_SinhVien.Margin = new Padding(3, 4, 3, 4);
            dGV_SinhVien.Name = "dGV_SinhVien";
            dGV_SinhVien.ReadOnly = true;
            dGV_SinhVien.RowHeadersWidth = 51;
            dGV_SinhVien.RowTemplate.Height = 25;
            dGV_SinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGV_SinhVien.Size = new Size(874, 313);
            dGV_SinhVien.TabIndex = 3;
            // 
            // btm_timPhongTrong
            // 
            btm_timPhongTrong.Location = new Point(448, 47);
            btm_timPhongTrong.Margin = new Padding(3, 4, 3, 4);
            btm_timPhongTrong.Name = "btm_timPhongTrong";
            btm_timPhongTrong.Size = new Size(126, 31);
            btm_timPhongTrong.TabIndex = 4;
            btm_timPhongTrong.Text = "Tìm phòng trống";
            btm_timPhongTrong.UseVisualStyleBackColor = true;
            btm_timPhongTrong.Click += btm_timPhongTrong_Click;
            // 
            // grb_Sv_Hd
            // 
            grb_Sv_Hd.Controls.Add(rdb_HoaDon);
            grb_Sv_Hd.Controls.Add(rdb_SV);
            grb_Sv_Hd.Location = new Point(21, 55);
            grb_Sv_Hd.Margin = new Padding(3, 4, 3, 4);
            grb_Sv_Hd.Name = "grb_Sv_Hd";
            grb_Sv_Hd.Padding = new Padding(3, 4, 3, 4);
            grb_Sv_Hd.Size = new Size(302, 124);
            grb_Sv_Hd.TabIndex = 5;
            grb_Sv_Hd.TabStop = false;
            // 
            // rdb_HoaDon
            // 
            rdb_HoaDon.AutoSize = true;
            rdb_HoaDon.Location = new Point(163, 45);
            rdb_HoaDon.Margin = new Padding(3, 4, 3, 4);
            rdb_HoaDon.Name = "rdb_HoaDon";
            rdb_HoaDon.Size = new Size(88, 24);
            rdb_HoaDon.TabIndex = 1;
            rdb_HoaDon.Text = "Hóa đơn";
            rdb_HoaDon.UseVisualStyleBackColor = true;
            rdb_HoaDon.CheckedChanged += rdb_HoaDon_CheckedChanged;
            // 
            // rdb_SV
            // 
            rdb_SV.AutoSize = true;
            rdb_SV.Checked = true;
            rdb_SV.Location = new Point(7, 45);
            rdb_SV.Margin = new Padding(3, 4, 3, 4);
            rdb_SV.Name = "rdb_SV";
            rdb_SV.Size = new Size(91, 24);
            rdb_SV.TabIndex = 0;
            rdb_SV.TabStop = true;
            rdb_SV.Text = "Sinh Viên";
            rdb_SV.UseVisualStyleBackColor = true;
            rdb_SV.CheckedChanged += rdb_SV_CheckedChanged;
            // 
            // FormQLPhongSv
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(914, 600);
            Controls.Add(grb_Sv_Hd);
            Controls.Add(btm_timPhongTrong);
            Controls.Add(dGV_SinhVien);
            Controls.Add(cbb_PhongTrong);
            Controls.Add(cbb_Phong);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_ChuyenPhong);
            Controls.Add(btn_XoaSV);
            Margin = new Padding(3, 4, 3, 4);
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