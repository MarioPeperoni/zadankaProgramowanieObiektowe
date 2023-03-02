using System;

namespace Zadania
{
    internal class Zadanie36
    {
        public static void ZadanieMain()
        {
            const int MAX = 1000000;
            int count = 0;

            bool[] prime = new bool[MAX + 1];
            for (int i = 2; i <= MAX; i++)
            {
                prime[i] = true;
            }

            for (int i = 2; i * i <= MAX; i++)
            {
                if (prime[i])
                {
                    for (int j = i * i; j <= MAX; j += i)
                    {
                        prime[j] = false;
                    }
                }
            }

            for (int i = 2; i <= MAX; i++)
            {
                if (prime[i])
                {
                    count++;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Istnieje {0} liczb pierwszych do {1}", count, MAX);
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}