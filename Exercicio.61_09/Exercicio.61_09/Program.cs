using System;
using System.Globalization;

namespace vetor8
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            String[] Nome = new string[N];
            Double[] Compra = new double[N];
            Double[] Venda = new double[N];

            for (int i = 0; i < N; i++)
            {
                String[] vetor = Console.ReadLine().Split(' ');
                Nome[i] = vetor[0];
                Compra[i] = double.Parse(vetor[1], CultureInfo.InvariantCulture);
                Venda[i] = double.Parse(vetor[2], CultureInfo.InvariantCulture);
            }

            int contAbaixoDe10 = 0;
            int contEntre10E20 = 0;
            int contAcimaDe20 = 0;

            for(int i = 0; i < N; i++)
            {
                Double lucro = Venda[i] - Compra[i];

                Double porcentagemDeLucro = lucro / Compra[i] * 100.0;
            
                if (porcentagemDeLucro < 10.0)
                {
                    contAbaixoDe10++;
                }
                else if (porcentagemDeLucro <= 20.0)
                {
                    contEntre10E20++;
                }
                else
                {
                    contAcimaDe20++;
                }
            }
            Console.WriteLine("Lucro abaixo de 10%: " + contAbaixoDe10);
            Console.WriteLine("Lucro entre 10% e 20%: " + contEntre10E20);
            Console.WriteLine("Lucro acima de 20%: " + contAcimaDe20);

            Double totalCompra = 0.0;
            Double totalVenda = 0.0;
            for(int i = 0; i < N; i++)
            {
                totalCompra = totalCompra + Compra[i];
                totalVenda = totalVenda + Venda[i];
            }

            Double totalLucro = totalVenda - totalCompra;

            Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + totalVenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + totalLucro.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}