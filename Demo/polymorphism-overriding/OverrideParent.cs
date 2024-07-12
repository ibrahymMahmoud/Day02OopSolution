using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.polymorphism_overriding
{
    internal class OverrideParent
    {
        private int _id;
        private string? _name;
        public void print()
        {
            Console.WriteLine("print from parent");
        }

        public virtual void overriding() 
        {
            Console.WriteLine("hello from parent");
        }

        public override string ToString()
        {
            return $"id= {this._id}\nname= {this._name}";
        }

        

    }
}
