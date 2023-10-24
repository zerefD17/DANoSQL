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

            var filter = Builders<Phong>.Filter.Where(doc =>
                doc.sinhVien.Count < doc.loaiPhong
            );

            var documents = collection.Find(filter).ToList();


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
        public void reset()
        {
            LoadDataIntoDataGridView();
            LoadPhongEmpty();
            txtEmail.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            txtID.Clear();

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

        private void btnThem_Click(object sender, EventArgs e)
        {
            string idSv = txtID.Text;
            string tenSv = txtHoTen.Text;
            DateTime ngaySinh = DateTime.Parse(dTPNgaySinh.Text);
            string sdt = txtSDT.Text;
            string email = txtEmail.Text;

            string soPhong = "";
            if (dGV_Phong.SelectedRows.Count > 0)
            {
                // Lấy dòng đầu tiên được chọn
                DataGridViewRow selectedRow = dGV_Phong.SelectedRows[0];

                // Lấy ô đầu tiên trong dòng được chọn
                DataGridViewCell firstCell = selectedRow.Cells[1];

                // Lấy giá trị của ô đầu tiên
                soPhong = firstCell.Value.ToString();

            }
            if (string.IsNullOrEmpty(soPhong) == true)
            {
                MessageBox.Show("Vui lòng chọn phòng cho sinh viên!");
                return;
            }


            if (string.IsNullOrEmpty(idSv) == true || string.IsNullOrEmpty(tenSv) == true || string.IsNullOrEmpty(sdt) == true || string.IsNullOrEmpty(email) == true || ngaySinh > DateTime.Now || string.IsNullOrEmpty(soPhong) == true)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            //else
            //{
            //    MessageBox.Show(idSv + tenSv + ngaySinh.ToString() + sdt + email + soPhong + "");
            //}

            try
            {


                var filter = Builders<Phong>.Filter.Where(x => x.sinhVien.Any(sv => sv.idSinhVien == idSv));

                var result = collection.Find(filter).ToList();


                if (result.Count != 0)
                {
                    MessageBox.Show("Sinh viên đã tồn tại");
                }
                else
                {
                    SinhVien sv = new SinhVien();
                    sv.idSinhVien = idSv;
                    sv.hoTen = tenSv;
                    sv.ngaySinh = ngaySinh;
                    sv.soDienThoai = sdt;
                    sv.email = email;



                    var filter1 = Builders<Phong>.Filter.Eq(x => x.soPhong, soPhong);

                    var sinhVienMoi = new SinhVien
                    {
                        idSinhVien = idSv.ToString(),
                        hoTen = tenSv.ToString(),
                        ngaySinh = DateTime.Parse(dTPNgaySinh.Text),
                        soDienThoai = sdt.ToString(),
                        email = email.ToString()
                    };

                    var update = Builders<Phong>.Update.AddToSet(x => x.sinhVien, sinhVienMoi);

                    collection.UpdateOne(filter1, update);
                    MessageBox.Show("Thêm sinh viên thành công!");

                    reset();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm sv thất bại!");
            }
        }

        private void dGV_Phong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dGV_Phong.Rows[e.RowIndex];
            string idPhong = selectedRow.Cells["soPhong"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string idSv = txtID.Text;
            string tenSv = txtHoTen.Text;
            DateTime ngaySinh = DateTime.Parse(dTPNgaySinh.Text);
            string sdt = txtSDT.Text;
            string email = txtEmail.Text;

            //string soPhong = dGV_Phong.SelectedCells[0].Value.ToString();




            if (string.IsNullOrEmpty(idSv) == true || string.IsNullOrEmpty(tenSv) == true || string.IsNullOrEmpty(sdt) == true || string.IsNullOrEmpty(email) == true || ngaySinh > DateTime.Now)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }

            try
            {


                var filter = Builders<Phong>.Filter.Where(x => x.sinhVien.Any(sv => sv.idSinhVien == idSv));

                var result = collection.Find(filter).ToList();


                if (result.Count == 0)
                {
                    MessageBox.Show("Sinh viên không tồn tại");
                }
                else
                {
                    SinhVien sv = new SinhVien();
                    sv.idSinhVien = idSv;
                    sv.hoTen = tenSv;
                    sv.ngaySinh = ngaySinh;
                    sv.soDienThoai = sdt;
                    sv.email = email;





                    var sinhVienMoi = new SinhVien
                    {
                        idSinhVien = idSv.ToString(),
                        hoTen = tenSv.ToString(),
                        ngaySinh = DateTime.Parse(dTPNgaySinh.Text),
                        soDienThoai = sdt.ToString(),
                        email = email.ToString()
                    };

                    var filter1 = Builders<Phong>.Filter.Where(x => x.sinhVien.Any(s => s.idSinhVien == sinhVienMoi.idSinhVien));
                    var update = Builders<Phong>.Update.Set(
                        "sinhVien.$[sv].hoTen", sinhVienMoi.hoTen)
                        .Set("sinhVien.$[sv].soDienThoai", sinhVienMoi.soDienThoai)
                        .Set("sinhVien.$[sv].email", sinhVienMoi.email)
                        .Set("sinhVien.$[sv].ngaySinh", new BsonDateTime(sinhVienMoi.ngaySinh));

                    var arrayFilters = new[]
                    {
                        new BsonDocumentArrayFilterDefinition<Phong>(new BsonDocument("sv.idSinhVien",sinhVienMoi.idSinhVien))
                        // Thêm các điều kiện khác nếu cần thiết
                    };

                    // Thực hiện update
                    var updateOptions = new UpdateOptions { ArrayFilters = arrayFilters };

                    collection.UpdateOne(filter1, update, updateOptions);
                    MessageBox.Show("Đã sửa thành công!");

                    reset();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể sửa sv thất bại!");
            }
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            FormTinhTien tt = new FormTinhTien();
            tt.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            dGV_SV.DataSource = null;

            string ten = txtHoTen.Text;

            var filter = Builders<Phong>.Filter.Where(x => x.sinhVien.Any(sv => sv.hoTen == ten));

            var result = collection.Find(filter).ToList();

            var documents = collection.Find(filter).ToList();
            
            List<SinhVien> lstsv = new List<SinhVien>();
            foreach(var document in documents)
            {
                foreach (SinhVien sv in document.sinhVien)
                {
                    lstsv.Add(sv);
                }
                dGV_SV.DataSource = lstsv;
                

            }



        }
    }
}
