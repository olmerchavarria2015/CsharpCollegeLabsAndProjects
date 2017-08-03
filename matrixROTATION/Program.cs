using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrixROTATION
{
    class Program
    {
        

        //int[,] rotated = RotateMatrix(array, 4);

        static int[,] RotateMatrix(int[,] matrix, int n)
        {
            int[,] ret = new int[n, n];

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    ret[i, j] = matrix[n - j - 1, i];
                    Console.Write(" "+ret[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            return ret;
        }
        static int[,] RotateMatrixLeft(int[,] matrix, int n)
        {
            int[,] ret = new int[n, n];

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    ret[i, j] = matrix[ j , (n-1)-i];
                    Console.Write(" " + ret[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            return ret;
        }
        static void Main(string[] args)
        {
            int[,] array = new int[4, 4] {
                           { 1,2,3,4 },
                           { 5,6,7,8 },
                           { 9,0,1,2 },
                           { 3,4,5,6 }
                       };
            Console.WriteLine("Initial Matrix");
            for (int y = 0; y < array.Length/4; ++y)
            {
                for (int x = 0; x < array.Length/4; ++x)
                {
                    Console.Write(" " + array[y, x]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Rotated Matrix 90 degrees to the right");
            int[,] rotatedR = RotateMatrix(array, 4);
            Console.WriteLine("Rotated Matrix 90 degrees to the left");
            int[,] rotatedL = RotateMatrixLeft(array, 4);


        }
    }
}
