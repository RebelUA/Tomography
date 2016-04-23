using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nzy3d_wpfDemo.math
{
    class Solver
    {

        public static double[] experiment;

        public static double[][] buildExperiment(int n, double value) {
            double[][] experiment = Matrix.initMatrix(n, n);

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    experiment[i][j] = value;
                }
            }

            return experiment;
        }

        public static double[][] solve(int n, int m, int k)
        {
            int nm = n * n;
            double size = 50;

            Rectangle[] rectangles = new Rectangle[nm];
            Line[] lines = new Line[nm];

            double distance = n * size;
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                double center = i * size + (size / 2);
                for (int j = 0; j < n; j++)
                {
                    rectangles[count] = new Rectangle(i * size, j * size, size, size);
                    lines[count++] = new Line(center, 0, j * size + (size / 2), distance);
                }
            }
            intersect(rectangles, lines, n, m, size);
            return calculate(rectangles, lines, n, m, size);
        }

        private static double[][] calculate(Rectangle[] rectangles, Line[] lines, int n, int m, double size)
        {

            double[][] matrix = Matrix.initMatrix(n * n, n * n);


            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < rectangles.Length; j++)
                {
                    Line line = lines[j];
                    double length = line.getIntersectionsLength(rectangles[i]);
                    matrix[j].SetValue(length / size, i);
                }
            }

            double[] vector = new double[n * n];

            for (int i = 0; i < matrix.Length; i++)
            {
                double[] row = (double[])matrix.GetValue(i);
                vector[i] = multiply(row, experiment);
            }

            double[][] tMatrix = Matrix.transpose(matrix);
            double[][] newMatrix = Matrix.multiply(tMatrix, matrix);
            double[] newVector = Matrix.multiply(tMatrix, vector);
            double[][] eMatrix = Matrix.E(n * n);
            eMatrix = Matrix.multiply(eMatrix, 0.001);
            newMatrix = Matrix.add(newMatrix, eMatrix);

            
            double[] values = Gauss.solve(newMatrix, newVector);

            return Matrix.rowToMatrix(values, n);
        }

        private static double percentage(double a, double b)
        {
            return Math.Abs((a - b) / ((a + b) / 2)) * 100;
        }

        private static double multiply(double[] a, double[] b)
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i] * b[i];
            }
            return sum;
        }

        private static void intersect(Rectangle[] rectangles, Line[] lines, int n, int m, double size)
        {
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {
                    List<Point> list = getIntersection(rectangles[i], lines[j]);
                    if (list.Count != 0)
                    {
                        lines[j].addIntersections(rectangles[i], list);
                    }
                }
            }
        }

        private static List<Point> getIntersection(Rectangle rectangle, Line line)
        {

            List<Point> points = new List<Point>();

            foreach (Line rectangleLine in rectangle.Lines)
            {
                Point point = intersect(line, rectangleLine, rectangle);
                if (point != null)
                {
                    points.Add(point);
                }
            }

            return points;
        }

        private static double a(Line line)
        {
            return line.Y2 - line.Y1;
        }

        private static double b(Line line)
        {
            return line.X1 - line.X2;
        }

        private static double c(Line line)
        {
            return a(line) * line.X1 + b(line) * line.Y1;
        }

        private static Point intersect(Line line1, Line line2, Rectangle rectangle)
        {
            double aline1 = a(line1);
            double aline2 = a(line2);
            double bline1 = b(line1);
            double bline2 = b(line2);

            double det = aline1 * bline2 - aline2 * bline1;

            if (det == 0)
            {
                return null;
            }


            double cline1 = c(line1);
            double cline2 = c(line2);

            double x = ((bline2 * cline1 - bline1 * cline2) / det);
            double y = ((aline1 * cline2 - aline2 * cline1) / det);

            if (!rectangle.contains(x, y))
            {
                return null;
            }

            return new Point(x, y);
        }
    }
}
