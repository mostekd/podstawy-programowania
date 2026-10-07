using System;

namespace polecenie02
{
    internal class Program02
    {
        static void Main(string[] args)
        {
            string imie_nazwisko = "Dawid Mostowski";
            string kierunek = "Informatyka, I rok";
            string nr_albumu = "nr. albumu: 23659";
            string email = "23659@ahns.pl";

            int szerokoscRamki = 30;
            for (int i = 0; i < szerokoscRamki; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.WriteLine($"*{imie_nazwisko,-28}*");
            Console.WriteLine($"*{kierunek,-28}*");
            Console.WriteLine($"*{nr_albumu,-28}*");
            Console.WriteLine($"*{email,-28}*");

            for (int i = 0; i < szerokoscRamki; i++)
            {
                Console.Write("*");
            }
            ;
        }
    }
}