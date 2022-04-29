using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    [Serializable]
    public abstract class Shape
    {
        private int pointA;
        private int pointB;
        private int pointC;

        public Color Color { get; set; } = Color.Red;
        public int PointA
        {
            get { return pointA; }
            private set
            {
                if (value < 0) { 
                    pointA = 0;
                }
                else
                {
                    pointA = value;
                }

            }
        }
        public int PointB
        {
            get { return pointB; }
            private set
            {
                if (value < 0)
                {
                    pointB = 0;
                }
                else
                {
                    pointB = value;
                }

            }
        }
        public int PointC
        {
            get { return pointC; }
            private set
            {
                if (value < 0)
                {
                    pointC = 0;
                }
                else
                {
                    pointC = value;
                }

            }
        }

        public double S { get; set; }
        public double P { get; set; }

        public Shape()
        {
            PointA = 0;
            PointC = 0;
            PointB = 0;
            Color = Color.Red;
        }

        public Shape(int _pointA, int _pointB, int _pointC, Color _color)
        {
            PointA = _pointA;
            PointA = _pointB;
            PointA = _pointC;
            Color = _color;
        }

        public abstract double FindS();
        public abstract double FindP();

        public abstract void Draw(Graphics draw);
    }
}
