using System;

namespace Zadania
{
    internal class Zadanie29
    {
        public static void ZadanieMain()
        {
            int[] tab = new int[15];
            Random r = new Random();

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = r.Next(0, 101);
            }
            Console.WriteLine("Warotsci elemetów w tablicy:");
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }

            int indexMax = 0;
            int indexMin = 0;

            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] > tab[indexMax])
                {
                    indexMax = i;
                }
                if (tab[i] < tab[indexMin])
                {
                    indexMin = i;
                }
            }
            Console.WriteLine("\nElement najmniejszy o indeksie " + indexMin + " posiada wartość " + tab[indexMin]);
            Console.WriteLine("Element największy o indeksie " + indexMax + " posiada wartość " + tab[indexMax]);
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}