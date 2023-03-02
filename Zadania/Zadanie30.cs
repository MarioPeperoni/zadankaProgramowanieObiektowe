using System;

namespace Zadania
{
    internal class Zadanie30
    {
        public static void ZadanieMain()
        {
            int[] tab = new int[3];

            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write("Podaj liczbe " + (i + 1) + " :");
                tab[i] = int.Parse(Console.ReadLine());
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
            Console.WriteLine("\nNajmniejsza z trzech: " + tab[indexMin]);
            Console.WriteLine("Największa z trzech: " + tab[indexMax]);
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}