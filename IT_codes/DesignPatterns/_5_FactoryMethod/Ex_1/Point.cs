using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_FactoryMethod
{
    public class Point
    {
        private double x, y;

        #region without using factory method
        //public Point(double x, double y)
        //{
        //    this.x = x;
        //    this.y = y;
        //}

        //public Point(float r, float theta)
        //{
        //    x = r * Math.Cos(theta);
        //    y = r * Math.Sin(theta);
        //}
        #endregion

        #region with using enum and constructor
        //public Point(double a, double b, // names do not communicate intent
        //             CoordinateSystem cs = CoordinateSystem.Cartesian)
        //{
        //    switch (cs)
        //    {
        //        case CoordinateSystem.Polar:
        //            x = a * Math.Cos(b);
        //            y = a * Math.Sin(b);
        //            break;
        //        default:
        //            x = a;
        //            y = b;
        //            break;
        //    }
        //}
        #endregion

        protected Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static Point NewCartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }

        public static Point NewPolarPoint(double rho, double theta)
        {
            return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
        }

        // other members omitted
    }
}
