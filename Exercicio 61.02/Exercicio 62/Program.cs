using System;
using System.Globalization;

namespace Exercicio61
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());
            int[] X = new int[N];

            String[] vetor = Console.ReadLine().Split(' ');
            int quantidadePares = 0;
            // Leitura dos N elementos, em vetor.
            for(int i = 0; i < N; i++)
            {
                X[i] = int.Parse(vetor[i]);
            }
            // Imprimindo números pares e quantidade de números pares.
            for (int i = 0; i < N; i++)
            {
                if (X[i] % 2 == 0)
                {
                    Console.Write(X[i] + " ");
                    quantidadePares++;
                }               
            }
            Console.WriteLine();
            Console.WriteLine(quantidadePares);

        }
    }
}