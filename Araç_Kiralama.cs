using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    internal class Araç_Kiralama
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-OVF3C9N2;Initial Catalog=\"araç kiralama\";Integrated Security=True");
        DataTable tablo;
        public void ekle_sil_guncelle(SqlCommand komut,string sorgu )
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public DataTable listele(SqlDataAdapter adtr,string sorgu)
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }
        public void Boş_Araçlar(ComboBox combo ,string sorgu)
        {
            
        }
       public void satışhesapla(Label lbl)
        {

            baglanti.Open();
             SqlCommand komut = new SqlCommand("select sum(tutar) from satış",baglanti);
            lbl.Text = "Toplam Tutar=" + komut.ExecuteScalar() + "TL";
            baglanti.Close();
        }

    }
}
