using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Shape
    {
        private int pointD;

        public int PointD
        {
            get { return pointD; }
            private set
            {
                if (value < 0)
                {
                    pointD = 0;
                }
                else
                {
                    pointD = value;
                }

            }
        }

        public Square()
        {
            PointD = 0;
        }

        public Square(int _pointA, int _pointB, int _pointC, int _pointD, Color _color) : base(_pointA, _pointB, _pointC, _color)
        {
            PointD = _pointD;
        }

        public override void Draw(Graphics draw)
        {
            using (Pen Pen = new(Color, 3))
            {
                draw.DrawRectangle(Pen, PointA, PointB, PointC, PointD);
            }

            using (var brush = new SolidBrush(Color))
                draw.FillRectangle(brush, PointA, PointB, PointC, PointD);
        }

        public override double FindP()
        {
            double p = PointA * 4;
            return p;
        }

        public override double FindS()
        {
            double s = PointA * PointA;
            return s;
        }
    }
}
