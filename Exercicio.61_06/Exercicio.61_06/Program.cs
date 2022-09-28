using System;
using System.Globalization;

namespace Exercicio_06
{
    class Program
    {
        static void Main(String[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());

            string[] nomes = new string[quantidade];
            int[] idade = new int[quantidade];

          
            for (int i = 0; i < quantidade; i++)
            {
                String[] vet = Console.ReadLine().Split(' ');
                nomes[i] = vet[0];
                idade[i] = int.Parse(vet[1]);
            }
            int maiorIdade = idade[0];
            int posicaoMaiorIdade = 0;

            for (int i = 1; i < quantidade; i++)
            {
                if (idade[i] > maiorIdade)
                {
                    maiorIdade = idade[i];
                    posicaoMaiorIdade = i;
                }
            }
            Console.WriteLine("Pessoa mais velha: " + nomes[posicaoMaiorIdade]);
        }
    }
}
