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
    public partial class FormDangNhap : Form
    {
        private MongoClient client;
        private IMongoDatabase database;
        private IMongoCollection<TaiKhoan> collection;
        public FormDangNhap()
        {
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("do_an");
            collection = database.GetCollection<TaiKhoan>("TaiKhoan");
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tentk = txtTenDangNhap.Text;
            string matkhau = txtMatKhau.Text;


            if (DangNhap(tentk, matkhau) == true)
            {
                MessageBox.Show("Đăng nhập thành công");
                FormTrangChu1 formMain = new FormTrangChu1();
                formMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
            


            
        }

        public bool DangNhap(string tentk, string matkhau)
        {
            bool check = false;
            var filter = Builders<TaiKhoan>.Filter.And(
                Builders<TaiKhoan>.Filter.Eq(x => x.tenTaiKhoan, tentk),
                Builders<TaiKhoan>.Filter.Eq(x => x.matKhau, matkhau)
            );
            var result = collection.Find(filter).FirstOrDefault();
            /*var result = collection.Find(_ => true).ToList();
            var taiKhoanDangNhap = result.Find(tk => tk.tenTaiKhoan == tentk && tk.matKhau == matkhau);*/
            if (result != null)
                check = true;
            return check;
        }
    }
}
