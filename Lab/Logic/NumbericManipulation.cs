using System;

namespace Logic
{
    public class NumbericManipulation
    {
        public static void Swap<T>(ref T lhs, ref T rhs)
        {
            T t = lhs;
            lhs = rhs;
            rhs = t;
        }
    }
}
