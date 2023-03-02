using System;

namespace Zadania
{
    internal class Zadanie8
    {
        public static void ZadanieMain()
        {
            Console.WriteLine("Podja pierwszą wartość: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podja drugą wartość: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Wartość maksymalna wynosi: " + (a > b ? a : b));
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}