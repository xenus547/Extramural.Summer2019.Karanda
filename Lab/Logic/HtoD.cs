using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public static class HtoD
    {
        public static int hexToDecimial(this string hexVal)
        {
            int len = hexVal.Length;

            // Initializing base1 value  
            // to 1, i.e 16^0 
            int base1 = 1;

            int dec_val = 0;

            // Extracting characters as 
            // digits from last character 
            for (int i = len - 1; i >= 0; i--)
            {
                // if character lies in '0'-'9',  
                // converting it to integral 0-9  
                // by subtracting 48 from ASCII value 
                if (hexVal[i] >= '0' &&
                    hexVal[i] <= '9')
                {
                    dec_val += (hexVal[i] - 48) * base1;

                    // incrementing base1 by power 
                    base1 = base1 * 16;
                }

                // if character lies in 'A'-'F' ,  
                // converting it to integral  
                // 10 - 15 by subtracting 55  
                // from ASCII value 
                else if (hexVal[i] >= 'A' &&
                         hexVal[i] <= 'F')
                {
                    dec_val += (hexVal[i] - 55) * base1;

                    // incrementing base1 by power 
                    base1 = base1 * 16;
                }
            }
            return dec_val;
        }
    }
}
