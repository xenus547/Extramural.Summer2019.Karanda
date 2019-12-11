using System;
using System.Text;

namespace Logic
{
    public static class NumbericManipulation
    {
        public static void Swap<T>(ref T lhs, ref T rhs)
        {
            T t = lhs;
            lhs = rhs;
            rhs = t;
        }

        public static string primeNum(this int n)
        {
            var sb = new StringBuilder();
            var count = 0u;
            var i = 0u;
            while (count < n)
            {
                if (IsPrimeNumber(i))
                {
                    sb.Append(i);
                    if (count < n - 1)
                    {
                        sb.Append(", ");
                    }
                    count++;
                }
                i++;
            }
            return sb.ToString();
        }

        public static bool IsPrimeNumber(uint n)
        {
            var result = true;

            if (n > 1)
            {
                for (var i = 2u; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
