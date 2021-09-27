using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_TextEditor
{
    class Program
    {
        //public static void DoIt(List<string> operationList)
        //{
        //    var str = new StringBuilder();
        //    var strUndo = new Stack<string>();

        //    foreach (var item in operationList)
        //    {
        //        var line = item.Split(' ');
        //        if (line[0] == "1")
        //        {
        //            strUndo.Push(str.ToString());
        //            str.Append(line[1]);
        //        }
        //        if (line[0] == "2")
        //        {
        //            strUndo.Push(str.ToString());
        //            int numberDeletes = int.Parse(line[1]);
        //            str.Remove(str.Length - numberDeletes, numberDeletes);
        //        }
        //        if (line[0] == "4")
        //        {
        //            str.Clear();
        //            str.Append(strUndo.Pop());
        //        }

        //        if (line[0] == "3")
        //        {
        //            int numberPrints = int.Parse(line[1]);
        //            Console.WriteLine(str.ToString()[numberPrints-1]);
        //        }
        //    }
        //}  
        static void Main(string[] args)
        {
            //var Q = int.Parse(Console.ReadLine());
            //var operationList = new List<string>();
            //for (int i = 0; i < Q; i++)
            //    operationList.Add(Console.ReadLine());

            //var str = new StringBuilder();
            //var strUndo = new Stack<string>();
            //var line = new string[2];
            //var output = new StringBuilder();

            foreach (var item in operationList)
            {
                line = item.Split(' ');
                if (line[0] == "1")
                {
                    strUndo.Push(str.ToString());
                    str.Append(line[1]);
                }
                if (line[0] == "2")
                {
                    strUndo.Push(str.ToString());
                    int numberDeletes = int.Parse(line[1]);
                    str.Remove(str.Length - numberDeletes, numberDeletes);
                }
                if (line[0] == "4")
                {
                    str.Clear();
                    str.Append(strUndo.Pop());
                }
                if (line[0] == "3")
                {
                    int numberPrints = int.Parse(line[1]);
                    output.Append(str.ToString()[numberPrints - 1]);
                    output.Append("\n");
                }
            }
            Console.WriteLine(output.ToString());
        }

       
    }
}
