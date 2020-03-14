using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePractice
{
    class Parent
    {
       internal int a;
       protected internal int b;

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        public void getValues(int x, int y)
        {
            this.A = x;
            this.B = y;

        }
        public void Display()
        {
            Console.WriteLine(this.A + "" + this.B);
        }
    }
    class Child : Parent
    {
        protected int c;
        public void cal()
        {
            c = this.A + this.B;
            Console.WriteLine(c);
        }
    }
    class grandChild : Child {
        int d;
        public void multiply(int n2)
        {
            this.d = n2;
            Console.WriteLine(this.d+this.b);
        }
        }

}
namespace demoprotected
{
    class Exchilde : InheritancePractice.Parent
    {
        public void Exdisplay()
        {
            Console.WriteLine(this.a + "" + this.b);
        }


    }
}