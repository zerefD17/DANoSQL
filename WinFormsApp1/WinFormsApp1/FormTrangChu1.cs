using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormTrangChu1 : Form
    {
        public Form activeForm;
        private MongoClient client;
        private IMongoDatabase database;
        private IMongoCollection<Phong> collection;
        public FormTrangChu1()
        {
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("do_an");
            collection = database.GetCollection<Phong>("QLDienNuoc");
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
            txtTitle.Text = "QUẢN LÝ SINH VIÊN - PHÒNG";
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

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            try
            {
                var collection = database.GetCollection<BsonDocument>("QLDienNuoc"); // Thay "ten-bang" bằng tên bảng bạn muốn sao lưu.

                var filter = new BsonDocument();
                var documents = collection.Find(filter).ToList();

                if (documents.Count > 0)
                {
                    var json = documents.ToJson();
                    File.WriteAllText("D:\\saoluu.json", json);
                    MessageBox.Show("Sao lưu thành công!");
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để sao lưu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sao lưu dữ liệu: " + ex.Message);
            }
        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            try
            {
                var filter = new BsonDocument(); // Điều kiện lọc để xóa tất cả dữ liệu
                var collection = database.GetCollection<BsonDocument>("QL2"); // Thay "ten-bang" bằng tên bảng bạn muốn phục hồi.
                collection.DeleteMany(filter);
                var json = File.ReadAllText("D:\\saoluu.json"); // Thay "duong-dan-tệp-phục-hồi.json" bằng đường dẫn đến tệp JSON bạn muốn phục hồi.

                var documents = MongoDB.Bson.Serialization.BsonSerializer.Deserialize<BsonDocument[]>(json);

                if (documents.Length > 0)
                {
                    collection.InsertMany(documents);
                    MessageBox.Show("Phục hồi thành công!");
                }
                else
                {
                    MessageBox.Show("Tệp phục hồi trống hoặc không hợp lệ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi phục hồi dữ liệu: " + ex.Message);
            }
        }
    }
}
