using tomography.math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tomography
{
    class ExpMapper : nzy3D.Plot3D.Builder.Mapper
    {

        private double[][] experiment2D;
        private double[][] values2D;

        private bool inited = false;

        public override double f(double x, double y)
        {
            if (!inited)
            {
                double[][] experiment = Solver.buildExperiment(10, 3000);
                Matrix.set(experiment, 4000, 3, 3, 6, 6);
                values2D = experiment;
                inited = true;
            }
            int i = (int) x / 50;
            int j = (int) y / 50;
            return values2D[i][j];
        }

    }
}
