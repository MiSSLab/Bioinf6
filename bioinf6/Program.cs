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

            Match m1 = new Match(str1, regex);
            Match m2 = new Match(str2, regex);
            Match m3 = new Match(str3, regex);

            char[] result1 = m1.FindMatch();
            char[] result2 = m2.FindMatch();
            char[] result3 = m3.FindMatch();

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
