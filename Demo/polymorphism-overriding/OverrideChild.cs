using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.polymorphism_overriding
{
    class OverrideChild : OverrideParent
    {
        public new void print()
            //static binding 
            //at compiletion time
        {
            Console.WriteLine("print from child (overried by new)");
        }
        public override void overriding()
            //dynamic binding
            //at runtime
        {
            Console.WriteLine("hello from child (overrided virtual)");
        }

        public override string ToString()
        {
            return $"{base.ToString} ans child";
        }

    }
}
