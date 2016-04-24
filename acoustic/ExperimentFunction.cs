using tomography.math;
using System;

namespace tomography
{
    class ExperimentFunction
    {

        public void solve(double[][] experiment)
        {
            values = experiment;
        }

        private double[][] values;

        public double f(double x, double y)
        {
            int i = (int) x / 50;
            int j = (int) y / 50;
            return values[i][j];
        }

    }
}
