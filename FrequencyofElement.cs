using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    public class FrequencyofElement
    {
        public static void CheckFrequency()
        {
            Console.WriteLine("Enter how many elements you want in Array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] intArray = new int[size];
            Console.WriteLine("Enter elements one by one ");
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Entered Elements are ");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(intArray[i] + " ");
            }

            var dict = new Dictionary<int, int>();
            foreach (int value in intArray)
            {
                if (dict.ContainsKey(value))
                    dict[value]++;
                else
                    dict[value] = 1;
            }

            Console.WriteLine();
            foreach (var pair in dict)
            {
                Console.WriteLine("{0} occurs {1} times", pair.Key, pair.Value);
            }
            Console.ReadLine();
        }
    }
}
