using System;
class Program
{
    static void Main()
    {
    Console.Write("Podaj swoje imię: ");
    string imie = Console.ReadLine(); // ReadLine zawsze zwraca tekst (string)
    Console.Write("Podaj rok urodzenia: ");
    int rok = int.Parse(Console.ReadLine()); // konwersja tekstu na liczbę całkowitą
    Console.Write("Podaj wzrost w metrach (np. 1,82): ");
    double wzrost = double.Parse(Console.ReadLine());
    int wiek = DateTime.Now.Year - rok;
    Console.WriteLine($"{imie}, w tym roku kończysz {wiek} lat, wzrost: {wzrost:F2} m.");
    }
}