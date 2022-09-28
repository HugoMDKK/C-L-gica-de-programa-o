using System;
using System.Globalization;

namespace uri1050
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            
            n1 = int.Parse(Console.ReadLine());

            if (n1 == 1)
            {
                Console.WriteLine("January");
            }
            else if (n1 == 2)
            {
                Console.WriteLine("February");
            }
            else if (n1 == 3)
            {
                Console.WriteLine("March");
            }
            else if (n1 == 4)
            {
                Console.WriteLine("April");
            }
            else if (n1 == 5)
            {
                Console.WriteLine("May");
            }
            else if (n1 == 6)
            {
                Console.WriteLine("June");
            }
            else if(n1 == 7)
            {
                Console.WriteLine("July");
            }
            else if(n1 == 8)
            {
                Console.WriteLine("August");
            }
            else if(n1 == 9)
            {
                Console.WriteLine("September");
            }
            else if(n1 == 10)
            {
                Console.WriteLine("October");
            }
            else if(n1 == 11)
            {
                Console.WriteLine("November");
            }
            else
            {
                Console.WriteLine("December");
            }

        }
    }
}