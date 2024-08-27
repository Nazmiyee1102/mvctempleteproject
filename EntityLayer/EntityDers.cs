using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityDers
    {
        public string dersad;

        public string DERSAD
        {
            get { return dersad; }
            set { dersad = value; }
        }

        public int min;

        public int MIN
        {
            get { return min; }
            set { min = value; }
        }

        public int max;

        public int MAX
        {
            get { return max; }
            set { max = value; }
        }

        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
    }
}
