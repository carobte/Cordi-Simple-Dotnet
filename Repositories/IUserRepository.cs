using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CordiSimpleDotnet.Models;

namespace CordiSimpleDotnet.Repositories
{
    public interface IUserRepository
    {
        Task Register(User user);
        Task Update(int id, User newInfo);
        Task Delete(int id);
        Task<List<User>> GetAll();
        Task<User> GetById(int id);
    }
}