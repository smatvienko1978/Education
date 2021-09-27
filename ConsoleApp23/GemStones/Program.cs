using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemStones
{
    class Program
    {
        public static int gemstones(List<string> arr)
        {
            var result = 0;
            var countedElements = new List<char>();

            if (arr[0] == null || arr[0].Length == 0)
                return 0;
            var elements = arr[0].ToCharArray();
            foreach (var item in elements)
            {
                var temp = 0;
                for (int i = 0; i < arr.Count; i++)
                    if (arr[i].Contains(item))
                        temp++;
                if (temp == arr.Count && !countedElements.Contains(item))
                {
                    countedElements.Add(item);
                    result++;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            var str = @"xhsbaqwbokcaqbkhrzddydwirmldcr
kwkbkhlwmlpuomfaenahhnnpgqpkcxlspbomrweoqq
rtdckeukfoppbsiccflxqcoxrhwnxpwyjsrvjngqmbgqfwahhkzcbifrvpamffoxcetdochazcqsqhazndwdk
cakdnrducighyuuemxhqmujauwxabextkdamxybkoyexmdmlyvnmlrwwrt
czuzxlzrmuaa
gquymxuabmymtnljadbqxjsipnixbyhwhaoaciinwdhppbpyxswcveddpojlopqsuqsvjhpobpdefuj
abtwcqoib
vqpgcuwvxdlaquaiwydejgpwvpwdjeybgbtienzijzeah
shrcvpgwzdkfcvpmjeuslonwerklxysafwgeurdnshmzunpaxmgfiwsehowfyjboeahpuqlatcmooenlicnrkhcbkl
jcvcatdtubemfmjqfplxgwkqeuyderpznnqhvvpjafnceutugnixltiyrmnptcxpvqadnpowacsuoucwmfgbkzs
ufaqewahvnqsbpqw
jzecprvdbgyxmhslqdxjsqnmdoavvifebqrtklohndgvkemackgmgtpkhqetqybxnpiyvlebovhbwivctrruc
wrhighznjjppsvmsxmtwtnphaxqmyjwtxrrfqxrurbengtrvgmeaxfodwtfucmdeasgzuxkghhjexblancvzd
hluadkczkazvptpjwwempwfpacbnfmhrzghznjln
znizntdoqtqabqvykqvnglbgkmclrzajsqwxnshlzalzfbalkxoxpsmtoon
paws
nwtsbxdtyqlapasbazttbsguceyqjvebxdjnfdw
kxafenseotsysgeswrtpzibyamlhbjknlcoveihukdebfbwsaqmzvdlaytfilpcqkspdwnysdfjvwdtlsqactcrelzzhxqxzv
yqaaayknxwnbmzkictawsgxeq
aaqkpvmiiho
ybnnrikqjybxrawihgyxiegxcimriyqrrgcxsfeidnhwfxjnpzxhloav
pjpdtrolhxvfrftvuweatcisajvqkaqqmblwugegmbpteukwxvoebpemcjquuvlrqkczeabuhmss
epgmbfpdjktvkbiczmumnoirupbasdvxpjhsocxaewcxkquxjolcqwjwnqtnirgsi
hjvkyhlyuqrsoonfqlyxlenoszrlquqsyjwrufuretagpuq
oaqdya
ikqnbkmmaoxqjmrmxupfaycfwxwzeldjynafrjdkulsvqweciuyukxnmzriseziuqxoxif
jgabqaqhwashxvki
xrryvkqfkossukeieayukmycfusyrikiotoiutvykatijjjzrioys
uaepqfgaevkewfmyhdmfeifsheilwfusmlnrpjtaeathypaql
pkzqkqvlgadoatqdwhgwkehalzrfawkxlivimioralfsnwqyhampnhqhdgssoo
lyqmibiheakvntaijqiwviwadksmxewhzejpkhdlbisqxmaqcmxctkfvqo
zgylpetfogykwgypzyoxjcuglfcawxubtqnteyvajnafzznmojnhovohsaowhuqpwhlydmtzwvrirjknynsiijivpqguabg
eftqjvctdzhxqbupfkwppcsrujgrziuelxozbzzcrcfbghqzdftctzfxgvmevyvbdbfigsykevjanvlaoepmqedufn
aotiefuigarhpgsghcptscko
pfrqhzapxgeltxikswnocynfguafqsigbpwehbfywndxbxaupzbdggshjocvowitjvunospmtzudcpl
yqzudnoqenlskxakuummlvkefmljvteacihzapaabuvjyjgodptyavvupptmvypvhnta
solabz
vxlaetxbklmxztfkozbzlolqr
wvcga
wahauykchejjiyikfwxzsbufdegpovkrbpampyuuhsaqzcnybbjzajjjrbszvbvdpyhbccwsjmnoztlejpffnzfytrdppsjrpvxx
cxkhanwweqhcjttjorgjocdfknajxbtbsucabin
oya
bznssnvxqvhhsqtmvluzmafqhftmorixkanbsixebrjqucgatepukzivhyhwxzfhgqztqtizkftvthyqjec
bbrjqukyipcnrhirhvcsmzgftpxtvehmfiizhorionzyhqdxodpaazjducjoqowtwzspfs
cnznakegiobpzqlzgyicllqwgrscxedu
hmofrxma
adh
oxa
bglhbygsyapztwrxjedcvpctvilcazozpralyodujolkixitrxwimazwnxmglwvkem
rgiyigzujasnsovsjjaqizcomxakticqyqdpdughlyuazpnfbmcgnveiemsybfdg
rioajgayihhagpcrj
zqgipdddjqxctpdzqiwzxwvxnwoxstodzcwgergfiiaizebhktlvrizzkomimalfbsxkduavkjxaoairfh
kgjdzysfkxmetkaoylyskcqlqtfzyayyyudxsknzxrcyujmwbnbkbtsfgitrrawfxzjthyfmgckgjqespdifqtpxjbgnvr
hiagaaeynarcvstegt
yadxdlavbxptwglaiayoowuogvvtgcfywluubqtkzrrhfxlovgef
hlypqfdiqlfnkllzouulioezroipxqdlsxwanwykvbcldhoetaeztgrootpjojcceuacwtzqagqamcvgfdednqczyvbtdx
zisguwmsaxhxuwjmhyfzuwiipggmwdouo
lbwzvwermrlvcmklemjkfrbljlnxrtizbyeikrgwjjptnzumttueabagmxizruareaeykxpblhrxcdyncqvpvcunwnfxzmpgys
prttjtiytlyyrultdkkpltjieolromizxwjfesyslnlxawtuxfiykdjobvoaeehfvxanlqzpkznggwkteeevlvsshvptayxvmttl
qgkpbaajagtvqiyiaodlrsikonhfwakpjdcbtalsxcjvbedvcempmvoeenrignubtaslxftwagdiobnevqzvqva
faedrfxkahlcgoilakrcyivijzutjlrdumyufckvt
vau
hbvbxfjzegevcqgaphablnsmlbsoeqmaioprbvtddsupvnqngwmxcpflvuafxpvd
brtfnusycjisbcphougpjdvauguelqkzipcuijeoy
ichepvyzntaev
zenwbsywgmpiutpzcjlaatkzmgobpxbcxmuxarykyoeqdx
lfluwbfavxkugqlwyxasngjzsdsyjpgeydajtolqsx
bhczkeeqzhzbartmeqpaqruysxjzaauoiqktopalvmdktikkldlrjllmcdpoygeiyukptponoihbsrrfvjfhoce
zap
ruiospjscgsufpnqkxkyykawjzwkczikahsyzauktafln
lreuxplanxvcqitroicfi
ohfaufeligmwtcsawktgxwtplivubrwmcjbqwgkcoxjyjwheidyqthgkoakhewhnwkvcatqpbwsqfkiqabjjonykglqwbswfyt
vocqooogtaicbhuaiupuipleufvdccabmfywoykochscytztchknyorlocfdntwwovefaq
xdmyaggpho
nscoqroxhdadpeuycosccvsnmtuugabmctqjeirzc
jhhlrbgojnrllgdewjvleyqdbfqvnjykfdjlxswwqeacczilgonlysaeqjghqpmwulkpupahsbbwihayahdfljjfgedri
mnfhtdoelgcismveynwpedfgqiosyjadntdewxlufoqorroevrcv
tzcetubjznmepihqloxfevhnyxhoytayxpkjvsgtmpkcimescblehhpgtbrngbwaufvjoqprgipwbahzkhjxfjxruqegcjgwgn
pvcuauizaozvhsbtwgxihosfgjazpahwkai
zsgkakcjezqvrqokvtgvecfgykwmvdpnapvjsuglckolshfiawxkogumzwiverjxpoyyuyhmopglvvfyuwa
rfywidpltzdddyrhorkbfanakjjbfyhs
liwgcigsdsyglkbefvbraoaexrprytclpvbwwpppouxbcmhpzswfkuhbkbzhymrceewbsdjsugwznmouri
epaotrdpredwowbjpafkswggzhhzigjcrkvlpbqgucvaprkskwilfmgzyqiijibzvteiujzjqeankernianranftzkoafyzrj
ntvvsjszkygncqfabnbajpmibfykwgyfaloozaoohtvnxclgsxjnlyvhvg
bpsbesgxuufgaxsmcyhbfgfmzcyaxwizbmoyecacp
mjootlmwwumapdrjmbhayptf
kbrna
xgooaibxlpjfotxwfgjtomwpjhmvjliubjavgjizaudpta
cclrtzxwjsybpazszlbhwewuqbathpvrstemsdfqxblzlgblgkdrvpwitgqykmduvyapqw
jsnpkdnmgpxgayihlblrxdpwqrctzvzoaylituwbiojtfuhfkpaggsbmqjaddmfjhaqpscyxpznwhlbxnp
afclnupiwlgqchkdahacm
ghibvbwuorvaubjkwphqghpzzqhgqhagzgsrtoouxefpckwvcndwlxjnpzzliqeeduqlezlayvdvzfstzpyomdyx
cabazene
iccteslmzahdvafdufaiactlgghsqqsayzalvyvfznwwiwgdshqrzgukgdqswm
va
evcmyciioxyggjpyeojrptzrfijszfargbtqjwyyseijzehgzlwhrresgbnpmzmasx
gadtslngjkipbhdzfeypofxqdycmornqzwjucxsslvjhrmewcljekmeqtjaimjmxasyfbpjhkvgugmwkjyylygswjehflhwxv
dpcazx
mqakmgqxwqmj
ombmwzjgntuvvhulglygpoqswngfedmdlywxqwjrpcyokultptfzmxpbflshggoycfaanaezburiqsphbzeqzbhkfykaemgsgu";
            var parse = str.Split('\r');
            var arr = parse.ToList<string>();
            //var arr = new List<string>() { "abcdde", "baccd", "eeabg"}; //2
            Console.WriteLine(gemstones(arr));

            Console.ReadKey();
        }
    }
}
