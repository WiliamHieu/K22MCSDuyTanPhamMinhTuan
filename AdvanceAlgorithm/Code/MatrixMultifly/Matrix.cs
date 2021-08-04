using System;

namespace MatrixMultifly
{
    public sealed class Matrix
    {
        #region Variables

        private int[,] values;

        public int Rows
        {
            get
            {
                return values.GetLength(0);
            }
        }

        public int Columns
        {
            get
            {
                return values.GetLength(1);
            }
        }

        public int Resize
        {
            set
            {
                var temp = Array.CreateInstance(values.GetType().GetElementType(), new int[] { value, value });
                int length = values.Length <= temp.Length ? values.Length : temp.Length;
                Array.ConstrainedCopy(values, 0, temp, 0, length);
                values = (int[,])temp;
            }
        }

        public int this[int row, int col]
        {
            get
            {
                return values[row, col];
            }
            set
            {
                values[row, col] = value;
            }
        }

        #endregion

        #region Constructors

        public Matrix(int m, int n)
        {
            if (m < 0)
                throw new ArgumentOutOfRangeException("m is less than or equal to zero.");
            if (n < 0)
                throw new ArgumentOutOfRangeException("n is less than or equal to zero.");

            values = new int[m, n];
        }

        public Matrix(int[,] values)
        {
            if (values == null)
                throw new ArgumentNullException("values == null.");

            this.values = values;
        }

        #endregion

        #region Operators

        public static Matrix operator +(Matrix a, Matrix b)
        {
            return Matrix.Add(a, b);
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            return Matrix.Subtract(a, b);
        }

        #endregion

        #region Functions

        public static Matrix Add(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Columns != b.Columns)
                throw new ArgumentException("Not identical matrices.");

            Matrix result = new Matrix(a.Rows, a.Columns);

            for (int row = 0; row < a.Rows; row++)
            {
                for (int col = 0; col < a.Columns; col++)
                {
                    result[row, col] = a[row, col] + b[row, col];
                }
            }
            return result;
        }

        public static Matrix Subtract(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Columns != b.Columns)
                throw new ArgumentException("Not identical matrices.");

            Matrix result = new Matrix(a.Rows, a.Columns);

            for (int row = 0; row < a.Rows; row++)
                for (int col = 0; col < a.Columns; col++)
                    result[row, col] = a[row, col] - b[row, col];

            return result;
        }

        public static Matrix Split(Matrix m, int rowFrom, int rowTo, int colFrom, int colTo)
        {
            Matrix result = new Matrix(rowTo - rowFrom, colTo - colFrom);

            for (int row = rowFrom, i = 0; row < rowTo; row++, i++)
            {
                for (int col = colFrom, j = 0; col < colTo; col++, j++)
                {
                    result[i, j] = m[row, col];
                }
            }
            return result;
        }

        public static Matrix Join(Matrix a11, Matrix a12, Matrix a21, Matrix a22)
        {
            Matrix result = new Matrix(a11.Rows * 2, a11.Rows * 2);
            int shift = a11.Rows;
            for (int row = 0; row < a11.Rows; row++)
            {
                for (int col = 0; col < a11.Columns; col++)
                {
                    result[row, col] = a11[row, col];
                    result[row, col + shift] = a12[row, col];
                    result[row + shift, col] = a21[row, col];
                    result[row + shift, col + shift] = a22[row, col];
                }
            }
            return result;
        }

        #endregion
    }
}
