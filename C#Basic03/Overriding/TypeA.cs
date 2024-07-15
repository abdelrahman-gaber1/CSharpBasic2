using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic03.Overriding
{
    public class TypeA
    {
        public int A {  get; set; }
        public TypeA(int _a)
        {
            A = _a;
        } 
        public void MyFunc01()
        {
            Console.WriteLine("I am Base");
        }
        public virtual void MyFunc02()
        {
            Console.WriteLine($"TypeA : A {A}");
        }
    }
    public class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int _a, int _b) : base(_a)
        {
            B = _b;
        }
        public new void MyFunc01()
        {
            Console.WriteLine("I am Child");
        }
        public override void MyFunc02()
        {
            Console.WriteLine($"TypeB : B {B} ");
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }

    class TypeC : TypeB
    {
        public int C { get; set; }

        public TypeC(int _a , int _b , int _c) : base(_a , _b)
        {
            C = _c;
        }
        public new void MyFunc01()
        {
            Console.WriteLine("I am grand Child");
        }
        public override void MyFunc02()
        {
            Console.WriteLine($"TypeC : C {C} ");
        }
    }
    class TypeD : TypeC
    {
        public int D { get; set; }

        public TypeD(int _a, int _b, int _c , int _d) : base(_a, _b, _c)
        {
            D = _d;
        }
        public new void MyFunc01()
        {
            Console.WriteLine("I am grand Child");
        }
        public new virtual void MyFunc02()
        {
            Console.WriteLine($"TypeD : D {D} ");
        }
    }

    class TypeE : TypeD
    {
        public int E { get; set; }

        public TypeE(int _a, int _b, int _c, int _d ,int _e) : base(_a, _b, _c , _d)
        {
            E = _e;
        }
        public new void MyFunc01()
        {
            Console.WriteLine("I am grand Child");
        }
        public override void MyFunc02()
        {
            Console.WriteLine($"TypeE : E {E} ");
        }
    }
}
