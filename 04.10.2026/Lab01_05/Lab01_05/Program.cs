using System;

namespace polecenie05
{
    class Program05
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj długość boku a prostokąta: ");
            string wejscieA = Console.ReadLine();

            Console.Write("Podaj długość boku b prostokąta: ");
            string wejscieB = Console.ReadLine();

            // Bezpieczna konwersja tekstu na liczby rzeczywiste
            if (double.TryParse(wejscieA, out double a) && double.TryParse(wejscieB, out double b))
            {
                // Obliczenia
                double pole = a * b;
                double obwod = 2 * a + 2 * b;
                double przekatna = Math.Sqrt(a * a + b * b); // Pierwiastek kwadratowy z użyciem Math.Sqrt

                // Wyświetlanie wyników z dokładnością do 3 miejsc po przecinku (format: F3)
                Console.WriteLine($"Pole prostokąta: {pole:F3}");
                Console.WriteLine($"Obwód prostokąta: {obwod:F3}");
                Console.WriteLine($"Długość przekątnej: {przekatna:F3}");
            }
            else
            {
                Console.WriteLine("Błąd: Wprowadzono niepoprawne dane. Użyj liczb rzeczywistych.");
            }
        }
    }
}

//Po wpisaniu liczby z przecinkiem (2,5), program wczytał ją prawidłowo jako liczbę ułamkową, jednak po wpisaniu liczby z kropką (2.5), konwersja się nie powiedzie (Błąd: Wprowadzono niepoprawne dane. Użyj liczb rzeczywistych.), a metoda TryParse uzna wprowadzony tekst za błędny format.
//Dzieje się tak, ponieważ podczas działania programu (wczytywania i wyświetlania liczb) platforma .NET domyślnie używa ustawień regionalnych systemu operacyjnego, w którym w polskim systemie Windows separatorem części ułamkowej jest przecinek.
//Z kolei kropka jako separator ułamkowy obowiązuje wyłącznie podczas pisania samego kodu źródłowego w języku C#