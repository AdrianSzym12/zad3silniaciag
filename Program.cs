using System;

namespace silnia_rekurecja_iteracyjna_i_fibanaci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz opcje: ");
            Console.WriteLine("1. Silnia iteracyjna ");
            Console.WriteLine("2. Silnia rekurencja ");
            Console.WriteLine("3. Fibanacci ");
            int wybor = int.Parse(Console.ReadLine());
            if (wybor == 1)
            {
                silnia();
            }
            else if (wybor == 2)
            {
                Console.Write("Podaj do wyliczenia n! ");
                int liczba = int.Parse(Console.ReadLine());
                int wynik = rekurencja(liczba);
                Console.WriteLine(wynik);
            }
            else if (wybor == 3)
            {
                Fibanacci();
            }
            else Console.WriteLine("Zła odp ;(");
            
            
        }
        static int silnia()
        {
            Console.Write("Podaj do wyliczenia n! ");
            int liczba = int.Parse(Console.ReadLine());
            int wynik = liczba;
            if (liczba < 31)
            {

                for (int i = 1; i < liczba; i = i + 1)
                {
                    wynik = wynik * (liczba - i);
                }
                Console.WriteLine("Wynik to= " + wynik);
            }
            else
            {
                Console.WriteLine("Za duży wynik, brak miejsca na liczby");
            }
            return wynik;
        }
        static int rekurencja(int liczba)
        {
            Console.WriteLine("liczba to = " + liczba);
            if (liczba == 1)
            {
                return 1;
            }
            else
            {
                int wynik = liczba * rekurencja(liczba - 1);
                return wynik;
            }
        }
        static void Fibanacci()
        {
            int pierwszy = 0, drugi = 1, trzeci = 0;
            Console.Write("Wybierz numer : ");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pierwsze {0} Fibonacci numery {1} {2} ", n, pierwszy, drugi);

            for (int i = 3; i <= n; i++)
            {
                trzeci = pierwszy + drugi;
                Console.Write("{0} ", trzeci);
                pierwszy = drugi;
                drugi = trzeci;
            }
        }
        
    }
}

