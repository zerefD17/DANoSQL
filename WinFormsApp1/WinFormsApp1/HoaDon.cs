using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class HoaDon
    {
        [BsonElement("so_hoa_don")]
        public string SoHoaDon { get; set; }
        public string idDN { get; set; }

        [BsonElement("trang_thai_thanh_toan")]
        public bool TrangThaiThanhToan { get; set; }

        [BsonElement("ngay_het_han")]
        public DateTime NgayHetHan { get; set; }

        [BsonElement("phi_tre_han")]
        public int PhiTreHan { get; set; }

        [BsonElement("thoi_gian_tao")]
        public DateTime ThoiGianTao { get; set; }

        [BsonElement("tong_tien")]
        public decimal TongTien { get; set; }

        [BsonElement("note")]
        public string Note { get; set; }
    }
}
