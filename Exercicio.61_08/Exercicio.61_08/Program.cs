using System;
using System.Globalization;

namespace vetor8
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] Altura = new double[N];
            String[] Sexo = new String[N];

            for (int i = 0; i < N; i++)
            {
                String[] vetor = Console.ReadLine().Split(' ');
                Altura[i] = double.Parse(vetor[0], CultureInfo.InvariantCulture);
                Sexo[i] = vetor[1];
            }
            Double MenorAltura = Altura[0];
            Double MaiorAltura = Altura[0];

            for (int i = 1; i < N; i++)
            {
                if (Altura[i] < MenorAltura)
                {
                    MenorAltura = Altura[i];
                }
            }
            Console.WriteLine("Menor altura = " + MenorAltura);

            for (int i = 1; i < N; i++)
            {
                if (Altura[i] > MaiorAltura)
                {
                    MaiorAltura = Altura[i];
                }
            }
            Console.WriteLine("Maior altura = " + MaiorAltura);

            double somaDasAlturasDasMulheres = 0.0;
            int contMulheres = 0;

            for (int i = 0; i < N; i++)
            {
                if (Sexo[i] == "F")
                {
                    somaDasAlturasDasMulheres = somaDasAlturasDasMulheres + Altura[i];
                    contMulheres++;
                }
            }

            if (contMulheres == 0)
            {
                Console.WriteLine("Nao ha nenhuma mulher dentre as pessoas");
            }
            else
            {
                double media = somaDasAlturasDasMulheres / contMulheres;
                Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2",CultureInfo.InvariantCulture));
            }

            int contHomens = 0;
            for (int i = 0; i < N;i++)
            {
                if (Sexo[i] == "M")
                {
                    contHomens++;
                }
            }
            Console.WriteLine("Numero de homens = " + contHomens);

        }
    }
}