using tomography.math;
using System;

namespace tomography
{
    public class ExperimentFunction
    {

        public void solve(double[][] experiment)
        {
            values = experiment;
        }

        private double[][] values;

        public double f(double x, double y)
        {
            int i = (int) x / 10;
            int j = (int) y / 20;
            return values[i][j];
        }

    }
}
