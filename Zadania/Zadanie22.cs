using System;
using System.IO;

namespace Zadania
{
    internal class Zadanie22
    {
        public static void ZadanieMain()
        {
            WypiszStruktureKatalogu(Environment.CurrentDirectory, "");
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }

        static void WypiszStruktureKatalogu(string sciezka, string wciecie)
        {
            try
            {
                foreach (var sciezkaPlik in Directory.GetFiles(sciezka))
                {
                    Console.WriteLine(wciecie + sciezkaPlik);
                }

                foreach (string sciezkaKatalog in Directory.GetDirectories(sciezka))
                {
                    Console.WriteLine(wciecie + sciezkaKatalog.ToUpper());
                    WypiszStruktureKatalogu(sciezkaKatalog, wciecie + "\t");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}