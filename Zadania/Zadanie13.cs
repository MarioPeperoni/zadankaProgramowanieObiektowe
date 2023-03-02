using System;

namespace Zadania
{
    internal class Zadanie13
    {
        public static void ZadanieMain()
        {
            SprawdzLiczbePierwsza();
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }

        static void SprawdzLiczbePierwsza()
        {
            Console.WriteLine("Podaj liczbe:");
            int no = int.Parse(Console.ReadLine());
            if (no == 2)
            {
                Console.WriteLine("Liczba {0} jest liczba pierwsza", no);
            }
            if (no % 2 == 0)
            {
                Console.WriteLine("Liczba {0} nie jest liczbą pierwszą", no);
            }
            else
            {
                bool lpierwsza = true;
                int limit = (int)Math.Sqrt(no);
                for (int i = 3; i < limit; i += 2)
                {
                    if (no % i == 0)
                    {
                        lpierwsza = false;
                        Console.WriteLine("Liczba {0} nie jest liczbą pierwszą", no);
                        break;
                    }
                }
                if (lpierwsza)
                {
                    Console.WriteLine("Liczba {0} jest liczba pierwsza", no);
                }
            }

        }
    }
}