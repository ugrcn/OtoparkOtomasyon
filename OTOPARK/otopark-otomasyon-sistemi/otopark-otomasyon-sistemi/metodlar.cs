using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace otopark_otomasyon_sistemi
{
    class metodlar
    {
        //YOL TANIMLAMASI YAPILDI burayı DE -ĞİŞ- Tİ - RİN
        public static SqlConnection conn = new SqlConnection("Data Source=CEYHANYILDIZ\\SQL;Initial Catalog=otopark;Integrated Security=True");
        //VERİ LİSTELEMEDE KULLANILAN ADAPTER NESNESİ TANIMLANDI
        public static SqlDataAdapter adab = new SqlDataAdapter();
        //conn bağlantı nesnesini kulanarak yeni bir komut nesnesi oluştur.
        public static SqlCommand cmd = conn.CreateCommand();

        //listeleme işlemlerinde
        //Tablogonder metodu string bir parametre alan, ve datatable tipinde 
        //veri döndüren ( tablo döndüren ) bir yapıya sahiptir. 
        public static DataTable TabloGonder(string sql)
        {
            DataTable dt = new DataTable();

            //SelectCommand özelliği geçerli bir sorguya sahip olmalıdır. 
            //Veri almak için kullanılan sorgu bir Command nesnesine işaret etmektedir. 
            //Çoğu zaman bir DataAdapter oluştururken bu sınıfın kurucusu içinde, select 
            //sorgularını string olarak gireriz.
            //Bu string aslında sonradan bir Command nesnesi haline gelerek, DataAdapter 
            // sınıfının SelectCommand özelliğine atanır.
            cmd.CommandText = sql;
            //SqlDataAdapter adap = new SqlDataAdapter("select * from araclar", conn);

            //cmd.CommandText = "select * from araclar";
            adab.SelectCommand = cmd;  // cmd iki tane 1. yol 2. komut
            //CommandText: Çalıştırılacak olan sorgu cümlesi yazılmaktadır.
            //sql sorgusunun yazıldığı nesnedir.--> cmd.commandText 

            adab.Fill(dt);

            return dt;
        }

        //bool dönüş tipi messegabox tan gelen true yada false duruma göre 
        //işlem yapar. döndürür.
        public static bool EkleSilGuncelle(string sql)
        {
            try
            { // insert delete ve update işlemlerinde tabloyu değiştiriyor
                conn.Open();
                //gelen sql string cmd nesnesinin komuttext ine eşitliyoruz
                cmd.CommandText = sql;
                //insert update ve delete işlemlerinde  executeNonQuery tabloyu değiştirir.
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }



        }
        }
    }

