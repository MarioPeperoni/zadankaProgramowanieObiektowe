using System;

namespace Zadania
{
    internal class Zadanie24
    {
        public static void ZadanieMain()
        {
            double a, b, c, x1, x2, delta;

            try
            {
                Console.Write("Podaj wartość parametru a: ");
                a = double.Parse(Console.ReadLine());

                if (a == 0)
                {
                    throw new Exception("Parametr a nie moze byc zerem.");
                }

                Console.Write("Podaj wartosc parametru b: ");
                b = double.Parse(Console.ReadLine());
                Console.Write("Podaj wartosc parametru c: ");
                c = double.Parse(Console.ReadLine());

                delta = Math.Sqrt(b) - 4 * a * c;

                if (delta > 0)
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Równanie ma dwa pierwiastki:");
                    Console.WriteLine("x1 = {0}", x1);
                    Console.WriteLine("x2 = {0}", x2);
                }
                if (delta == 0)
                {
                    x1 = -b / (2 * a);
                    Console.WriteLine("Równanie ma jeden pierwiastek:");
                    Console.WriteLine("x1 = {0}", x1);
                }
                if (delta < 0)
                {
                    Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}