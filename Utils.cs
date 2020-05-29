using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome_v1
{
    class Utils
    {
        public static String IntToHexString(int n, int len)
        {
            char[] ch = new char[len--];
            for (int i = len; i >= 0; i--) ch[len - i] = ByteToHexChar((byte)((uint)(n >> 4 * i) & 15));
            return new String(ch);
        }

        public static char ByteToHexChar(byte b)
        {
            if (b < 0 || b > 15)
                throw new Exception("IntToHexChar: input out of range for Hex value");
            return b < 10 ? (char)(b + 48) : (char)(b + 55);
        }
    }
}
