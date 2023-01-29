using Microsoft.AspNetCore.Mvc;
using SoftwareDesignProject.Data.Interfaces;
using SoftwareDesignProject.Data.Models;

namespace SoftwareDesignProject.Data.Services
{
    public class AplikimiService : IAplikimiService
    {
        private readonly AppDbContext _context;

        public AplikimiService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAplikimi(Aplikimi aplikimi)
        {
           
            _context.Aplikimet.Add(aplikimi);
            _context.SaveChanges();

        }

       /* public string matchFKwithNP(int nrPersonal)
        {
            var _studenti = _context.Students.FirstOrDefault(n => n.NrLeternjoftimit == nrPersonal);
            if(_studenti == null)
            {
                return "Numri Personal nuk u gjet";
            }
            var _fakulteti = _studenti.Fakulteti;      
            var _departamenti = _fakulteti.Departamenti;
            return _departamenti;
        }
       */
    }
}
