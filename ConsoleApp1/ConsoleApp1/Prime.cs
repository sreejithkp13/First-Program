using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Calc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int a = int.Parse(Console.ReadLine());
            prime(a);
            fact(a);
        }
        static void prime(int c)
        {
            string result = "The Entered number is a Prime Number";
            int y = c;
            int b = y / 2;
            int i;
            for (i = 2; i <= b; i++)
            {
                if (y % i == 0)
                {
                    result = "The Entered number is not a prime number";
                }
            }
            Console.WriteLine(result);
        }  
        static void fact(int d)
        {
            int e = d;
            long fact = 1;
            for (int j=1; j<=e; j++)
            {
                fact *= j;
            }
            Console.WriteLine("The Factorial of entered number is : " + fact);
        }
    }
}
