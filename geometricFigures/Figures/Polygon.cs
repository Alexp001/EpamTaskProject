using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Polygon : Figure
    {
        public Polygon(int Size, params Point[] Points) : base(Size)
        {
            for (int i = 0; i < Points.Length; i++)
            {
                points[i] = new Point();
                points[i] = Points[i];
            }
        }

        public override double Area()
        {
            double area = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                area += points[i].x * points[i + 1].y - points[i + 1].x * points[i].y;
            }
            area += points[points.Length - 1].x * points[0].y - points[1].x * points[points.Length - 1].y;
            return Math.Abs(area) / 2;
        }
    }
}
