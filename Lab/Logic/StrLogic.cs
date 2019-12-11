using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public static class StrLogic
    {
        public static string ReverceString(this string str)
        {
            StringBuilder sb = new StringBuilder(str.Length);
            for (int i = str.Length; i-- != 0;)
                sb.Append(str[i]);
            return sb.ToString();
        } 

        public static string firstLatterBig(this string str)
        {
            var sb = new StringBuilder(str.Length);
            bool inWord = false;
            foreach (var c in str)
            {
                if (char.IsLetter(c))
                {
                    if (!inWord)
                        sb.Append(char.ToUpper(c));
                    else
                        sb.Append(c);
                    inWord = true;
                }
                else
                {
                    sb.Append(c);
                    inWord = false;
                }
            }
            return sb.ToString();
        }
    }
}
