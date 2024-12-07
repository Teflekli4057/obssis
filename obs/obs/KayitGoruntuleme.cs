using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace obs
{
    public partial class KayitGoruntuleme : Form
    {
        public KayitGoruntuleme()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-AVTCPRK3\\SQLEXPRESS;Initial Catalog=dbObs;Integrated Security=True;TrustServerCertificate=True;");

        private void KayitGoruntuleme_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select OgrAdi as 'Ad', OgrSoyad as 'Soyad',OgrNo as 'Öğrenci Numarası' ,Eposta as 'Öğrenci E-Postası',KayitTarihi as 'Kayıt Tarihi' ,Bolum as 'Bölüm', Tc as 'T.C Kimlik Numarası' from Ogrenciler",con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
         }
    }
}
