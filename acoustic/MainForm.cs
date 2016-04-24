using tomography.HidrohimDBDataSetTableAdapters;
using ILNumerics;
using ILNumerics.Drawing;
using ILNumerics.Drawing.Plotting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tomography;
using tomography.math;

namespace tomography
{
    public partial class MainForm : Form
    {

        private ILScene scene;
        private ApproximateFunction function = new ApproximateFunction();
        private ExperimentFunction expFunction = new ExperimentFunction();
        HidrohimDBDataSet.wellsDataTable wells;
        DataRow[] rows;

        public MainForm()
        {
            InitializeComponent();
            initData();
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
            expFunction.solve(experiment);
        }

        private void initData()
        {
            wells = new HidrohimDBDataSet().wells;
            wellsTableAdapter adapter = new wellsTableAdapter();
            adapter.Fill(wells);
            rows = wells.Select(null, null, DataViewRowState.CurrentRows);
        }

        private void PlotPanel_Load(object sender, EventArgs e)
        {
            scene = new ILScene() {
  new ILPlotCube(twoDMode: false, tag: "Speed") {
    new ILSurface((x, y) => (float)expFunction.f(x, y),
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

        private void mapPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 1);
            Brush blackBrush = new SolidBrush(Color.Black);
            Brush redBrush = new SolidBrush(Color.Red);
            Brush brush = new SolidBrush(Color.LightGray);

            g.FillRectangle(brush, mapPanel.Bounds);
            for (int i = 0; i < 10; i++)
            {
                DataRow row = rows[i];
                if (row["coordX"].GetType().Equals(typeof(Double)) && row["coordY"].GetType().Equals(typeof(Double)))
                {
                    float x = Convert.ToSingle(row["coordX"]) / 20;
                    float y = Convert.ToSingle(row["coordY"]) / 40;
                    g.FillEllipse(redBrush, x, y, 10, 10);
                    //Font font = new Font("Times New Roman", 12.0f);
                    //g.DrawString(i.ToString(), font, blackBrush, x - 8, y + 8);

                }
            }
            pen.Dispose();
            brush.Dispose();
        }
    }
}
