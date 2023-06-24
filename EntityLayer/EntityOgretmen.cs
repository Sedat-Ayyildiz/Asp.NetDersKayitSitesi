using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class EntityOgretmen
    {
        private int Ogretmenid;
        public int OGRETMENID
        {
            get { return Ogretmenid; }
            set { Ogretmenid = value; }
        }

        private string OgretmenAd;
        public string OGRETMENAD
        {
            get { return OgretmenAd; }
            set { OgretmenAd = value; }
        }

        private string OgretmenBrans;
        public string OGRETMENBRANS
        {
            get { return OgretmenBrans; }
            set { OgretmenBrans = value; }
        }
    }
}
