using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestAufgabe_uniorg.Controllers.Repsotories;

namespace TestAufgabe_uniorg.Models.IServices
{
    public class UserRepository : IRepository<User>
    {
        IList<User> users;
        public void Add(User user)
        {
            users.Add(user);
        }
        public IList<User> liste()
        {
            return users.ToList();
        }
    }
}