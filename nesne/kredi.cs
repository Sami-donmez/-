using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesne
{
    class Kredi : odeme
    {
        
        public static string numara;
        public static string tip;
        public static string bitisay;
        public static string bitisyıl;

        public Kredi(string nm,string tp,string ba,string by,string ttr)
        {
            tutar = ttr;
            numara = nm;
            tip = tp;
            bitisay = ba;
            bitisyıl = by;
            odemeonay(numara, tip, bitisay, bitisyıl);
        }

        public static Boolean odemeonay(string nr,string tp,string ay, string yıl)
        {
            Boolean a = true;
            return a;
        }

        

    } 
}
