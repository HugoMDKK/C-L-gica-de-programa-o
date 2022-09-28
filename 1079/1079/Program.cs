using System;
using System.Globalization;

namespace URI1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i <= n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                double v1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double v2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double v3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                double media = (v1 * 2.0 + v2 * 3.0 + v3 * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}