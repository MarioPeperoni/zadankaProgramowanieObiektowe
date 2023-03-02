using System;

namespace Zadania
{
    internal class Zadanie2
    {
        public static void ZadanieMain()
        {
            Console.WriteLine("Podaj liczbe:");
            int factNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Silnia dla {0} wynosi {1}", factNo, Fact(factNo));
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }

        static int Fact(int no)
        {
            int returnValue = 1;
            for (int i = 2; i <= no; i++)
            {
                returnValue *= i;
            }
            return returnValue;
        }
    }
}