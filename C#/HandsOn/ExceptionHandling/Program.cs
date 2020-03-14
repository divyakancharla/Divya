using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[3] { 1, 2, 3 };
               // Console.WriteLine(arr[4]);
                try
                {
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine(num / 0);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            
            //catch(FormatException e)
            //{
            //    Console.WriteLine(e.Message+""+e.Source+""+e.StackTrace+""+e.TargetSite);
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message + "" + e.Source + "" + e.StackTrace + "" + e.TargetSite);
            //}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("gdgdg");
            }
            {
                Console.WriteLine("fsfsf");
            }
        }

    }
}
