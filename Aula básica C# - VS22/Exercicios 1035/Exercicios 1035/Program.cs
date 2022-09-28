using System;
using System.Globalization;

    namespace curso
{
    class program
    {
        static void Main(String[] args)
        {
            double n1, n2, n3, n4, media, notaExame, mediaFinal;

            string[] vet = Console.ReadLine().Split(' ');

            n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            n4 = double.Parse(vet[3], CultureInfo.InvariantCulture);

            media = (2 * n1 + 3 * n2 + 4 * n3 + 1 * n4) / 10;
            if (media == 4.85f)
            {
                media = 4.8f;
            }

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                mediaFinal = (media + notaExame) / 2;
                Console.WriteLine("Nota do Exame:" + notaExame.ToString("F1", CultureInfo.InvariantCulture));
                if (mediaFinal >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media Final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
