using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityBasvuruForm
    {
        private int Basvuruid;
        public int BASVURUID
        {
            get { return Basvuruid; }
            set { Basvuruid = value; }
        }

        private int BasDersid;
        public int BASDERSID
        {
            get { return BasDersid; }
            set { BasDersid = value; }
        }

        private int BasOgrid;
        public int BASOGRID
        {
            get { return BasOgrid; }
            set { BasOgrid = value; }
        }
    }
}
