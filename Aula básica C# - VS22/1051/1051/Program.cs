using System;
using System.Globalization;

namespace uri1045
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double impostos;
            if (salario <= 2000.0)
            {
                impostos = 0.0;
            }
            else if(salario <= 3000.0)
            {
                impostos = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0)
            {
                impostos = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                impostos = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (impostos == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + impostos.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}