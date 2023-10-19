using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class TaiKhoan
    {
        [BsonId]

        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string tenTaiKhoan { get; set; }
        public string matKhau { get; set; }
    }
}
