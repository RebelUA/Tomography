using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomography
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

        public static double[][] addToMainDiag(double[][] A, double value)
        {
            for (int j = 0; j < Math.Min(A.Length, A[0].Length); j++)
            {
                A[j][j] += value;
            }
            return A;
        }

        public static double[][] E(int size)
        {
            double[][] temp = initMatrix(size, size);
            for (int i = 0; i < size; i++)
            {
                temp[i][i] = 1;
            }
            return temp;
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
                return null;
            }
            double[] y = new double[m];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    y[i] += A[i][j] * B[j];
            return y;
        }

        public static double[][] multiply(double[][] A, double[][] B)
        {
            int nA = A.Length;
            int mA = A[0].Length;
            int nB = B.Length;
            int mB = B[0].Length;
            if (mA != nB)
            {
                return null;
            }
            double[][] C = initMatrix(nA, mB);
            for (int i = 0; i < nA; i++)
                for (int j = 0; j < mB; j++)
                    for (int k = 0; k < mA; k++)
                        C[i][j] += A[i][k] * B[k][j];
            return C;
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
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    values2D[i][j] = row[count++];
                }
            }
            return values2D;
        }

        public static double[] matrixToRow(double[][] matrix)
        {
            int n = matrix.Length;
            double[] values = new double[n * n];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
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
    }
}
