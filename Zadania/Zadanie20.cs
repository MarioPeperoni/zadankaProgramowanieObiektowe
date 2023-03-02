using System;

namespace Zadania
{
    internal class Zadanie20
    {

        static float StopaProcentowa(float saldo)
        {
            if (saldo < 0)
            {
                return 3.213f;
            }
            else if (saldo < 1000f)
            {
                return 0.5f;
            }
            else if (saldo < 5000f)
            {
                return 1.621f;
            }
            else
            {
                return 2.475f;
            }
        }

        static float AktualizacjaSaldaRocznego(float saldo)
        {
            float stopaProcentowa = StopaProcentowa(saldo) / 100;
            float odsetki = saldo * (float)stopaProcentowa;
            return saldo + odsetki;
        }

        static int IleLatPrzedOczekiwanymSaldem(float saldo, float oczekiwaneSaldo)
        {
            int lata = 0;
            while (saldo < oczekiwaneSaldo)
            {
                saldo = AktualizacjaSaldaRocznego(saldo);
                lata++;
            }
            return lata;
        }

        public static void ZadanieMain()
        {
            float saldo = 200.75f;
            float stopaProcentowa = StopaProcentowa(saldo);
            float saldoPoRoku = AktualizacjaSaldaRocznego(saldo);
            Console.WriteLine($"odsetki: {stopaProcentowa}");
            Console.WriteLine($"{saldoPoRoku}");

            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}