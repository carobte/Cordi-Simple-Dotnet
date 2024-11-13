using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CordiSimpleDotnet.Models;
using CordiSimpleDotnet.Utilities;
using Microsoft.EntityFrameworkCore;

namespace CordiSimpleDotnet.Seeders
{
    public class UserSeeders
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "caro",
                    LastName = "bte",
                    Email = "caro@example.com",
                    Password = "password",
                    Role = "admin"
                },
                
                new User
                {
                    Id = 2,
                    Name = "cami",
                    LastName = "campi",
                    Email = "cami@example.com",
                    Password = "password",
                    Role = "user"
                }
            );
        }
    }
}