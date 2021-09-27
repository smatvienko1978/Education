using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotoshop
{
    public struct Point
    {
        private double r;
        private double g;
        private double b;
        public double R { get => r; set { r = Check(value); } }
        public double G { get => g; set { g = Check(value); } }
        public double B { get => b; set { b = Check(value); } }
        public Point (double r, double g, double b)
        {
            this.r = this.g = this.b = 0;
            this.R = r;
            this.G = g;
            this.B = b;
        }
        public static Point operator * (Point point, double multiplier)
        {
            return new Point(
                Trim(point.R*multiplier), 
                Trim(point.G*multiplier),
                Trim(point.B*multiplier));
        }
        public static Point operator *(double multiplier, Point point)
        {
            return point * multiplier;
        }
        private double Check(double value)
        {
            if (value < 0 || value > 1)
                throw new ArgumentException("The value must be between 0 and 1");
            return value;
        }
        public static double Trim (double value)
        {
            if (value > 1) return 1;
            if (value < 0) return 0;
            return value;
        }
    }
}
