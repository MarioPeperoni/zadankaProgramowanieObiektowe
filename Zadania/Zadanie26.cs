using System;

namespace Zadania
{
    internal class Zadanie26
    {
        public static void ZadanieMain()
        {
            Console.Write("Podaj przesunięcie: ");
            int przesuniecie = int.Parse(Console.ReadLine());

            Console.WriteLine("Zacznij wpisywać szyfr (q aby zakończyć)");

            while (true)
            {
                char curChar = Console.ReadKey(true).KeyChar;
                if (curChar == 'q')
                    break;
                Console.Write(Encode(curChar, przesuniecie));
            }
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }

        static char Encode(char character, int przesuniecie)
        {
            char startIndex = char.IsUpper(character) ? 'A' : 'a';
            int alphabetIndex = ((((int)character - (int)startIndex) + przesuniecie) % 26);
            return (char)((int)startIndex + alphabetIndex);
        }
    }
}