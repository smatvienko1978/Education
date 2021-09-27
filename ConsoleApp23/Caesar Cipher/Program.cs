using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    class Program
    {
        public static string caesarCipher(string s, int k)
        {
            while (k > 26)
                k = k - 26;
            var arr = new StringBuilder();
            foreach (char ch in s)
            {
                if (Char.IsLetter(ch))
                {
                    int temp = (int)ch;
                    temp = temp + k;

                    if (temp > 90 && Char.IsUpper(ch))
                        temp = temp - 90+64;
                    if (temp > 122 && Char.IsLower(ch))
                        temp = temp - 122+96;
                    arr.Append((char)temp);
                }
                else
                    arr.Append(ch);
            }
            return arr.ToString();
        }

        static void Main(string[] args)
        {
            var result = caesarCipher("!m-rB`-oN!.W`cLAcVbN/CqSoolII!SImji.!w/`Xu`uZa1TWPRq`uRBtok`xPT`lL-zPTc.BSRIhu..-!.!tcl!-U", 62);
            //!w-bL`-yX!.G`mVKmFlX/MaCyyvSS!CSwts.!g/`He`eJk1DGZBa`eBLdyu`hZD`vV-jZDm.LCBSre..-!.!dmv!-E
            Console.WriteLine(result);

            
            Console.ReadKey();
        }
    }
}
