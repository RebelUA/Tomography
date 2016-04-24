using tomography.math;
using System;

namespace tomography
{
    class ApproximateFunction
    {
        public void solve(double[][] experiment, int n, int m, int k)
        {
            values2D = Solver.solve(experiment, n, m, k);
        }

        private double[][] values2D;

        public double f(double x, double y)
        {
            int i = (int) x / 50;
            int j = (int) y / 50;
            return values2D[i][j];
        }

    }
}
