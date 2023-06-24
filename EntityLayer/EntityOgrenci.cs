using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgrenci
    {
        private int Ogrid;
        public int OGRID
        {
            get { return Ogrid; }
            set { Ogrid = value; }
        }

        private string Ad;
        public string AD
        {
            get { return Ad; }
            set { Ad = value; }
        }

        private string Soyad;
        public string SOYAD
        {
            get { return Soyad; }
            set { Soyad = value; }
        }

        private string Numara;
        public string NUMARA
        {
            get { return Numara; }
            set { Numara = value; }
        }

        private string Fotograf;
        public string FOTOGRAF
        {
            get { return Fotograf; }
            set { Fotograf = value; }
        }

        private string Sifre;
        public string SİFRE
        {
            get { return Sifre; }
            set { Sifre = value; }
        }

        private double Bakiye;
        public double BAKİYE
        {
            get { return Bakiye; }
            set { Bakiye = value; }
        }
    }
}
