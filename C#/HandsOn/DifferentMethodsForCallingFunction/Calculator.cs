using System;
using System.Collections.Generic;
using System.Text;

namespace DifferentMethodsForCallingFunction
{
    class Calculator
    {
        public int a;
     public int b;

       //ublic int B { get => b; set => b = value; }
        public Calculator() { }
        public Calculator(int a, int b)
        {
            this.a= a;
            this.b = b;
        }
        public int Add(ref int n1,ref int n2)
        {
            return (n1+n2);
        }
        public void swap(ref int num1,ref int num2,out int temp1,out int temp2)
        {
            int temp = 0;
            temp = num1;
            temp1 = 32;
            temp2= 56  ;
            Console.WriteLine("---num1--{0}" + "\n" + "---num2---{1}" + num1+num2);
        }
    }
}
