using System;
using System.Globalization;

namespace URI1065 
{
    class program
    {
        static void Main(String[] args)
        {
            int n1, n2, n3, n4, n5;
            
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            n5 = int.Parse(Console.ReadLine());

            int cont = 0;
            if (n1 % 2 == 0)
            {
                cont = cont + 1;
            }
            if (n2 % 2 == 0)
            {
                cont = cont + 1;
            }
            if (n3 % 2 == 0)
            {
                cont = cont + 1;
            }
            if (n4 % 2 == 0)
            {
                cont = cont + 1;
            }
            if (n5 % 2 == 0)
            {
                cont = cont + 1;
            }
            Console.WriteLine(cont + " valores pares");
        }

    }
}
