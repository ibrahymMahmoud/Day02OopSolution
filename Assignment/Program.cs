using System.Globalization;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Assignment
{
        /*Part02 Q1*/
    public enum Gender
    {
        Male =0 ,
        female
    }

    public enum SecurityLevel 
    {
        guest, 
        Developer, 
        secretary,
        DBA
    }

    class Employee
    {
        private int Id;
        private string Name;
        private SecurityLevel SecurityLevel;
        private Gender Gender;
        private decimal salary;
        private DateTime HireDate;

        public Employee( int Id , string Name , SecurityLevel SecurityLevel , Gender Gender , decimal Salary , DateTime HireDate )
        {
            this.Id = Id;
            this.Name = Name;
            this.SecurityLevel = SecurityLevel;
            this.Gender = Gender;
            this.salary = Salary;
            this.HireDate = HireDate;
        }
        public override string ToString()
        {
            return $"Employee ID: {Id}, Name: {Name}, " +
                   $"\nSecurity Level: {SecurityLevel}, " +
                   $"\nSalary: {salary.ToString("C" , new CultureInfo("en-US"))}," +
                   $"\nHire Date: {HireDate.ToShortDateString()}, " +
                   $"\nGender: {Gender}";
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            /*Part 02*/
            #region Q1

           /// Employee Emp1 = new Employee(
           ///     1,
           ///     "Hema",
           ///     SecurityLevel.Developer,
           ///     Gender.Male,
           ///     21_000,
           ///     new DateTime(2024,12,24)
           ///     );
           /// Console.WriteLine( Emp1.ToString());
           

            #endregion
        }
    }
}
