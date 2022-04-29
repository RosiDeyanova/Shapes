using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle() : base(){}

        public Triangle(int _pointA, int _pointB, int _pointC, Color _color) : base(_pointA, _pointB, _pointC, _color) { }

        public override void Draw(Graphics draw)
        {
            Point[] point = { new Point(PointC, PointA), new Point(PointA, PointB), new Point(PointB, PointC) };
            using (Pen pen = new(Color, 3))
                draw.DrawPolygon(pen, point);

            using (var solidBrush = new SolidBrush(Color))
                draw.FillPolygon(solidBrush, point);
        }

        public override double FindP()
        {
            throw new NotImplementedException();
        }

        public override double FindS()
        {
            throw new NotImplementedException();
        }
        //public override double FindP()
        //{
        //    double p = PointA + SideB + SideC;
        //    return p;
        //}

        //public override double FindS()
        //{
        //    double halfS = (PointA + SideB + SideC) /2;
        //    double s = Math.Abs(halfS*(halfS - PointA)*(halfS - SideB)*(halfS - SideC));
        //    return s;
        //}
    }
}
