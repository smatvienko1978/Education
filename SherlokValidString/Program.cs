using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlokValidString
{
    class Program
    {
        public static string isValid(string s)
        {
            int[] sFreq = new int[26];
            sFreq.Initialize();

            foreach (var ch in s)
                sFreq[ch - 97]++;

            foreach (var item in sFreq)
                Console.Write(item + " ");
            Console.WriteLine();
            var result = 0;


            
            var avg = 0;
            var max = 0;
            var freq = new Dictionary<int, int>();
            foreach (var item in sFreq)
            {
                if (item == 0)
                    continue;
                if (freq.ContainsKey(item))
                    freq[item]++;
                else
                    freq[item] = 1;
            }

            foreach (var item in freq)
            {
                Console.WriteLine(item);
                if (item.Value > max)
                {
                    avg = item.Key;
                    max = item.Value;
                }

            };


            Console.WriteLine(avg);
            foreach (var item in sFreq)
            {
                if (item == 0 || item==avg)
                    continue;

                if (Math.Abs(item - avg) > 1 && item>1)
                    return "NO"; 
                result++;
            }
            Console.WriteLine(result);
            return result>1?"NO":"YES";

        }

        static void Main(string[] args)
        {
            /// Console.WriteLine(isValid("aabbccddeefghi")); //NO
            //Console.WriteLine(isValid("aaaabbcc"));//NO
            Console.WriteLine(isValid("ibfdgaeadiaefgbhbdghhhbgdfgeiccbiehhfcggchgghadhdhagfbahhddgghbdehidbibaeaagaeeigffcebfbaieggabcfbiiedcabfihchdfabifahcbhagccbdfifhghcadfiadeeaheeddddiecaicbgigccageicehfdhdgafaddhffadigfhhcaedcedecafeacbdacgfgfeeibgaiffdehigebhhehiaahfidibccdcdagifgaihacihadecgifihbebffebdfbchbgigeccahgihbcbcaggebaaafgfedbfgagfediddghdgbgehhhifhgcedechahidcbchebheihaadbbbiaiccededchdagfhccfdefigfibifabeiaccghcegfbcghaefifbachebaacbhbfgfddeceababbacgffbagidebeadfihaefefegbghgddbbgddeehgfbhafbccidebgehifafgbghafacgfdccgifdcbbbidfifhdaibgigebigaedeaaiadegfefbhacgddhchgcbgcaeaieiegiffchbgbebgbehbbfcebciiagacaiechdigbgbghefcahgbhfibhedaeeiffebdiabcifgccdefabccdghehfibfiifdaicfedagahhdcbhbicdgibgcedieihcichadgchgbdcdagaihebbabhibcihicadgadfcihdheefbhffiageddhgahaidfdhhdbgciiaciegchiiebfbcbhaeagccfhbfhaddagnfieihghfbaggiffbbfbecgaiiidccdceadbbdfgigibgcgchafccdchgifdeieicbaididhfcfdedbhaadedfageigfdehgcdaecaebebebfcieaecfagfdieaefdiedbcadchabhebgehiidfcgahcdhcdhgchhiiheffiifeegcfdgbdeffhgeghdfhbfbifgidcafbfcd"));//YES

            Console.ReadKey();
        }
    }
}
