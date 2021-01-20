using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Product
    {
        string UrunAdi = "Elma";
        double fiyati = 15;
        string aciklama = "Amasya elması";

        //string[] meyveler = new string[] { };

        Product urun1 = new Product();
        urun1.Adi ="Elma";
        urun1.Fiyati = 15;
        urun1.Aciklama ="Amasya elması";

        Product urun2 = new UrunAdi();
        urun2.Adi = "Karpuz";
        urun2.Fiyati =80;
        urun2.Aciklama ="Diyarbakır Karpuzu";

        Product[] urunler = new Product[] { urun1, urun2 };;
        
        foreach (Product urun in urunler)
    {
            Console.WriteLine (urun.Adi);
            Console.WriteLine(urun.Fiyati);
            Console.WriteLine(urun.Aciklama);

    }

}
}
