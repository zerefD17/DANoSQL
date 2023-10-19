namespace WinFormsApp1
{
    partial class FormDangNhap
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
            label2 = new Label();
            label3 = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(188, 24);
            label1.Name = "label1";
            label1.Size = new Size(213, 46);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(75, 131);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(112, 200);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(232, 129);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(243, 27);
            txtTenDangNhap.TabIndex = 2;
            txtTenDangNhap.TextChanged += textBox1_TextChanged;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(232, 201);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(243, 27);
            txtMatKhau.TabIndex = 2;
            txtMatKhau.TextChanged += textBox1_TextChanged;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(188, 287);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(213, 57);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(625, 427);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDangNhap";
            Text = "FormDangNhap";
            Load += FormDangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
    }
}