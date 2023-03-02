using System;

namespace Zadania
{
    internal class Zadanie12
    {
        public static void ZadanieMain()
        {
            Random random = new Random();
            const int a = 1;
            const int b = 100;

            Console.WriteLine("Podaj wartosc wylosowanej liczy z przedziału <{0}, {1}>", a, b);
            int n = random.Next(a, b);
            int m = int.Parse(Console.ReadLine());

            if (n == m)
            {
                Console.WriteLine("Totalny szef! 😎 Trafiłeś liczbe!");
            }
            else
            {
                Console.WriteLine("Nietrafiłeś Wariacie!");
                Console.WriteLine("Wylosowaną liczbą byla liczba {0}", n);
            }
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}