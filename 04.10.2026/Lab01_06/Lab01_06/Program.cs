using System;

namespace polecenie06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj masę ciała [kg]: ");
            // Wczytywanie i walidacja masy ciała (musi być liczbą i być większa od zera)
            if (!double.TryParse(Console.ReadLine(), out double masa) || masa <= 0)
            {
                Console.WriteLine("Błąd: Wprowadzono niepoprawną masę ciała. Program kończy działanie.");
                return; // Zakończenie działania programu
            }

            Console.Write("Podaj wzrost [cm]: ");
            // Wczytywanie i walidacja wzrostu (musi być liczbą i być większa od zera)
            if (!double.TryParse(Console.ReadLine(), out double wzrostCm) || wzrostCm <= 0)
            {
                Console.WriteLine("Błąd: Wprowadzono niepoprawny wzrost. Program kończy działanie.");
                return; // Zakończenie działania programu
            }

            // Przeliczenie wzrostu z centymetrów na metry
            double wzrostM = wzrostCm / 100.0;

            // Obliczenie wskaźnika BMI: masa / wzrost^2 (wzrost w metrach)
            double bmi = masa / (wzrostM * wzrostM);

            // Wyświetlenie wyniku z jednym miejscem po przecinku (format: F1)
            Console.WriteLine($"Twój wskaźnik BMI wynosi: {bmi:F1}");
        }
    }
}