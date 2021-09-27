using System;

namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
            var days = new string[30];
            for (var d = 0; d < 30; d++)
                days[d] = (d + 2).ToString();
            var months = new string[12];
            for (int m = 0; m < 12; m++)
            {
                months[m] = (m + 1).ToString();
            }
            var data = new double[30, 12];
            foreach (var item in names)
            {
                if (item.BirthDate.Day!=1)
                    data[item.BirthDate.Day-2, item.BirthDate.Month-1]++; 
            }

            return new HeatmapData(
                "Пример карты интенсивностей",
                data, 
                days, 
                months);
        }
    }
}