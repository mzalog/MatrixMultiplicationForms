using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MatrixMultiplicationForms
{
    public partial class Form1 : Form
    {
        private Matrix matrixA;
        private Matrix matrixB;
        private Matrix resultMatrix;
        private PerformanceTester performanceTester;

        public Form1()
        {
            InitializeComponent();
            performanceTester = new PerformanceTester(txtResults);

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int size = int.Parse(txtSize.Text);
            matrixA = Matrix.GenerateRandomMatrix(size, size);
            matrixB = Matrix.GenerateRandomMatrix(size, size);
            DisplayMatrix(matrixA, dgvMatrixA);
            DisplayMatrix(matrixB, dgvMatrixB);
            MessageBox.Show("Matrices generated.");
        }

        private void btnMultiplySequentially_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            resultMatrix = MatrixOperations.MultiplySequentially(matrixA, matrixB);
            stopwatch.Stop();
            lblSequentialTime.Text = $"Sequential Time: {stopwatch.ElapsedMilliseconds} ms";
            DisplayMatrix(resultMatrix, dgvResultMatrix);

        }

        private void btnMultiplyInParallel_Click(object sender, EventArgs e)
        {
            int threadCount = int.Parse(txtThreads.Text);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            resultMatrix = MatrixOperations.MultiplyParallel(matrixA, matrixB, threadCount);
            stopwatch.Stop();
            lblParallelTime.Text = $"Parallel Time: {stopwatch.ElapsedMilliseconds} ms";
            DisplayMatrix(resultMatrix, dgvResultMatrix);

        }
        private void DisplayMatrix(Matrix matrix, DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            for (int i = 0; i < matrix.Columns; i++)
            {
                dgv.Columns.Add($"Column{i}", "");
                dgv.Columns[i].Width = 50; // Adjust column width
            }

            for (int i = 0; i < matrix.Rows; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgv);

                for (int j = 0; j < matrix.Columns; j++)
                {
                    row.Cells[j].Value = matrix.Data[i, j];
                }

                dgv.Rows.Add(row);
            }
        }



        private void btnRunPerformanceTests_Click(object sender, EventArgs e)
        {
            performanceTester.RunTests();
        }



        private void btnMultiplyUsingParallel_Click(object sender, EventArgs e)
        {
            int size = int.Parse(txtSize.Text);  // Pobierz rozmiar macierzy wprowadzony przez u¿ytkownika
            int threads = int.Parse(txtThreads.Text);  // Pobierz liczbê w¹tków wprowadzon¹ przez u¿ytkownika

            Matrix matrixA = Matrix.GenerateRandomMatrix(size, size);
            Matrix matrixB = Matrix.GenerateRandomMatrix(size, size);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Matrix resultMatrix = MatrixOperations.MultiplyUsingParallel(matrixA, matrixB, threads);
            stopwatch.Stop();

            lblParallelTimelibrary.Text = $"Parallel Time: {stopwatch.ElapsedMilliseconds} ms using {threads} threads";
            DisplayMatrix(resultMatrix, dgvResultMatrix);  // Wyœwietl wynik w DataGridView
        }


    }
}
