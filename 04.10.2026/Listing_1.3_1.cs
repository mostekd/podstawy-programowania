using System; // import przestrzeni nazw System (Console, Math, ...)
namespace Lab01 // własna przestrzeń nazw – grupuje klasy projektu
{
    class Program // klasa zawierająca punkt wejścia programu
    {
        static void Main(string[] args) // metoda Main – od niej zaczyna się wykonanie
        {
        Console.WriteLine("Witaj na laboratorium z Podstaw programowania!");
        Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
        Console.ReadKey(true); // zatrzymanie programu do naciśnięcia klawisza
        }
    }
}