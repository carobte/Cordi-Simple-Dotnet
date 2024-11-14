using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CordiSimpleDotnet.Data;
using CordiSimpleDotnet.Models;
using CordiSimpleDotnet.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CordiSimpleDotnet.Services
{
    public class EventService : IEventRepository
    {
       protected readonly AppDbContext _context;

        public EventService(AppDbContext context)
        {
            _context = context;
        }


        public async Task Create(Event newEvent)
        {
            if (newEvent == null)
            {
                throw new ArgumentNullException();
            }

            try
            {
                await _context.Events.AddAsync(newEvent);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException exception) // Database errors
            {
                throw new Exception("An error has occurred while registering the event in database" + exception.Message);
            }
            catch (TimeoutException timeoutEx) // Database operation is taking too long or if there are network problems that cause a timeout
            {
                throw new Exception("Timeout when registering event", timeoutEx);
            }
            catch (Exception exception) // Generic exception for any kind of error
            {
                throw new Exception("An unexpected error has occurred while registering the event" + exception.Message);
            }
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Event>> Get()
        {
            return await _context.Events.ToListAsync();           
        }

        public async Task<Event> GetById(int id)
        {
            var eventFound = await _context.Events.FindAsync(id);    
            if (eventFound == null )  {
                return null;
            }     
            return eventFound;
        }

        public Task Update(int id, Event newInfo)
        {
            throw new NotImplementedException();
        }
    }
}