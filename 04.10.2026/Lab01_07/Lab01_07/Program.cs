using System;

namespace polecenie07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kwota: ");
            // Wczytanie kwoty całkowitej z walidacją
            if (!int.TryParse(Console.ReadLine(), out int kwota) || kwota <= 0)
            {
                Console.WriteLine("Błąd: Wprowadzono niepoprawną kwotę. Podaj dodatnią liczbę całkowitą.");
                return;
            }

            int ilosc;

            // Nominał 500 zł
            ilosc = kwota / 500;
            if (ilosc > 0) Console.WriteLine($"500 zł x {ilosc}");
            kwota = kwota % 500;

            // Nominał 200 zł
            ilosc = kwota / 200;
            if (ilosc > 0) Console.WriteLine($"200 zł x {ilosc}");
            kwota = kwota % 200;

            // Nominał 100 zł
            ilosc = kwota / 100;
            if (ilosc > 0) Console.WriteLine($"100 zł x {ilosc}");
            kwota = kwota % 100;

            // Nominał 50 zł
            ilosc = kwota / 50;
            if (ilosc > 0) Console.WriteLine($"50 zł x {ilosc}");
            kwota = kwota % 50;

            // Nominał 20 zł
            ilosc = kwota / 20;
            if (ilosc > 0) Console.WriteLine($"20 zł x {ilosc}");
            kwota = kwota % 20;

            // Nominał 10 zł
            ilosc = kwota / 10;
            if (ilosc > 0) Console.WriteLine($"10 zł x {ilosc}");
            kwota = kwota % 10;

            // Nominał 5 zł
            ilosc = kwota / 5;
            if (ilosc > 0) Console.WriteLine($"5 zł x {ilosc}");
            kwota = kwota % 5;

            // Nominał 2 zł
            ilosc = kwota / 2;
            if (ilosc > 0) Console.WriteLine($"2 zł x {ilosc}");
            kwota = kwota % 2;

            // Nominał 1 zł
            ilosc = kwota / 1;
            if (ilosc > 0) Console.WriteLine($"1 zł x {ilosc}");
            // kwota = kwota % 1; // Ostatnia operacja modulo nie jest już konieczna
        }
    }
}