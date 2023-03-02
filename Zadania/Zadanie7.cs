using System;

namespace Zadania
{
    internal class Zadanie7
    {
        public static void ZadanieMain()
        {
            const Double vat = 0.22;
            Console.Write("Podaj cenę netto: ");
            Double nettoPrice = Convert.ToDouble(Console.ReadLine());

            Double podatek = nettoPrice * vat;
            Double brutto = nettoPrice + podatek;

            Console.WriteLine("Cenna wynosi {0} zł, w tym kwota podatku {1} zł.", brutto, podatek);
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}