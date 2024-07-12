using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Binding
{
    public class TypeA
    {
        public int A;
        public TypeA(int A)
        {
            this.A = A;
        }
        public void Fun01()
        {
            Console.WriteLine("i'm base [parent]");
        }
        public virtual void Fun02()
        {
            Console.WriteLine($"TypA: A=  {A}");
        }
    }

    public class TypeB : TypeA 
    {
        public int B;
        public TypeB(int A , int B):base( A)
        {
            this.B = B;
        }
        public new void Fun01()
        {
            Console.WriteLine("i'm child [typeB]");
        }
        public override void Fun02()
        {
            Console.WriteLine($"TypB: A=  {A} , B= {B}");
        }
    }
    public class TypeC : TypeB 
    {
        public int C;
        public TypeC(int A , int B , int C ):base(A,B)
        {
            this.C = C;
        }
        public new void Fun01()
        {
            Console.WriteLine("i'm child [typeC]");
        }
        public override void Fun02()
        {
            Console.WriteLine($"TypC: A=  {A} , B= {B} , C= {C}");
        }
    }

    public class TypeD : TypeC 
    {
        public int D;
        public TypeD(int A , int B , int C , int D):base(A, B,C)
        {
            this.D = D;
        }
        public new void Fun01()
        {
            Console.WriteLine("i'm child [typeD]");
        }
        public new virtual void Fun02()
        {
            Console.WriteLine($"TypD: A=  {A} , B= {B} , C= {C} , D= {D}");
        }
    }
    public class TypeE : TypeD 
    {
        public int E;
        public TypeE(int A , int B , int C , int D , int E):base(A,B,C,D)
        {
            this.E = E;
        }
        public new void Fun01()
        {
            Console.WriteLine("i'm child [typeE]");
        }
        public override void Fun02()
        {
            Console.WriteLine($"TypE: A=  {A} , B= {B} , C= {C} , D= {D} , E= {E}");
        }
    }

}
