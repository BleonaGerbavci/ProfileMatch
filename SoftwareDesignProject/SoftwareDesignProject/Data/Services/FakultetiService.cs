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

        public void AddFakulteti(Fakulteti fakulteti)
        {
            var _fakulteti = new Fakulteti()
            {
                Id = fakulteti.Id,
                Drejtimi = fakulteti.Drejtimi,
                Departamenti = fakulteti.Departamenti
            };
             _context.Fakultetet.Add(_fakulteti);
             _context.SaveChangesAsync();
        }

        public void DeleteFakulteti(int fakultetiId)
        {
            var _fakulteti = _context.Fakultetet.FirstOrDefault(x => x.Id == fakultetiId);
            if (_fakulteti != null)
            {
                _context.Fakultetet.Remove(_fakulteti);
                 _context.SaveChanges();
            }
        }

        public List<Fakulteti> GetAll()
        {
            return _context.Fakultetet.ToList();
        }

        public Fakulteti GetFacultyById(int id) { 
            return _context.Fakultetet.FirstOrDefault(x => x.Id == id);
        }


        public Fakulteti UpdateFakulteti(int fakultetiId, Fakulteti fakulteti)
        {
            var _fakulteti = _context.Fakultetet.FirstOrDefault(x => x.Id == fakultetiId);
            if (_fakulteti != null)
            {
                _fakulteti.Drejtimi = fakulteti.Drejtimi;
                _fakulteti.Departamenti = fakulteti.Departamenti;

                _context.SaveChanges();
            }

            return _fakulteti;
        }
    }
}
