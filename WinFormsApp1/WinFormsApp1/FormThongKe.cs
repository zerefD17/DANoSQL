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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace WinFormsApp1
{
    public partial class FormThongKe : Form
    {
        private MongoClient client;
        private IMongoDatabase database;
        private IMongoCollection<Phong> collection;
        public FormThongKe()
        {
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("do_an");
            collection = database.GetCollection<Phong>("QLDienNuoc");
            //collection = database.GetCollection<BsonDocument>("QLDienNuoc");

            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            getTongDoanhThu();
            getSoLuongHD();
            getSLSinhVien();
            getSoDienNuoc();
        }

        List<Phong> getDSPhong()
        {
            var phongList = collection.Find(new BsonDocument()).ToList();
            return phongList;
        }

        void getSoDienNuoc()
        {
            var phongList = collection.Find(_ => true).ToList();

            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;
            // ki truoc
            int previousMonth = currentMonth == 1 ? 12 : currentMonth - 1;
            int previousYear = currentMonth == 1 ? currentYear - 1 : currentYear;

            var dienNuocThangNay = phongList.SelectMany(phong => phong.soDienNuoc)
                                            .Where(dn => dn.ky.Contains($"{currentMonth}/{currentYear}"))
                                            .ToList();

            var dienNuocThangTruoc = phongList.SelectMany(phong => phong.soDienNuoc)
                                              .Where(dn => dn.ky.Contains($"{previousMonth}/{previousYear}"))
                                              .ToList();

            decimal tongSoDien = dienNuocThangNay.Sum(dn => dn.chiSoDien);
            decimal tongSoNuoc = dienNuocThangNay.Sum(dn => dn.chiSoNuoc);

            decimal tongSoDienTruoc = dienNuocThangTruoc.Sum(dn => dn.chiSoDien);
            decimal tongSoNuocTruoc = dienNuocThangTruoc.Sum(dn => dn.chiSoNuoc);

            // ti le
            decimal tiLeSoDien = (tongSoDien - tongSoDienTruoc) / tongSoDienTruoc * 100;
            decimal tiLeSoNuoc = (tongSoNuoc - tongSoNuocTruoc) / tongSoNuocTruoc * 100;

            Color textColorSoDien = tiLeSoDien > 0 ? Color.Green : Color.Red;
            Color textColorSoNuoc = tiLeSoNuoc > 0 ? Color.Green : Color.Red;

            txtSoDien.Text = tongSoDien.ToString();
            txtSoNuoc.Text = tongSoNuoc.ToString();

            txtSSDien.Text = tiLeSoDien.ToString() + "%";
            txtSSNuoc.Text = tiLeSoNuoc.ToString() + "%";
            txtSSDien.ForeColor = textColorSoDien;
            txtSSNuoc.ForeColor = textColorSoNuoc;

        }
        void getSLSinhVien()
        {

            var filter = Builders<Phong>.Filter.Empty;
            var phongList = collection.Find(filter).ToList();

            var totalPhong = collection.CountDocuments(filter);
            var totalSinhVien = collection.AsQueryable()
                                .SelectMany(phong => phong.sinhVien)
                                .Count();
            var phongTrong = collection.AsQueryable()
                                .Where(phong => phong.sinhVien.Count == 0)
                                .Count();

            txtSoPhongTrong.Text = phongTrong.ToString();
            txtTongSV.Text = totalSinhVien.ToString();
            txtTongPhong.Text = totalPhong.ToString();
        }

        //void getSoLuongHD()
        //{

        //    int currentMonth = DateTime.Now.Month;
        //    int currentYear = DateTime.Now.Year;

        //    var phongList = getDSPhong();

        //    // Số lượng hóa đơn trong tháng hiện tại
        //    int totalHoaDonCurrentMonth = 0;

        //    // Số lượng hóa đơn đã thanh toán trong tháng hiện tại
        //    int totalHoaDonDaThanhToan = 0;

        //    // Số lượng hóa đơn chưa thanh toán trong tháng hiện tại
        //    int totalHoaDonChuaThanhToan = 0;

        //    foreach (var phong in phongList)
        //    {
        //        foreach (var hoaDon in phong.hoaDon)
        //        {
        //            var hoaDonMonth = hoaDon.ThoiGianTao.Month;
        //            var hoaDonYear = hoaDon.ThoiGianTao.Year;

        //            if (hoaDonMonth == currentMonth && hoaDonYear == currentYear)
        //            {
        //                totalHoaDonCurrentMonth++;

        //                if (hoaDon.TrangThaiThanhToan)
        //                {
        //                    totalHoaDonDaThanhToan++;
        //                }
        //                else
        //                {
        //                    totalHoaDonChuaThanhToan++;
        //                }
        //            }
        //        }
        //    }

        //    // Hiển thị thông tin trên giao diện người dùng
        //    txtSoLuongHD.Text = totalHoaDonCurrentMonth.ToString();
        //    txtSoLuongHDDaTT.Text = totalHoaDonDaThanhToan.ToString();
        //    txtSoLuongHDChuaTT.Text = totalHoaDonChuaThanhToan.ToString();
        //}

        void getSoLuongHD()
        {
            var currentMonth = DateTime.Now.Month;
            var currentYear = DateTime.Now.Year;


            var filter = Builders<Phong>.Filter.Empty;

            var hdList = collection.Find(filter).ToList();

            var hdThangNay = hdList.SelectMany(phong => phong.hoaDon)
                                   .Where(hoaDon => hoaDon.ThoiGianTao.Month == currentMonth
                                                 && hoaDon.ThoiGianTao.Year == currentYear)
                                   .ToList();

            var totalHoaDon = hdThangNay.Count;
            var totalHoaDonDaThanhToan = hdThangNay.Count(hd => hd.TrangThaiThanhToan == true);
            var totalHoaDonChuaThanhToan = hdThangNay.Count(hd => hd.TrangThaiThanhToan == false);


            txtSoLuongHD.Text = totalHoaDon.ToString();
            txtSoLuongHDDaTT.Text = totalHoaDonDaThanhToan.ToString();
            txtSoLuongHDChuaTT.Text = totalHoaDonChuaThanhToan.ToString();
        }

        void getTongDoanhThu()
        {


            //var filter = Builders<Phong>.Filter.ElemMatch(p => p.hoaDon, hd => hd.TrangThaiThanhToan == true);

            var builder = Builders<Phong>.Filter;
            var filter = builder.Eq("hoaDon.trang_thai_thanh_toan", true);
            var phongList = collection.Find(filter).ToList();

            decimal tongDoanhThu = 0;
            decimal tongDoanhThuThangNay = tongDoanhThuThangHT();
            decimal tongTienChuaThanhToan = tongTienChuaTT();


            foreach (var phong in phongList)
            {
                foreach (var hoaDon in phong.hoaDon)
                {
                    if (hoaDon.TrangThaiThanhToan)
                    {
                        tongDoanhThu += hoaDon.TongTien;

                    }
                }
            }

            txtTongTienChuaThanhToan.Text = tongTienChuaThanhToan.ToString();
            txtTongDoanhThuThangNay.Text = tongDoanhThuThangNay.ToString();
            txtTongDoanhThu.Text = tongDoanhThu.ToString();
        }

        private decimal tongDoanhThuThangHT()
        {
            decimal tongDoanhThuHT = 0;
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;


            var builder = Builders<Phong>.Filter;
            var filter = builder.Eq("hoaDon.trang_thai_thanh_toan", true);

            var phongList = collection.Find(filter).ToList();

            var hoaDonList = phongList
                .SelectMany(phong => phong.hoaDon)
                .Where(hoaDon => hoaDon.TrangThaiThanhToan == false
                    && hoaDon.ThoiGianTao.Month == currentMonth
                    && hoaDon.ThoiGianTao.Year == currentYear)
                .ToList();

            tongDoanhThuHT = hoaDonList.Sum(hoaDon => hoaDon.TongTien);

            return tongDoanhThuHT;

        }

        private decimal tongTienChuaTT()
        {



            decimal tongTienChuaThanhToan = 0;
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;



            var builder = Builders<Phong>.Filter;
            var filter = builder.Eq("hoaDon.trang_thai_thanh_toan", false);

            var phongList = collection.Find(filter).ToList();

            var hoaDonList = phongList
                .SelectMany(phong => phong.hoaDon)
                .Where(hoaDon => hoaDon.TrangThaiThanhToan == false
                    && hoaDon.ThoiGianTao.Month == currentMonth
                    && hoaDon.ThoiGianTao.Year == currentYear)
                .ToList();

            tongTienChuaThanhToan = hoaDonList.Sum(hoaDon => hoaDon.TongTien);

            return tongTienChuaThanhToan;
        }



        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
