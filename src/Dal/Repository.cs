using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class Repository : IRepository
    {
        #region Constructor

        private ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        #endregion

        #region Users

        public IEnumerable<User> GetAllUsers()
        {
            try
            {
                var users = _context.Users.ToList();
                return users;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User GetUserById(int id)
        {
            try
            {
                var user = _context.Users.FirstOrDefault(u => u.Id == id);
                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User SaveUser(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();

                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User UpdateUser(User user)
        {
            try
            {
                var userDb = _context.Users.FirstOrDefault(u => u.Id == user.Id);
                userDb = user;
                _context.SaveChanges();

                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteUser(int id)
        {
            try
            {
                var user = _context.Users.FirstOrDefault(u => u.Id == id);

                if (user == null)
                {
                    return false;
                }

                _context.Users.Remove(user);
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
