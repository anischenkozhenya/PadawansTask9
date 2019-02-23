using System;
using System.Collections.Generic;

namespace PadawansTask9
{
    public class CartesianCoordinates
    {
        public static List<Point> GetNeighbors(Point point, int range, params Point[] points)
        {
            List<Point> PointList = new List<Point>();
            if (point.Equals(null))
                throw new ArgumentNullException();
            if (points == null)
                throw new ArgumentNullException();
            if (range <= 0)
                throw new ArgumentException();

            for (int i = 0; i <= points.Length - 1; i++)
            {
                if (Math.Abs(point.X - points[i].X) <= range
                    && Math.Abs(point.Y - points[i].Y) <= range)
                {
                    if (points[i].Equals(null))
                        throw new ArgumentNullException();
                    PointList.Add(points[i]);
                }
            }
            return PointList;

        }
    }
}