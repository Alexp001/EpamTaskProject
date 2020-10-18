using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Trapezoid : Figure
    {
        public Trapezoid (Point a, Point b, Point c, Point d, int Size = 4) : base(Size)
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
            double area = 0;
            for (int i = 0; i < 3; i++)
            {
                area += points[i].x * points[i + 1].y - points[i + 1].x * points[i].y;
            }
            area += points[3].x * points[0].y - points[1].x * points[3].y;
            return Math.Abs(area) / 2;
        }


    }
}
