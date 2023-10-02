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
    public partial class PhongForm : Form
    {
        private MongoClient client;
        private IMongoDatabase database;
        private IMongoCollection<Phong> collection;

        public PhongForm()
        {
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("do_an");
            collection = database.GetCollection<Phong>("QLDienNuoc");

            InitializeComponent();
        }

        private void PhongForm_Load(object sender, EventArgs e)
        {
            LoadDataPhong();

        }


        public void LoadDataPhong()
        {

            var phongList = collection.Find(_ => true).ToList();

            dataGridView1.DataSource = phongList;
            dataGridView1.Columns["_id"].Visible = false;
        }

        public void btnThem_Click(object sender, EventArgs e)
        {
            string soPhong = txtSoPhong.Text;

            int loaiPhong;
            if (int.TryParse(txtLoaiPhong.Text, out loaiPhong))
            {

                var filter = Builders<Phong>.Filter.Eq(x => x.soPhong, soPhong);
                var existingRoom = collection.Find(filter).FirstOrDefault();

                if (existingRoom != null)
                {
                    MessageBox.Show("Phòng đã tồn tại. Vui lòng sử dụng số phòng khác.");
                    txtSoPhong.Clear();
                    txtSoPhong.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(soPhong) || loaiPhong <= 0)
                {
                    MessageBox.Show("Số phòng không được để trống và Loại phòng phải là số nguyên dương.");
                    return;
                }

                Phong phong = new Phong
                {
                    soPhong = soPhong,
                    loaiPhong = loaiPhong,
                    sinhVien = new List<SinhVien>(),
                    soDienNuoc = new List<SoDienNuoc>(),
                    hoaDon = new List<HoaDon>()
                };

                collection.InsertOne(phong);

                MessageBox.Show("Thêm phòng thành công!");
                ClearForm();
                LoadDataPhong();


            }
            else
            {
                MessageBox.Show("Loại phòng chỉ nhận chữ số");
            }

        }

        public void ClearForm()
        {
            txtLoaiPhong.Clear();
            txtSoPhong.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string soPhong = selectedRow.Cells["soPhong"].Value.ToString();

                var filter = Builders<Phong>.Filter.Eq(x => x.soPhong, soPhong);
                var result = collection.DeleteOne(filter);

                if (result.DeletedCount > 0)
                {
                    MessageBox.Show("Xóa Phòng thành công!");


                    LoadDataPhong();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phòng có số: " + soPhong);
                }
            }
            else
            {
                MessageBox.Show("Chọn một phòng để xóa");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            string soPhong = txtSoPhong.Text;
            int loaiPhong = Int32.Parse(txtLoaiPhong.Text);



            var filter = Builders<Phong>.Filter.Eq(x => x.soPhong, soPhong);
            var p = collection.Find(filter).FirstOrDefault();

            if (p != null)
            {

                p.soPhong = soPhong;
                p.loaiPhong = loaiPhong;



                try
                {
                    collection.ReplaceOne(filter, p);
                    MessageBox.Show("Cập nhật thông tin phòng thành công!");
                    LoadDataPhong();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật phongf: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy phòng có mã: " + soPhong);
            }

            ClearForm();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {

                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Lấy giá trị của các ô trong hàng được chọn
                string soPhong = selectedRow.Cells["soPhong"].Value.ToString();
                string loaiPhong = selectedRow.Cells["loaiPhong"].Value.ToString();



                txtSoPhong.Text = soPhong;
                txtLoaiPhong.Text = loaiPhong;

            }
        }
    }
}
