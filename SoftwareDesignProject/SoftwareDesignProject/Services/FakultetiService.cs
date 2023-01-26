using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoftwareDesignProject.Data;
using SoftwareDesignProject.Data.Models;

namespace SoftwareDesignProject.Services
{
    public class FakultetiService : IFakultetiService
    {
        private readonly AppDbContext _context;
        public FakultetiService(AppDbContext context)
        {
            _context = context;
        }

        public async void AddFakulteti(Fakulteti fakulteti)
        {
             _context.Fakultetet.Add(fakulteti);
            await _context.SaveChangesAsync();
        }

        public async void DeleteFakulteti(int fakultetiId)
        {
            var fakulteti = await _context.Fakultetet.FindAsync(fakultetiId);
         
            _context.Fakultetet.Remove(fakulteti);
            await _context.SaveChangesAsync();
        }

        public async Task<ActionResult<IEnumerable<Fakulteti>>> GetAll()
        {
            return await _context.Fakultetet.ToListAsync();
        }

        public Fakulteti UpdateFakulteti(int fakultetiId)
        {
            throw new NotImplementedException();
        }

    }
}
