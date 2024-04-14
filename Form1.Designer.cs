namespace MatrixMultiplicationForms
{
    partial class Form1
    {
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnMultiplySequentially;
        private System.Windows.Forms.Button btnMultiplyInParallel;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtThreads;
        private System.Windows.Forms.Label lblSequentialTime;
        private System.Windows.Forms.Label lblParallelTime;
        private System.Windows.Forms.Label lblParallelTimelibrary;
        private System.Windows.Forms.DataGridView dgvMatrixA;
        private System.Windows.Forms.DataGridView dgvMatrixB;
        private System.Windows.Forms.DataGridView dgvResultMatrix;
        private System.Windows.Forms.Button btnRunPerformanceTests;
        private System.Windows.Forms.RichTextBox txtResults;
        private System.Windows.Forms.Button btnMultiplyUsingParallel;




        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSize = new TextBox();
            txtThreads = new TextBox();
            btnGenerate = new Button();
            btnMultiplySequentially = new Button();
            btnMultiplyInParallel = new Button();
            lblSequentialTime = new Label();
            lblParallelTime = new Label();
            lblParallelTimelibrary = new Label();
            dgvMatrixA = new DataGridView();
            dgvMatrixB = new DataGridView();
            dgvResultMatrix = new DataGridView();
            btnRunPerformanceTests = new Button();
            txtResults = new RichTextBox();
            labelMatrixsize = new Label();
            labelNumberOfThreads = new Label();
            btnMultiplyUsingParallel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMatrixA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMatrixB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResultMatrix).BeginInit();
            SuspendLayout();
            // 
            // txtSize
            // 
            txtSize.Location = new Point(12, 24);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(100, 27);
            txtSize.TabIndex = 0;
            txtSize.Validating += new System.ComponentModel.CancelEventHandler(this.txtSize_Validating);
            txtSize.KeyPress += new KeyPressEventHandler(txtSize_KeyPress);
            // 
            // txtThreads
            // 
            txtThreads.Location = new Point(12, 77);
            txtThreads.Name = "txtThreads";
            txtThreads.Size = new Size(100, 27);
            txtThreads.TabIndex = 1;
            txtThreads.Validating += new System.ComponentModel.CancelEventHandler(this.txtThreads_Validating);
            txtThreads.KeyPress += new KeyPressEventHandler(txtThreads_KeyPress);
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(12, 141);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(150, 30);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "Generate Matrices";
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnMultiplySequentially
            // 
            btnMultiplySequentially.Location = new Point(12, 189);
            btnMultiplySequentially.Name = "btnMultiplySequentially";
            btnMultiplySequentially.Size = new Size(150, 30);
            btnMultiplySequentially.TabIndex = 3;
            btnMultiplySequentially.Text = "Multiply Sequentially";
            btnMultiplySequentially.Click += btnMultiplySequentially_Click;
            // 
            // btnMultiplyInParallel
            // 
            btnMultiplyInParallel.Location = new Point(12, 276);
            btnMultiplyInParallel.Name = "btnMultiplyInParallel";
            btnMultiplyInParallel.Size = new Size(150, 30);
            btnMultiplyInParallel.TabIndex = 4;
            btnMultiplyInParallel.Text = "Multiply in Parallel";
            btnMultiplyInParallel.Click += btnMultiplyInParallel_Click;
            // 
            // lblSequentialTime
            // 
            lblSequentialTime.Location = new Point(12, 222);
            lblSequentialTime.Name = "lblSequentialTime";
            lblSequentialTime.Size = new Size(200, 30);
            lblSequentialTime.TabIndex = 5;
            // 
            // lblParallelTime
            // 
            lblParallelTime.Location = new Point(12, 309);
            lblParallelTime.Name = "lblParallelTime";
            lblParallelTime.Size = new Size(200, 30);
            lblParallelTime.TabIndex = 6;
            // 
            // lblParallelTimelibrary
            // 
            lblParallelTimelibrary.Location = new Point(12, 375);
            lblParallelTimelibrary.Name = "lblParallelTimelibrary";
            lblParallelTimelibrary.Size = new Size(200, 30);
            lblParallelTimelibrary.TabIndex = 20;
            // 
            // dgvMatrixA
            // 
            dgvMatrixA.ColumnHeadersHeight = 29;
            dgvMatrixA.Location = new Point(218, 31);
            dgvMatrixA.Name = "dgvMatrixA";
            dgvMatrixA.RowHeadersWidth = 51;
            dgvMatrixA.Size = new Size(322, 221);
            dgvMatrixA.TabIndex = 7;
            // 
            // dgvMatrixB
            // 
            dgvMatrixB.ColumnHeadersHeight = 29;
            dgvMatrixB.Location = new Point(570, 31);
            dgvMatrixB.Name = "dgvMatrixB";
            dgvMatrixB.RowHeadersWidth = 51;
            dgvMatrixB.Size = new Size(322, 221);
            dgvMatrixB.TabIndex = 8;
            // 
            // dgvResultMatrix
            // 
            dgvResultMatrix.ColumnHeadersHeight = 29;
            dgvResultMatrix.Location = new Point(218, 278);
            dgvResultMatrix.Name = "dgvResultMatrix";
            dgvResultMatrix.RowHeadersWidth = 51;
            dgvResultMatrix.Size = new Size(322, 230);
            dgvResultMatrix.TabIndex = 9;
            // 
            // btnRunPerformanceTests
            // 
            btnRunPerformanceTests.Location = new Point(12, 478);
            btnRunPerformanceTests.Name = "btnRunPerformanceTests";
            btnRunPerformanceTests.Size = new Size(200, 30);
            btnRunPerformanceTests.TabIndex = 10;
            btnRunPerformanceTests.Text = "Run Performance Tests";
            btnRunPerformanceTests.Click += btnRunPerformanceTests_Click;
            // 
            // txtResults
            // 
            txtResults.Location = new Point(560, 278);
            txtResults.Name = "txtResults";
            txtResults.ReadOnly = true;
            txtResults.Size = new Size(332, 230);
            txtResults.TabIndex = 11;
            txtResults.Text = "";
            // 
            // labelMatrixsize
            // 
            labelMatrixsize.AutoSize = true;
            labelMatrixsize.Location = new Point(12, 54);
            labelMatrixsize.Name = "labelMatrixsize";
            labelMatrixsize.Size = new Size(129, 20);
            labelMatrixsize.TabIndex = 12;
            labelMatrixsize.Text = "Matrix size input x";
            // 
            // labelNumberOfThreads
            // 
            labelNumberOfThreads.AutoSize = true;
            labelNumberOfThreads.Location = new Point(12, 107);
            labelNumberOfThreads.Name = "labelNumberOfThreads";
            labelNumberOfThreads.Size = new Size(140, 20);
            labelNumberOfThreads.TabIndex = 13;
            labelNumberOfThreads.Text = "Input threads (0-16)";
            // 
            // btnMultiplyUsingParallel
            // 
            btnMultiplyUsingParallel.Location = new Point(12, 342);
            btnMultiplyUsingParallel.Name = "btnMultiplyUsingParallel";
            btnMultiplyUsingParallel.Size = new Size(200, 30);
            btnMultiplyUsingParallel.TabIndex = 14;
            btnMultiplyUsingParallel.Text = "Multiply Using Parallel";
            btnMultiplyUsingParallel.Click += btnMultiplyUsingParallel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 553);
            Controls.Add(btnMultiplyUsingParallel);
            Controls.Add(labelNumberOfThreads);
            Controls.Add(labelMatrixsize);
            Controls.Add(txtSize);
            Controls.Add(txtThreads);
            Controls.Add(btnGenerate);
            Controls.Add(btnMultiplySequentially);
            Controls.Add(btnMultiplyInParallel);
            Controls.Add(lblSequentialTime);
            Controls.Add(lblParallelTime);
            Controls.Add(lblParallelTimelibrary);
            Controls.Add(dgvMatrixA);
            Controls.Add(dgvMatrixB);
            Controls.Add(dgvResultMatrix);
            Controls.Add(btnRunPerformanceTests);
            Controls.Add(txtResults);
            Name = "Form1";
            Text = "Matrix Multiplication";
            ((System.ComponentModel.ISupportInitialize)dgvMatrixA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMatrixB).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResultMatrix).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void InitializeDataGridView(DataGridView dgv)
        {
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.ColumnHeadersVisible = false;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
        }

        private void txtSize_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!int.TryParse(txtSize.Text, out int size) || size < 1 || size > 655)
            {
                MessageBox.Show("Please enter a valid size between 1 and 655.", "Invalid Size", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;  // Zatrzymaj utratę fokusu
                txtSize.SelectAll();  // Zaznacz tekst do poprawy
            }
        }

        private void txtThreads_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!int.TryParse(txtThreads.Text, out int threads) || threads < 1 || threads > 16)
            {
                MessageBox.Show("Please enter a valid thread count between 1 and 16.", "Invalid Thread Count", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;  // Zatrzymaj utratę fokusu
                txtThreads.SelectAll();  // Zaznacz tekst do poprawy
            }
        }
        private void txtSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;  // Ignoruj wprowadzenie znaku, który nie jest cyfrą
            }
        }

        private void txtThreads_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;  // Ignoruj wprowadzenie znaku, który nie jest cyfrą
            }
        }


        #endregion

        private Label labelMatrixsize;
        private Label labelNumberOfThreads;
    }
}
