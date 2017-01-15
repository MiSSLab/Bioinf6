using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bioinf6;

namespace bioinf6
{
    public class Sequence
    {
        protected AAlist list;
        protected char[] matched;
        protected List<string> queries;

        public Sequence(string aminoAcids, string regex)
        {
            list = new AAlist(aminoAcids);
            queries = regex.Split('-').ToList();
            int length = queries.Count();
            matched = new char[length];
        }

        public override string ToString()
        {
            return string.Join(" ", list);
        }

        public char[] Match()
        {
            if (list != null)
            {
                for (int i = 0; i < list.Count(); i++)
                {
                    //Console.WriteLine("------------------" + i);
                    int q = 0;
                    int totalMatch = 0;
                    char matching = '1';
                    int l = i;
                    while (matching != '0')
                    {
                        matching = '0';
                        matching = list.Find(l, queries[q]);
                        //Console.WriteLine(matching);
                        matched[q] = matching;
                        totalMatch++;
                        q++;
                        l++;
                        if (totalMatch == queries.Count())
                        {
                            //Console.WriteLine(matched);
                            return matched;
                        }
                    }
                }
            }
            return matched;
        }
    }
}
