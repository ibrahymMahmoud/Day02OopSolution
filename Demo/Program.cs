using Demo.inheritance;
using Demo.polymorphism_overriding;

namespace Demo
{
   
    internal class Program
    {
        static void Main(string[] args)
        {

            ///   Car car ;
            ///   //Declare for reference of type "car" ,refering to null
            ///   //CLR will allocate 4 bytes at stack for this reference "car"
            ///   //clr will allocate 0 bytes at heap
            ///   car = new Car(120 , 70 , "kia");
            ///   //allocate required numbers of bytes in heap for the allocated object
            ///   //initialize the allocated bytes of each and every attributes with the default value
            ///   //call user-defined constructor [if exists]
            ///   //assign the address of the allocated object in the heap to the referance
            ///
            ///   Console.WriteLine(car);

            #region Class Vs struct
            /*
             In C#, both classes and structs are reference types, but they have some key differences:

  1- Value vs. Reference Types:
         *Classes
            are reference types, meaning that when you create an instance of a class,
            you are creating a reference to an object in memory. 
            When you pass a class instance to a method or assign it to a variable, 
            you are passing a reference to the same object.

         *Structs
            are value types, meaning that when you create an instance of a struct,
            you are creating a copy of the data. When you pass a struct instance to a method or assign it to a variable,
            you are passing a copy of the data.

 2- Memory Allocation:
         *Classes 
            are allocated on the managed heap, which is part of the .NET runtime's memory management system. 
            This means that class instances can be garbage collected when they are no longer in use.

        *Structs 
            are allocated on the stack, which is a more efficient memory location for small, simple data structures. 
            Struct instances are not subject to garbage collection.

 3- Inheritance:
        *Classes 
            support inheritance, which allows you to create derived classes 
            that inherit properties and methods from a base class.

       *Structs
            do not support inheritance, but they can implement interfaces.

 4-Null Values:
        *Classes 
            can have null values, meaning that a variable of a class type can be assigned a null reference.

        *Structs 
            cannot have null values, as they are value types. 
            However, you can use the Nullable<T> type to create a struct that can have a null value.

 5-Performance:
        *Structs 
            are generally more efficient than classes for small, 
            simple data structures because they are allocated on the stack and do not require the overhead of the managed heap and garbage collection.
        *Classes 
            are better suited for more complex data structures and scenarios where reference semantics are important, 
             such as when you need to pass objects by reference or use polymorphism.
             
             */

            //The choice between using a class or a struct depends on the specific requirements of your application,
            //such as the size and complexity of the data,
            //the need for reference semantics,
            //and performance considerations.
            #endregion

            #region inheritance
            /// Child child1 = new Child(5, 10);
            /// child1.Z = 20;
            /// child1.ToString();
            /// child1.PrintX();
            #endregion


            #region PolyMorphism
            /*
             * PolyMorphism (overloading , override)
             *   Poly->Many
             *   Morphism->forms
             */

            #endregion

            #region Overloading
            ///  Overloading sum = new Overloading();
            ///  Console.WriteLine(sum.sum(5, 10));
            ///  Console.WriteLine(sum.sum(5, 10, 100));
            ///  Console.WriteLine(sum.sum(1, 2, 3, 4));
            ///  Console.WriteLine(sum.sum(5.5, 4.5));  
            #endregion


            #region override
           ///  OverrideChild o1 = new OverrideChild();
           ///  Console.WriteLine(o1.ToString()); 
           ///  o1.print();
            #endregion


        }
    }
}
