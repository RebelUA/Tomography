using System;
using System.Windows.Forms;
using tomography.math;
using acoustic;
using nzy3D.Plot3D.Primitives.Axes.Layout;
using nzy3D.Plot3D.Rendering.View;
using nzy3D.Maths;
using nzy3D.Plot3D.Primitives;
using nzy3D.Plot3D.Builder;
using nzy3D.Plot3D.Builder.Concrete;
using nzy3D.Colors;
using nzy3D.Colors.ColorMaps;
using nzy3D.Chart;
using nzy3D.Plot3D.Rendering.Canvas;
using nzy3D.Chart.Controllers.Thread.Camera;

namespace tomography
{
    public partial class MainForm : Form
    {

        private CameraThreadController t;
        private IAxeLayout axeLayout;
        private ApproximateFunction function = new ApproximateFunction();
        private ExperimentFunction expFunction = new ExperimentFunction();

        int globalN;
        int globalM;
        int globalK;

        public MainForm()
        {
            InitializeComponent();
            tabSpeed.TabPages.Remove(tabPage2);
            solveBtn.Enabled = false;
            drawButton.Enabled = false;
        }


        private void resetView(object sender, MouseEventArgs e)
        {
        }

        public void InitRenderer()
        {
            // Create the Renderer 3D control.
            //Renderer3D myRenderer3D = new Renderer3D();

            //// Add the Renderer control to the panel
            //plotPanel.Controls.Clear();
            //plotPanel.Controls.Add(myRenderer3D);

            // Create a range for the graph generation
            int x = Math.Max(globalN, globalK);
            Range xRange = new Range(0, x * 10 - 1);
            int xSteps = 30;//Math.Min(x * 2, 30);
            Range yRange = new Range(0, globalM * 20 - 1);
            int ySteps = 30;//Math.Min(globalM * 2, 30);

            // Build a nice surface to display with cool alpha colors 
            // (alpha 0.8 for surface color and 0.5 for wireframe)
            Shape surface = Builder.buildOrthonomal(new OrthonormalGrid(xRange, xSteps, yRange, ySteps), function);
            surface.ColorMapper = new ColorMapper(new ColorMapRainbow(), surface.Bounds.zmin, surface.Bounds.zmax, new Color(1, 1, 1, 0.8));
            surface.FaceDisplayed = true;
            surface.WireframeDisplayed = true;
            surface.WireframeColor = Color.GRAY;
            surface.WireframeColor.mul(new Color(1, 1, 1, 0.5));

            // Create the chart and embed the surface within
            Chart chart = new Chart(renderer, Quality.Nicest);
            chart.Scene.Graph.Add(surface);
            axeLayout = chart.AxeLayout;

            // Create a mouse control
            nzy3D.Chart.Controllers.Mouse.Camera.CameraMouseController mouse = new nzy3D.Chart.Controllers.Mouse.Camera.CameraMouseController();
            mouse.addControllerEventListener(renderer);
            chart.addController(mouse);

            // This is just to ensure code is reentrant (used when code is not in Form_Load but another reentrant event)
            DisposeBackgroundThread();

            // Create a thread to control the camera based on mouse movements
            t = new CameraThreadController();
            t.addControllerEventListener(renderer);
            mouse.addSlaveThreadController(t);
            chart.addController(t);
            t.Start();

            // Associate the chart with current control
            renderer.setView(chart.View);
        }

        private void DisposeBackgroundThread()
        {
            if ((t != null))
            {
                t.Dispose();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hidrohimDBDataSet.speeds' table. You can move, or remove it, as needed.
            try {
                this.speedsTableAdapter.Fill(this.hidrohimDBDataSet.speeds);
            } catch (Exception ex)
            {
                //Do nothing (
            }
            this.wellsTableAdapter.FillBy(this.hidrohimDBDataSet.wells);
        }

        private void selectFirstButton_Click(object sender, System.EventArgs e)
        {
            Int32 selectedRowCount =
                dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                if (selectedRowCount > 1)
                {
                    MessageBox.Show("Select only one row", "Error");
                    return;
                }

                DataGridViewRow row = dataGridView1.SelectedRows[0];

                int id = (int)row.Cells[0].Value;
                string name = row.Cells[1].Value.ToString();
                double x = (double)row.Cells[2].Value;
                double y = (double)row.Cells[3].Value;
                double depth = (double)row.Cells[4].Value;

                if (bId.Visible == true)
                {
                    int numBiD = Int32.Parse(bId.Text);
                    if (id == numBiD)
                    {
                        MessageBox.Show("Select different from second well", "Error");
                        return;
                    }
                    double bXnum = Double.Parse(bX.Text);
                    double bYnum = Double.Parse(bY.Text);

                    distance.Text = calcDistance(x, y, bXnum, bYnum).ToString();
                    distance.Visible = true;
                    solveBtn.Enabled = true;
                }

                aId.Text = id.ToString();
                aId.Visible = true;
                aName.Text = name;
                aName.Visible = true;
                aX.Text = x.ToString();
                aX.Visible = true;
                aY.Text = y.ToString();
                aY.Visible = true;
                aDepth.Text = depth.ToString();
                aDepth.Visible = true;
                infADepth.Text = aDepth.Text;
                infADepth.Visible = true;
            }
        }

