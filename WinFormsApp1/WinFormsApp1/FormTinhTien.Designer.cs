namespace WinFormsApp1
{
    partial class FormTinhTien
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
            label1 = new Label();
            cbb_Phong = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_CSDienCu = new TextBox();
            txt_CSNuocCu = new TextBox();
            txt_CSNuocMoi = new TextBox();
            txt_CSDienMoi = new TextBox();
            btn_TaoHoaDon = new Button();
            btn_ThanhToan = new Button();
            dGV_HoaDon = new DataGridView();
            txt_Ky = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dGV_HoaDon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 49);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Phòng";
            // 
            // cbb_Phong
            // 
            cbb_Phong.FormattingEnabled = true;
            cbb_Phong.Location = new Point(113, 41);
            cbb_Phong.Name = "cbb_Phong";
            cbb_Phong.Size = new Size(121, 23);
            cbb_Phong.TabIndex = 1;
            cbb_Phong.SelectedValueChanged += cbb_Phong_SelectedValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(425, 49);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 0;
            label2.Text = "Kỳ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 91);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 0;
            label3.Text = "Chỉ số điện cũ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(425, 91);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 0;
            label4.Text = "Chỉ số điện mới";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 130);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 0;
            label5.Text = "Chỉ số nước cũ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(425, 130);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 0;
            label6.Text = "Chỉ số nước mới";
            // 
            // txt_CSDienCu
            // 
            txt_CSDienCu.Location = new Point(113, 91);
            txt_CSDienCu.Name = "txt_CSDienCu";
            txt_CSDienCu.Size = new Size(100, 23);
            txt_CSDienCu.TabIndex = 2;
            // 
            // txt_CSNuocCu
            // 
            txt_CSNuocCu.Location = new Point(113, 127);
            txt_CSNuocCu.Name = "txt_CSNuocCu";
            txt_CSNuocCu.Size = new Size(100, 23);
            txt_CSNuocCu.TabIndex = 2;
            // 
            // txt_CSNuocMoi
            // 
            txt_CSNuocMoi.Location = new Point(533, 127);
            txt_CSNuocMoi.Name = "txt_CSNuocMoi";
            txt_CSNuocMoi.Size = new Size(100, 23);
            txt_CSNuocMoi.TabIndex = 2;
            // 
            // txt_CSDienMoi
            // 
            txt_CSDienMoi.Location = new Point(533, 91);
            txt_CSDienMoi.Name = "txt_CSDienMoi";
            txt_CSDienMoi.Size = new Size(100, 23);
            txt_CSDienMoi.TabIndex = 2;
            // 
            // btn_TaoHoaDon
            // 
            btn_TaoHoaDon.Location = new Point(533, 179);
            btn_TaoHoaDon.Name = "btn_TaoHoaDon";
            btn_TaoHoaDon.Size = new Size(116, 23);
            btn_TaoHoaDon.TabIndex = 4;
            btn_TaoHoaDon.Text = "Tạo hóa đơn";
            btn_TaoHoaDon.UseVisualStyleBackColor = true;
            btn_TaoHoaDon.Click += btn_TaoHoaDon_Click;
            // 
            // btn_ThanhToan
            // 
            btn_ThanhToan.Location = new Point(553, 466);
            btn_ThanhToan.Name = "btn_ThanhToan";
            btn_ThanhToan.Size = new Size(116, 23);
            btn_ThanhToan.TabIndex = 6;
            btn_ThanhToan.Text = "Thanh Toán";
            btn_ThanhToan.UseVisualStyleBackColor = true;
            btn_ThanhToan.Click += btn_ThanhToan_Click;
            // 
            // dGV_HoaDon
            // 
            dGV_HoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV_HoaDon.Location = new Point(41, 224);
            dGV_HoaDon.Name = "dGV_HoaDon";
            dGV_HoaDon.RowTemplate.Height = 25;
            dGV_HoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGV_HoaDon.Size = new Size(587, 212);
            dGV_HoaDon.TabIndex = 5;
            // 
            // txt_Ky
            // 
            txt_Ky.Location = new Point(533, 41);
            txt_Ky.Name = "txt_Ky";
            txt_Ky.Size = new Size(100, 23);
            txt_Ky.TabIndex = 7;
            // 
            // FormTinhTien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 523);
            Controls.Add(txt_Ky);
            Controls.Add(btn_ThanhToan);
            Controls.Add(dGV_HoaDon);
            Controls.Add(btn_TaoHoaDon);
            Controls.Add(txt_CSDienMoi);
            Controls.Add(txt_CSNuocMoi);
            Controls.Add(txt_CSNuocCu);
            Controls.Add(txt_CSDienCu);
            Controls.Add(cbb_Phong);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormTinhTien";
            Text = "FormTinhTien";
            Load += FormTinhTien_Load;
            ((System.ComponentModel.ISupportInitialize)dGV_HoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbb_Phong;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_CSDienCu;
        private TextBox txt_CSNuocCu;
        private TextBox txt_CSNuocMoi;
        private TextBox txt_CSDienMoi;
        private Button btn_TaoHoaDon;
        private Button btn_ThanhToan;
        private DataGridView dGV_HoaDon;
        private TextBox txt_Ky;
    }
}