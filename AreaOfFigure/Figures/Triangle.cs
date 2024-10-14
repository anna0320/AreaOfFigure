using System;

namespace AreaOfFigure.Figures
{
    public class Triangle : IFigure
    {
        public double Segment1 { get;}
        public double Segment2 { get;}
        public double Segment3 { get;}

        public Triangle (double segment1, double segment2, double segment3)
        {
            Segment1 = segment1;
            Segment2 = segment2;
            Segment3 = segment3;
        }

        public double CalculateArea()
        {
            double semiperimeter = ( Segment1 + Segment2 + Segment3 ) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - Segment1) * (semiperimeter - Segment2) * (semiperimeter - Segment3));
        }

        public bool IsRightTriangle()
        {
            double[] sides = {Segment1, Segment2, Segment3 };
            Array.Sort(sides); //сортируем, чтобы найти наибольшую сторону треугольника
            if (sides[2] * sides[2] == sides[0] * sides[0] + sides[1] * sides[1])
                return true;
            else return false;
        }
    }
}
