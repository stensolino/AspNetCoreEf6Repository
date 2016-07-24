using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    interface IRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
        User SaveUser(User user);
        User UpdateUser(User user);
        bool DeleteUser(int id);
    }
}
