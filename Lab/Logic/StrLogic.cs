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
    }
}
