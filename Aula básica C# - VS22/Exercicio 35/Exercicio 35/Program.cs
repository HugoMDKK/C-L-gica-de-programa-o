﻿using System;
using System.Globalization;

namespace curso
{
    class program
    {
        static void Main(String[] args)
        {

            int n1, n2, n3;
            string[] vet = Console.ReadLine().Split(' ');

            n1 = int.Parse(vet[0]);
            n2 = int.Parse(vet[1]);
            n3 = int.Parse(vet[2]);

            if (n1 < n2 && n2 < n3)
            {
                Console.WriteLine("MENOR = " + n1);
            }
            else if (n2 < n3 )
            {
                Console.WriteLine("MENOR = " + n2);
            }
            else {
                Console.WriteLine("MENOR = " + n3);
            }
        }
    }
}
