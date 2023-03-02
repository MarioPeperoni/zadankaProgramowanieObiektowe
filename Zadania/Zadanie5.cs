using System;

namespace Zadania
{
    internal class Zadanie5
    {
        public static void ZadanieMain()
        {
            Console.Write("Podaj wartość zmiennej x: ");
            float x = Convert.ToSingle(Console.ReadLine());
            Console.Write("Podaj wartość zmiennej y: ");
            float y = Convert.ToSingle(Console.ReadLine());
            Console.Write("Podaj wartość zmiennej z: ");
            float z = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Wartość wyrażenia wynosi: {0}", Formula(x, y, z));
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }

        static float Formula(float x, float y, float z)
        {
            return ((4 * x) - y) / (3 * ((z * z) + 1));
        }
    }
}
