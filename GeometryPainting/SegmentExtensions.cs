using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryTasks;

namespace GeometryPainting
{
    //Напишите здесь код, который заставит работать методы segment.GetColor и segment.SetColor
    public static class SegmentExtensions
    {
        private static Dictionary<Segment, Color> colors = new Dictionary<Segment, Color>();
                    
        
        public static void SetColor (this Segment segment, Color color)
        {
            if (!colors.ContainsKey(segment))
                colors.Add(segment, color);
            else
                colors[segment] = color;
        }

        public static Color GetColor (this Segment segment)
        {
            return colors.ContainsKey(segment)?colors[segment]:Color.Black;
        }
    }
}
