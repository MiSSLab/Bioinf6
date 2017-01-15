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
            list = s.ToCharArray();
        }

        public int Count()
        {
            return list.Count();
        }

        public string Find(int l, string str)
        {
            if (str.StartsWith("["))
            {
                for (int s = 1; s < str.Length - 1; s++)
                {
                    if (list[l] == str[s]) return list[l].ToString();
                }
            }
            if (str.StartsWith("{"))
            {
                int check = 0;
                for (int s = 1; s < str.Length - 1; s++)
                {
                    if (list[l] == str[s]) check = 1;
                }
                if (check == 0) return list[l].ToString();
            }
            if (str.StartsWith("x"))
            {
                if (str.Length == 1)
                {
                    return list[l].ToString();
                }
                else //x(3)
                {
                    string result = "";
                    int number = Int32.Parse(str[2].ToString());
                    for (int i = 0; i < number; i++)
                        result += list[l + i].ToString();
                    return result;
                }
            }
            else if(str[0] == list[l])
            {
                if (str.Length == 1) //G
                {
                    return list[l].ToString();
                }
                else
                {
                    if (str.Contains(",")) //G(2,4)
                    {
                        int counter = 0;
                        int minNumber = Int32.Parse(str[2].ToString());
                        int maxNumber = Int32.Parse(str[4].ToString());
                        string result = "";
                        for (int i = 0; i < maxNumber; i++)
                        {
                            if (list[l + i] == str[0]) counter++;
                            result += str[0];
                        }
                        if (counter >= minNumber && counter <= maxNumber) return result;
                    }
                    else //G(4)
                    {
                        int counter = 0;
                        int number = Int32.Parse(str[2].ToString());
                        string result = "";
                        for (int i = 0; i < number; i++)
                        {
                            if (list[l + i] == str[0]) counter++;
                            result += str[0];
                        }
                        if (counter == number) return result;
                    }
                }
            }
            return "0";
        }
    }
}
