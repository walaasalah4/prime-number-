using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRO_1_prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
           double  n;
            Console.Write("Enter the number");
            n = double.Parse(Console.ReadLine());
            for (double i = 2; i <= n - 1; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("the number isn't prime");
                }

                if (n % i != 0)
                {
                    Console.WriteLine("the number is prime");



                }
            }
        }
    }
}
