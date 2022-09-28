using System;
using System.Globalization;

namespace Exercicio_63_03
{
    class Program
    {
        static void Main(String[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] M = new double[N];
            String[] vet = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
               
                M[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
            }
            double soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                soma = soma + M[i];
            }
            double media = soma / N;
            Console.WriteLine("MEDIA = " + media.ToString("F3", CultureInfo.InvariantCulture));

            for (int i = 0; i < N; i++)
            {
                if (M[i] < media)
                {
                    Console.WriteLine(M[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
