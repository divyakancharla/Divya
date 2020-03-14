using System;

namespace BankAssignment
{
    class Program
    {
        static void Main(string[] args)
        {


          //  Bank b = new Bank();
            long Accno=long.Parse(Console.ReadLine());
            string Cusnam=(Console.ReadLine());
            string Acctyp= (Console.ReadLine());
            char transtyp= char.Parse(Console.ReadLine());
            int amount=int.Parse(Console.ReadLine());

            int bal=int.Parse(Console.ReadLine());
           Bank b1 = new Bank(Accno,Cusnam,Acctyp,transtyp,amount,bal);
            if(transtyp=='d')
            {
                //int a= b.credit(amount,bal);
                //Console.WriteLine(Accno + Cusnam + Acctyp + transtyp + amount + a);
                b1.credit(amount);
            }
            else
            {
                //int b1=b.deposit(amount,bal);
                //Console.WriteLine(Accno + Cusnam + Acctyp + transtyp + amount +b1);
                b1.credit(amount);
            }

            
        }
    }
}
