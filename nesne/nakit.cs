using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesne
{
    class nakit : odeme
    {
        public nakit(string ttr)
        {
            tutar = ttr;
            onay();
        }

        public static Boolean onay()
        {
            return true;
        }
    }
}
