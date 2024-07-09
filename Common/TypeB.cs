using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB : TypeA
    {
        TypeA TypeA= new TypeA();
        public TypeB()
        {
            //x is private can't access
            //y is private can't access,can access if  their inherit and same file
            //z is private can't access,can access if  their inherit
            //w is can access if in the same file,can access if  their inherit in same file (interinal) else (private)
            //s is access only in the same file
            //b is can access anywhere
            
        }
    }
}
