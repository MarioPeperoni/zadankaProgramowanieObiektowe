using System;

namespace Zadania
{
    internal class Zadanie4
    {
        public static void ZadanieMain()
        {
            Console.Write("Podaj wartosc zmiennej a: ");
            Double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj wartosc zmiennej b: ");
            Double b = Convert.ToDouble(Console.ReadLine());
            SwitchVars(ref a, ref b);
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }

        static void SwitchVars(ref double a, ref double b)
        {
            Double temp = a;
            a = b;
            b = temp;
        }
    }
}