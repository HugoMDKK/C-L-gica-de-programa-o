using System;
using System.Globalization;

namespace Exercício_68_02
{
    class Program
    {
        static void Main(String[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] mat = new int[N, N];

            for(int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            for (int i = 0; i < N; i++)
            {
                int maior = mat[i, 0];
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] > maior)
                    {
                        maior = mat[i, j];
                    }
                }
                Console.WriteLine(maior);
            }
        }
    }
}