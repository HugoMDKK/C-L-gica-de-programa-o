using System;
using System.Globalization;

namespace uri1045
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] vet = Console.ReadLine().Split(' ');
            int v1 = int.Parse(vet[0]);
            int v2 = int.Parse(vet[1]);
            int v3 = int.Parse(vet[2]);

            int A, B, C;
            if (v1 < v2 && v1 < v3)
            {
                A = v1;
                if (v2 < v3)

                {
                    B = v2;
                    C = v3;
                }
                else
                {
                    B = v3;
                    C = v2;
                }
            }
            else if (v2 < v3)
            {
                A = v2;
                if (v1 < v3)
                {
                    B = v1;
                    C = v3;
                }
                else
                {
                    B = v3;
                    C = v2;
                }
            }
            else
            {
                A = v3;
                if (v1 < v2)
                {
                    B = v1;
                    C = v2;
                }
                else
                {
                    B = v2;
                    C = v1;
                }
            }
            Console.WriteLine(v3);
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine();
            Console.WriteLine(B);
            Console.WriteLine(C);
            Console.WriteLine(A);                     
        }
    }
}