using System;

namespace Zadania
{
    internal class Zadanie35
    {
        public static void ZadanieMain()
        {
            int row = 0;
            int i = 0;
            while (i < 10)
            {
                row++;
                for (int j = 0; j < row; j++)
                {
                    i++;
                    Console.Write(i);
                }
                Console.Write("\n");
            }
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}