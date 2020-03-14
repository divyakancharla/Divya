using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTicketsBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Passenger p = new Passenger("kalyani", 9);
            Console.WriteLine("enter no of tickets");
            int no = int.Parse(Console.ReadLine());
            p.ticketbooking(no);
        }
    }
    public class TicketException : Exception
    {
        public TicketException(string s):base(s)
        {

        }
    }
    public class Passenger
    {
        string name;
        int age;
        public Passenger(string name,int age)
        {
            this.name=name;
            this.age=age;
        }
        public void ticketbooking(int n)
        {
            try
            {
                if (n >= 2) throw new TicketException("cant book more than 2");
                else
                    Console.WriteLine("tickets are booked");
            }
            catch(TicketException t)
            {
                Console.WriteLine(t.Message + " " + t.StackTrace);
            }
            //finally
            //{
            //    Console.WriteLine("tickets are booked");
            //}

        }
    }
}
