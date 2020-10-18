using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Rectangle : Figure
    {
        public Rectangle(Point a, Point b, Point c, Point d, int Size = 4) : base(Size)
        {
            points[0] = new Point();
            points[0] = a;
            points[1] = new Point();
            points[1] = b;
            points[2] = new Point();
            points[2] = c;
            points[3] = new Point();
            points[3] = d;
        }

        public override double Area()
        {
            return Point.LengthStraight(points[0], points[1]) * Point.LengthStraight(points[1], points[2]);
        }

    }
}
