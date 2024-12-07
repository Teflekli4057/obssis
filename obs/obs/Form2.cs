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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrYeniKayıt f3=new OgrYeniKayıt();
            f3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KayitGoruntuleme f4=new KayitGoruntuleme();
            f4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frmsil frm=new Frmsil();
            frm.Show();
        }
    }
}
