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
        public AAlist(string s)
        {
            this.list = s.ToCharArray();
        }
        public int Count()
        {
            return list.Count();
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

        public char Find(int l, string str)
        {
            //Console.WriteLine(str + " " + list[l]);
            if (str.StartsWith("["))
            {
                for (int s = 1; s < str.Length - 1; s++)
                {
                    if (list[l] == str[s]) return list[l];
                }
            }
            if (str.StartsWith("{"))
            {
                int check = 0;
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
            if (str.StartsWith("x"))
            {
                return list[l];
            }
            else if(str[0] == list[l])
            {
                return list[l];
            }
            else
            {
                return '0';
            }
        }
    }
}
