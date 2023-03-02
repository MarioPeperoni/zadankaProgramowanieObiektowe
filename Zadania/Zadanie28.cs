using System;

namespace Zadania
{
    internal class Zadanie28
    {
        public static void ZadanieMain()
        {
            int[] tablica;
            bool posiadaNieparzystosc = false;
            Console.WriteLine("Podaj zbiór liczb całkowitych (odzielonych spcjami):");
            tablica = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            for (int i = 0; i < tablica.Length && posiadaNieparzystosc == false; i++)
            {
                if (tablica[i] % 2 == 1)
                    posiadaNieparzystosc = true;
            }

            Console.WriteLine("Czy tablica posiada nieparzystosc? " + posiadaNieparzystosc);
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}