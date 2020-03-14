using System;
using ClassLibraryAssignment.Context;
using ClassLibraryAssignment.Models;
namespace ClassLibraryChild
{
    class Program
    {
        static void Main(string[] args)
        {
            using(Contextt dc=new Contextt())
            {
                Item it = new Item() { Itemname = "Puri", Itemprice = 2300 };
                dc.Add(it);
                dc.SaveChanges();
                Order o = new Order() { ItemId = 1, OrderDate = DateTime.Parse("12.02.2019") };
                dc.Add(o);
                dc.SaveChanges();
            }
        }
    }
}
