int i = 65;
double d = i; // niejawna (bezpieczna) konwersja int -> double
int j = (int)3.99; // jawne rzutowanie – obcięcie, wynik 3
int k = (int)Math.Round(3.5); // zaokrąglenie „bankowe” – wynik 4 (do parzystej)
int k2 = (int)Math.Round(2.5);// wynik 2 (!)
char c = (char)i; // 'A' – kod Unicode 65
int kod = 'a'; // 97
string s = i.ToString(); // liczba -> tekst
int z = Convert.ToInt32("123");
Console.WriteLine($"{d} {j} {k} {k2} {c} {kod} {s} {z}");
Console.WriteLine($"{Math.Sqrt(2):F4} {Math.Pow(2, 10)} {Math.PI:F5} {Math.Max(3, 8)}");