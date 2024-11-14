using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CordiSimpleDotnet.Models;

namespace CordiSimpleDotnet.Repositories
{
    public interface IEventRepository
    {
        Task<IEnumerable<Event>> Get();
        Task<Event> GetById(int id);
        Task Create(Event newEvent);
        Task Delete(int id);
        Task Update(int id, Event newInfo);
    }
}