using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace otopark_otomasyon_sistemi
{
    public partial class arackayit : DevExpress.XtraEditors.XtraForm
    {
        public arackayit()
        {
            InitializeComponent();
        }

        //public void konum()
        //{
        //    comboKonum.Items.Clear();
        //    if (metodlar.conn.State == ConnectionState.Closed)
        //    {
        //        metodlar.conn.Open();
        //    }
        //    SqlCommand komut = new SqlCommand("select * from bos", metodlar.conn);
        //    SqlDataReader oku = komut.ExecuteReader();
        //    while (oku.Read())
        //    {
        //        comboKonum.Items.Add(oku[0].ToString());

        //    }
        //    oku.Close();
        //    metodlar.conn.Close();
        //}
        //public void konum2()
        //{
        //    comboKonum.Items.Clear();
        //    if (metodlar.conn.State == ConnectionState.Closed)
        //    {
        //        metodlar.conn.Open();
        //    }
        //    SqlCommand komut = new SqlCommand("select * from dolu", metodlar.conn);
        //    SqlDataReader oku = komut.ExecuteReader();
        //    while (oku.Read())
        //    {
        //        comboKonum.Items.Add(oku[0].ToString());

        //    }
        //    oku.Close();
        //    metodlar.conn.Close();
        //}
        public void AracTipiGetir()
        {
            comboArac.Items.Clear();
            if (metodlar.conn.State == ConnectionState.Closed)
            {
                metodlar.conn.Open();
            }
            SqlCommand komut = new SqlCommand("select * from aractipi", metodlar.conn);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboArac.Items.Add(oku[0].ToString());

            }
            oku.Close();
            metodlar.conn.Close();
        }
         string durumkontrol="BOS";
        public void KonumGetir()
        {
            comboKonum.Items.Clear();
            if (metodlar.conn.State == ConnectionState.Closed)
            {
                metodlar.conn.Open();
            }
           
            SqlCommand komut = new SqlCommand("select * from park where durum='"+durumkontrol+"' ", metodlar.conn);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboKonum.Items.Add(oku[0].ToString());

            }
            oku.Close();
            metodlar.conn.Close();
        }
        /*   public void plakayaz()
           {
               comboKonum.Items.Clear();
               if (metodlar.conn.State == ConnectionState.Closed)
               {
                   metodlar.conn.Open();
               }
               SqlCommand komut = new SqlCommand("select * from arackayit", metodlar.conn);
               SqlDataReader oku = komut.ExecuteReader();
               while (oku.Read())
               {
                   switch (oku[7].ToString())
                   {
                       case "A1":
                           {
                               btnA1.Text = oku[4].ToString();
                               btnA1.BackColor = System.Drawing.Color.Red;
                               break;     
                           }
                       case "A2":
                           {
                               btnA2.Text = oku[4].ToString();
                               btnA2.BackColor = System.Drawing.Color.Red;
                               break;
                           }
                       case "A3":
                           {
                               btnA3.Text = oku[4].ToString();
                               btnA3.BackColor = System.Drawing.Color.Red;
                               break;
                           }
                       case "A4":
                           {
                               btnA4.Text = oku[4].ToString();
                               btnA4.BackColor = System.Drawing.Color.Red;
                               break;
                           }
                       case "A5":
                           {
                               btnA5.Text = oku[4].ToString();
                               btnA5.BackColor = System.Drawing.Color.Red;
                               break;
                           }
                       case "B1":
                           {
                               btnB1.Text = oku[4].ToString();
                               btnB1.BackColor = System.Drawing.Color.Red;
                               break;
                           }
                       case "B2":
                           {
                               btnB2.Text = oku[4].ToString();
                               btnB2.BackColor = System.Drawing.Color.Red;
                               break;
                           }
                       case "B3":
                           {
                               btnB3.Text = oku[4].ToString();
                               btnB3.BackColor = System.Drawing.Color.Red;
                               break;
                           }
                       case "B4":
                           {
                               btnB4.Text = oku[4].ToString();
                               btnB4.BackColor = System.Drawing.Color.Red;
                               break;
                           }
                       case "B5":
                           {
                               btnB5.Text = oku[4].ToString();
                               btnB5.BackColor = System.Drawing.Color.Red;
                               break;
                           }
                       case "C1":
                           {
                               btnC1.Text = oku[4].ToString();
                               btnC1.BackColor = System.Drawing.Color.Red;
                               break;
                           }
                       case "C2":
                           {
                               btnC2.Text = oku[4].ToString();
                               btnC2.BackColor = System.Drawing.Color.Red;
                               break;
                           }
                       case "C3":
                           {
                               btnC3.Text = oku[4].ToString();
                               btnC3.BackColor = System.Drawing.Color.Red;
                               break;
                           }
                       case "C4":
                           {
                               btnC4.Text = oku[4].ToString();
                               btnC4.BackColor = System.Drawing.Color.Red;
                               break;
                           }
                       case "C5":
                           {
                               btnC5.Text = oku[4].ToString();
                               btnC5.BackColor = System.Drawing.Color.Red;
                               break;
                           }
                       case "D1":
                           {
                               btnD1.Text = oku[4].ToString();
                               btnD1.BackColor = System.Drawing.Color.Red;
                               break;
                           }
                       case "D2":
                           {
                               btnD2.Text = oku[4].ToString();
                               btnD2.BackColor = System.Drawing.Color.Red;
                               break;
                           }
                       case "D3":
                           {
                               btnD3.Text = oku[4].ToString();
                               btnD3.BackColor = System.Drawing.Color.Red;
                               break;
                           }
                       case "D4":
                           {
                               btnD4.Text = oku[4].ToString();
                               btnD4.BackColor = System.Drawing.Color.Red;
                               break;
                           }
                       case "D5":
                           {
                               btnD5.Text = oku[4].ToString();
                               btnD5.BackColor = System.Drawing.Color.Red;
                               break;
                           }
                       
                   }


               }
               oku.Close();
               metodlar.conn.Close();
           }
         */

        /* public void plakasil()
         {
             switch (comboKonum.Text)
             {
                 case "A1":
                     {
                         btnA1.Text = "A1";
                         btnA1.BackColor = System.Drawing.Color.Green;
                         break;
                     }
                 case "A2":
                     {
                         btnA2.Text = "A2";
                         btnA2.BackColor = System.Drawing.Color.Green;
                         break;
                     }
                 case "A3":
                     {
                         btnA3.Text = "A3";
                         btnA3.BackColor = System.Drawing.Color.Green;
                         break;
                     }
                 case "A4":
                     {
                         btnA4.Text = "A4";
                         btnA4.BackColor = System.Drawing.Color.Green;
                         break;
                     }
                 case "A5":
                     {
                         btnA5.Text = "A5";
                         btnA5.BackColor = System.Drawing.Color.Green;
                         break;
                     }
                 case "B1":
                     {
                         btnB1.Text = "B1";
                         btnB1.BackColor = System.Drawing.Color.Green;
                         break;
                     }
                 case "B2":
                     {
                         btnB2.Text = "B2";
                         btnB2.BackColor = System.Drawing.Color.Green;
                         break;
                     }
                 case "B3":
                     {
                         btnB3.Text = "B3";
                         btnB3.BackColor = System.Drawing.Color.Green;
                         break;
                     }
                 case "B4":
                     {
                         btnB4.Text = "B4";
                         btnB4.BackColor = System.Drawing.Color.Green;
                         break;
                     }
                 case "B5":
                     {
                         btnB5.Text = "B5";
                         btnB5.BackColor = System.Drawing.Color.Green;
                         break;
                     }
                 case "C1":
                     {
                         btnC1.Text = "C1";
                         btnC1.BackColor = System.Drawing.Color.Green;
                         break;
                     }
                 case "C2":
                     {
                         btnC2.Text = "C2";
                         btnC2.BackColor = System.Drawing.Color.Green;
                         break;
                     }
                 case "C3":
                     {
                         btnC3.Text = "C3";
                         btnC3.BackColor = System.Drawing.Color.Green;
                         break;
                     }
                 case "C4":
                     {
                         btnC4.Text = "C4";
                         btnC4.BackColor = System.Drawing.Color.Green;
                         break;
                     }
                 case "C5":
                     {
                         btnC5.Text = "C5";
                         btnC5.BackColor = System.Drawing.Color.Green;
                         break;
                     }
                 case "D1":
                     {
                         btnD1.Text = "D1";
                         btnD1.BackColor = System.Drawing.Color.Green;
                         break;
                     }
                 case "D2":
                     {
                         btnD2.Text = "D2";
                         btnD2.BackColor = System.Drawing.Color.Green;
                         break;
                     }
                 case "D3":
                     {
                         btnD3.Text = "D3";
                         btnD3.BackColor = System.Drawing.Color.Green;
                         break;
                     }
                 case "D4":
                     {
                         btnD4.Text = "D4";
                         btnD4.BackColor = System.Drawing.Color.Green;
                         break;
                     }
                 case "D5":
                     {
                         btnD2.Text = "D5";
                         btnD2.BackColor = System.Drawing.Color.Green;
                         break;
                     }
             }
         }
        */       
        
         
        // public void kontroldurum()
       
        // {
        //     DataTable dt=new DataTable
           
             
        //     dt=metodlar.TabloGonder("select durum from park where parkyeri='"+A1+"'");
        //         if(dt.Rows.Count>0)
        //         {
        //            string  kntldurum=dt.Rows.[0][0].tostring();
        //             if(kntldurum=="BOS")
        //             {
        //                 btnA1.BackColor=System.Drawing.Color.Red;
        //             }
        //             else
        //             {
        //                 btnA1.BackColor=System.Drawing.Color.Green;
        //             }

        //         }
        //}
        public void listele()
        {

           dataGridView1.DataSource = metodlar.TabloGonder("select * from arackayit");
        }
        private void btnAracGiris_Click(object sender, EventArgs e)
        {

            string saat = DateTime.Now.ToShortTimeString();
            //string saat = "hh";
            // MessageBox.Show(saat);
            metodlar.EkleSilGuncelle("insert into arackayit(TcKimlikNo,Ad,SoyAd,CepTel,PlakaNo,AracTipi,Model,Konumu,GirisTarihi,GirisSaati,ucret)values('" + txtTcKimlik.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + Convert.ToInt32(txtceptel.Text) + "','" + txtPlakaNo.Text + "','" + comboArac.Text + "','" + txtmodel.Text + "', '" + comboKonum.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + saat + "','" + Convert.ToInt32(txtucret.Text) + "')");
           // metodlar.EkleSilGuncelle("insert into park(durum)values('"+ comboKonum.Text + "')");
            //metodlar.EkleSilGuncelle("DELETE from bos WHERE BosYerler='" + comboKonum.Text + "' ");

            MessageBox.Show("KAYIT BAŞARILI", "BİLGİLENDİRME");
            listele();
            KonumGetir();
            //konum();
            //plakayaz();
                
            txtTcKimlik.Text = "";
            txtAd.Text= "";
            txtSoyad.Text = "";
            txtceptel.Text = "";
            txtPlakaNo.Text = "";
            comboArac.Text = "";
            txtmodel.Text = "";
            comboKonum.Text = "";
            txtucret.Text = "";

        }

        private void arackayit_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = metodlar.TabloGonder("select * from arackayit ");
            AracTipiGetir();
            KonumGetir();
            //konum();
            //konum2();
            //plakayaz();
            //plakasil();
        }

        private void txtarama_EditValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = metodlar.TabloGonder("select * from arackayit where PlakaNo like'%" + txtarama.Text + "%' ");
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = metodlar.TabloGonder("select * from arackayit where PlakaNo like'%" + txtarama.Text + "%' ");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txttc.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textEdit1ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textEdit2Soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textEditPlakano.Text= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
           
        }
        string cikisSaati= DateTime.Now.ToShortTimeString();
        private void btnaraccikis_Click(object sender, EventArgs e)
        {
            DialogResult tus = MessageBox.Show("EMİN MİSİN", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (tus == DialogResult.Yes)
            {
                metodlar.EkleSilGuncelle("insert into cikisSaati(cikisSaati)values('" + cikisSaati + "') ");
                metodlar.EkleSilGuncelle("delete from arackayit where TcKimlikNo='" + txttc.Text + "' ");
              
                metodlar.EkleSilGuncelle("insert into bos(BosYerler)values('" + comboKonum.Text + "')");
                metodlar.EkleSilGuncelle("DELETE from dolu WHERE DoluYerler='" + comboKonum.Text + "' ");
               
                MessageBox.Show("KAYIT SİLİNDİ", "BİLGİLENDİRME");
                listele();
                KonumGetir();
                //konum();
                //konum2();
                //plakasil();

                
            }
            else
            {
                MessageBox.Show("Silme İşleminden Vaz Geçtiniz", "BİLGİLENDİRME");
            }
            txtarama.Text = "";
            txttc.Text = "";
            textEdit1ad.Text = "";
            textEdit2Soyad.Text = "";
            textEditPlakano.Text = "";
        }
           

      
    }
}