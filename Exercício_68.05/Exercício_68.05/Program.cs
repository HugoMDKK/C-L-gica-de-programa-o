using System;
using System.Globalization;

namespace Exercício_68_02
{
    class Program
    {
        static void Main(String[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int N = int.Parse(s[0]);
            int M = int.Parse(s[1]);


            int[,] A = new int[N, M];
            int[,] B = new int[N, M];
            int[,] C = new int[N, M];

            // Leitura da primeira matriz A
            for(int i = 0; i < N; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < M; j++)
                {
                    A[i, j] = int.Parse(s[j]);
                }
            }

            // Leitura da primeira matriz B
            for (int i = 0; i < N; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < M; j++)
                {
                    B[i, j] = int.Parse(s[j]);
                }
            }


            // Leitura da primeira matriz C
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < M; ++j)
                {
                    C[i, j]  = A[i, j] + B[i, j];
                }
            }


            // Impressão dos resultados da matris C
            for ( int i = 0; i < N; ++i)
            {
                for( int j = 0; j < M; ++j)
                {
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}