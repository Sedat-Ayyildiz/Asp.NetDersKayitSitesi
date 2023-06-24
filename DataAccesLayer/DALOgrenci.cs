using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccesLayer
{
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komutEkle = new SqlCommand("insert into TblOgrenci(OgrAd,OgrSoyad,OgrNumara,OgrFoto,OgrSifre) " +
                "values(@p1,@p2,@p3,@p4,@p5)",Connection.bgl);
            if (komutEkle.Connection.State != ConnectionState.Open)//Bağlantı Açık mı Değil mi Kontrol Ettik !
            {
                komutEkle.Connection.Open();
            }
            komutEkle.Parameters.AddWithValue("@p1", parametre.AD);
            komutEkle.Parameters.AddWithValue("@p2", parametre.SOYAD);
            komutEkle.Parameters.AddWithValue("@p3", parametre.NUMARA);
            komutEkle.Parameters.AddWithValue("@p4", parametre.FOTOGRAF);
            komutEkle.Parameters.AddWithValue("@p5", parametre.SİFRE);
            return komutEkle.ExecuteNonQuery();
        }

        public static List<EntityOgrenci> OgrenciListesi()//Öğrenci Verilerini Okuyup Listeledik !
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komutEkle2 = new SqlCommand("select * from TblOgrenci",Connection.bgl);
            if (komutEkle2.Connection.State != ConnectionState.Open)//Bağlantı Açık mı Değil mi Kontrol Ettik !
            {
                komutEkle2.Connection.Open();
            }
            SqlDataReader dr = komutEkle2.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.OGRID = Convert.ToInt32(dr["OgrID"].ToString());
                ent.AD = dr["OgrAd"].ToString();
                ent.SOYAD = dr["OgrSoyad"].ToString();
                ent.NUMARA = dr["OgrNumara"].ToString();
                ent.FOTOGRAF = dr["OgrFoto"].ToString();
                ent.SİFRE = dr["OgrSifre"].ToString();
                ent.BAKİYE = Convert.ToDouble(dr["OgrBakiye"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciSil(int parametre2)
        {
            SqlCommand komutSil = new SqlCommand("delete from TblOgrenci where OgrID=@p1",Connection.bgl);
            if (komutSil.Connection.State != ConnectionState.Open)//Bağlantı Açık mı Değil mi Kontrol Ettik !
            {
                komutSil.Connection.Open();
            }
            komutSil.Parameters.AddWithValue("@p1", parametre2);
            return komutSil.ExecuteNonQuery() > 0;
        }

        public static List<EntityOgrenci> OgrenciDetay(int id)//ÖgrGuncelle Kısmına Öğrenci Verilerini Taşıdık !
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komutEkle4 = new SqlCommand("select * from TblOgrenci where OgrID=@p1", Connection.bgl);
            komutEkle4.Parameters.AddWithValue("@p1", id);
            if (komutEkle4.Connection.State != ConnectionState.Open)//Bağlantı Açık mı Değil mi Kontrol Ettik !
            {
                komutEkle4.Connection.Open();
            }
            SqlDataReader dr = komutEkle4.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.OGRID = Convert.ToInt32(dr["OgrID"].ToString());
                ent.AD = dr["OgrAd"].ToString();
                ent.SOYAD = dr["OgrSoyad"].ToString();
                ent.NUMARA = dr["OgrNumara"].ToString();
                ent.FOTOGRAF = dr["OgrFoto"].ToString();
                ent.SİFRE = dr["OgrSifre"].ToString();
                ent.BAKİYE = Convert.ToDouble(dr["OgrBakiye"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            SqlCommand komutGuncelle = new SqlCommand("update TblOgrenci set OgrAd=@p1,OgrSoyad=@p2,OgrNumara=@p3,OgrFoto=@p4," +
                "OgrSifre=@p5 where OgrID=@p6",Connection.bgl);
            if (komutGuncelle.Connection.State != ConnectionState.Open)//Bağlantı Açık mı Değil mi Kontrol Ettik !
            {
                komutGuncelle.Connection.Open();
            }
            komutGuncelle.Parameters.AddWithValue("@p1", deger.AD);
            komutGuncelle.Parameters.AddWithValue("@p2", deger.SOYAD);
            komutGuncelle.Parameters.AddWithValue("@p3", deger.NUMARA);
            komutGuncelle.Parameters.AddWithValue("@p4", deger.FOTOGRAF);
            komutGuncelle.Parameters.AddWithValue("@p5", deger.SİFRE);
            komutGuncelle.Parameters.AddWithValue("@p6", deger.OGRID);            
            return komutGuncelle.ExecuteNonQuery() > 0 ;
        }
    }
}
