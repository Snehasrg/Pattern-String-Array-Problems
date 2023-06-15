using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    public class MaxMinElement
    {
        public static void FindMaxMin()
        {
            int[] arr = new int[10];
            int i;

            Console.Write("Input 10 elements in the array :\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Minimum number is " + arr.Min());
            Console.WriteLine("Maximum number is " + arr.Max());
        }

        /*  ----------------------2nd way---------------------------------
          public static void FindMaxMin()
          {
              int[] arr = { 8, 3, 5, -1, 2 };
              Console.WriteLine("Minimum number is " + arr.Min());
              Console.WriteLine("Maximum number is " + arr.Max());
          }*/


        /*  --------------------- 3rd way-----------------------------------
          public static void FindMaxMin()
          {
              int[] arr = { 8, 3, 5, -1, 2 };

              int mx = arr[0];
              int mn = arr[0];

              for (int i = 1; i < arr.Length; i++)
              {
                  if (arr[i] > mx)
                  {
                      mx = arr[i];
                  }


                  if (arr[i] < mn)
                  {
                      mn = arr[i];
                  }
              }
              Console.Write("Maximum element is : {0}\n", mx);
              Console.Write("Minimum element is : {0}\n\n", mn);
          }*/
    }
}
