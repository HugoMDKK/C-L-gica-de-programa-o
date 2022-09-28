using System;
using System.Globalization;

namespace Exercício_68_02
{
    class Program
    {
        static void Main(String[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double[,] mat = new double[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = double.Parse(s[j], CultureInfo.InvariantCulture);
                }
            }

            int linha = int.Parse(Console.ReadLine());
            int coluna = int.Parse(Console.ReadLine());

            // Soma dos números positivos
            double soma = 0;
            for (int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if (mat[i, j] > 0.0)
                    {
                        soma = soma + mat[i, j];
                    }
                }
            }
            Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1", CultureInfo.InvariantCulture));


            // Leitura do índice de uma linha da matriz
            Console.WriteLine("LINHA ESCOLHIDA: ");
            for (int j = 0; j < N; j++)
            {
                Console.Write(mat[linha, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            // Leitura do índice de uma coluna da matriz
            Console.WriteLine("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(mat[i, coluna].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            // Elementos da diagonal principal da matriz
            Console.WriteLine("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(mat[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            // Alterando a matriz elevando todos os número negativos ao quadrado
            for (int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if (mat[i, j] < 0.0)
                    {
                        mat[i, j] = mat[i, j] * mat[i, j];
                    }
                }
            }
            Console.WriteLine("MATRIZ ALTERADA: ");
            for (int i = 0; i < N; i++)
            {
                for ( int j = 0; j < N; j++)
                {
                    Console.Write(mat[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}