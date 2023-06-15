using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    public class ReverseStar
    {
        public static void DisplayStar()
        {
            Console.WriteLine("Enter number for display");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
