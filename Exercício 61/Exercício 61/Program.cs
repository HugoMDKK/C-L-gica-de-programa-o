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

            double[] x = new double[N];
            String[] vet = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                x[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
            }
            
            double maior = x[0];
            int posicaoMaior = 0;

            for (int i = 1; i < N; i++)
            {
                if (x[i] > maior)
                {
                    maior = x[i];
                    posicaoMaior = i;
                }                               
            }
            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicaoMaior);
        }
    }
}