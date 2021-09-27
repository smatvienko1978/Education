using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTasks
{
    public class Vector
    {
        public double X;
        public double Y;
        public double GetLength()
        {
            return Geometry.GetLength(this);
        }

        public Vector Add(Vector vector2)
        {
            return Geometry.Add(this, vector2);
        }

        public bool Belongs(Segment segment)
        {
            return Geometry.IsVectorInSegment(this, segment);
        }
    }

    public class Geometry
    {
        public static Vector Add(Vector vector1, Vector vector2)
        {
            var result = new Vector();
            result.X = vector1.X + vector2.X;
            result.Y = vector1.Y + vector2.Y;
            return result;
        }

        public static double GetLength(Vector vector)
        {
            return Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
        }

        public static double GetLength(Segment segment)
        {
            var x = segment.End.X - segment.Begin.X;
            var y = segment.End.Y - segment.Begin.Y;
            return Math.Sqrt(x * x + y * y);
        }

        public static bool IsVectorInSegment(Vector vector, Segment segment)
        {
            var ab = GetLength(segment);

            var axSegm = new Segment();
            axSegm.Begin = new Vector();
            axSegm.End = new Vector();
            axSegm.Begin.X = segment.Begin.X;
            axSegm.End.X = vector.X;
            axSegm.Begin.Y = segment.Begin.Y;
            axSegm.End.Y = vector.Y;
            var ax = GetLength(axSegm);

            var xbSegm = new Segment();
            xbSegm.Begin = new Vector();
            xbSegm.End = new Vector();
            xbSegm.Begin.X = vector.X;
            xbSegm.End.X = segment.End.X;
            xbSegm.Begin.Y = vector.Y;
            xbSegm.End.Y = segment.End.Y;
            var xb = GetLength(xbSegm);

            return ax + xb == ab;
        }
    }

    public class Segment
    {
        public Vector Begin;
        public Vector End;
        public double GetLength()
        {
            return Geometry.GetLength(this);
        }

        public bool Contains(Vector vector)
        {
            return Geometry.IsVectorInSegment(vector, this);
        }
    }
}
