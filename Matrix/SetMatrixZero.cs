using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class SetMatrixZero
    {
        int[,] matrix = { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 1, 1 } };
        public void SetMatrixZero1()
        {
            int r = matrix.GetLength(0);
            int c = matrix.GetLength(1);

            int[] rows = new int[r];
            int[] cols = new int[c];

            for (int i = 0; i < r; i++)
            {
                rows[i] = 1;
            }
            for (int i = 0; i < c; i++)
            {
                cols[i] = 1;
            }

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        rows[i] = 0;
                        cols[j] = 0;
                    }
                }
            }

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if(rows[i] == 0 || cols[j] == 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            PrintMatrix.printMatrix(matrix);

        }

        
    }
}
