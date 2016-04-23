using System;
using System.Collections;
using System.Collections.Generic;

namespace nzy3d_wpfDemo
{
    class Line
    {
        private double x1;
        private double y1;
        private double x2;
        private double y2;

        private Dictionary<Rectangle, List<Point>> intersections;

        public Line(double x1, double y1, double x2, double y2)
        {
            this.X1 = x1;
            this.X2 = x2;
            this.Y1 = y1;
            this.Y2 = y2;
            this.intersections = new Dictionary<Rectangle, List<Point>>();
        }

        public void addIntersections(Rectangle rectangle, List<Point> points)
        {
            if (points.Count != 2 && points.Count != 3)
            {
                throw new Exception("Wrong amount of points: " + points.Count);
            }
            if (points.Count == 3)
            {
                if (points[0].Equals(points[1]))
                {
                    points[1] = points[2];
                    points.RemoveAt(2);
                }
                else if (points[1].Equals(points[2]) || points[0].Equals(points[2]))
                {
                    points.RemoveAt(2);
                }
                else
                {
                    throw new Exception("Wrong amont of points: " + points.Count);
                }
            }
            intersections.Add(rectangle, points);
        }

        public List<Point> getIntersections(Rectangle rectangle)
        {
            List<Point> points;
            intersections.TryGetValue(rectangle, out points);
            return points;
        }

        public double getIntersectionsLength(Rectangle rectangle)
        {
            List<Point> list = getIntersections(rectangle);
            if (list != null && list.Count != 0)
            {
                if (list.Count != 2)
                {
                    throw new Exception("Wrong amont of points: " + list);
                }

                Point point1 = list[0];
                Point point2 = list[1];

                return Math.Sqrt((point2.X - point1.X) * (point2.X - point1.X)
                        + (point2.Y - point1.Y) * (point2.Y - point1.Y));
            }
            return 0;
        }

        public Line()
        {
        }

        public double X1
        {
            get
            {
                return x1;
            }

            set
            {
                x1 = value;
            }
        }

        public double Y1
        {
            get
            {
                return y1;
            }

            set
            {
                y1 = value;
            }
        }

        public double X2
        {
            get
            {
                return x2;
            }

            set
            {
                x2 = value;
            }
        }

        public double Y2
        {
            get
            {
                return y2;
            }

            set
            {
                y2 = value;
            }
        }
    }
}
