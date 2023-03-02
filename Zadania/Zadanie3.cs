using System;

namespace Zadania
{
    internal class Zadanie3
    {
        public static void ZadanieMain()
        {
            Console.WriteLine("Podaj liczbe:");
            int no = int.Parse(Console.ReadLine());
            Console.WriteLine("Liczba " + no + " jest " + (IsEven(no) ? "parzysta" : "nieparzysta"));
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }

        static bool IsEven(int no)
        {
            return no % 2 == 0;
        }
    }
}