using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityBasvuruFormu
    {
        private int basvuruid;

        public int BASVURUID
        {
            get { return basvuruid; }
            set { basvuruid = value; }
        }

        private int basvurudersid;

        public int BASVURUDERSID
        {
            get { return basvurudersid; }
            set { basvurudersid = value; }
        }

        private int basvuruogrid;

        public int BASVURUOGRID
        {
            get { return basvuruogrid; }
            set { basvuruogrid = value; }
        }
    }
}
