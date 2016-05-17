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
using acoustic;
using acoustic.HidrohimDBDataSetTableAdapters;

namespace tomography
{
    public partial class MainForm : Form
    {

        private ILScene scene;
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

        private void PlotPanel_Load(object sender, EventArgs e)
        {
            scene = new ILScene() {
  new ILPlotCube(twoDMode: false, tag: "Speed") {
    new ILSurface((x, y) => (float) function.f(x, y),
            xmin: 0, xmax: Math.Max(globalN, globalK) * 10 - 1, xlen: 30,
            ymin: 0, ymax: globalM * 20 - 1, ylen: 30,
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

        private void resetView(object sender, MouseEventArgs e)
        {
            scene.First<ILPlotCube>().Reset();
            scene.First<ILPlotCube>().Rotation = Matrix4.Rotation(Vector3.UnitZ, Math.PI / 2);
        }

        //private void mapPanel_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    Pen pen = new Pen(Color.Black, 1);
        //    Brush blackBrush = new SolidBrush(Color.Black);
        //    Brush redBrush = new SolidBrush(Color.Red);
        //    Brush brush = new SolidBrush(Color.LightGray);

        //    g.FillRectangle(brush, mapPanel.Bounds);
        //    for (int i = 0; i < 10; i++)
        //    {
        //        DataRow row = rows[i];
        //        if (row["coordX"].GetType().Equals(typeof(Double)) && row["coordY"].GetType().Equals(typeof(Double)))
        //        {
        //            float x = Convert.ToSingle(row["coordX"]) / 20;
        //            float y = Convert.ToSingle(row["coordY"]) / 40;
        //            g.FillEllipse(redBrush, x, y, 10, 10);
        //            //Font font = new Font("Times New Roman", 12.0f);
        //            //g.DrawString(i.ToString(), font, blackBrush, x - 8, y + 8);

        //        }
        //    }
        //    pen.Dispose();
        //    brush.Dispose();
        //}

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
                PlotPanel_Load(null, null);
            }
            expFunction.solve(experiment);
        }

        private void exactBtn_Click(object sender, EventArgs e)
        {
            ExactDataForm form = new ExactDataForm(expFunction, globalN, globalM, globalK);
            form.Show();
        }
    }
}
