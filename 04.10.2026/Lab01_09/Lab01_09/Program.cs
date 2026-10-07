using System;

namespace polecenie09
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- CZĘŚĆ 1: Eksperyment z przepełnieniem (Silnia) ---
            Console.WriteLine("--- Silnia ---");

            int silniaInt = 1;
            long silniaLong = 1;
            double silniaDouble = 1;
            decimal silniaDecimal = 1;

            for (int i = 1; i <= 25; i++)
            {
                // UWAGA: Aby zaobserwować zgłoszenie wyjątku OverflowException, 
                // odkomentuj poniższy blok 'checked' i zakomentuj instrukcje bez niego.
                // checked 
                // {
                //     silniaInt *= i;
                //     silniaLong *= i;
                // }

                silniaInt *= i;
                silniaLong *= i;
                silniaDouble *= i;
                silniaDecimal *= i;

                if (i >= 10)
                {
                    Console.WriteLine($"\nn = {i}");
                    Console.WriteLine($"int:     {silniaInt}");
                    Console.WriteLine($"long:    {silniaLong}");
                    Console.WriteLine($"double:  {silniaDouble}");
                    Console.WriteLine($"decimal: {silniaDecimal}");
                }
            }

            // --- CZĘŚĆ 2: Precyzja liczb rzeczywistych ---
            Console.WriteLine("\n--- Sumowanie 0.1 dziesięć razy ---");

            double sumaDouble = 0;
            decimal sumaDecimal = 0m; // Sufiks 'm' dla typu decimal

            for (int i = 0; i < 10; i++)
            {
                sumaDouble += 0.1;
                sumaDecimal += 0.1m;
            }

            // Wyświetlanie wyniku z 17 miejscami po przecinku (F17)
            Console.WriteLine($"Suma double:  {sumaDouble:F17} | Czy równa 1? {sumaDouble == 1.0}");
            Console.WriteLine($"Suma decimal: {sumaDecimal:F17} | Czy równa 1? {sumaDecimal == 1.0m}");
        }
    }
}