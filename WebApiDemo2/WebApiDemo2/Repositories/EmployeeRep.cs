using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo2.Models;
namespace WebApiDemo2.Repositories
{
    public class EmployeeRep
    {
        public List<Employee> getall()
        {
            using (PracticeDBContext pd = new PracticeDBContext())
            {
                return pd.Employee.ToList();
            }
        }
        public Employee GetById(int eid)
        {
            using(PracticeDBContext pd=new PracticeDBContext())
            {
                return pd.Employee.SingleOrDefault(e => e.Eid==eid);
            }
        }
        public void Add(Employee item)
        {
            using(PracticeDBContext pd=new PracticeDBContext())
            {
                pd.Employee.Add(item);
                pd.SaveChanges();
            }
        }
        public void Delete(int eid)
        {
            using(PracticeDBContext pd=new PracticeDBContext())
            {
                Employee e = pd.Employee.SingleOrDefault(e=>e.Eid==eid);
                pd.Remove(e);
                pd.SaveChanges();
            }
        }
        public void Update(Employee eid)
        {
            using (PracticeDBContext pd = new PracticeDBContext())
            {
                pd.Update(eid);
                pd.SaveChanges();
            }
        }
    }
}
