using tomography.math;
using System;

namespace tomography
{
    class ApproximateFunction : nzy3D.Plot3D.Builder.Mapper
    {
        public void solve(double[][] experiment, int n, int m, int k)
        {
            values2D = Solver.solve(experiment, n, m, k);
        }

        private double[][] values2D;

        public override double f(double x, double y)
        {
            int i = (int) x / 10;
            int j = (int) y / 20;
            return values2D[i][j];
        }
    }
}
