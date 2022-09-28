// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace testes_ec { 
    class Program
    {
        static void Main(String[] args) {

            double nota1, nota2, soma;

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = nota1 + nota2;

            Console.WriteLine("NOTA FINAL = " + soma.ToString("F1", CultureInfo.InvariantCulture));

            if  (soma < 60.0) {
                Console.WriteLine("REPROVADO");
            };

            Console.ReadLine();

        }
    }
}

