using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeA
    {
        private int x;              //access only in this scope of class
        private protected int y;    //the class who inherit this class inherit y but private
        protected int z;            //access only the class and driven class
        internal protected int w;   //class who inherit this class inherit w internal if in the same file private if another file
        internal int s;             //can access on the same file
        public int b;               //can access on any files
    }
}
