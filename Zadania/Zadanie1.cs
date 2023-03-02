using System;

namespace Zadania
{
    internal class Zadanie1
    {
        public static void ZadanieMain()
        {
            Console.WriteLine("Podaj liczbę 1:");
            int liczba1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbe 2:");
            int liczba2 = int.Parse(Console.ReadLine());

            WyliczSredniaProceduralnie(liczba1, liczba2);

            double wynik = WyliczSredniaFunkcyjnie(liczba1, liczba2);
            Console.WriteLine("Średnia to: {0}", wynik);

            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }

        static void WyliczSredniaProceduralnie(double liczba1, double liczba2)
        {
            double srednia = (liczba1 + liczba2) / 2;
            Console.WriteLine("Średnia to: {0}", srednia);
        }

        static Double WyliczSredniaFunkcyjnie(double liczba1, double liczba2)
        {
            double srednia = (liczba1 + liczba2) / 2;
            return srednia;
        }
    }
}