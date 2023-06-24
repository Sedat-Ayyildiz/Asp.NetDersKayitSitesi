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
    public class DALDers
    {
        public static List<EntityDers> DersListesi()//
        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand komut1 = new SqlCommand("select * from TblDersler", Connection.bgl);
            if (komut1.Connection.State != ConnectionState.Open)//Bağlantı Açık mı Değil mi Kontrol Ettik !
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.DERSID = Convert.ToInt32(dr["DersID"].ToString());
                ent.DERSAD = dr["DersAd"].ToString();
                ent.MIN = int.Parse(dr["DersMinKont"].ToString());
                ent.MAX = int.Parse(dr["DersMaksKont"].ToString());                
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static int TalepEkle(EntityBasvuruForm parametre)
        {
            SqlCommand komutTalep = new SqlCommand("insert into TblBasvuruForm(OgrenciID, DersID) values(@p1,@p2)",Connection.bgl);
            komutTalep.Parameters.AddWithValue("@p1", parametre.BASOGRID);
            komutTalep.Parameters.AddWithValue("@p2", parametre.BASDERSID);
            if (komutTalep.Connection.State != ConnectionState.Open)//Bağlantı Açık mı Değil mi Kontrol Ettik !
            {
                komutTalep.Connection.Open();
            }
            return komutTalep.ExecuteNonQuery();
        }
    }
}
