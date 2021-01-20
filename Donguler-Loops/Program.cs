using System;

namespace Donguler_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici";
            string kurs2 = "Program Temel Kurs";
            string kurs3 = "Java";


            // Type your username and press enter
            //Console.WriteLine("Enter username:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            //string userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            //Console.WriteLine("Username is: " + userName);

            // array - dizi
            string[] kurslar = new string[] {"Yazılım Geliştirici",
                "Program Temel Kurs",
                "Java", "Python","C#"};
                Console.WriteLine(kurslar);

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa sonu-footer");


        }
    }
}
