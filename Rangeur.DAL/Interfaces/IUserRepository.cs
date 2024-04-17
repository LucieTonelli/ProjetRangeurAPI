using Rangeur.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Rangeur.DAL.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User? GetById(int idUser);
        //User? GetByPseudo (string pseudo);
        //User Create(User user);
        //User Update(User user);
        //bool Delete(int id);
    }
}
