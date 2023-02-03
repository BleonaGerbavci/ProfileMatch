using SoftwareDesignProject.Data.Interfaces;
using SoftwareDesignProject.Data.Models;
using SoftwareDesignProject.Data.ViewModels;

namespace SoftwareDesignProject.Data.Services
{
    public class AnkesaService : IAnkesaService
    {
        private readonly AppDbContext _context;

        public AnkesaService(AppDbContext context)
        {
            _context = context;
        }

       
        public List<Ankesa> GetAllAnkesat()
        {
            return _context.Ankesat.ToList();
        }

        public Ankesa AnkesaById(int id)
        {
            return _context.Ankesat.FirstOrDefault(a => a.Id == id);
        }

        public void AddAnkesa(AnkesaVM ankesa)
        {
            var _ankesa = new Ankesa()
            {
                Permbajtja = ankesa.Permbajtja
            };
            _context.Ankesat.Add(_ankesa);
            _context.SaveChanges();
        }

        public void DeleteAnkesa(int ankesaId)
        {
            var _ankesa = _context.Ankesat.FirstOrDefault(n => n.Id == ankesaId);
            if (_ankesa != null)
            {
                _context.Ankesat.Remove(_ankesa);
                _context.SaveChanges();
            }
        }

        public Ankesa UpdateAnkesa(int ankesaId, AnkesaVM ankesa)
        {
            var _ankesa = _context.Ankesat.FirstOrDefault(n => n.Id == ankesaId);
            if (_ankesa != null)
            {
                _ankesa.Id = ankesa.Id;
                _ankesa.Permbajtja = ankesa.Permbajtja;

                _context.SaveChanges();
            }
            return _ankesa;
        }
    }
}
