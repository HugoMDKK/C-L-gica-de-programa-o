using System;
using System.Globalization;

namespace Exercicio_63_03
{
    class Program
    {
        static void Main(String[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] vetor = new double[N];
            String[] vet = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vetor[i] = double.Parse(vet[i]);
            }
            double soma = 0;
            int pares = 0;           
          
            for (int i = 0; i < N; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    soma = soma + vetor[i];
                    pares++;
                }                
            }
            if (pares == 0)
            {
                Console.WriteLine("Nao havia nenhum numero par");
            }
            else
            {
                double media = soma / pares;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }          
        }
    }
}

