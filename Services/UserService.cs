using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CordiSimpleDotnet.Data;
using CordiSimpleDotnet.DTO.Auth;
using CordiSimpleDotnet.Models;
using CordiSimpleDotnet.Repositories;
using CordiSimpleDotnet.Utilities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace CordiSimpleDotnet.Services
{
    public class UserService : IUserRepository
    {
        private readonly AppDbContext _context;
        private readonly PasswordHasher _passwordHasher;

        public UserService(AppDbContext context, PasswordHasher passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Register(RegisterRequest user)
        {
            if (user == null)
            {
                throw new ArgumentNullException();
            }

            try
            {
                await _context.Users.AddAsync(new User
                {
                    Name = user.Name,
                    LastName = user.LastName,
                    Email = user.Email,
                    Password = _passwordHasher.EncryptSHA256(user.Password), // Password Hash
                    Role = "client",
                });

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException exception) // Database errors
            {
                throw new Exception("An error has occurred while registering the user in database" + exception.Message);
            }
            catch (TimeoutException timeoutEx) // Database operation is taking too long or if there are network problems that cause a timeout
            {
                throw new Exception("Timeout when registering user", timeoutEx);
            }
            catch (Exception exception) // Generic exception for any kind of error
            {
                throw new Exception("An unexpected error has occurred while registering the user" + exception.Message);
            }

        }

        public Task Update(int id, User newInfo)
        {
            throw new NotImplementedException();
        }
    }
}