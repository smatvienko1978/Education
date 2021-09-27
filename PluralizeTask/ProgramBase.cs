namespace Pluralize
{
    internal class ProgramBase
    {
        static string PluralizeTask(int rubels)
        {
            rubels = rubels % 20;
            if (rubels == 0 || rubels >= 5)
            {
                return "рублей";
            }
            if (rubels == 1)
            {
                return "рубль";
            }
            return "рубля";
        }
    }
}