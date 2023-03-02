using System;

namespace Zadania
{
    internal class Zadanie15
    {
        public static void ZadanieMain()
        {
            Powiedz("Justyna");
            Powiedz("Piotr");
            Powiedz("Mateusz");
            Powiedz("Aleksandra");
            Powiedz("Bartłomiej");
            Powiedz("Stanisław");
            Powiedz("Dorota");
            Powiedz("Michał");
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }

        static void Powiedz(string imie)
        {
            if (imie[imie.Length - 1] == 'a')
            {
                imie = imie.Remove(imie.Length - 1, 1) + 'y';
            }
            else
            {
                imie += 'a';
            }
            Console.WriteLine("Jedno dla {0}, jedno dla mnie.", imie);
        }
    }
}