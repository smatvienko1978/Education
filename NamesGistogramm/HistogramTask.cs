using System;
using System.Linq;

namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {
            var days = new string[31];
            for (var d = 0; d < 31; d++)
                days[d] = (d+1).ToString();
            var count = new double[31] ;
            foreach (var item in names)
            {
                if (item.Name.Equals(name))
                if (item.BirthDate.Day != 1)
                    count[item.BirthDate.Day - 1]++;
            }
            return new HistogramData(
                string.Format("Рождаемость людей с именем '{0}'", name), 
                days, 
                count);
        }
    }
}