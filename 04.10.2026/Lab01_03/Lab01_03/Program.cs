using System;

namespace polecenie03
{
    internal class Program03
    {
        static void Main(string[] args)
        {
            double cena = 1234.5678;
            double rabat = 0.075;
            int ilosc = 7;

            Console.WriteLine($"Cena: {cena:N2}");
            Console.WriteLine($"Cena: {cena:C}");
            Console.WriteLine($"Rabat: {rabat:P}");
            Console.WriteLine($"Ilość: {ilosc:D4}");
            Console.WriteLine($"{cena * ilosc * (1 - rabat),15}");
        }
    }
}
