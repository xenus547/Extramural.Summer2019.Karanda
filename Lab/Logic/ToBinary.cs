using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public static class ToBinary
    {
        public static string ToB(this int value)
        {
            var builder = new StringBuilder();

            char sign = value >= 0 ? ' ' : '-';

            value = Math.Abs(value);

            while (value != 0)
            {
                char unit = value % 2 == 0 ? '0' : '1';

                builder.Append(unit);

                value /= 2;
            }

            builder.Append(sign);

            for (int i = 0; i < builder.Length / 2; i++)
            {
                char tmp = builder[i];

                builder[i] = builder[builder.Length - i - 1];

                builder[builder.Length - i - 1] = tmp;
            }

            return builder.ToString();
        }
    }
}
