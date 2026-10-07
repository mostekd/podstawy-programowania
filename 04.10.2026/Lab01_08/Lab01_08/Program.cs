using System;

namespace polecenie08
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- CZĘŚĆ 1: Siła grawitacji ---
            const double G = 6.674e-11; // Stała grawitacji
            double m1 = 5.972e24;       // Masa Ziemi w kg
            double m2 = 7.348e22;       // Masa Księżyca w kg

            // Odległość w km zamieniona na metry (1 km = 1000 m)
            double r = 384400.0 * 1000.0;

            // Obliczenie siły przyciągania
            double F = G * m1 * m2 / (r * r);

            // Wyświetlenie wyniku w notacji naukowej z 3 miejscami po przecinku
            Console.WriteLine($"Siła przyciągania między Ziemią a Księżycem: {F:E3} N");

            // --- CZĘŚĆ 2: Złoty podział ---
            // Obliczenie wartości wyrażenia (pierwiastek z 5 + 1) / 2
            double zlotyPodzial = (Math.Sqrt(5) + 1) / 2;

            // Wyświetlenie wyniku z dokładnością do 4 miejsc po przecinku
            Console.WriteLine($"Wartość złotego podziału: {zlotyPodzial:F4}");

            // Sprawdzenie właściwości: czy phi^2 == phi + 1
            double kwadrat = Math.Pow(zlotyPodzial, 2);
            double powiekszoneO1 = zlotyPodzial + 1;

            // Porównanie z tolerancją (np. 1e-9) zamiast operatora ==
            bool czyRowne = Math.Abs(kwadrat - powiekszoneO1) < 1e-9;

            Console.WriteLine($"Czy wynik podniesiony do kwadratu jest równy wynikowi powiększonemu o 1? {czyRowne}");
        }
    }
}