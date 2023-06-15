using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    public class UniqueElement
    {
        public static void UniqueIntElement()
        {
            Console.WriteLine("Enter how many element you want to Put in Array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] intArray = new int[size];
            Console.WriteLine("Enter element one by one ");
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Entered Elements are: ");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(intArray[i] + " ");
            }

            Console.WriteLine("\nUnique elements are:");
            for (int i = 0; i < intArray.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < intArray.Length; j++)
                {
                    if (i != j && intArray[i] == intArray[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    Console.WriteLine("" + intArray[i]);
                }
            }
        }
    }
}
