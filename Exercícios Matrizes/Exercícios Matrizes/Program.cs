using System;
using System.Globalization;

namespace Exercicio_Mesa
{
    class Program
    {
        static void Main(String[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] mat;

            
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    mat = new int[i, j];
                    mat[i,j] = 1 + i + j;                   
                }
            }            
        }
    }
}