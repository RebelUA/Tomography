using System;
using System.Windows.Forms;
using tomography;

namespace acoustic
{
    public partial class ExactDataForm : Form
    {
        private ExperimentFunction function;
        private int n;
        private int m;
        private int k;

        public ExactDataForm(ExperimentFunction function, int n, int m, int k)
        {
            this.n = n;
            this.m = m;
            this.k = k;
            this.function = function;
            InitializeComponent();
        }

        private void PlotPanel_Load(object sender, EventArgs e)
        {
  //          scene = new ILScene() {
  //new ILPlotCube(twoDMode: false, tag: "Speed") {
  //  new ILSurface((x, y) => (float) function.f(x, y),
  //          xmin: 0, xmax: Math.Max(n, k) * 10 - 1, xlen: 30,
  //          ymin: 0, ymax: m * 20 - 1, ylen: 30,
  //          colormap: Colormaps.ILNumerics) {
  //    UseLighting = true,
  //    Children = {
  //          new ILColorbar()
      //}
    }
  //}
//};
            //scene.First<ILPlotCube>().Rotation = Matrix4.Rotation(Vector3.UnitZ, Math.PI / 2);
            //ilPanel1.Scene = scene;
            //scene.MouseDoubleClick += resetView;
        //}

        private void resetView(object sender, MouseEventArgs e)
        {
            //scene.First<ILPlotCube>().Reset();
            //scene.First<ILPlotCube>().Rotation = Matrix4.Rotation(Vector3.UnitZ, Math.PI / 2);
        }
    }
}
