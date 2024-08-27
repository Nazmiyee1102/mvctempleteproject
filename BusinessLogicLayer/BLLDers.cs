using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLDers
    {
        public static List<EntityDers> BllListele()
        {
            return DALDers.DersListesi();
        }

        public static int TalepEkleBLL(EntityBasvuruFormu p)
        {
            if (p.BASVURUOGRID != null && p.BASVURUDERSID != null)
            {
                return DALDers.TalepEkle(p);
            }
            return -1;
        }
    }
}
