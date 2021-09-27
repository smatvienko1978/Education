using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_CrossAndCircle
{
    class Program
    {

        //private static string DecodeMessage(string[] lines)
        //{
        //    string result = "";
        //    for (int i = lines.Length-1; i > 1; i--)
        //    {
        //        var parce = lines[i].Split(' ');
        //        foreach (var item in parce)
        //        {
        //            char first = item[0];
        //            if (Char.IsUpper(first))
        //                result += lines[i] + " ";
        //        }
        //    }
        //    return result;
        //}

        private static string DecodeMessage(string[] lines)
        {            
            List<string> words = new List<string>();
            foreach (var line in lines)
            {
                var parce = line.Split(' ');
                foreach (var word in parce)
                    if (word.Length>0 && Char.IsUpper(word[0]))
                        words.Add(word);
            }
            words.Reverse();

            //string result = "";
            //for (int i = 0; i < words.Count(); i++)
            //{
            //    result += words[i];
            //    if (i < words.Count() - 1)
            //        result += " ";
            //}
            //return result;

            return string.Join(" ", words.ToArray());
        }
        static void Main(string[] args)
        {
            var message = new[]{"решИла нЕ Упрощать и зашифРОВАтЬ Все послаНИЕ",
                                "дАже не Старайся нИЧЕГО у тЕбя нЕ получится с расшифРОВкой",
                                "Сдавайся НЕ твоего ума Ты не споСОбЕн Но может быть",
                                "если особенно упорно подойдешь к делу",
                                "  ",
                                "будет Трудно конечнО",
                                "Код ведЬ не из простых",
                                "очень ХОРОШИЙ код",
                                "то у тебя все получится",
                                "и я буДу Писать тЕбЕ еще",
                                " ",
                                "чао"};
            Console.WriteLine(DecodeMessage(message));

            Console.ReadKey();
        }
    }
}
