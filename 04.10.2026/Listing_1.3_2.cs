using System; // import przestrzeni nazw System (Console, Math, ...)
namespace Lab01 // własna przestrzeń nazw – grupuje klasy projektu
{
    class Program // klasa zawierająca punkt wejścia programu
    {
        static void Main(string[] args) // metoda Main – od niej zaczyna się wykonanie
        {
            string imie = "Anna";
            int wiek = 20;
            double srednia = 4.356;
            Console.Write("Tekst bez przejścia do nowej linii. ");
            Console.WriteLine("A ten tekst kończy linię.");
            // 1) łączenie łańcuchów operatorem +
            Console.WriteLine("Imię: " + imie + ", wiek: " + wiek);
            // 2) formatowanie złożone – numerowane miejsca {0}, {1}, ...
            Console.WriteLine("Imię: {0}, wiek: {1}", imie, wiek);
            // 3) interpolacja łańcuchów (zalecana) – znak $ przed cudzysłowem
            Console.WriteLine($"Imię: {imie}, wiek: {wiek}, średnia: {srednia:F2}");
            // formatowanie liczb i wyrównanie w kolumnach
            Console.WriteLine($"|{wiek,6}|{srednia,10:F3}|{imie,-8}|"); // ,6 = do prawej, ,-8 = do lewej
            Console.WriteLine($"{0.256:P1} {1234567.891:N2} {255:X} {42:D5}");
            // sekwencje specjalne
            Console.WriteLine("Kolumna1\tKolumna2\nNowa linia, cudzysłów: \" i ukośnik: \\");
            Console.WriteLine(@"C:\Users\student\Pulpit"); // łańcuch dosłowny (verbatim)
        }
    }
}