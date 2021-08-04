using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace MatrixMultifly
{
    public partial class frmMain : Form
    {
        TutorialFormBase ba = new TutorialFormBase();

        private Matrix matrixA, matrixB, matrixRN, matrixRS;

        private string runType, runResult = string.Empty;
        private Stopwatch watch;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (brgWorker.IsBusy)
            {
                MessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", "Nhân ma trận", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                return;
            }
            try
            {
                if (ba != null) ba.Exit();
            }
            catch (Exception)
            {
            }
        }

        private bool CheckNumber(string numString)
        {
            try
            {
                int value = Convert.ToInt32(numString);
                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }

        private static void Matrix_Fill(Matrix matrix, int row, int col)
        {
            int cont = 0;

            if (row > 1)
            {
                while (row >= 2)
                {
                    row /= 2;
                    cont++;
                }
                row = col;
                if (row != (Math.Pow(2, cont)))
                {
                    matrix.Resize = Convert.ToInt32(Math.Pow(2, cont + 1)); 
                }
            }
        }

        public static Matrix NormalMultiply(Matrix a, Matrix b)
        {
            Matrix result = new Matrix(a.Rows, b.Columns);
            for (int row = 0; row < a.Rows; row++)
            {
                for (int col = 0; col < b.Columns; col++)
                {
                    int tmp = 0;
                    for (int i = 0; i < a.Columns; i++) // or i < b.Rows, it's equal
                    {
                        tmp += a[row, i] * b[i, col];
                    }
                    result[row, col] = tmp;
                }
            }
            return result;
        }

        public static Matrix StrassenMultiply(Matrix a, Matrix b)
        {
            int N = b.Rows;
            if (N <= 48)  return NormalMultiply(a, b);

            int halfN = N / 2;

            var a11 = Matrix.Split(a, 0, halfN, 0, halfN);
            var a12 = Matrix.Split(a, 0, halfN, halfN, N);
            var a21 = Matrix.Split(a, halfN, N, 0, halfN);
            var a22 = Matrix.Split(a, halfN, N, halfN, N);

            var b11 = Matrix.Split(b, 0, halfN, 0, halfN);
            var b12 = Matrix.Split(b, 0, halfN, halfN, N);
            var b21 = Matrix.Split(b, halfN, N, 0, halfN);
            var b22 = Matrix.Split(b, halfN, N, halfN, N);

            var m1 = StrassenMultiply(a11 + a22, b11 + b22);
            var m2 = StrassenMultiply(a21 + a22, b11);
            var m3 = StrassenMultiply(a11, b12 - b22);
            var m4 = StrassenMultiply(a22, b21 - b11);
            var m5 = StrassenMultiply(a11 + a12, b22);
            var m6 = StrassenMultiply(a21 - a11, b11 + b12);
            var m7 = StrassenMultiply(a12 - a22, b21 + b22);

            var c11 = m1 + m4 - m5 + m7;
            var c12 = m3 + m5;
            var c21 = m2 + m4;
            var c22 = m1 - m2 + m3 + m6;

            return Matrix.Join(c11, c12, c21, c22);
        }

        private void btnCreateMatrix_Click(object sender, EventArgs e)
        {
            if (brgWorker.IsBusy)
            {
                MessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", "Nhân ma trận", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ba.CreateWaitDialog();
            ba.SetWaitDialogCaption("Bắt đầu tạo ma trận");

            int row = Convert.ToInt32(txtRow.Value);
            if (row <= 0)
            {
                MessageBox.Show("Chưa nhập Số dòng", "Nhân ma trận", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int col = Convert.ToInt32(txtColumn.Value);
            if (col <= 0)
            {
                MessageBox.Show("Chưa nhập Số cột", "Nhân ma trận", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (col != row)
            {
                MessageBox.Show("Ma trận được tạo phải Số dòng = Số cột", "Nhân ma trận", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool limit = chkLimit.Checked;

            SaveFileDialog sfdDialog = new SaveFileDialog
            {
                FileName = string.Format("Matrix{0}x{1}.csv", row, col),
                Filter = "CSV files (*.csv)|*.csv"
            };
            if (sfdDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter swCSV = new StreamWriter(sfdDialog.FileName))
                    {
                        Random random = new Random();
                        int value; string line;

                        swCSV.WriteLine(row + "," + col);

                        for (int i = 0; i < row; i++)
                        {
                            line = string.Empty;
                            for (int j = 0; j < col; j++)
                            {
                                if (limit) value = random.Next(0, 10);
                                else value = random.Next();

                                line += (j < col - 1 ? value + "," : value.ToString());
                            }
                            swCSV.WriteLine(line);
                        }
                    }
                    MessageBox.Show("Tạo ma trận thành công", "Nhân ma trận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tạo ma trận thất bại: " + ex.Message, "Nhân ma trận", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            ba.SetWaitDialogCaption("Kết thúc tạo ma trận");
            ba.Exit();
        }

        private void btnSelectMatrixFile_Click(object sender, EventArgs e)
        {
            if (brgWorker.IsBusy)
            {
                MessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", "Nhân ma trận", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            OpenFileDialog ofdDialog = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "csv",
                Filter = "CSV files (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (ofdDialog.ShowDialog() == DialogResult.OK)
            {
                if ((sender as Button).Name.Contains("1"))
                {
                    btnSelectMatrix1File.Enabled = false;
                    btnResetMatrix1File.Enabled = true;
                    txtMatrix1FilePath.Text = ofdDialog.FileName;
                }
                else
                {
                    btnSelectMatrix2File.Enabled = false;
                    btnResetMatrix2File.Enabled = true;
                    txtMatrix2FilePath.Text = ofdDialog.FileName;
                }
                if (ofdDialog.FileName.Length == 0)
                {
                    return;
                }
                ba.CreateWaitDialog();
                ba.SetWaitDialogCaption("Bắt đầu truy vấn tập tin");
                brgWorker.RunWorkerAsync((sender as Button).Name);
            }
        }

        private void btnResetMatrixFile_Click(object sender, EventArgs e)
        {
            if (brgWorker.IsBusy)
            {
                MessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", "Nhân ma trận", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((sender as Button).Name.Contains("1"))
            {
                matrixA = null;

                btnSelectMatrix1File.Enabled = true;
                btnResetMatrix1File.Enabled = false;
                txtMatrix1FilePath.Text = string.Empty;

                btnSelectMatrix1File.Focus();
            }
            else
            {
                matrixB = null;

                btnSelectMatrix2File.Enabled = true;
                btnResetMatrix2File.Enabled = false;
                txtMatrix2FilePath.Text = string.Empty;

                btnSelectMatrix2File.Focus();
            }
            matrixRN = null;
            matrixRS = null;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (brgWorker.IsBusy)
            {
                MessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", "Nhân ma trận", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string matrix1FilePath = txtMatrix1FilePath.Text;
            if (matrix1FilePath.Length == 0)
            {
                MessageBox.Show("Chưa chọn Tập tin chứa Ma trận 1", "Nhân ma trận", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSelectMatrix1File.Focus();
                return;
            }
            string matrix2FilePath = txtMatrix2FilePath.Text;
            if (matrix2FilePath.Length == 0)
            {
                MessageBox.Show("Chưa chọn Tập tin chứa Ma trận 2", "Nhân ma trận", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSelectMatrix2File.Focus();
                return;
            }
            if (matrixA == null || matrixA.Rows == 0 || matrixA.Columns == 0)
            {
                MessageBox.Show("Ma trận 1 không tồn tại hoặc dữ liệu không đúng định dạng", "Nhân ma trận", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSelectMatrix1File.Focus();
                return;
            }
            if (matrixB == null || matrixB.Rows == 0 || matrixB.Columns == 0)
            {
                MessageBox.Show("Ma trận 1 không tồn tại hoặc dữ liệu không đúng định dạng", "Nhân ma trận", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSelectMatrix2File.Focus();
                return;
            }
            Button btn = (sender as Button);
            btn.Enabled = false;

            watch = new Stopwatch();
            watch.Start();

            ba.CreateWaitDialog();
            ba.SetWaitDialogCaption("Bắt đầu tính toán nhân ma trận");
            brgWorker.RunWorkerAsync(btn.Name);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (brgWorker.IsBusy)
            {
                MessageBox.Show("Đang truy vấn dữ liệu, xin chờ trong giây lát...", "Nhân ma trận", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Matrix result; string perfix = string.Empty;
            Button btnSave = sender as Button;
            if (btnSave.Name.Contains("Normal"))
            {
                if (matrixRN == null || matrixRN.Rows == 0)
                {
                    MessageBox.Show("Không tồn tại kết quả nhân thủ công", "Nhân ma trận", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                perfix = "Normal";
                result = matrixRN;
            }
            else
            {
                if (matrixRS == null || matrixRS.Rows == 0)
                {
                    MessageBox.Show("Không tồn tại kết quả nhân bằng Strassen", "Nhân ma trận", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                perfix = "Strassen";
                result = matrixRS;
            }
            SaveFileDialog sfdDialog = new SaveFileDialog
            {
                FileName = string.Format("Result{0}{1}x{2}.csv", perfix, result.Rows, result.Columns),
                Filter = "CSV files (*.csv)|*.csv"
            };

            if (sfdDialog.ShowDialog() == DialogResult.OK)
            {
                ba.CreateWaitDialog();
                ba.SetWaitDialogCaption("Bắt đầu lưu kết quả ra tập tin");

                using (StreamWriter swCSV = new StreamWriter(sfdDialog.FileName))
                {
                    string line;

                    swCSV.WriteLine(result.Rows + "," + result.Columns);

                    for (int i = 0; i < result.Rows; i++)
                    {
                        line = string.Empty;
                        for (int j = 0; j < result.Columns; j++)
                        {
                            line += (j < result.Columns - 1 ? result[i, j] + "," : result[i, j].ToString());
                        }
                        swCSV.WriteLine(line);
                    }
                }

                ba.SetWaitDialogCaption("Kết thúc lưu kết quả ra tập tin");
                ba.Exit();
            }
        }

        private void brgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            runType = e.Argument.ToString();
            if (runType.Contains("Select"))
            {
                string filePath = runType.Contains("1") ? txtMatrix1FilePath.Text : txtMatrix2FilePath.Text;

                var lstLines = new List<string>(File.ReadAllLines(filePath));

                if (lstLines == null || lstLines.Count == 0)
                {
                    runResult = "Không thể mở tập tin";
                    e.Cancel = true;
                    return;
                }
                string[] aValue; string value;

                aValue = lstLines[0].Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (aValue == null || aValue.Length != 2)
                {
                    runResult = "Tập tin không đúng cấu trúc";
                    e.Cancel = true;
                    return;
                }
                value = aValue.GetValue(0).ToString().TrimStart().TrimEnd();
                if (!CheckNumber(value))
                {
                    runResult = "Số dòng ma trận phải là kiểu số";
                    e.Cancel = true;
                    return;
                }
                int row = Convert.ToInt32(value);
                if (row == 0)
                {
                    runResult = "Số dòng ma trận > 0";
                    e.Cancel = true;
                    return;
                }
                value = aValue.GetValue(1).ToString().TrimStart().TrimEnd();
                if (!CheckNumber(value))
                {
                    runResult = "Số cột ma trận phải là kiểu số";
                    e.Cancel = true;
                    return;
                }
                int col = Convert.ToInt32(value);
                if (col == 0)
                {
                    runResult = "Số cột ma trận > 0";
                    return;
                }
                if (row != col)
                {
                    runResult = "Ma trận vuông nên Số cột = Số dòng";
                    e.Cancel = true;
                    return;
                }

                if (runType.Contains("1"))
                {
                    matrixA = new Matrix(row, col);

                    Matrix_Fill(matrixA, row, col);
                }
                else
                {
                    matrixB = new Matrix(row, col);

                    Matrix_Fill(matrixB, row, col);
                }
                lstLines.RemoveAt(0);

                for (int i = 0; i < lstLines.Count; i++)
                {
                    aValue = lstLines[i].Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                    for (int j = 0; j < aValue.Length; j++)
                    {
                        value = aValue.GetValue(j).ToString().TrimStart().TrimEnd();
                        if (CheckNumber(value) == false)
                        {
                            runResult = string.Format("Lỗi đọc giá trị ô {0}:{1}", i, j);
                            e.Cancel = true;
                            return;
                        }
                        if (runType.Contains("1"))
                        {
                            matrixA[i, j] = Convert.ToInt32(value);
                        }
                        else
                        {
                            matrixB[i, j] = Convert.ToInt32(value);
                        }
                    }
                }
                col = matrixA.Columns;
            }
            else if (runType.Contains("Execute"))
            {
                if (runType.Contains("Normal"))
                {
                    matrixRN = NormalMultiply(matrixA, matrixB);
                }
                else
                {
                    matrixRS = StrassenMultiply(matrixA, matrixB);
                }
            }
        }

        private void brgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (runType.Contains("Select"))
            {
                ba.SetWaitDialogCaption("Kết thúc truy vấn tập tin");
                ba.Exit();

                if (matrixA != null && matrixB != null && matrixA.Rows > 0 && matrixB.Rows > 0)
                {
                    btnExecuteNormal.Enabled = true;
                    btnExecuteStrassen.Enabled = true;
                }

                if (runResult.Length > 0)
                {
                    MessageBox.Show(runResult, "Nhân ma trận", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (runType.Contains("Execute"))
            {
                watch.Stop();

                ba.SetWaitDialogCaption("Kết thúc tính toán nhân ma trận");
                ba.Exit();

                if (runResult.Length > 0)
                {
                    MessageBox.Show(runResult, "Nhân ma trận", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string time;
                if (watch.ElapsedMilliseconds > 1000) time = (watch.ElapsedMilliseconds / 1000) + "giây" + watch.ElapsedMilliseconds % 1000 + "ms";
                else time = watch.ElapsedMilliseconds + "ms";

                if (runType.Contains("Normal"))
                {
                    txtTimeNormal.Text = time;
                    btnSaveNormal.Enabled = true;
                }
                else
                {
                    txtTimeStrassen.Text = time;
                    btnSaveStrassen.Enabled = true;
                }
            }
        }
    }
}
