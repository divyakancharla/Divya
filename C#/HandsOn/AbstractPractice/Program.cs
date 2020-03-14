using System;

namespace AbstractPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            Console.WriteLine("Menu");
            Console.WriteLine("1.Cricket Player Details");
            Console.WriteLine("2.Hockey Player Details");
            Console.WriteLine("enter choice");
            int ch = int.Parse(Console.ReadLine());
            

            if(ch==1)
            {
                
                CricketPlayer cp = new CricketPlayer("kalyani", "chennai", 1, 345, 7);
                cp.display();
                
            }
            else if(ch==2)
            {
                HockeyPlayer hp = new HockeyPlayer("divya", "royals", 2, "karthi", 6);
                hp.display();
            }
            else

                Console.WriteLine("Invalid");

            Console.ReadLine();
        }
    }
}
