using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesne
{
    class cek:odeme
    {
        public static string bankno;
        public static string isim;

        public cek(String bn,string nm,string ttr)
        {
            bankno = bn;
            isim = nm;
            tutar = ttr;
            onay(bankno,isim);
        }

        public static Boolean onay(string bn, string nm) {

            return true;
        }
    }
}