        private void selectSecondButton_Click(object sender, System.EventArgs e)
        {
            Int32 selectedRowCount =
                dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                if (selectedRowCount > 1)
                {
                    MessageBox.Show("Select only one row", "Error");
                    return;
                }

                DataGridViewRow row = dataGridView1.SelectedRows[0];

                int id = (int)row.Cells[0].Value;
                string name = row.Cells[1].Value.ToString();
                double x = (double)row.Cells[2].Value;
                double y = (double)row.Cells[3].Value;
                double depth = (double)row.Cells[4].Value;

                if (aId.Visible == true)
                {
                    int numAiD = Int32.Parse(aId.Text);
                    if (id == numAiD)
                    {
                        MessageBox.Show("Select different from first well", "Error");
                        return;
                    }
                    double aXnum = Double.Parse(aX.Text);
                    double aYnum = Double.Parse(aY.Text);

                    distance.Text = calcDistance(x, y, aXnum, aYnum).ToString();
                    distance.Visible = true;
                    solveBtn.Enabled = true;
                    drawButton.Enabled = true;
                }

                bId.Text = id.ToString();
                bId.Visible = true;
                bName.Text = name;
                bName.Visible = true;
                bX.Text = x.ToString();
                bX.Visible = true;
                bY.Text = y.ToString();
                bY.Visible = true;
                bDepth.Text = depth.ToString();
                bDepth.Visible = true;
                infBDepth.Text = bDepth.Text;
                infBDepth.Visible = true;
            }
        }

        private double calcDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }

        private void solveBtn_Click(object sender, EventArgs e)
        {
            double dist = Double.Parse(distance.Text);
            double depthA = Double.Parse(aDepth.Text);
            double depthB = Double.Parse(bDepth.Text);

            if (dist < 20)
            {
                MessageBox.Show("Distance is too small, probably two wells are the same", "Error");
                return;
            }

            mapDist.Text = ((int) dist).ToString();
            mapDepthA.Text = depthA.ToString();
            mapDepthB.Text = depthB.ToString();

            double maxDepth = Math.Max(depthA, depthB);

            depthAPanel.Height = (int)(380 * depthA / maxDepth);
            depthBPanel.Height = (int)(380 * depthB / maxDepth);

            globalN = (int)depthA;
            globalM = (int)dist / 20;
            globalK = (int)depthB;

            if (checkBox1.Checked)
            {
                globalN = Math.Min(globalN, globalK);
                globalK = globalN;
            } else
            {
                if (Math.Abs(globalN - globalK) > 5)
                {
                    MessageBox.Show("Differnce if depth is too large, it is recomended to use optimized method", "Warning");
                }
            }

            double[][] experiment = Solver.buildRandomExperiment(Math.Max(globalN, globalK), globalM, 3000);
            //Matrix.set(experiment, 4000, 3, 3, 6, 6);
            //Matrix.set(experiment, 3500, 1, 1, 2, 2);
            //experiment[1][1] = 4000;
            //experiment[3][3] = 3600;
            //experiment[4][1] = 5000;
            function.solve(experiment, globalN, globalM, globalK);
            if (!tabSpeed.TabPages.Contains(tabPage2))
            {
                tabSpeed.TabPages.Add(tabPage2);
            }
            else
            {
            }
            expFunction.solve(experiment);
        }

        private void exactBtn_Click(object sender, EventArgs e)
        {
            ExactDataForm form = new ExactDataForm(expFunction, globalN, globalM, globalK);
            form.Show();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            InitRenderer();
        }
    }
}
