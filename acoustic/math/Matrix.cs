using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace tomography.math
{
    class Matrix
    {
        public static double[][] transpose(double[][] m)
        {
            int length = m.Length;
            int rowLength = m[0].Length;

            double[][] temp = initMatrix(rowLength, length);
            for (int i = 0; i < length; i++)
                for (int j = 0; j < rowLength; j++)
                    temp[j][i] = m[i][j];
            return temp;
        }

        public static void addToMainDiag(double[][] A, double value)
        {
            for (int j = 0; j < Math.Min(A.Length, A[0].Length); j++)
            {
                A[j][j] += value;
            }

        }

        public static double[][] multiply(double[][] m, double value)
        {
            double[][] temp = (double[][])m.Clone();
            for (int i = 0; i < m.Length; i++)
                for (int j = 0; j < m[0].Length; j++)
                    temp[i][j] = m[i][j] * value;
            return temp;
        }

        public static double[] multiply(double[][] A, double[] B)
        {
            int m = A.Length;
            int n = A[0].Length;
            if (B.Length != n)
            {
                throw new Exception("Incorrect dimensions");
            }
            double[] y = new double[m];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    y[i] += A[i][j] * B[j];
            return y;
        }

        public static double[][] multiply(double[][] A, double[][] B)
        {
            int aRows = A.Length;
            int aCols = A[0].Length;
            int bRows = B.Length;
            int bCols = B[0].Length;
            if (aCols != bRows)
            {
                throw new Exception("Incorrect dimensions");
            }

            double[][] result = initMatrix(aRows, bCols);

            for (int i = 0; i < aRows; ++i) // each row of A
                for (int j = 0; j < bCols; ++j) // each col of B
                    for (int k = 0; k < aCols; ++k) // could use k < bRows
                        result[i][j] += A[i][k] * B[k][j];
            return result;
        }

        public static double[][] multiplyParallel(double[][] A, double[][] B)
        {
            int aRows = A.Length;
            int aCols = A[0].Length;
            int bRows = B.Length;
            int bCols = B[0].Length;
            if (aCols != bRows)
            {
                throw new Exception("Incorrect dimensions");
            }

            double[][] result = initMatrix(aRows, bCols);

            Parallel.For(0, aRows, i =>
            {
                for (int j = 0; j < bCols; ++j)
                    for (int k = 0; k < aCols; ++k)
                        result[i][j] += A[i][k] * B[k][j];
            }
            );

            return result;
        }

        public static double[][] initMatrix(int n, int m)
        {
            double[][] matrix = new double[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new double[m];
            }
            return matrix;
        }

        public static double[][] rowToMatrix(double[] row, int n, int m)
        {
            double[][] values2D = initMatrix(n, m);
            int count = 0;
            double value;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (count <= row.Length)
                    {
                        value = row[count++];
                    } else
                    {
                        value = 0;
                    }
                    values2D[i][j] = value;
                }
            }
            return values2D;
        }

        public static double[] matrixToRow(double[][] matrix)
        {
            int n = matrix.Length;
            int m = matrix[0].Length;
            double[] values = new double[n * m];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    values[k] = matrix[i][j];
                    k++;
                }
            }
            return values;
        }

        public static void set(double[][] matrix, double value, int i1, int j1, int i2, int j2)
        {
            for (int i = i1; i < i2; i++)
            {
                for (int j = j1; j < j2; j++)
                {
                    matrix[i][j] = value;
                }
            }
        }

        public static double sumMultiply(double[] a, double[] b)
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i] * b[i];
            }
            return sum;
        }

        public static double[][] TrimArray(List<int> toRemove, double[][] originalArray)
        {
            int n = originalArray.Length;
            int m = originalArray[0].Length;
            int newN = n - toRemove.Count;

            double[][] result = initMatrix(newN, m);

            for (int i = 0, j = 0; i < n; i++)
            {
                if (toRemove.Contains(i))
                    continue;

                for (int k = 0; k < m; k++)
                {
                    result[j][k] = originalArray[i][k];
                }
                j++;
            }

            return result;
        }

        public static double[] TrimArray(List<int> toRemove, double[] originalArray)
        {
            int n = originalArray.Length;
            int newN = n - toRemove.Count;

            double[] result = new double[newN];

            for (int i = 0, j = 0; i < n; i++)
            {
                if (toRemove.Contains(i))
                    continue;
                result[j] = originalArray[i];
                j++;
            }

            return result;
        }
    }
}
