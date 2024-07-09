using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.inheritance
{
    internal class Parent
    {
        private int x;
        private int y;
        public int X { get; set; }
        public int Y { get; set; }
        
        public Parent(int x , int y)
        {
            this.X = x;
            this.Y = y;
            Console.WriteLine("hello from parent");
        }
        public void PrintX()
        {
            Console.WriteLine($"x= {x}\nz= {this.y}");
        }

        public override string ToString()
        {
            return $"x= {this.x}\ny= {this.y}";
        }



    }
}
