using Microsoft.AspNetCore.Mvc;
using SoftwareDesignProject.Data.Interfaces;
using SoftwareDesignProject.Data.Models;
using SoftwareDesignProject.Data.ViewModels;

namespace SoftwareDesignProject.Data.Services
{
    public class AplikimiService : IAplikimiService
    {
        private readonly AppDbContext _context;

        public AplikimiService(AppDbContext context)
        {
            _context = context;
        }

        public void AddAplikimi(AplikimiVM aplikimi)
        {

            var _aplikimi = new Aplikimi()
            {
               
                isSpecialCategory = aplikimi.isSpecialCategory,
                SpecialCategoryReason = aplikimi.isSpecialCategory ? aplikimi.SpecialCategoryReason : null,
                ApplyDate = DateTime.Now,
                StudentiNrLeternjoftimit = aplikimi.StudentiNrLeternjoftimit
            };   
            _context.Aplikimet.Add(_aplikimi);
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
