Console.Write("Podaj liczbę całkowitą: ");
string tekst = Console.ReadLine();
if (int.TryParse(tekst, out int liczba))
{
 Console.WriteLine($"Poprawnie wczytano: {liczba}, jej kwadrat to {liczba * liczba}");
}
else
{
 Console.WriteLine($"\"{tekst}\" nie jest poprawną liczbą całkowitą.");
}
