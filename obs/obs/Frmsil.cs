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
    public partial class Frmsil : Form
    {
        public Frmsil()
        {
            InitializeComponent();
        }
        SqlConnection con=new SqlConnection("Data Source=LAPTOP-AVTCPRK3\\SQLEXPRESS;Initial Catalog=dbObs;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        void Listele()
        {
            SqlCommand komut = new SqlCommand("select OgrAdi as 'Ad', OgrSoyad as 'Soyad',OgrNo as 'Öğrenci Numarası' ,Eposta as 'Öğrenci E-Postası',KayitTarihi as 'Kayıt Tarihi' ,Bolum as 'Bölüm',Tc as 'T.C. Kimlik Numarası' from Ogrenciler", con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            dataAdapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
        private void Frmsil_Load(object sender, EventArgs e)
        {
        
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int OgrNumara = Convert.ToInt16(textBox1.Text);
            SqlCommand komut = new SqlCommand("delete Ogrenciler where OgrNo='"+OgrNumara+"'",con);
            
            con.Open();

            int sonuc=komut.ExecuteNonQuery();
            
            if (sonuc > 0 )
            {
                MessageBox.Show("Kayıt başarıyla silindi.", "Silme ekranı");

            }
            else 
                MessageBox.Show("Hatalı bilgi girdiniz. Kayıt silinemedi.","Silme ekranı.",MessageBoxButtons.OK, MessageBoxIcon.Warning);

            textBox1.Text = "";

                con.Close();
            Listele();
        }
    }
}

//Listele fonksiyonu ile kayıtlı öğrencilerin tablosununu datagridview'de listeleniyor.
//53. satırdaki komut çağırma işlemi ile kaydın son hali gösteriliyor.