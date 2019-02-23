using System;
using System.Collections.Generic;

namespace PadawansTask9
{
    public class CartesianCoordinates
    {
        public static List<Point> GetNeighbors(Point point, int range, params Point[] points)
        {
            List<Point> PointList = new List<Point>();
            try
            {
                //Проверка range more 0
                if (range <= 0)
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {

            }

            for (int i = 0; i <= points.Length - 1; i++)
            {
                if (Math.Abs(point.X - points[i].X) <= range
                    && Math.Abs(point.Y - points[i].Y) <= range)
                {
                    PointList.Add(points[i]);
                }
            }
            return PointList;

        }
    }
}