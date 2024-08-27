using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgretmen
    {
        private int ogrtid;

        public int OGRTID
        {
            get { return ogrtid; }
            set { ogrtid = value; }
        }

        private int ogrtad;

        public int OGRTAD
        {
            get { return ogrtad; }
            set { ogrtad = value; }
        }

        private int ogrtbrans;

        public int OGRTBRANS
        {
            get { return ogrtbrans; }
            set { ogrtbrans = value; }
        }
    }
}
