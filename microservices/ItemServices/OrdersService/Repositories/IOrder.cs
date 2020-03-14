using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrdersService.Models;
namespace OrdersService.Repositories
{
    public interface IOrder
    {
        List<Orders> Getall();
        public Orders GetById(string id);
        public void AddItems(Orders item);
        public void delete(string id);
        public void update(Orders item);
    }
}
