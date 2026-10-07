using System; // import przestrzeni nazw System (Console, Math, ...)
namespace Lab01 // własna przestrzeń nazw – grupuje klasy projektu
{
    class Program // klasa zawierająca punkt wejścia programu
    {
        static void Main(string[] args) // metoda Main – od niej zaczyna się wykonanie
        {
            int a = 7, b = 2;
            Console.WriteLine(a / b); // 3 – dzielenie całkowite (część ułamkowa jest odcinana)
            Console.WriteLine(a % b); // 1 – reszta z dzielenia (modulo)
            Console.WriteLine(a / 2.0); // 3,5 – jeden argument rzeczywisty => wynik rzeczywisty
            Console.WriteLine((double)a / b); // 3,5 – rzutowanie jawne przed dzieleniem
            double x = 0.1 + 0.2;
            Console.WriteLine(x == 0.3); // False! – błąd reprezentacji binarnej
            Console.WriteLine(Math.Abs(x - 0.3) < 1e-9); // True – porównanie z tolerancją
            decimal m = 0.1m + 0.2m;
            Console.WriteLine(m == 0.3m); // True – decimal liczy dziesiętnie (finanse)
            int duza = int.MaxValue;
            duza = duza + 1; // przepełnienie – „zawinięcie” do int.MinValue
            Console.WriteLine(duza); // -2147483648
            long bezpieczna = (long)int.MaxValue + 1;
            Console.WriteLine(bezpieczna); // 2147483648
            const double G = 9.81; // stała – wartości nie można zmienić
            var t = 2.5; // var – typ wywnioskowany przez kompilator (double)
            Console.WriteLine($"Droga spadku po {t} s: {G * t * t / 2:F2} m");
        }
    }
}