using System;

namespace Zadania
{
    internal class Zadanie6
    {
        public static void ZadanieMain()
        {
            Console.Write("Podaj długość promienia: ");
            double r = double.Parse(Console.ReadLine());

            double pole = Math.PI * r * r;
            double obwod = 2 * Math.PI * r;

            Console.WriteLine("Pole koła o promieniu {0} wynosi {1}.", r, pole);
            Console.WriteLine("Obwód koła o promieniu {0} wynosi {1}.", r, obwod);

            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}