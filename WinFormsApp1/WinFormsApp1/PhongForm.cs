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
    public partial class PhongForm : Form
    {
        public PhongForm()
        {
            
            InitializeComponent();
        }

        private void PhongForm_Load(object sender, EventArgs e)
        {
            LoadDataPhong();
            
        }

        public void LoadDataPhong()
        {
            MongoClient client = new MongoClient("mongodb://localhost:27017");
            IMongoDatabase database = client.GetDatabase("do_an");
            IMongoCollection<Phong> collection = database.GetCollection<Phong>("QLDienNuoc");

            var phongList = collection.Find(_ => true).ToList();

            dataGridView1.DataSource = phongList;
            dataGridView1.Columns["_id"].Visible = false;
        }
    }
}
