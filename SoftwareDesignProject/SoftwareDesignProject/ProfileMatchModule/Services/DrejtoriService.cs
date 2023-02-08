using Microsoft.EntityFrameworkCore;
using SoftwareDesignProject.ProfileMatchModule.Interfaces;
using SoftwareDesignProject.ProfileMatchModule.Models;
using SoftwareDesignProject.ProfileMatchModule.ViewModels;
using System.Linq;

namespace SoftwareDesignProject.ProfileMatchModule.Services
{
    public class DrejtoriService : IDrejtoriService
    {
        private readonly AppDbContext _context;

        public DrejtoriService(AppDbContext context)
        {
            _context = context;
        }

        public void AddDrejtori(DrejtoriVM drejtori)
        {
            var _drejtori = new Drejtori()
            {

                Emri = drejtori.Emri,
                Mbiemri = drejtori.Mbiemri,
                Vendlindja = drejtori.Vendlindja,
                NumriTelefonit = drejtori.NumriTelefonit

            };
            _context.Drejtoret.Add(_drejtori);
            _context.SaveChanges();
        }

        public void DeleteDrejtori(int Id)
        {
            var _drejtori = _context.Drejtoret.FirstOrDefault(e => e.Id == Id);
            if (_drejtori != null)
            {
                _context.Drejtoret.Remove(_drejtori);
                _context.SaveChanges();
            }
        }

        public List<Drejtori> GetAll()
        {
            return _context.Drejtoret.ToList();
        }


        public Drejtori DrejtoriById(int Id)
        {
            return _context.Drejtoret.FirstOrDefault(d => d.Id == Id);

        }

        public Drejtori UpdateDrejtori(int Id, DrejtoriVM drejtori)
        {
            var _drejtori = _context.Drejtoret.FirstOrDefault(e => e.Id == Id);
            if (_drejtori != null)
            {

                _drejtori.Emri = drejtori.Emri;
                _drejtori.Mbiemri = drejtori.Mbiemri;
                _drejtori.Vendlindja = drejtori.Vendlindja;
                _drejtori.NumriTelefonit = drejtori.NumriTelefonit;


                _context.SaveChanges();
            }
            return _drejtori;
        }


    }
}









