using SoftwareDesignProject.AplikimiModule.Interfaces;
using SoftwareDesignProject.AplikimiModule.Models;
using SoftwareDesignProject.AplikimiModule.ViewModels;

namespace SoftwareDesignProject.AplikimiModule.Services
{
    public class FakultetiService : IFakultetiService
    {
        private readonly AppDbContext _context;
        public FakultetiService(AppDbContext context)
        {
            _context = context;
        }

        public void AddFakulteti(FakultetiVM fakulteti)
        {
            var _fakulteti = new Fakulteti()
            {
                Drejtimi = fakulteti.Drejtimi,
                Departamenti = fakulteti.Departamenti
            };
            _context.Fakultetet.Add(_fakulteti);
            _context.SaveChanges();
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

        public Fakulteti GetFacultyById(int id)
        {
            return _context.Fakultetet.FirstOrDefault(x => x.Id == id);
        }


        public Fakulteti UpdateFakulteti(int fakultetiId, FakultetiVM fakulteti)
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
