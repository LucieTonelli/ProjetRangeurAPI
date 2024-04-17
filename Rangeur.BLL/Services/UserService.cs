using Rangeur.BLL.Interfaces;
using Rangeur.DAL.Interfaces;
using Rangeur.Domain.Models;
using SendGrid.Helpers.Errors.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rangeur.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService (IUserRepository repository)
        {
            _repository = repository;
        }
        //public User Create(User user)
        //{
        //    //Attention, repasser ici pour mot de passe 
        //    return _repository.Create(user);
        //}

        //public bool Delete(int idUser)
        //{
        //    bool success = _repository.Delete(idUser);
        //    if (!success)
        //    {
        //        throw new NotFoundException($"L'id '{idUser}' n'a pas été trouvé");
        //    }
        //    return true;
        //}

        public IEnumerable<User> GetAll()
        {
            return _repository.GetAll();
        }

        public User? GetById(int idUser)
        {
            User? user = _repository.GetById(idUser);
            if (user == null)
            {
                throw new NotFoundException($"L'id '{idUser}' n'a pas été trouvé");
            }
            return user;
        }

        //public User? GetByPseudo(string pseudoUser)
        //{
        //    {
        //        User? user = _repository.GetByPseudo(pseudoUser);
        //        if (user == null)
        //        {
        //            throw new NotFoundException($"L'id '{pseudoUser}' n'a pas été trouvé");
        //        }
        //        return user;
        //    }
        //}
        //public User? Update(User user)
        //{
        //    User? userToUpdate = _repository.GetById(user.IdUser);
        //    if (userToUpdate == null) 
        //    {
        //        throw new NotFoundException($"L'id `{user.IdUser}`n'a pas été trouvé");
        //    }

        //    return userToUpdate;
        //}
    }
}
