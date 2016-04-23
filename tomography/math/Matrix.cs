using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nzy3d_wpfDemo
{
    class Matrix
    {
        public static double[][] transpose(double[][] m)
        {
            int length = m.Length;
            int rowLength = m.GetLength(0);

            double[][] temp = initMatrix(rowLength, length);
            for (int i = 0; i < length; i++)
                for (int j = 0; j < rowLength; j++)
                    temp[j][i] = m[i][j];
            return temp;
        }

        public static double[][] add(double[][] m1, double[][] m2)
        {
            if (m1.Length != m2.Length || m1.GetLength(0) != m2.GetLength(0))
            {
                return null;
            }
            double[][] temp = (double[][])m1.Clone();
            for (int i = 0; i < m1.Length; i++)
                for (int j = 0; j < m1.GetLength(0); j++)
                    temp[i][j] += m2[i][j];
            return temp;
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
                for (int j = 0; j < m.GetLength(0); j++)
                    temp[i][j] = m[i][j] * value;
            return temp;
        }

        public static double[] multiply(double[][] A, double[] x)
        {
            int m = A.Length;
            int n = A.GetLength(0);
            if (x.Length != n)
            {
                return null;
            }
            double[] y = new double[m];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    y[i] += A[i][j] * x[j];
            return y;
        }

        public static double[][] multiply(double[][] A, double[][] B)
        {
            int mA = A.Length;
            int nA = A.GetLength(0);
            int mB = B.Length;
            int nB = B.GetLength(0);
            if (nA != mB)
            {
                return null;
            }
            double[][] C = initMatrix(mA, nB);
            for (int i = 0; i < mA; i++)
                for (int j = 0; j < nB; j++)
                    for (int k = 0; k < nA; k++)
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

        public static double[][] rowToMatrix(double[] row, int n)
        {
            double[][] values2D = initMatrix(n, n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    values2D[i][j] = row[i * n + j];
                }
            }
            return values2D;
        }

        public static double[] matrixToRow(double[][] matrix) {
            int n = matrix.Length;
            double[] values = new double[n*n];
            int k = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    values[k] = matrix[i][j];
                    k++;
                }
            }
            return values;
        }

        public static void set(double[][] matrix, double value, int i1, int j1, int i2, int j2)
        {
            for (int i = i1; i < i2; i++) {
                for (int j = j1; j < j2; j++) {
                    matrix[i][j] = value;
                }
            }
        }
    }
}
