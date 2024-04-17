using Rangeur.DAL.Interfaces;
using Rangeur.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rangeur.DAL.Repositories
{
    public class UserEntityRepository : IUserRepository
    {
        private readonly RangeurContext _context;

        public UserEntityRepository (RangeurContext context)
        {
            _context = context;
        }
        public User Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        //public bool Delete(int idUser)
        //{
        //    User? user = _context.Users.FirstOrDefault(u => u.IdUser == idUser);
        //    if (user == null) 
        //    { 
        //    return false;
        //    }
        //    _context.Users.Remove(user);
        //    _context.SaveChanges();
        //    return true;
        //}

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }

        public User? GetById(int idUser)
        {
            User? user = _context.Users.FirstOrDefault(u => u.IdUser == idUser);
            if (user == null)
            {
                return null;
            }
            return user;
        }

        //public User? GetByPseudo(string pseudoUser)
        //{
        //    User? user = _context.Users.FirstOrDefault(u => u.PseudoUser == pseudoUser);
        //    if (user == null)
        //    {
        //        return null;
        //    }
        //    return user;
        //}

        //public User Update(User user)
        //{
        //    _context.Users.Update(user);
        //    _context.SaveChanges();
        //    return user;
        //}
    }
}
