using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace tomography.math
{
    class Solver
    {

        private static double[] experiment;

        public static double[][] buildExperiment(int n, int m, double value)
        {
            double[][] experiment = Matrix.initMatrix(n, m);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    experiment[i][j] = value;
                }
            }
            return experiment;
        }

        public static double[][] solve(double[][] experiment, int n, int m, int k)
        {
            Solver.experiment = Matrix.matrixToRow(experiment);
            int rectangleCount = Math.Max(n, k) * m;
            int linesCount = n * k;
            double size = 10;

            Rectangle[] rectangles = new Rectangle[rectangleCount];
            Line[] lines = new Line[linesCount];

            double distance = m * size;
            int iCount = 0;
            int jCount = 0;
            for (int i = 0; i < n; i++)
            {
                double center = i * size + (size / 2);
                for (int j = 0; j < k; j++)
                {
                    lines[jCount++] = new Line(center, 0, j * size + (size / 2), distance);
                }
            }
            for (int i = 0; i < Math.Max(n, k); i++)
            {
                for (int j = 0; j < m; j++)
                {
                    rectangles[iCount++] = new Rectangle(i * size, j * size, size, size);
                }
            }
            intersect(rectangles, lines, n, m, k, size);
            return calculate(rectangles, lines, n, m, k, size);
        }

        private static double[][] calculate(Rectangle[] rectangles, Line[] lines, int n, int m, int k, double size)
        {
            int nk = Math.Max(n, k);

            double[][] matrix = Matrix.initMatrix(n * k, nk * m);


            for (int i = 0; i < lines.Length; i++)
            {
                Line line = lines[i];
                for (int j = 0; j < rectangles.Length; j++)
                {
                    double length = line.getIntersectionsLength(rectangles[j]);
                    matrix[i][j] = length / size;
                }
            }

            double[] vector = new double[n * k];

            for (int i = 0; i < matrix.Length; i++)
            {
                double[] row = matrix[i];
                vector[i] = Matrix.sumMultiply(row, experiment);
            }

            List<int> toRemove = new List<int>();

            for (int i = 0; i < nk * m; i++)
            {
                if (!rectangles[i].Intersected)
                {
                    toRemove.Add(i);
                }
            }
            matrix = Matrix.trimColumns(toRemove, matrix);


            ////////
            //int rowLength = matrix[0].Length;
            //int colLength = matrix.Length;

            //for (int i = 0; i < colLength; i++)
            //{
            //    for (int j = 0; j < rowLength; j++)
            //    {
            //        Console.Write(string.Format("{0:0.00} ", matrix[i][j]));
            //    }
            //    Console.Write(string.Format("= {0:0.00} ", vector[i]));
            //    Console.Write(Environment.NewLine + Environment.NewLine);
            //}
            //////////

            double[][] tMatrix = Matrix.transpose(matrix);
            double[][] newMatrix = Matrix.multiplyParallel(tMatrix, matrix);
            double[] newVector = Matrix.multiply(tMatrix, vector);
            Matrix.addToMainDiag(newMatrix, 0.01);

            double[] values = Gauss.solve(newMatrix, newVector);

            //////
            //Console.WriteLine("Values:");
            //for (int i = 0; i < values.Length; i++)
            //{
            //    Console.Write(string.Format("{0:0} ", values[i]));
            //}
            ////////

            return Matrix.rowToMatrix(values, toRemove, nk, m);
        }

        private static void intersect(Rectangle[] rectangles, Line[] lines, int n, int m, int k, double size)
        {
            for (int i = 0; i < Math.Max(n, k) * m; i++)
            {
                for (int j = 0; j < n * k; j++)
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
