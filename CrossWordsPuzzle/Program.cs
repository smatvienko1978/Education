using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossWordsPuzzle
{
    class Program
    {
        public static List<string> crosswordPuzzle(List<string> crossword, string words)
        {
            var arr = GetIntArray(crossword);
            var vacantion = GetVacantion(arr);
            List<List<string>> combinations = GetCombinations(words);
              for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    var str = arr[i, j].ToString() + " ";
                    Console.Write(str);
                    Console.Write(str.Length < 3 ? " " : "");
                }
                Console.WriteLine();
                Console.WriteLine();
            }          
            foreach (var item in combinations)
                if (checkCombination(item, arr))
                    return item;




            return crossword;
        }

        private static List<List<string>> GetCombinations(string words)
        { /////////////////////   it's stub !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!11
            var result = new List<List<string>>();
            var parse = words.Split(';');
            var temp = parse.ToList<string>();
            result.Add(temp);
            return result;
        }

        private static bool checkCombination(List<string> words,  int[,] arr)
        {
            var board = new char[10, 10];
            var horisontalList = new List<List<int>>();// 1 numb - word, 2- line, 3- column, 4 length 
            var firstVerticalWord = GetFirstVerticalWordNumber(arr);
            horisontalList = PutHorizontalWords(words, arr, board, firstVerticalWord);
            var verticalList = PutVerticalWords(words, arr, board, firstVerticalWord);
            foreach (var item in horisontalList)
            {
                foreach (var it in item)
                    Console.Write(it + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            foreach (var item in verticalList)
            {
                foreach (var it in item)
                    Console.Write(it+ " ");
                Console.WriteLine();
            }
            ///////////////////////////////////////////////  write comparation
            return true;

        }

        private static List<List<int>> PutVerticalWords(List<string> words, int[,] arr, char[,] board, int firstVerticalWord)
        {////////////////////////////////////////////////////////////////////////////////////////////////////
            var result = new List<List<int>>();
           // result.Add(new List<int>() { 0 });//dumb
            for (int i = firstVerticalWord-1; i < words.Count; i++)
            {
                var word = words[i];
                for (int line = 0; line < 10; line++)
                {
                    var flag = false;
                    for (int column = 0; column < 10; column++)
                    {
                        if (arr[line, column] == i || (int)arr[line, column]/10 == firstVerticalWord )
                        {
                            WriteVerticalWords(word, board, line, column);
                            result.Add(new List<int>() { i, line, column, word.Length });
                            flag = true;
                            break;
                        }
                    }
                    if (flag) break;
                }
            }
        return result;
        }

        private static void WriteVerticalWords(string word, char[,] board, int line, int column)
        {
            for (int i = 0; i < word.Length; i++)
                board[line+i, column] = word[i]; ;
        }

        private static List<List<int>> PutHorizontalWords(List<string> words, int[,] arr, char[,] board, int firstVerticalWord)
        {
            var result = new List<List<int>>();
            //result.Add(new List<int>() { 0 });//dumb
            for (int i = 0; i < firstVerticalWord-1; i++)//////////////////////////////0?1
            {
                var word = words[i];
                for (int line = 0; line < 10; line++)
                {
                    var flag = false;
                    for (int column = 0; column < 10; column++)
                    {
                        if (arr[line,column]==i || arr[line, column] ==firstVerticalWord*10+i)
                        {
                            WriteHorizontalWords(word, board, line, column);
                            result.Add(new List<int>() { i, line, column, word.Length });
                            flag = true;
                            break;
                        }
                    }
                    if (flag) break;
                }
            }
            return result;        
        }

        private static void WriteHorizontalWords(string word, char[,] board, int startLine, int startColumn)
        {
            for (int i = 0; i < word.Length; i++)
                board[startLine, startColumn + i] = word[i];
        }

        private static int GetFirstVerticalWordNumber(int[,] arr)
        {
            int result=0;
            for (int i = 0; i < 10; i++)
            {
                bool flag = false;
                for (int j = 0; j < 10; j++)
                {
                    if (arr[i, j] > 10)
                    {
                        flag = true;
                        result = (int)Math.Floor((double)arr[i, j] / 10);
                        break;
                    }
                }
                if (flag) break;
            }

            return result;
        }

        private static List<int> GetVacantion(int[,] arr, int minLeghtword=2)
        {
            var result = new List<int>();
            //result.Add(0); //dumb for numeration at 1 
            //scan horisontal
            for (int i = 0; i < 10; i++)
            {
                var counter = 0;
                for (int j = 0; j < 10; j++)
                    if (arr[i, j] != -1)
                        counter++;
                if (counter > minLeghtword)
                {
                    result.Add(counter);
                    //fill number of word
                    for (int j = 0; j < 10; j++)
                        if (arr[i, j] != -1)
                            if (arr[i, j] == 0)
                                arr[i, j] = result.Count-1 ;
                    //else
                    //    arr[i, j] = arr[i,j] + (result.Count-1)*10;
                }
            }
            //scan vertical
            for (int j = 0; j < 10; j++)
            {
                var counter = 0;
                for (int i = 0; i < 10; i++)
                    if (arr[i, j] != -1)
                        counter++;
                if (counter > minLeghtword)
                {
                    result.Add(counter);
                    //fill 
                    for (int i = 0; i < 10; i++)
                        if (arr[i, j] != -1)
                            if (arr[i, j] == 0)
                                arr[i, j] = result.Count-1 ;
                            else
                                arr[i, j] = arr[i, j]  + (result.Count -1) * 10;
                }
            }

            foreach (var item in result)
                Console.WriteLine(item);

            return result;
        }

        private static int[,] GetIntArray(List<string> crossword)
        {
            var result = new int[10,10];
            for (int i = 0; i < 10; i++)
            {
                var line = crossword[i];
                for (int j = 0; j < 10; j++)
                    if (line[j] == '-')
                        result[i, j] = 0;
                    else result[i, j] = -1;
            }
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //        Console.Write(result[i, j] + " ");
            //    Console.WriteLine();
            //}
            return result;
        }

        static void Main(string[] args)
        {
            var crossword = new List<string>() {
                "+-++++++++",
                "+-++++++++",
                "+-++++++++",
                "+-----++++",
                "+-+++-++++",
                "+-+++-++++",
                "+++++-++++",
                "++------++",
                "+++++-++++",
                "+++++-++++"};

            var words = "LONDON;DELHI;ICELAND;ANKARA";
            var result = crosswordPuzzle(crossword, words);
            //foreach (var item in result)
            //    Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
