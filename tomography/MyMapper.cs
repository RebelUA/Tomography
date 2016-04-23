using tomography.math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tomography
{
    class MyMapper : nzy3D.Plot3D.Builder.Mapper
    {
        private double[][] values2D;

        private bool inited = false;

        public override double f(double x, double y)
        {
            if (!inited)
            {
                int n = MainWindow.n;
                int m = MainWindow.m;
                double[][] experiment = Solver.buildExperiment(Math.Max(n, m), 3000);
                experiment[1][1] = 4000;
                experiment[3][3] = 3600;
                experiment[4][1] = 5000;
                Solver.experiment = Matrix.matrixToRow(experiment);
                values2D = Solver.solve(n, m, 3);
                inited = true;
            }
            int i = (int) x / 50;
            int j = (int) y / 50;
            return values2D[i][j];
        }

    }
}
