using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace obs
{
    public partial class OgrEkrani : Form
    {
        public OgrEkrani()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            GrsGuncelle frm = new GrsGuncelle();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DersKayitEkrani frm1 = new DersKayitEkrani();
            frm1.Show();
        }
    }
}
