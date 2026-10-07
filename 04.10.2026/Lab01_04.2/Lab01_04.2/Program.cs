using System;

namespace polecenie04
{
    class Program04
    {
        static void Main(string[] args)
        {
            int x = 5;// CS1002: oczekiwano ; (zamieniono „x = 5” na „int x = 5;”)
            Console.WriteLine(x); // CS0103: nazwa 'y' nie istnieje w bieżącym kontekście (zamieniono 'y' na 'x')
            int z = 10; // CS0029: Nie można niejawnie przekonwertować typu „string” na „int”. (usunięto przypisanie „z = "10"” i zastąpiono je „z = 10”)
            int w = 8; // (zamieniono „w” na „w = 8”)
            Console.WriteLine(w + z); // CS0165: Użyto nieprzypisanej zmiennej lokalnej „w” (zamieniono „w” na „w + z”)
            if (x > 3) // ostrzeżenie CS0642: Prawdopodobnie omyłkowo wystąpiła pusta instrukcja (zamieniono „if (x > 3);” na „if (x > 3)”)
            {
                Console.WriteLine("Ten blok wykona się ZAWSZE");
            }; //(dodano „;”)
        }
    }
}