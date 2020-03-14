using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ServicesIntro.Models;
using ServicesIntro.Repositories;

namespace TestProject
{
    class TestItemRepo
    {
     ItemRepository _repo;
        [SetUp]
        public void setup()
        {
            _repo = new ItemRepository(new ShopDBContext());
        }
        [Test]
        public void Testcetitems()
        {
            var res = _repo.GetAllItems();
            Assert.IsNotNull(res);

            Assert.Greater(res.Count,1);
        }
        [Test]
        public void Testcetitemsbyid()
        {
            var res = _repo.GetById("12");
            Assert.IsNotNull(res);

        }
        public void TestAddItems()
        {
            _repo.AddItems(new Items()
            {
                Itemid = "1001",
                Name = "ABCD",
                Price = 34,
                Stock = 100
            });
            var result = _repo.GetById("1001");
            Assert.Null(result);
        }
        [Test]
        public void TestDelete()
        {
            _repo.delete("1001");
            var result = _repo.GetById("1001");
            Assert.Null(result);

        }
        [Test]
        public void TestUpdate()
        {
            Items item = _repo.GetById("1001");
            item.Price = 200;
            _repo.update(item);
            Items item1 = _repo.GetById("1001");
            Assert.AreSame(item, item1);

        }

    }
}
