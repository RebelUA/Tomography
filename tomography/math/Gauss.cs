using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomography
{
    class Gauss
    {

        private static double EPSILON = 1e-10;

        public static double[] solve(double[][] A, double[] b)
        {
            int N = b.Length;

            for (int p = 0; p < N; p++)
            {

                // find pivot row and swap
                int max = p;
                for (int i = p + 1; i < N; i++)
                {
                    if (Math.Abs(A[i][p]) > Math.Abs(A[max][p]))
                    {
                        max = i;
                    }
                }
                double[] temp = (double[]) A.GetValue(p);
                A.SetValue((double[]) A.GetValue(max), p);
                A.SetValue(temp, max);
                double t = b[p];
                b[p] = b[max];
                b[max] = t;

                // singular or nearly singular
                if (Math.Abs(A[p][p]) <= Gauss.EPSILON)
                {
                    throw new Exception("Matrix is singular or nearly singular");
                }

                // pivot within A and b
                for (int i = p + 1; i < N; i++)
                {
                    double alpha = A[i][p] / A[p][p];
                    b[i] -= alpha * b[p];
                    for (int j = p; j < N; j++)
                    {
                        A[i][j] -= alpha * A[p][j];
                    }
                }
            }

            // back substitution
            double[] x = new double[N];
            for (int i = N - 1; i >= 0; i--)
            {
                double sum = 0.0;
                for (int j = i + 1; j < N; j++)
                {
                    sum += A[i][j] * x[j];
                }
                x[i] = (b[i] - sum) / A[i][i];
            }
            return x;
        }
    }
}
