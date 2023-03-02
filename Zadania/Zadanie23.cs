using System;

namespace Zadania
{
    internal class Zadanie23
    {
        public static void ZadanieMain()
        {
            Console.WriteLine("Silnia dla 4 to:\n" + WyliczSilnie(4));
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }

        static int WyliczSilnie(int n)
        {
            if (n <= 1)
                return 1;
            return n * WyliczSilnie(n - 1);
        }
    }
}