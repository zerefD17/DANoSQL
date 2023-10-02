using MongoDB.Driver;
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
    public partial class SinhVienForm : Form
    {
        private MongoClient client;
        private IMongoDatabase database;
        private IMongoCollection<Phong> collection;
        public SinhVienForm()
        {

            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("do_an");
            collection = database.GetCollection<Phong>("QLDienNuoc");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormSV_Load(object sender, EventArgs e)
        {

            LoadDataIntoDataGridView();

        }




        private void LoadDataIntoDataGridView()
        {
            // Lấy danh sách tất cả các phòng từ MongoDB
            var phongList = collection.Find(_ => true).ToList();

            List<SinhVien> allSinhVien = new List<SinhVien>();

            foreach (var phong in phongList)
            {
                allSinhVien.AddRange(phong.sinhVien);
                

            }

            // Gán danh sách sinh viên vào DataGridView
            dataGridView1.DataSource = allSinhVien;

            


            changeNameCol();
            changeWidthCol();

        }

        

        private void changeNameCol()
        {

            dataGridView1.Columns["idSinhVien"].HeaderText = "ID";
            dataGridView1.Columns["hoTen"].HeaderText = "Họ và Tên";
            dataGridView1.Columns["ngaySinh"].HeaderText = "Ngày Sinh";
            dataGridView1.Columns["soDienThoai"].HeaderText = "Số Điện Thoại";
            dataGridView1.Columns["email"].HeaderText = "Email";
        }

        private void changeWidthCol()
        {

            dataGridView1.Columns["idSinhVien"].Width = 130;
            dataGridView1.Columns["hoTen"].Width = 150;
            dataGridView1.Columns["ngaySinh"].Width = 120;
            dataGridView1.Columns["soDienThoai"].Width = 150;
            dataGridView1.Columns["email"].Width = 180;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy dữ liệu của hàng được chọn
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

            // Lấy giá trị của các ô trong hàng được chọn
            string idSinhVien = selectedRow.Cells["idSinhVien"].Value.ToString();
            string hoTen = selectedRow.Cells["hoTen"].Value.ToString();
            string ngaySinh = selectedRow.Cells["ngaySinh"].Value.ToString();
            string soDienThoai = selectedRow.Cells["soDienThoai"].Value.ToString();
            string email = selectedRow.Cells["email"].Value.ToString();
            

            // Gán giá trị vào các trường nhập tương ứng
            txtID.Text = idSinhVien;
            txtHoTen.Text = hoTen;
            // Chuyển đổi ngày tháng từ chuỗi sang kiểu DateTime (nếu cần)
            DateTime ngaySinhDateTime = DateTime.Parse(ngaySinh);
            dTPNgaySinh.Value = ngaySinhDateTime;
            txtSDT.Text = soDienThoai;
            txtEmail.Text = email;
            
        }
    }
}
