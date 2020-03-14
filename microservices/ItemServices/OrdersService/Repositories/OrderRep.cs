using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrdersService.Models;
using OrdersService.Repositories;
namespace OrdersService.Repositories
{
    public class OrderRep:IOrder
    {
        private readonly ShopDBContext conn;
        public OrderRep(ShopDBContext con)
        {
            conn = con;
        }

        public void AddItems(Orders item)
        {
                conn.Add(item);
                conn.SaveChanges();
        }

        public void delete(string id)
        {
            Orders e = conn.Orders.Find(id);
            conn.Remove(e);
            conn.SaveChanges();

        }

        public List<Orders> Getall()
        {
            return conn.Orders.ToList();
        }

        public Orders GetById(string id)
        {
            Orders e = conn.Orders.Find(id);
            return e;
        }

        public void update(Orders item)
        {
            Orders e = conn.Orders.SingleOrDefault(e => e.Orderid == "1001");
            conn.Update(e);
            conn.SaveChanges();
        }
       
    }
}
