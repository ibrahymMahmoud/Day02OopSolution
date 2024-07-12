using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Overloading
    {
        public int sum(int y, int x)
        {
            return x+y;

        }
        public int sum(int y, int x, int z)
        {
            return x+y+z;

        }
        public int sum(int y, int x, int z, int e)
        {
            return x+y+z+e;

        }
        public double sum(double y, double x)
        {
            return x+y;

        }
    }
}
