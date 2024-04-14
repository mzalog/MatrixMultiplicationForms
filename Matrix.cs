using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplicationForms
{
    public class Matrix
    {
        public int[,] Data { get; private set; }
        public int Rows { get; private set; }
        public int Columns { get; private set; }

        public Matrix(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Data = new int[rows, columns];
        }

        public static Matrix GenerateRandomMatrix(int rows, int cols)
        {
            Random rand = new Random();
            Matrix matrix = new Matrix(rows, cols);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix.Data[i, j] = rand.Next(1, 10);
                }
            }
            return matrix;
        }
    }

}
