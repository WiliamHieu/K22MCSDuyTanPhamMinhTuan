using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace StrassenMultiply
{
    class Program
    {
        static void Main(string[] args)
        {
            int SIZE = 8;

            Matrix_CreateFile("MatrixA.txt", 6);
            Matrix_CreateFile("MatrixB.txt", 6);

            Matrix mtA = Matrix_ReadFromFile("MatrixA.txt", out int rowA, out int colA);
            Matrix mtB = Matrix_ReadFromFile("MatrixB.txt", out int rowB, out int colB);

            Matrix_Fill(mtA, rowA, colA);
            Matrix_Fill(mtB, rowB, colB);

            Matrix_Print(mtA);
            Matrix_Print(mtB);

            //Stopwatch t1 = Stopwatch.StartNew();
            //var normal = NormalMultiply(mtA, mtB);
            //t1.Stop();
            //Console.WriteLine($"Normal execution time: {t1.ElapsedMilliseconds} ms");

            //Stopwatch t2 = Stopwatch.StartNew();
            //var strassen = StrassenMultiply(mtA, mtB);
            //t2.Stop();

            //Console.WriteLine($"Strassen execution time: {t2.ElapsedMilliseconds} ms");

            //Matrix_WriteFile("KQA.txt", mtA);
            //Matrix_WriteFile("KQB.txt", mtB);
            //Matrix_WriteFile("KQBormal.txt", strassen);
            //Matrix_WriteFile("KQStrassen.txt", strassen);

            Console.ReadLine();
        }

        private static void Matrix_CreateFile(string fileName, int mtSize)
        {
            string filePath = Directory.GetCurrentDirectory() + "\\" + fileName;

            Random random = new Random();
            using (StreamWriter sw = File.CreateText(filePath))
            {
                //First-line contains the number of Rows and Columns
                sw.WriteLine(mtSize + " " + mtSize);

                int value = 0; string row = string.Empty;
                for (int i = 0; i < mtSize; i++)
                {
                    row = string.Empty;
                    for (int j = 0; j < mtSize; j++)
                    {
                        value = random.Next(0, 9);
                        row += (j < mtSize - 1 ? value + " " : value.ToString());
                    }
                    sw.WriteLine(row);
                }
            }
        }

        private static Matrix Matrix_ReadFromFile(string fileName, out int mtRows, out int mtCols)
        {
            string filePath = Directory.GetCurrentDirectory() + "\\" + fileName;
            mtRows = 0; mtCols = 0;

            var lstLines = File.ReadLines(filePath).ToList();
            if (lstLines == null || lstLines.Count() == 0)
            {
                Console.WriteLine("Lỗi đọc file");
                return null;
            }
            string[] aValue; string value;

            aValue = lstLines[0].Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            value = aValue.GetValue(0).ToString().TrimStart().TrimEnd();
            if (CheckNumber(value) == false)
            {
                Console.WriteLine("Lỗi đọc giá trị dòng");
                return null;
            }
            mtRows = Convert.ToInt32(value);

            value = aValue.GetValue(1).ToString().TrimStart().TrimEnd();
            if (CheckNumber(value) == false)
            {
                Console.WriteLine("Lỗi đọc giá trị cột");
                return null;
            }
            mtCols = Convert.ToInt32(value);

            lstLines.RemoveAt(0);

            Matrix matrix = new Matrix(mtRows, mtCols);

            for (int i = 0; i < lstLines.Count; i++)
            {
                aValue = lstLines[i].Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < aValue.Length; j++)
                {
                    value = aValue.GetValue(j).ToString().TrimStart().TrimEnd();
                    if (CheckNumber(value) == false)
                    {
                        Console.WriteLine(string.Format("Lỗi đọc giá trị ô {0}:{1}", i, j));
                        return null;
                    }
                    matrix[i, j] = Convert.ToInt32(value);
                }
            }
            return matrix;
        }

        private static void Matrix_WriteFile(string fileName, Matrix matrix)
        {
            string filePath = Directory.GetCurrentDirectory() + "\\" + fileName;

            using (StreamWriter sw = File.CreateText(filePath))
            {
                //First-line contains the number of Rows and Columns
                sw.WriteLine(matrix.Rows + " " + matrix.Columns);

                string row = string.Empty;
                for (int i = 0; i < matrix.Rows; i++)
                {
                    row = string.Empty;
                    for (int j = 0; j < matrix.Columns; j++)
                    {
                        row += (j < matrix.Rows - 1 ? matrix[i, j] + " " : matrix[i, j].ToString());
                    }
                    sw.WriteLine(row);
                }
            }
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
                    col = Convert.ToInt32(Math.Pow(2, cont + 1));
                    matrix.Columns = col;
                    //for (int i = 0; i < col; i++)
                    //{
                    //    for (int j = 0; j < col; j++)
                    //    {
                    //        if ((i >= row) || (j >= row))
                    //        {
                    //            matrix[i, j] = 0;
                    //        }
                    //    }
                    //}
                }
            }
        }

        private static void Matrix_Print(Matrix matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    Console.Write(string.Format("{0} ", matrix[i, j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static bool CheckNumber(string numString)
        {
            if (!numString.Any(c => c < '0' || c > '9'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Matrix NormalMultiply(Matrix a, Matrix b)
        {
            if (a.Columns != b.Rows)
                throw new ArgumentException("Number of rows of the matrix a doesnt equal to number of columns of the matrix b.");

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
            // TODO If the matrices A, B are not of type 2n x 2n we fill the missing rows and columns with zeros.
            var sizes = new int[] { a.Rows, a.Columns, b.Rows, b.Columns };
            if (sizes.Distinct().Count() != 1 || (a.Rows & (a.Rows - 1)) != 0)
                throw new ArgumentException("Not identical or square matrices.");

            int N = b.Rows;
            if (N <= 48)
                return NormalMultiply(a, b);

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
    }
}
