using ILNumerics;
using ILNumerics.Drawing;
using ILNumerics.Drawing.Plotting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tomography;
using tomography.math;

namespace acoustic
{
    public partial class MainForm : Form
    {

        private ILScene scene;
        private ApproximateFunction function = new ApproximateFunction();
        public MainForm()
        {
            InitializeComponent();
            int n = 10;
            int m = 10;
            int k = 10;
            double[][] experiment = Solver.buildExperiment(Math.Max(n, k), m, 3000);
            Matrix.set(experiment, 4000, 3, 3, 6, 6);
            Matrix.set(experiment, 3500, 1, 1, 2, 2);
            //experiment[1][1] = 4000;
            //experiment[3][3] = 3600;
            //experiment[4][1] = 5000;
            function.solve(experiment, n, m, k);
        }

        private void PlotPanel_Load(object sender, EventArgs e)
        {
            scene = new ILScene() {
  new ILPlotCube(twoDMode: false, tag: "Speed") {
    new ILSurface((x, y) => (float)function.f(x, y),
            xmin: 0, xmax: 499, xlen: 50,
            ymin: 0, ymax: 499, ylen: 50,
            colormap: Colormaps.ILNumerics) {
      UseLighting = true,
      Children = {
            new ILColorbar()
      }
    }
  }
};

            scene.First<ILPlotCube>().Rotation = Matrix4.Rotation(Vector3.UnitZ, Math.PI / 2);
            plotPanel.Scene = scene;
            scene.MouseDoubleClick += resetView;


        }

        public void Update(ILInArray<double> A)
        {
            using (ILScope.Enter(A))
            {

                // fetch a reference to the plot
                var plot = plotPanel.Scene.First<ILLinePlot>(tag: "mylineplot");
                if (plot != null)
                {
                    // make sure, to convert elements to float
                    plot.Update(ILMath.tosingle(A));
                    //
                    // ... do more manipulations here ...

                    // finished with updates? -> Call Configure() on the changes 
                    plot.Configure();

                    // cause immediate redraw of the scene
                    plotPanel.Refresh();
                }

            }
        }

        private void resetView(object sender, MouseEventArgs e)
        {
            scene.First<ILPlotCube>().Reset();
            scene.First<ILPlotCube>().Rotation = Matrix4.Rotation(Vector3.UnitZ, Math.PI / 2);
            //scene.First<ILPlotCube>().RotateZ(Math.PI / 2);
        }
    }
}
