using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace otopark_otomasyon_sistemi
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            dt = metodlar.TabloGonder("select * from kullanici where TcKimlikNo='" + txtkullaniciadi.Text + "' and Sifre='" + txtsifre.Text + "'");
            arackayit arc = new arackayit();
            arc.Show();
            this.Hide();
        }
    }
}
