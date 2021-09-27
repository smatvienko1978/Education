using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    class Program
    {
        public static string timeConversion(string s)
        {
            string result = s.Substring(0, s.Length - 2);
            string hoursString = result.Substring(0, 2);
            int hoursInt = int.Parse(hoursString);

            if (s[s.Length - 2] == 'A')
            {
                if (hoursInt == 12)
                    return "00" + result.Substring(2);
            }
            if (s[s.Length - 2] == 'P')
            {
                if (hoursInt == 12)
                    return "12" + result.Substring(2);
                hoursInt += 12;
            }

            if (hoursInt == 24 || hoursInt == 0)
                return "00" + result.Substring(2);
            if (hoursInt < 10)
                return "0" + hoursInt.ToString() + result.Substring(2);
            return hoursInt.ToString() + result.Substring(2);
            static void Main(string[] args)
        {
        }
    }
}
