using System;

namespace DifferentMethodsForCallingFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cl = new Calculator();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
           Console.WriteLine(cl.Add(ref a, ref b));
            cl.swap(ref a,ref b, out int sub,out int sub1);
            Console.WriteLine(sub);
            Console.WriteLine(sub1);
           // cl.swap(a, b);

    }
    }
}
