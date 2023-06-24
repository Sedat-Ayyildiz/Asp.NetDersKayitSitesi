using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.AD != null && p.SOYAD != null && p.NUMARA != null && p.SİFRE != null && p.FOTOGRAF != null)
            {
                return DALOgrenci.OgrenciEkle(p);
            }
            return -1;  
        }

        public static List<EntityOgrenci> BllListele()
        {
            return DALOgrenci.OgrenciListesi();
        }

        public static bool OgrenciSilBLL(int p)
        {
            if (p > 0)
            {
                return DALOgrenci.OgrenciSil(p);
            }
            return false;
        }

        public static List<EntityOgrenci> BllDetay(int p)
        {
            return DALOgrenci.OgrenciDetay(p);
        }

        public static bool OgrenciGuncelleBLL(EntityOgrenci p)
        {
            if (p.AD != null && p.AD !="" && p.SOYAD != null && p.SOYAD != "" && p.NUMARA != null && p.NUMARA != "" && 
                p.SİFRE != null && p.NUMARA != "" && p.FOTOGRAF != null && p.FOTOGRAF != "" && p.OGRID > 0)
            {
                return DALOgrenci.OgrenciGuncelle(p);
            }
            return false;
        }
    }
}
