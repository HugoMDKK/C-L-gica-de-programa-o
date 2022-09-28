using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(String[] args)
        {
            int minutos;
            double conta;

            minutos = int.Parse(Console.ReadLine());

            conta = 50.00;
            if ( minutos > 100)
            {
                conta += (minutos - 100) * 2.00;
            }
            Console.WriteLine(" Valor a pagar: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}