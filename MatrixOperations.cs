using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplicationForms
{
    using System;
    using System.Threading;

    public class MatrixOperations
    {
        public static Matrix MultiplySequentially(Matrix a, Matrix b)
        {
            if (a.Columns != b.Rows)
                throw new ArgumentException("Matrices cannot be multiplied.");

            Matrix result = new Matrix(a.Rows, b.Columns);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < b.Columns; j++)
                {
                    for (int k = 0; k < a.Columns; k++)
                    {
                        result.Data[i, j] += a.Data[i, k] * b.Data[k, j];
                    }
                }
            }
            return result;
        }

        public static Matrix MultiplyParallel(Matrix a, Matrix b, int threadCount)
        {
            if (a.Columns != b.Rows)
                throw new ArgumentException("Matrices cannot be multiplied.");

            Matrix result = new Matrix(a.Rows, b.Columns);
            Thread[] threads = new Thread[threadCount];
            int rowsPerThread = a.Rows / threadCount;
            int remainder = a.Rows % threadCount;

            for (int i = 0; i < threadCount; i++)
            {
                int startRow = i * rowsPerThread;
                int endRow = (i + 1) * rowsPerThread + (i == threadCount - 1 ? remainder : 0);
                threads[i] = new Thread(() => MultiplyPart(a, b, result, startRow, endRow));
                threads[i].Start();
            }

            foreach (Thread thread in threads)
                thread.Join();

            return result;
        }

        private static void MultiplyPart(Matrix a, Matrix b, Matrix result, int startRow, int endRow)
        {
            for (int i = startRow; i < endRow; i++)
            {
                for (int j = 0; j < b.Columns; j++)
                {
                    for (int k = 0; k < a.Columns; k++)
                    {
                        result.Data[i, j] += a.Data[i, k] * b.Data[k, j];
                    }
                }
            }
        }

        public static Matrix MultiplyUsingParallel(Matrix a, Matrix b, int threadCount)
        {
            if (a.Columns != b.Rows)
                throw new ArgumentException("Matrices cannot be multiplied.");

            Matrix result = new Matrix(a.Rows, b.Columns);
            var options = new ParallelOptions { MaxDegreeOfParallelism = threadCount };  // Ustawienie maksymalnej liczby równoczesnych operacji

            Parallel.For(0, a.Rows, options, i =>
            {
                for (int j = 0; j < b.Columns; j++)
                {
                    for (int k = 0; k < a.Columns; k++)
                    {
                        result.Data[i, j] += a.Data[i, k] * b.Data[k, j];
                    }
                }
            });

            return result;
        }

    }

}
