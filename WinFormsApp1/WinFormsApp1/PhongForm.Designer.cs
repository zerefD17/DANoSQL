namespace WinFormsApp1
{
    partial class PhongForm
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
            label1 = new Label();
            label2 = new Label();
            txtSoPhong = new TextBox();
            txtLoaiPhong = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btn_SV = new Button();
            button1 = new Button();
            btn_QlSVP = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(102, 218);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(364, 141);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 58);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Số Phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 120);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Loại Phòng";
            // 
            // txtSoPhong
            // 
            txtSoPhong.Location = new Point(190, 56);
            txtSoPhong.Margin = new Padding(3, 2, 3, 2);
            txtSoPhong.Name = "txtSoPhong";
            txtSoPhong.Size = new Size(170, 23);
            txtSoPhong.TabIndex = 2;
            // 
            // txtLoaiPhong
            // 
            txtLoaiPhong.Location = new Point(190, 118);
            txtLoaiPhong.Margin = new Padding(3, 2, 3, 2);
            txtLoaiPhong.Name = "txtLoaiPhong";
            txtLoaiPhong.Size = new Size(170, 23);
            txtLoaiPhong.TabIndex = 2;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(102, 170);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(82, 22);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(190, 170);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(82, 22);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += button2_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(277, 170);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(82, 22);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btn_SV
            // 
            btn_SV.Location = new Point(102, 385);
            btn_SV.Margin = new Padding(3, 2, 3, 2);
            btn_SV.Name = "btn_SV";
            btn_SV.Size = new Size(82, 22);
            btn_SV.TabIndex = 3;
            btn_SV.Text = "Sinh viên";
            btn_SV.UseVisualStyleBackColor = true;
            btn_SV.Click += button4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(209, 385);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 4;
            button1.Text = "Hóa đơn";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_QlSVP
            // 
            btn_QlSVP.Location = new Point(307, 385);
            btn_QlSVP.Name = "btn_QlSVP";
            btn_QlSVP.Size = new Size(125, 23);
            btn_QlSVP.TabIndex = 5;
            btn_QlSVP.Text = "Quản lý Sv-Phòng";
            btn_QlSVP.UseVisualStyleBackColor = true;
            btn_QlSVP.Click += btn_QlSVP_Click;
            // 
            // PhongForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 441);
            Controls.Add(btn_QlSVP);
            Controls.Add(button1);
            Controls.Add(btn_SV);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtLoaiPhong);
            Controls.Add(txtSoPhong);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PhongForm";
            Text = "PhongForm";
            Load += PhongForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox txtSoPhong;
        private TextBox txtLoaiPhong;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btn_SV;
        private Button button1;
        private Button btn_QlSVP;
    }
}