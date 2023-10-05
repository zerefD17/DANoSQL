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
    public partial class FormQLPhongSv : Form
    {
        private MongoClient client;
        private IMongoDatabase database;
        private IMongoCollection<Phong> collection;
        public FormQLPhongSv()
        {
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("do_an");
            collection = database.GetCollection<Phong>("QLDienNuoc");
            InitializeComponent();
        }

        private void FormQLPhongSv_Load(object sender, EventArgs e)
        {
            loadPhong();

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
        private void loadPhongTrong()
        {
            var filter = Builders<Phong>.Filter.Where(doc =>
                doc.sinhVien.Count < doc.loaiPhong
            );



            var documents = collection.Find(filter).ToList();
            foreach (Phong document in documents)
            {
                cbb_PhongTrong.Items.Add(document.soPhong);
            }
        }
        public void loadSinhVienHD()
        {
            var filter = Builders<Phong>.Filter.Where(doc =>
                doc.soPhong == cbb_Phong.SelectedItem.ToString()

            );
            var documents = collection.Find(filter).ToList();
            var document = documents.First();
            if (rdb_HoaDon.Checked == true)
            {
                List<HoaDon> lsthd = new List<HoaDon>();
                foreach (HoaDon h in document.hoaDon)
                {
                    if (h.TrangThaiThanhToan == true)
                        lsthd.Add(h);
                }
                dGV_SinhVien.DataSource = lsthd;
            }
            else
            {
                List<SinhVien> lstsv = new List<SinhVien>();
                foreach (SinhVien sv in document.sinhVien)
                {
                    lstsv.Add(sv);
                }
                dGV_SinhVien.DataSource = lstsv;
            }
        }
        private void btm_timPhongTrong_Click(object sender, EventArgs e)
        {
            loadPhongTrong();
        }

        private void cbb_Phong_SelectedValueChanged(object sender, EventArgs e)
        {
            loadSinhVienHD();
        }

        private void btn_XoaSV_Click(object sender, EventArgs e)
        {
            string idsv = "";

            if (dGV_SinhVien.SelectedRows.Count > 0)
            {
                // Lấy dòng đầu tiên được chọn
                DataGridViewRow selectedRow = dGV_SinhVien.SelectedRows[0];

                // Lấy ô đầu tiên trong dòng được chọn
                DataGridViewCell firstCell = selectedRow.Cells[0];

                // Lấy giá trị của ô đầu tiên
                idsv = firstCell.Value.ToString();

            }
            if (string.IsNullOrEmpty(idsv) == false)
            {
                var filter = Builders<Phong>.Filter.Where(doc =>
                                    doc.soPhong == cbb_Phong.SelectedItem.ToString());


                var pullFilter1 = Builders<SinhVien>.Filter.Eq("idSinhVien", idsv);
                var update1 = Builders<Phong>.Update.PullFilter("sinhVien", pullFilter1);
                var updateOptions1 = new UpdateOptions { IsUpsert = false };
                collection.UpdateMany(filter, update1, updateOptions1);



                MessageBox.Show("Đã xóa sinh viên!");
                loadSinhVienHD();
            }
            else
            {
                MessageBox.Show("Không thể xóa!");
            }
        }

        private void rdb_SV_CheckedChanged(object sender, EventArgs e)
        {
            btn_XoaSV.Enabled = true;
            btn_ChuyenPhong.Enabled = true;

        }

        private void rdb_HoaDon_CheckedChanged(object sender, EventArgs e)
        {
            btn_XoaSV.Enabled = false;
            btn_ChuyenPhong.Enabled = false;
        }

        private void btn_ChuyenPhong_Click(object sender, EventArgs e)
        {
            string idsv = "";

            if (dGV_SinhVien.SelectedRows.Count > 0)
            {
                // Lấy dòng đầu tiên được chọn
                DataGridViewRow selectedRow = dGV_SinhVien.SelectedRows[0];

                // Lấy ô đầu tiên trong dòng được chọn
                DataGridViewCell firstCell = selectedRow.Cells[0];

                // Lấy giá trị của ô đầu tiên
                idsv = firstCell.Value.ToString();

            }
            if (string.IsNullOrEmpty(idsv) == false)
            {
                var filter = Builders<Phong>.Filter.Where(doc =>
                                    doc.soPhong == cbb_Phong.SelectedItem.ToString());





                var pullFilter1 = Builders<SinhVien>.Filter.Eq("idSinhVien", idsv);


                var soPhong = cbb_PhongTrong.Text.ToString();
                var filter1 = Builders<Phong>.Filter.Eq(x => x.soPhong, soPhong);
                List<Phong> result = new List<Phong>();
                result = collection.Find(filter).ToList();
                List<SinhVien> documents = new List<SinhVien>();
                foreach (Phong r in result)
                {
                    foreach (SinhVien r1 in r.sinhVien)
                    {

                        documents.Add(r1);
                    }


                }
                SinhVien doc = new SinhVien();
                foreach (SinhVien sv in documents)
                {
                    if (sv.idSinhVien == idsv)
                        doc = sv;
                }


                var update = Builders<Phong>.Update.Push(x => x.sinhVien, doc);
                collection.UpdateOne(filter1, update);


                var update1 = Builders<Phong>.Update.PullFilter("sinhVien", pullFilter1);
                var updateOptions1 = new UpdateOptions { IsUpsert = false };
                collection.UpdateMany(filter, update1, updateOptions1);



                MessageBox.Show("Đã chuyển sinh viên!");
                loadSinhVienHD();
            }
            else
            {
                MessageBox.Show("Không thể xóa!");
            }
        }
    }
}
