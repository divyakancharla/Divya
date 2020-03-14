using System;
using System.Collections.Generic;
using System.Text;

namespace BankAssignment
{
    class Bank
    {
        static string bname = "sbi";
        long Accno;
        string Cusnam;
        string Acctyp;
        char transtyp;
        int amount;
        int bal;
        static Bank() { 
            bname="sbi";
            }
        public Bank(long Accno,
        string Cusnam,
        string Acctyp,
        char transtyp,
        int amount, int bal)
        {
            this.Accno = Accno;
            this.Cusnam = Cusnam;
            this.Acctyp = Acctyp;
            this.transtyp = transtyp;
            this.amount = amount;
            this.bal = bal;
        }
        
        public int credit(int amountt,int bal)
        {
            bal = bal + amountt;
            return bal;
        }
        public void deposit(int amounts)


        {
            bal = bal - amounts;
            //return ball;
        }
        public void display()
        {
            Console.WriteLine(bname+Accno + Cusnam + Acctyp + transtyp + amount + bal);

            
        } 
    }
}
