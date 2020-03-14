using System;

namespace InheritancePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
           Child c= new Child();
            c.getValues(21, 45);
            c.Display();
            c.cal();
            grandChild gc = new grandChild();
            gc.getValues(21, 45);

            gc.multiply(31);
            demoprotected.Exchilde a = new demoprotected.Exchilde();
            a.getValues(34, 45);
            a.Exdisplay();
        }
    }
}
