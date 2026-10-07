using System; // import przestrzeni nazw System (Console, Math, ...)
namespace Lab01 // własna przestrzeń nazw – grupuje klasy projektu
{
    class Program // klasa zawierająca punkt wejścia programu
    {
        static void Main(string[] args) // metoda Main – od niej zaczyna się wykonanie
        {
            int x = 5                   // CS1002: oczekiwano ;
            Console.WriteLine(y);       // CS0103: nazwa 'y' nie istnieje w bieżącym kontekście
            int z = "10";               // CS0029: nie można niejawnie przekonwertować string na int
            int w;
            Console.WriteLine(w);       // CS0165: użycie nieprzypisanej zmiennej lokalnej 'w'
            if (x > 3);                 // ostrzeżenie CS0642: pusta instrukcja – średnik kończy if!
            {
            Console.WriteLine("Ten blok wykona się ZAWSZE");
            }
        }
    }
}