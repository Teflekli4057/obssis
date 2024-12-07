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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-AVTCPRK3\\SQLEXPRESS;Initial Catalog=dbObs;Integrated Security=True;TrustServerCertificate=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select *from Kullanıcılar where KullaniciAdi='"+kAditxt.Text+"' and Sifre='"+Parolatxt.Text+"'", con);

            con.Open();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form2 f2 = new Form2();
                f2.Show();
            }
            else
                MessageBox.Show("Hatalı kullanıcı adı veya parola", "Giriş ekranı", MessageBoxButtons.OK,MessageBoxIcon.Warning);

            kAditxt.Text = "";
            Parolatxt.Text = "";

            con.Close();

        }
    }
}
