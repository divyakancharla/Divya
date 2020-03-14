using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo2.Models;
namespace WebApiDemo2.Repositories
{
    public class CourseRep
    {
        public List<Cours> getall()
        {
            using (PracticeDBContext pd = new PracticeDBContext())
            {
                return pd.Cours.ToList();
            }
        }
        public Cours GetById(int eid)
        {
            using (PracticeDBContext pd = new PracticeDBContext())
            {
                return pd.Cours.Find(eid);
            }
        }
        public void Add(Cours item)
        {
            using (PracticeDBContext pd = new PracticeDBContext())
            {
                pd.Cours.Add(item);
                pd.SaveChanges();
            }
        }
        public void Delete(int eid)
        {
            using (PracticeDBContext pd = new PracticeDBContext())
            {
                Cours e = pd.Cours.Find(eid);
                pd.Remove(e);
                pd.SaveChanges();
            }
        }
        public void Update(Cours eid)
        {
            using (PracticeDBContext pd = new PracticeDBContext())
            {
                pd.Update(eid);
                pd.SaveChanges();
            }
        }
    }
}
