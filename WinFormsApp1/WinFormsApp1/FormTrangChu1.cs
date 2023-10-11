using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormTrangChu1 : Form
    {
        public Form activeForm;
        public FormTrangChu1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(childForm);
            this.panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SinhVienForm(), sender);
            txtTitle.Text = "SINH VIÊN";
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLPhongSv(), sender);
            txtTitle.Text = "HÓA ĐƠN";
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTinhTien(), sender);
            txtTitle.Text = "TÍNH TIỀN";
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhongForm(), sender);
            txtTitle.Text = "PHÒNG";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            txtTitle.Text = "Trang chủ";
            btnClose.Visible = false;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongKe(), sender);
            txtTitle.Text = "THỐNG KÊ";
        }
    }
}
