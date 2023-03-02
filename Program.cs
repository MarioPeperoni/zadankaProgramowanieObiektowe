using System;
using Zadania;
internal class Program
{
    public static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Wybierz program:");
            Console.WriteLine("1. 📐 Średnia");
            Console.WriteLine("2. 📐 Silnia");
            Console.WriteLine("3. 📐 Liczba parzysta");
            Console.WriteLine("4. 💱 Zamiana");
            Console.WriteLine("5. ➗ Wyrażenie");
            Console.WriteLine("6. ⭕ Koło");
            Console.WriteLine("7. 🦕 Podatek");
            Console.WriteLine("8. 🌕 Maksimum");
            Console.WriteLine("9. 🌝 Maksimum cztery");
            Console.WriteLine("10. 🍺 Wyrażenie 2");
            Console.WriteLine("11. 🌺 NWD - Największy wspólny dzielnik");
            Console.WriteLine("12. 👽 Gra");
            Console.WriteLine("13. 🎆 Liczba pierwsza");
            Console.WriteLine("14. 🧽 Pierwiastek");
            Console.WriteLine("15. 😦 Imiona");
            Console.WriteLine("16. 😎 Liczby");
            Console.WriteLine("17. 😎 Liczby cd.");
            Console.WriteLine("18. 😎 Liczby cdn.");
            Console.WriteLine("19. △ Trójkąt");
            Console.WriteLine("20. 💰 Oszczednosci");
            Console.WriteLine("21. 😦 Fibonacci");
            Console.WriteLine("22. 🤯 Katalogi");
            Console.WriteLine("23. 🎆 Silnia rekurencyjna");
            Console.WriteLine("24. 😋 Delta");
            Console.WriteLine("25. 😎 Suma Iloczyn");
            Console.WriteLine("26. ⏮ Szyfr Cezara");
            Console.WriteLine("27. 👤 Imiona");
            Console.WriteLine("28. 🔢 Liczba nieparzysta w tablicy");
            Console.WriteLine("29. 🐤 Maksimum i Minimum");
            Console.WriteLine("30. ☑ Minimum Maksimum użytkownika");
            Console.WriteLine("31. 🥴 TotoLotek");
            Console.WriteLine("32. 🍅 Mnożenie Macierzy");
            Console.WriteLine("33. 🔤 Zamiana znaków");
            Console.WriteLine("34. ⏮ Odwrocenie zdania");
            Console.WriteLine("35. ⏮ Trójkątny tekst");
            Console.WriteLine("36. ⏮ Sito Eratotenesa");
            if (int.TryParse(Console.ReadLine(), out int selection))
            {
                Console.Clear();
                switch (selection)
                {
                    case 1:
                        Zadanie1.ZadanieMain();
                        break;
                    case 2:
                        Zadanie2.ZadanieMain();
                        break;
                    case 3:
                        Zadanie3.ZadanieMain();
                        break;
                    case 4:
                        Zadanie4.ZadanieMain();
                        break;
                    case 5:
                        Zadanie5.ZadanieMain();
                        break;
                    case 6:
                        Zadanie6.ZadanieMain();
                        break;
                    case 7:
                        Zadanie7.ZadanieMain();
                        break;
                    case 8:
                        Zadanie8.ZadanieMain();
                        break;
                    case 9:
                        Zadanie9.ZadanieMain();
                        break;
                    case 10:
                        Zadanie10.ZadanieMain();
                        break;
                    case 11:
                        Zadanie11.ZadanieMain();
                        break;
                    case 12:
                        Zadanie12.ZadanieMain();
                        break;
                    case 13:
                        Zadanie13.ZadanieMain();
                        break;
                    case 14:
                        Zadanie14.ZadanieMain();
                        break;
                    case 15:
                        Zadanie15.ZadanieMain();
                        break;
                    case 16:
                        Zadanie16.ZadanieMain();
                        break;
                    case 17:
                        Zadanie17.ZadanieMain();
                        break;
                    case 18:
                        Zadanie18.ZadanieMain();
                        break;
                    case 19:
                        Zadanie19.ZadanieMain();
                        break;
                    case 20:
                        Zadanie20.ZadanieMain();
                        break;
                    case 21:
                        Zadanie21.ZadanieMain();
                        break;
                    case 22:
                        Zadanie22.ZadanieMain();
                        break;
                    case 23:
                        Zadanie23.ZadanieMain();
                        break;
                    case 24:
                        Zadanie24.ZadanieMain();
                        break;
                    case 25:
                        Zadanie25.ZadanieMain();
                        break;
                    case 26:
                        Zadanie26.ZadanieMain();
                        break;
                    case 27:
                        Zadanie27.ZadanieMain();
                        break;
                    case 28:
                        Zadanie28.ZadanieMain();
                        break;
                    case 29:
                        Zadanie29.ZadanieMain();
                        break;
                    case 30:
                        Zadanie30.ZadanieMain();
                        break;
                    case 31:
                        Zadanie31.ZadanieMain();
                        break;
                    case 32:
                        Zadanie32.ZadanieMain();
                        break;
                    case 33:
                        Zadanie33.ZadanieMain();
                        break;
                    case 34:
                        Zadanie34.ZadanieMain();
                        break;
                    case 35:
                        Zadanie35.ZadanieMain();
                        break;
                    case 36:
                        Zadanie36.ZadanieMain();
                        break;
                    default:
                        exit = true;
                        break;
                }
            }
        }
    }
}