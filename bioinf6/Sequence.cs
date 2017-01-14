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
        protected List<char> matched;
        protected List<string> queries;

        public Sequence(string aminoAcids, string regex)
        {
            list.CreateAAlist(aminoAcids);
            queries = regex.Split('-').ToList();
        }

        public override string ToString()
        {
            return string.Join(" ", list);
        }

        private bool Containing(List<string> s)
        {
            return true;
        }

        public List<char> Match()
        {
            for(int i = 0; i < queries.Count; i++)
            {
                if (list.Contains(queries[i])){
                    char matching = list.Find(queries[i]);
                    matched.Add(matching);
                }
            }
            return matched;
        }
    }
}
