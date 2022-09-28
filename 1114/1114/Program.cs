using System;
using System.Globalization;

namespace URI1114
{
    class Program
    {
        static void Main (String[] args)
        {
            int senha;

            senha = int.Parse(Console.ReadLine());

            while (senha != 2002) {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
            
        }
    }
}