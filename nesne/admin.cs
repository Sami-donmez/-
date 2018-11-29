using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nesne
{
    class admin
    {
        public static string name;
        static List<string[]> Listedondur() //admin txt listeye çevirir.
        {
            string dosya_yolu = @"admin.txt";
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



        public static Boolean login(string kadi, string sifre)//login işlemi gerçekleştirir.
        {
            MessageBox.Show(kadi.Length.ToString());
            string gsifre = "";
            Boolean kontrol2 = false;
            Boolean kontrol = false;
            List<string[]> liste2 = Listedondur();

            foreach (string[] isim in liste2)
            {
                MessageBox.Show(isim[0]);

                if (kadi == isim[0])
                {
                    
                    kontrol = true;
                    gsifre = isim[1];
                    name = isim[0];

                    break;
                }
                else
                {
                    kontrol = false;
                }
            }
           string gsifre2 = gsifre.Substring(0, gsifre.Length - 1);
            if (kontrol == false)
            {
                kontrol2 = false;
                MessageBox.Show("kullanıcı adı yanlış");
            }
            else
            {
                if (sifre == gsifre2)
                {
                    kontrol2 = true;
                    MessageBox.Show("giriş dogru");
                }
                else
                {
                    kontrol2 = false;
                    MessageBox.Show("Şifre degeri yanlış");
                }
            }
            return kontrol2;
        }
    }
}
