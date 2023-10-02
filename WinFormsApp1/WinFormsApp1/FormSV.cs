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
    public partial class FormSV : Form
    {
        private MongoClient client;
        private IMongoDatabase database;
        private IMongoCollection<SinhVien> collection;
        public FormSV()
        {

            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("do_an");
            collection = database.GetCollection<SinhVien>("QLDienNuoc");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormSV_Load(object sender, EventArgs e)
        {

            LoadDataIntoDataGridView();

        }

       /* private List<Phong> GetAllPhongData()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("do_an");
            var collection = database.GetCollection<Phong>("QLDienNuoc");

            
            var phongList = collection.Find(_ => true).ToList();

            return phongList;
        }*/


        private void LoadDataIntoDataGridView()
        {

        }

    }
}
