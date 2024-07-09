using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.inheritance
{
    internal class Child : Parent
    {
        
        private int z;

        public int Z
        {
            get { return z; }
            set { z = value; }
        }

        public int X { get; set; }
        public int Y { get; set; }
        public Child(int x , int y):base(x , y)
            // constructor chaining
        {
            Console.WriteLine("hello from child");

        }

        public override string ToString()
            //can copy virtual property
        {
            return $"{base.ToString()} \nz= {this.z}";
        }

        public  new void PrintX()
            // can't override on property not virtual
            // so new to take new copy of it
        {
            Console.WriteLine($"z= {this.z}");
        }

    }
}
