namespace Pluralize
{
	public static class PluralizeTask
	{
        public static string PluralizeRubles(int count)
        {
            while (count > 100)
            {
                count = count % 100;
            }
            int remainder = count % 10;
            System.Console.WriteLine(remainder);
            string result = "рублей";

            if ((remainder == 1) && !(count==11 || count%100 ==11)) result ="рубль";
               
            if ((remainder>1 && remainder<5) && !(count==12||count==13||count==14|count==15)) result = "рубля";

            return result;

        }
	}
}