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

        public void DeleteAplikimi(int id)
        {
            var _aplikimi = _context.Aplikimet.FirstOrDefault(x => x.Id == id);
            if (_aplikimi != null)
            {
                _context.Aplikimet.Remove(_aplikimi);
                _context.SaveChanges();
            }
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

        public List<Aplikimi> GetAllAplikimet() => _context.Aplikimet.ToList();

        public Aplikimi GetAplikimiById(int aplikimiId) => _context.Aplikimet.FirstOrDefault(n => n.Id == aplikimiId);


        public Aplikimi UpdateAplikiminById(int aplikimiId, AplikimiVM aplikimi)
        {
            var _aplikimi = _context.Aplikimet.FirstOrDefault(n => n.Id == aplikimiId);
            if (_aplikimi != null)
            {
                _aplikimi.isSpecialCategory = aplikimi.isSpecialCategory;
                _aplikimi.SpecialCategoryReason = aplikimi.SpecialCategoryReason;
                _aplikimi.ApplyDate = aplikimi.ApplyDate;
                _aplikimi.StudentiNrLeternjoftimit = aplikimi.StudentiNrLeternjoftimit;
                
                _context.SaveChanges();
            }
            return _aplikimi;
        }
    }
}
