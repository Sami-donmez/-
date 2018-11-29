using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace nesne
{
    class kullanıcı
    {
        public static string name;
        public static string adres;
        public static string tel;

        static List<string[]> Listedondur()
        {
            string dosya_yolu = @"user.txt";
            //İşlem yapacağımız dosyanın yolunu belirtiyoruz.
            string metin = File.ReadAllText(dosya_yolu);
            string[] parcalar = metin.Split('\n');
            int i = 0;
            List<string[]> liste = new List<string[]>();
            while (i < parcalar.Count())
            {
                string[] ekle = parcalar[i].Split(',');
                liste.Add(ekle);
                i++;
            }
            return liste;
        }

       

        public static Boolean login(string kadi,string sifre)
        {
            string gsifre = "";
            string gad = "";
            string gadd = "";
            string gtel = "";
            Boolean kontrol2 = false;
            Boolean kontrol = false;
            List<string[]> liste2 = Listedondur();

            foreach (string[] isim in liste2)
            {
                
                if (kadi == isim[1])
                {
                    kontrol = true;
                    gsifre = isim[2];
                    gad = isim[0];
                    gadd = isim[3];
                    gtel = isim[4];
                    break;
                }
                else
                {
                    kontrol = false;
                }
            }
            //string gsifre2 = gsifre.Substring(0, gsifre.Length - 1);
            if (kontrol == false)
            {
                kontrol2 = true;
                MessageBox.Show("kullanıcı adı yanlış");
            }
            else
            {
                if (sifre == gsifre)
                {   kontrol2 = true;
                    MessageBox.Show("giriş dogru");
                    name = gad;
                    adres = gadd;
                    tel = gtel;
                    
                }
                else
                {
                    kontrol2 =false ;
                    MessageBox.Show("Şifre degeri yanlış");
                }
            }
            return kontrol2;
        }


    }
}

