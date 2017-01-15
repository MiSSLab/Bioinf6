using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bioinf6
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = "[RK]-G-{EDRKHPCG}-[AGSCI]-[FY]-[LIVA]-x-[FYM]";
            var str1 = "SRSLKMRGQAFVIFKEVSSAT";
            var str2 = "KLTGRPRGVAFVRYNKREEAQ";
            var str3 = "VGCSVHKGFAFVQYVNERNAR";

            Sequence AAsequence1 = new Sequence(str1, regex);
            Sequence AAsequence2 = new Sequence(str2, regex);
            Sequence AAsequence3 = new Sequence(str3, regex);

            char[] result1 = AAsequence1.Match();
            char[] result2 = AAsequence2.Match();
            char[] result3 = AAsequence3.Match();

            Console.WriteLine(str1);
            Console.WriteLine(result1);
            Console.WriteLine(System.Environment.NewLine);

            Console.WriteLine(str2);
            Console.WriteLine(result2);
            Console.WriteLine(System.Environment.NewLine);

            Console.WriteLine(str3);
            Console.WriteLine(result3);

            Console.ReadLine();
        }
    }
}
