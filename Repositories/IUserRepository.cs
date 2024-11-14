using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CordiSimpleDotnet.DTO.Auth;
using CordiSimpleDotnet.Models;

namespace CordiSimpleDotnet.Repositories
{
    public interface IUserRepository
    {
        Task Register(RegisterRequest user);
        Task Update(int id, User newInfo);
        Task Delete(int id);
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(int id);
    }
}