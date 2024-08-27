using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgrenci
    {
        private string ad;

        public string AD
        {
            get { return ad; }
            set { ad = value; }
        }

        private string soyad;

        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value; }
        }

        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string numara;

        public string NUMARA
        {
            get { return numara; }
            set { numara = value; }
        }

        private string fotograf;

        public string  FOTOGRAF
        {
            get { return fotograf; }
            set { fotograf = value; }
        }

        private double bakiye;

        public double BAKIYE
        {
            get { return bakiye; }
            set { bakiye = value; }
        }

        private string sifre;

        public string SIFRE
        {
            get { return sifre; }
            set { sifre = value; }
        }
    }
}
