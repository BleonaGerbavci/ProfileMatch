using Microsoft.EntityFrameworkCore;
using SoftwareDesignProject.AplikimiModule.Models;
using SoftwareDesignProject.ProfileMatchModule.Interfaces;
using SoftwareDesignProject.ProfileMatchModule.Models;
using SoftwareDesignProject.ProfileMatchModule.ViewModels;

namespace SoftwareDesignProject.ProfileMatchModule.Services
{
    public class AnkesaService : IAnkesaService
    {
        private readonly AppDbContext _context;

        public AnkesaService(AppDbContext context)
        {
            _context = context;
        }



        public List<Ankesa> GetAllAnkesat() => _context.Ankesat.Include(a => a.Studenti).ToList();


        public Ankesa AnkesaById(int id)
        {
            return _context.Ankesat.FirstOrDefault(a => a.Id == id);
        }

        //get student by their personal number
        public Student GetStdByPN(int personalNumber)
        {

            return _context.Students.FirstOrDefault(s => s.NrLeternjoftimit == personalNumber);

        }
        public void AddAnkesa(AnkesaVM ankesa)
        {
            var student = GetStdByPN(ankesa.StudentiNrLeternjoftimit);
            if (student == null)
            {
                throw new Exception("You can't make a complain!");
            }
            var _ankesa = new Ankesa()
            {
                Permbajtja = ankesa.Permbajtja,
                StudentiNrLeternjoftimit = ankesa.StudentiNrLeternjoftimit

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

                _ankesa.Permbajtja = ankesa.Permbajtja;
                _ankesa.StudentiNrLeternjoftimit = ankesa.StudentiNrLeternjoftimit;


                _context.SaveChanges();
            }
            return _ankesa;
        }
    }
}
