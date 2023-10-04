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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class FormTinhTien : Form
    {
        private MongoClient client;
        private IMongoDatabase database;
        private IMongoCollection<Phong> collection;
        public FormTinhTien()
        {
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("do_an");
            collection = database.GetCollection<Phong>("QLDienNuoc");
            InitializeComponent();
        }

        private void FormTinhTien_Load(object sender, EventArgs e)
        {
            loadPhong();
            txt_CSDienCu.Enabled = false;
            txt_CSNuocCu.Enabled = false;
            dGV_HoaDon.ReadOnly = true;
        }

        private void loadPhong()
        {
            var filter = Builders<Phong>.Filter.Where(doc =>
                doc.sinhVien.Count != 0
            );

            var documents = collection.Find(filter).ToList();
            foreach (Phong document in documents)
            {
                cbb_Phong.Items.Add(document.soPhong);
            }
        }
        public void loadDienNuocCu()
        {
            var filter = Builders<Phong>.Filter.Where(doc =>
                doc.soPhong == cbb_Phong.SelectedItem.ToString()
            );

            var documents = collection.Find(filter).ToList();
            var document = documents.Last();
            if (document.soDienNuoc.Count != 0)
            {
                var sdn = document.soDienNuoc.Last();
                txt_CSDienCu.Text = sdn.chiSoDien.ToString();
                txt_CSNuocCu.Text = sdn.chiSoNuoc.ToString();
                var kyTruoc = sdn.ky.ToString();
                var t = kyTruoc.Substring(0, 1);
                int thang = int.Parse(t);
                var n = kyTruoc.Substring(kyTruoc.Length - 4);
                int nam = int.Parse(n);
                string kysau = "";
                if (thang == 12)
                {
                    kysau = "1" + "/" + (nam + 1).ToString();
                }
                else
                {
                    kysau = (thang + 1).ToString() + "/" + nam.ToString();
                }
                txt_Ky.Text = kysau;
            }
            else
            {
                txt_CSDienCu.Text = "";
                txt_CSNuocCu.Text = "";
                txt_Ky.Text = DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            }

        }
        public void loadHoaDon()
        {
            var filter = Builders<Phong>.Filter.Where(doc =>
                doc.soPhong == cbb_Phong.SelectedItem.ToString()

            );

            //var filter = Builders<Phong>.Filter.And(
            //    Builders<Phong>.Filter.Where(doc => doc.soPhong == cbb_Phong.SelectedItem.ToString()),
            //    Builders<Phong>.Filter.Where(doc => doc.hoaDon.Any(doc1 => doc1.TrangThaiThanhToan == false))

            //    );

            var documents = collection.Find(filter).ToList();

            var document = documents.First();
            List<HoaDon> lsthd = new List<HoaDon>();
            foreach (HoaDon h in document.hoaDon)
            {
                if (h.TrangThaiThanhToan == false)
                    lsthd.Add(h);
            }
            //var lsthd = document.hoaDon;

            dGV_HoaDon.DataSource = lsthd;
            //dGV_HoaDon.Columns["_id"].Visible = false;
        }

        private void cbb_Phong_SelectedValueChanged(object sender, EventArgs e)
        {
            loadDienNuocCu();
            loadHoaDon();
        }

        private void btn_TaoHoaDon_Click(object sender, EventArgs e)
        {
            int csDienMoi = int.Parse(txt_CSDienMoi.Text.ToString());
            int csNuocMoi = int.Parse(txt_CSNuocMoi.Text.ToString());
            int csDienCu = int.Parse(txt_CSDienCu.Text.ToString());
            int csNuocCu = int.Parse(txt_CSNuocCu.Text.ToString());
            if (csDienMoi < csDienCu || csNuocMoi < csNuocCu)
            {
                MessageBox.Show("Vui lòng lại chỉ số điện mới và chỉ số nước mới!");
                return;
            }
            else
            {
                var filter = Builders<Phong>.Filter.Where(doc =>
                                doc.soPhong == cbb_Phong.SelectedItem.ToString()

                            );
                var dienNuoc = new SoDienNuoc
                {
                    idDienNuoc = "DN" + txt_Ky.Text.ToString(),
                    chiSoDien = csDienMoi,
                    chiSoNuoc = csNuocMoi,
                    ky = txt_Ky.Text.ToString()
                };

                var update = Builders<Phong>.Update.AddToSet(x => x.soDienNuoc, dienNuoc);

                collection.UpdateOne(filter, update);

                var hd = new HoaDon
                {
                    SoHoaDon = "HD" + txt_Ky.Text.ToString(),
                    idDN = dienNuoc.idDienNuoc,
                    TrangThaiThanhToan = false,
                    ThoiGianTao = DateTime.Now,
                    TongTien = TINHTOAN.TONGTIEN(csDienMoi - csDienCu, csNuocMoi - csNuocCu),
                    Note = "",
                    NgayHetHan = DateTime.Now.AddDays(30)

                };
                var update1 = Builders<Phong>.Update.AddToSet(x => x.hoaDon, hd);

                collection.UpdateOne(filter, update1);
                MessageBox.Show("Tạo hóa đơn thành công!");
            }
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            string soHD = "";
            if (dGV_HoaDon.SelectedRows.Count > 0)
            {
                // Lấy dòng đầu tiên được chọn
                DataGridViewRow selectedRow = dGV_HoaDon.SelectedRows[0];

                // Lấy ô đầu tiên trong dòng được chọn
                DataGridViewCell firstCell = selectedRow.Cells[0];

                // Lấy giá trị của ô đầu tiên
                soHD = firstCell.Value.ToString();

            }
            if (string.IsNullOrEmpty(soHD) == false)
            {
                var filter = Builders<Phong>.Filter.Where(doc =>
                                    doc.soPhong == cbb_Phong.SelectedItem.ToString());

                var update = Builders<Phong>.Update.Set(
                            "hoaDon.$[hd].trang_thai_thanh_toan", true)
                            .Set("hoaDon.$[hd].ngayThanhToan", new BsonDateTime(DateTime.Now));

                var arrayFilters = new[]
                {
                            new BsonDocumentArrayFilterDefinition<Phong>(new BsonDocument("hd.so_hoa_don",soHD))
                            // Thêm các điều kiện khác nếu cần thiết
                        };

                // Thực hiện update
                var updateOptions = new UpdateOptions { ArrayFilters = arrayFilters };

                collection.UpdateOne(filter, update, updateOptions);
                MessageBox.Show("Đã thanh toán hóa đơn!");
                loadHoaDon();
            }
            else
            {
                MessageBox.Show("Chọn hóa đơn muốn thanh toán!");
            }
        }
    }
}
