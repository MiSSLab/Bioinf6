using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bioinf6
{
    public class AAlist
    {
        protected IList<char> list;
        protected List<char> matched;
        public void CreateAAlist(string s)
        {
            list = s.ToCharArray();
        }
        public bool Contains(string str)
        {
            if (str.StartsWith("["))
            {
                for(int l = 0; l < list.Count; l++)
                {
                    for (int s = 1; s < str.Length - 1; s++)
                    {
                        if(list[l] == str[s]) return true;
                    }
                }
            }
            if (str.StartsWith("{"))
            {
                int check = 0;
                for (int l = 0; l < list.Count; l++)
                {
                    for (int s = 1; s < str.Length - 1; s++)
                    {
                        if (list[l] == str[s]) check = 1;
                    }
                }
                if(check == 0) return true;
                else return false;

            }
            if (str.StartsWith("x"))
            {
                return true;
            }
            if(list.ToString().Contains(str)) return true;
            else return false;
        }

        public char Find(string str)
        {
            if (str.StartsWith("["))
            {
                for (int l = 0; l < list.Count; l++)
                {
                    for (int s = 1; s < str.Length - 1; s++)
                    {
                        if (list[l] == str[s]) return list[l];
                    }
                }
            }
            if (str.StartsWith("{"))
            {
                int check = 0;
                for (int l = 0; l < list.Count; l++)
                {
                    for (int s = 1; s < str.Length - 1; s++)
                    {
                        if (list[l] == str[s]) check = 1;
                    }

                    if (check == 0)
                    {
                        return list[l];
                    }
                    else
                    {
                        check = 0;
                    }
                }
            }
            if (str.StartsWith("x"))
            {
                return list[0];
            }
            else
            {
                return '0';
            }
        }
    }
}
