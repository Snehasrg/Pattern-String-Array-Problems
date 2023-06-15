using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    public class SumofEachRowofMatrix
    {
        public static void DisplayMatrix()
        {
            int i = 0; int j = 0;
            int sum = 0;
            int row = 2;
            int col = 2;

            int[,] Matrix = new int[row, col];

            Console.Write("Enter the elements of matrix:\n");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\nMatrix: ");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            for (i = 0; i < row; i++)
            {
                sum = 0;
                for (j = 0; j < col; j++)
                {
                    sum += Matrix[i, j];
                }
                Console.WriteLine("\nSum of row[{0}]: {1}", (i + 1), sum);
            }

            /*  -------------------------2nd way----------------------------------
              int i = 0; int j = 0; int sum = 0;
              int row = 2;
              int col = 2;

              int[,] arr2d = new int[2, 2]{
                                  {1, 2},
                                  {3, 4},

                              };
              Console.WriteLine("\nMatrix: ");
              for (i = 0; i < 2; i++)
              {
                  for (j = 0; j < 2; j++)
                  {
                      Console.Write(arr2d[i, j] + "\t");
                  }
                  Console.WriteLine();
              }
              for (i = 0; i < row; i++)
              {
                  sum = 0;
                  for (j = 0; j < col; j++)
                  {
                      sum += arr2d[i, j];
                  }
                  Console.WriteLine("\nSum of row[{0}]: {1}", (i + 1), sum);
              }*/
        }
    }
}
