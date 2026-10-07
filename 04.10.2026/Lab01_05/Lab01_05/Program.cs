using System;

namespace polecenie05
{
    class Program05
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość boku prostokąta: ");
            int długość = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj szerokość boku prostokąta: ");
            int szerokość = int.Parse(Console.ReadLine());

            Console.WriteLine("Pole prostokąta wynosi: " + (długość * szerokość));
            Console.WriteLine("Obwód prostokąta wynosi: " + (2 * (długość + szerokość)));
            Console.WriteLine("Przekątna prostokąta wynosi: " + Math.Sqrt(Math.Pow(długość, 2) + Math.Pow(szerokość, 2)));

        }
    }
}