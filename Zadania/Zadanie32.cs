using System;

namespace Zadania
{
    internal class Zadanie32
    {
        public static void ZadanieMain()
        {
            const int N = 3;
            const int M = 3;
            const int K = 2;

            int[,] A = new int[N, K];
            int[,] B = new int[K, M];
            int[,] C = new int[N, M];

            Console.WriteLine("Podaj elementy macierzy A:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < K; j++)
                {
                    Console.Write("A[{0},{1}] = ", i + 1, j + 1);
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Podaj elementy macierzy B:");

            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write("B[{0},{1}] = ", i + 1, j + 1);
                    B[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    for (int k = 0; k < K; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                }
            }
            Console.WriteLine("Wynikiem mnożenia podanych macierzy jest macierz:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write("{0}\t", C[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}