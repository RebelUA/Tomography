using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomography
{
    class Rectangle
    {
        private double x;
        private double width;
        private double y;
        private double height;
        private Line[] lines;

        public Rectangle(double x, double y, double width, double height)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;

            double x1 = X;
            double x2 = x1 + Width;
            double y1 = Y;
            double y2 = y1 + Height;

            this.lines = new Line[4];
            this.lines[0] = new Line(x1, y1, x2, y1);
            this.lines[1] = new Line(x2, y1, x2, y2);
            this.lines[2] = new Line(x2, y2, x1, y2);
            this.lines[3] = new Line(x1, y2, x1, y1);
        }

        public bool contains(Point localPoint)
        {
            return contains(localPoint.X, localPoint.Y);
        }

        public bool contains(double localX, double localY)
        {
            return localX >= X && localX <= (X + Width)
                    && localY >= Y && localY <= (Y + Height);
        }

        public Line[] Lines
        {
            get
            {
                return lines;
            }
        }

        public double X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }

        public double Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

    }
}
