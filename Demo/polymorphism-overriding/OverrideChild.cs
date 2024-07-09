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
        {
            Console.WriteLine("print from child");
        }
        public override void overriding()
        {
            Console.WriteLine("hello from child");
        }

        public override string ToString()
        {
            return $"{base.ToString} ans child";
        }

    }
}
