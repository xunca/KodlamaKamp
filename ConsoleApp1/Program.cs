using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {   //type safety = tip güvenliği
            // ; ile satır biter
            // çift tırnak kullanılır
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            // string askuser 
            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
                Console.WriteLine("Artış Butonu");
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }
            

            if (sistemeGirisYapmisMi == false)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {

                Console.WriteLine("Giriş Yap Butonu");
            }
            Console.WriteLine(kategoriEtiketi);
        }

    }
}
