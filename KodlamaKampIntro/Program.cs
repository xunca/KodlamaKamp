using System;

namespace KodlamaKampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Samet";
            kurs1.izlenmeOrani = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Ana";
            kurs2.izlenmeOrani = 65;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Emre";
            kurs3.izlenmeOrani = 64;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
                Console.WriteLine(Kurs.KursAdi);
            Console.WriteLine("Hello");
        }
    }
    }
    class Kurs
        {
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }

    public string IzlenmeOrani { get; set; }

        internal class KursAdi
        {
        }
    }


        }
    
}
