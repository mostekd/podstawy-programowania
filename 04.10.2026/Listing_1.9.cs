int licznik = 5;
licznik++; // 6 (inkrementacja)
licznik += 10; // 16 (to samo co licznik = licznik + 10)
licznik %= 7; // 2
int n = 5;
int p1 = n++; // p1 = 5, potem n = 6 (postinkrementacja)
int p2 = ++n; // n = 7, potem p2 = 7 (preinkrementacja)
int wiek = 19;
bool student = true;
bool znizka = (wiek < 26 && student) || wiek >= 65; // && – „i”, || – „lub”
bool nieparzysta = !(n % 2 == 0); // ! – negacja
Console.WriteLine($"{licznik} {p1} {p2} {znizka} {nieparzysta}");