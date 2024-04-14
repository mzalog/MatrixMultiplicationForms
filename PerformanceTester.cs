using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

//using MatrixMultiplicationForms;

namespace MatrixMultiplicationForms
{
    public class PerformanceTester
    {
        private RichTextBox resultsBox;

        public PerformanceTester(RichTextBox resultsBox)
        {
            this.resultsBox = resultsBox;
        }

        public void RunTests()
        {
            int[] matrixSizes = new[] { 100, 500, 1000, 1500 };
            int[] threadCounts = new[] { 1, 2, 4, 8, Environment.ProcessorCount };

            foreach (var size in matrixSizes)
            {
                Matrix matrixA = Matrix.GenerateRandomMatrix(size, size);
                Matrix matrixB = Matrix.GenerateRandomMatrix(size, size);

                // Measure Sequential Multiplication
                Stopwatch stopwatchSequential = new Stopwatch();
                stopwatchSequential.Start();
                Matrix resultSequential = MatrixOperations.MultiplySequentially(matrixA, matrixB);
                stopwatchSequential.Stop();
                long timeSequential = stopwatchSequential.ElapsedMilliseconds;

                foreach (var threads in threadCounts)
                {
                    // Measure Parallel Multiplication using Threads
                    Stopwatch stopwatchThread = new Stopwatch();
                    stopwatchThread.Start();
                    Matrix resultThread = MatrixOperations.MultiplyParallel(matrixA, matrixB, threads);
                    stopwatchThread.Stop();
                    long timeThread = stopwatchThread.ElapsedMilliseconds;

                    // Measure Parallel Multiplication using Parallel.For
                    Stopwatch stopwatchParallel = new Stopwatch();
                    stopwatchParallel.Start();
                    Matrix resultParallel = MatrixOperations.MultiplyUsingParallel(matrixA, matrixB, threads);
                    stopwatchParallel.Stop();
                    long timeParallel = stopwatchParallel.ElapsedMilliseconds;

                    double speedupThread = (double)timeSequential / timeThread;
                    double speedupParallel = (double)timeSequential / timeParallel;

                    string result = $"Size: {size}x{size}, Threads: {threads}, Sequential Time: {timeSequential} ms, Thread Time: {timeThread} ms, Parallel Time: {timeParallel} ms, Thread Speedup: {speedupThread:F2}x, Parallel Speedup: {speedupParallel:F2}x\n";
                    resultsBox.Invoke(new Action(() => resultsBox.AppendText(result)));
                }
            }
        }
    }
}
