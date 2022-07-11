using System;

namespace DataTypes_Lib
{
    public class TypeConversion
    {
        public static short UIntToShort(uint num)
        {
            short result = Convert.ToInt16(num);
            return result;
        }

        public static long FloatToLong(float num)
        {
            long result = Convert.ToInt64(num);
            return result;
        }
    }
}
