using System;
using System.Collections.Generic;
using System.Linq;

namespace SaffariParkApp
{
    public struct Point3D
    {
        public int x, y, z;

        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public int SumOfPoints()
        {
            return x + y + z;
        }
    }
}
