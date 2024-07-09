using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Car
    {
		private int id;

		private double speed;

		private string? name;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}
        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public string? Name
        {
            get { return name; }
            set { name = value; }
        }
        //if no user-defined constructor exists, compiler will always generate empty parameterless constructor
        //if you define a constructor, compiler will no longer generate empty parameterless constructor

        public Car()
        {
            Console.WriteLine("empty constructor");
        }
        public Car( int id , double speed , string name):this(5,150)
        {
            Console.WriteLine("pramterise constructor");
            this.id = id;
            this.speed = speed; 
            this.name = name;
        }
        public Car(int id , double speed)
            //constructor chaining
        {
            this.id = id;
            this.speed = speed;
            this.name = "BMW";
            Console.WriteLine("second constructor");
        }
        // constructor overloading
        public override string ToString()
        {
            return $"Id = {id}\nSpeed = {speed}\nName = {name}";
        }

    }
}
