using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvcExample.Models;
namespace mvcExample.Repositories
{
    public class UserRepositories
    {
        public static List<User> list = new List<User>()
        {
            new User() { Name = "shreyas", Country = "India" ,Uname = "Hamsi", Pwd = "1234" }
    };
        public UserRepositories()
        {
         
       
        }
        public void Add(User item)
        {
            list.Add(item);
        }
        public User validate(string username,string pass)
        {
            foreach(var li in list)
            {
                if(li.Uname==username && li.Pwd == pass)
                {
                    return li;
                }
            }
            return null;

        }
    }
}
