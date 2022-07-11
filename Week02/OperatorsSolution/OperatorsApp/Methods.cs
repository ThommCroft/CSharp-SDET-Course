using System;

namespace OperatorsApp
{
    public class Methods
    {
        public static int GetStones(int totalPounds)
        {
            int poundsInStone = 14;
            return totalPounds / poundsInStone;
        }

        public static int GetPounds(int totalPounds)
        {
            int poundsInStone = 14;
            return totalPounds % poundsInStone;
        }
    }
}
