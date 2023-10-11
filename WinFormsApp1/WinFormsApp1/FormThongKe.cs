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
            var phongList = getDSPhong();
            // Lấy tháng và năm hiện tại
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;

            // Tổng số điện và nước trong tháng hiện tại
            decimal soDienCurrent = 0;
            decimal soNuocCurrent = 0;
            decimal soDienPrevious = 0;
            decimal soNuocPrevious = 0;

            foreach (var phong in phongList)
            {
                foreach (var soDienNuoc in phong.soDienNuoc)
                {
                    var ky = soDienNuoc.ky;

                    // Tách kỳ thành tháng và năm (10/2023)=>10,2023
                    var parts = ky.Split('/');
                    if (parts.Length == 2)
                    {
                        int kyMonth, kyYear;
                        if (int.TryParse(parts[0], out kyMonth) && int.TryParse(parts[1], out kyYear))
                        {
                            if (kyMonth == currentMonth && kyYear == currentYear)
                            {
                                soDienCurrent = soDienNuoc.chiSoDien;
                                soNuocCurrent = soDienNuoc.chiSoNuoc;
                            }
                            else if (kyMonth == currentMonth - 1 && kyYear == currentYear)
                            {
                                soDienPrevious = soDienNuoc.chiSoDien;
                                soNuocPrevious = soDienNuoc.chiSoNuoc;
                            }
                        }
                    }
                }
            }
            // Tính tỷ lệ tăng/giảm cho số điện và số nước
            decimal percentSoDien = 0;
            decimal percentSoNuoc = 0;
            if (soDienPrevious != 0)
            {
                percentSoDien = ((soDienCurrent - soDienPrevious) / soDienPrevious) * 100;
            }

            if (soNuocPrevious != 0)
            {
                percentSoNuoc = ((soNuocCurrent - soNuocPrevious) / soNuocPrevious) * 100;
            }


            Color textColorSoDien = percentSoDien > 0 ? Color.Green : Color.Red;
            Color textColorSoNuoc = percentSoNuoc > 0 ? Color.Green : Color.Red;


            txtSoDien.Text = soDienCurrent.ToString();
            txtSoNuoc.Text = soNuocCurrent.ToString();

            txtSSDien.Text = percentSoDien.ToString() + "%";
            txtSSNuoc.Text = percentSoNuoc.ToString() + "%";
            txtSSDien.ForeColor = textColorSoDien;
            txtSSNuoc.ForeColor = textColorSoNuoc;

        }
        void getSLSinhVien()
        {
            var phongList = getDSPhong();
            int totalSinhVien = 0;
            int totalPhong = phongList.Count;

            foreach (var phong in phongList)
            {
                totalSinhVien += phong.sinhVien.Count;
            }

            // Hiển thị thông tin trên giao diện người dùng
            txtTongSV.Text = totalSinhVien.ToString();
            txtTongPhong.Text = totalPhong.ToString();
        }

        void getSoLuongHD()
        {

            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;

            var phongList = getDSPhong();

            // Số lượng hóa đơn trong tháng hiện tại
            int totalHoaDonCurrentMonth = 0;

            // Số lượng hóa đơn đã thanh toán trong tháng hiện tại
            int totalHoaDonDaThanhToan = 0;

            // Số lượng hóa đơn chưa thanh toán trong tháng hiện tại
            int totalHoaDonChuaThanhToan = 0;

            foreach (var phong in phongList)
            {
                foreach (var hoaDon in phong.hoaDon)
                {
                    var hoaDonMonth = hoaDon.ThoiGianTao.Month;
                    var hoaDonYear = hoaDon.ThoiGianTao.Year;

                    if (hoaDonMonth == currentMonth && hoaDonYear == currentYear)
                    {
                        totalHoaDonCurrentMonth++;

                        if (hoaDon.TrangThaiThanhToan)
                        {
                            totalHoaDonDaThanhToan++;
                        }
                        else
                        {
                            totalHoaDonChuaThanhToan++;
                        }
                    }
                }
            }

            // Hiển thị thông tin trên giao diện người dùng
            txtSoLuongHD.Text = totalHoaDonCurrentMonth.ToString();
            txtSoLuongHDDaTT.Text = totalHoaDonDaThanhToan.ToString();
            txtSoLuongHDChuaTT.Text = totalHoaDonChuaThanhToan.ToString();
        }

        void getTongDoanhThu()
        {

            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;

            var phongList = getDSPhong();


            decimal totalRevenue = 0;

            foreach (var phong in phongList)
            {
                foreach (var hoaDon in phong.hoaDon)
                {
                    var hoaDonMonth = hoaDon.ThoiGianTao.Month;
                    var hoaDonYear = hoaDon.ThoiGianTao.Year;
                    if (hoaDon.TrangThaiThanhToan && hoaDonMonth == currentMonth && hoaDonYear == currentYear)
                    {
                        totalRevenue += hoaDon.TongTien;
                    }

                }
            }


            txtTongDoanhThu.Text = totalRevenue.ToString();
        }

    }
}
