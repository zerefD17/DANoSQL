using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Phong
    {
        [BsonId]

        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string soPhong { get; set; }
        public int loaiPhong { get; set; }
        public List<SinhVien> sinhVien { get; set; }
        public List<SoDienNuoc> soDienNuoc { get; set; }
        public List<HoaDon> hoaDon { get; set; }


    }
}
