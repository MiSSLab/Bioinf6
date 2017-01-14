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

            //Pattern query = new Pattern(regex);
            Sequence AAsequence1 = new Sequence(str1, regex);
            AAsequence1.Match();

            //Console.WriteLine(query.ToString());
            Console.WriteLine(AAsequence1.ToString());
            Console.ReadLine();
        }
    }
}
