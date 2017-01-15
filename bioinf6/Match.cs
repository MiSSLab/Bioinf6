using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bioinf6;

namespace bioinf6
{
    public class Match
    {
        protected AAlist list;
        protected char[] matched;
        protected List<string> queries;

        public Match(string aminoAcids, string regex)
        {
            list = new AAlist(aminoAcids);
            queries = regex.Split('-').ToList();
            matched = new char[20];
        }

        public override string ToString()
        {
            return string.Join(" ", list);
        }

        public char[] FindMatch()
        {
            for (int i = 0; i < list.Count(); i++)
            {
                int q = 0;
                int totalMatch = 0;
                string matching = "1";
                int l = i;

                while (matching != "0") //until all queries match
                {
                    matching = "0";
                    if (l < list.Count()) matching = list.Find(l, queries[q]);
                    if (matching.Length > 1) //in case of x(4)
                    {
                        for (int m = 0; m < matching.Length; m++)
                        {
                            matched[q + m] = matching[m];
                        }
                        totalMatch ++;
                        q ++;
                        l += matching.Length;
                    }
                    else if(matching.Length == 1 && matching !="0") //all other cases
                    {
                        matched[q] = matching.ToCharArray()[0];
                        totalMatch++;
                        q++;
                        l++;
                    }
                    if (totalMatch == queries.Count()) //all queries matched
                    {
                        return matched;
                    }
                }
            }
            matched = "No match.".ToCharArray();
            return matched;
        }
    }
}
