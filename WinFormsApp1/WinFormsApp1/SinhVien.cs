using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class SinhVien
    {
        
        public string idSinhVien { get; set; }
        public string hoTen { get; set; }
        public DateTime ngaySinh { get; set; }
        public string soDienThoai { get; set; }
        public string email { get; set; }

    }
}
