using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association_Aggregation
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee[] employees { get; set; }
        public Department( string Name)
        {
            this.Name = Name;
        }
        public Department( string Name , Employee[] employees)
        {
            this.Name=Name;
            this.employees = employees; 
        }
    }
}
