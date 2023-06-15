using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    public class SumofAllDigit
    {
        public static void CalculateSum()
        {
            int a = 777, sum = 0, b;
            while (a != 0)
            {
                b = a % 10; //extract a digit
                sum = sum + b; //adding the digits
                a = a / 10; //remained number
            }
            Console.WriteLine("The sum of the digits is: " + sum);
        }
    }
}
