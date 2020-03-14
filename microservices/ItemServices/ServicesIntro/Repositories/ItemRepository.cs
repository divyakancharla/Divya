using ServicesIntro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesIntro.Repositories
{

    public class ItemRepository : IItem
    {
        private readonly ShopDBContext _context;
        public ItemRepository(ShopDBContext context)
        {
            _context = context;
        }
        public void AddItems(Items items)
        {
            _context.Add(items);
            _context.SaveChanges();
        }

        public void delete(string id)
        {
            Items e = _context.Items.Find(id);
            _context.Remove(e);
            _context.SaveChanges();
        }

        public List<Items> GetAllItems()
        {
            return _context.Items.ToList();
        }

        public Items GetById(string id)
        {
            Items e = _context.Items.Find(id);
            return e;
        }

        public void update(Items item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }
    }
}
