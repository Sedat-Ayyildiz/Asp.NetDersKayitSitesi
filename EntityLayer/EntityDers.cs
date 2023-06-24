using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityDers
    {
        private int Dersid;
        public int DERSID
        {
            get { return Dersid; }
            set { Dersid = value; }
        }

        private string DersAd;
        public string DERSAD
        {
            get { return DersAd; }
            set { DersAd = value; }
        }

        private int DersMinKont;
        public int MIN
        {
            get { return DersMinKont; }
            set { DersMinKont = value; }
        }

        private int DersMaksKont;
        public int MAX
        {
            get { return DersMaksKont; }
            set { DersMaksKont = value; }
        }
    }
}
