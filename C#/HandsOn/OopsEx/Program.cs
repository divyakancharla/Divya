using System;

namespace OopsEx
{
    class Program
    {
       
        public static void Main(string[] args)
        {
            /*Bike ktm= new Bike();
             ktm.StartEngine();
             ktm.FileGas(int.Parse(Console.ReadLine()));
            int k= ktm.Travel(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
             Console.WriteLine(k);*/

            //Console.WriteLine(det.ROllNo);
            //det.ROllNo = 23;
            // Console.WriteLine(det.Name);
            //det.Name = "jsf";
            //det.Marks = 78;
            //det.AcceptStudentDetails();
            Student st = new Student();
           Student det = new Student("divya",45,"iy",45,67);
           // Student();
            det.DisplayStudentDetails();
        }
    }
}
