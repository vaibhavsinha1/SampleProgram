using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public static class PrintMatrix
    {
        public static void printMatrix(int[,] mat)
        {
            int R = mat.GetLength(0);
            int C = mat.GetLength(1);
            int i, j;
            for (i = 0; i < R; i++)
            {
                for (j = 0; j < C; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
