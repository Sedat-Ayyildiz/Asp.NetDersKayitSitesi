using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLDers
    {
        public static List<EntityDers> BllListele()
        {
            return DALDers.DersListesi();
        }

        public static int TalepEkle(EntityBasvuruForm p)
        {
            if (p.BASOGRID != null && p.BASDERSID != null)
            {
                return DALDers.TalepEkle(p);
            }
            return -1;
        }
    }
}
