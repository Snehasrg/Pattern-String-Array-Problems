using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    public class ReverceWordofString
    {
        public static void CheckReverseWord()
        {
            string Name = "Sneha";
            char[] chars = Name.ToCharArray();
            List<char> list = new List<char>();
            Console.WriteLine("Before Reversing String");
            foreach (char c in chars)
            {
                list.Add(c);
                Console.WriteLine(c);
            }
            list.Reverse();
            Console.WriteLine("After Reversing string");
            foreach (char d in list)
            {
                Console.WriteLine(d);
            }
        }
    }
}
