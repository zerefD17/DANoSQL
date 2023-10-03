using MongoDB.Bson;
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
            LoadPhongEmpty();
        }


        private void LoadPhongEmpty()
        {
            var filter = Builders<BsonDocument>.Filter.Where(doc =>
            doc["sinhVien"].AsBsonArray.Count < doc["loaiPhong"].AsInt32
        );

            var documents = collection.Find(filter => true).ToList();


            //var phongList = collection.Find(_ => true).ToList();

            dGV_Phong.DataSource = documents;
            dGV_Phong.Columns["_id"].Visible = false;
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
            dGV_SV.DataSource = allSinhVien;




            changeNameCol();
            changeWidthCol();

        }



        private void changeNameCol()
        {

            dGV_SV.Columns["idSinhVien"].HeaderText = "ID";
            dGV_SV.Columns["hoTen"].HeaderText = "Họ và Tên";
            dGV_SV.Columns["ngaySinh"].HeaderText = "Ngày Sinh";
            dGV_SV.Columns["soDienThoai"].HeaderText = "Số Điện Thoại";
            dGV_SV.Columns["email"].HeaderText = "Email";
        }

        private void changeWidthCol()
        {

            dGV_SV.Columns["idSinhVien"].Width = 130;
            dGV_SV.Columns["hoTen"].Width = 150;
            dGV_SV.Columns["ngaySinh"].Width = 120;
            dGV_SV.Columns["soDienThoai"].Width = 150;
            dGV_SV.Columns["email"].Width = 180;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy dữ liệu của hàng được chọn
            DataGridViewRow selectedRow = dGV_SV.Rows[e.RowIndex];

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
