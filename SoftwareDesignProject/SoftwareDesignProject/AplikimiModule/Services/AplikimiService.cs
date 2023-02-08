﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoftwareDesignProject.AplikimiModule.Interfaces;
using SoftwareDesignProject.AplikimiModule.Models;
using SoftwareDesignProject.AplikimiModule.ViewModels;
using SoftwareDesignProject.Exceptions;

namespace SoftwareDesignProject.AplikimiModule.Services
{
    public class AplikimiService : IAplikimiService
    {
        private readonly AppDbContext _context;

        public AplikimiService(AppDbContext context)
        {
            _context = context;
        }

        //get student by their personal number
        public Student GetStudentByPersonalNumber(int personalNumber)
        {

            return _context.Students.FirstOrDefault(s => s.NrLeternjoftimit == personalNumber);

        }

        // check if the student has already applied
        public bool HasStudentAlreadyApplied(int personalNumber)
        {
            var existingApplication = _context.Aplikimet.FirstOrDefault(a => a.StudentiNrLeternjoftimit == personalNumber);
            return existingApplication != null;
        }



        public void AddAplikimi(AplikimiVM aplikimi)
        {
            var student = GetStudentByPersonalNumber(aplikimi.StudentiNrLeternjoftimit);
            if (student == null)
            {
                throw new StudentNotFoundException("You can't apply!");
            }
            var hasAlreadyApplied = _context.Aplikimet.Any(a => a.StudentiNrLeternjoftimit == aplikimi.StudentiNrLeternjoftimit);
            if (hasAlreadyApplied)
            {
                throw new StudentAlreadyAppliedException("You have already applied.");
            }


            var _aplikimi = new Aplikimi()
            {
                isSpecialCategory = aplikimi.isSpecialCategory,
                SpecialCategoryReason = aplikimi.isSpecialCategory ? aplikimi.SpecialCategoryReason : null,
                ApplyDate = DateTime.Now,
                StudentiNrLeternjoftimit = aplikimi.StudentiNrLeternjoftimit,
                FileId = aplikimi.isSpecialCategory ? aplikimi.FileId : null
            };
            _context.Aplikimet.Add(_aplikimi);
            _context.SaveChanges();

        }





        public List<Aplikimi> GetAllAplikimet() =>
                _context.Aplikimet
                         .Include(a => a.Studenti)
                         .Include(a => a.Studenti.Fakulteti)
                         .Include(f => f.FileDetails)
                         .ToList();


        public Aplikimi GetAplikimiById(int aplikimiId) =>
                       _context.Aplikimet
                       .Include(a => a.Studenti)
                       .Include(a => a.Studenti.Fakulteti)
                       .Include(f => f.FileDetails)
                      .FirstOrDefault(n => n.Id == aplikimiId);



        public Aplikimi UpdateAplikiminById(int aplikimiId, AplikimiVM aplikimi)
        {
            var _aplikimi = _context.Aplikimet.FirstOrDefault(n => n.Id == aplikimiId);
            if (_aplikimi != null)
            {
                _aplikimi.isSpecialCategory = aplikimi.isSpecialCategory;
                _aplikimi.SpecialCategoryReason = aplikimi.SpecialCategoryReason;
                _aplikimi.ApplyDate = aplikimi.ApplyDate;
                _aplikimi.StudentiNrLeternjoftimit = aplikimi.StudentiNrLeternjoftimit;
                _aplikimi.FileId = aplikimi.FileId;

                _context.SaveChanges();
            }
            return _aplikimi;
        }

        public async Task<ActionResult> DeleteAplikimi(int id)
        {
            var _aplikimi = _context.Aplikimet.FirstOrDefault(x => x.Id == id);
            if (_aplikimi != null)
            {
                _context.Aplikimet.Remove(_aplikimi);
                _context.SaveChanges();
                return new OkObjectResult("Aplikimi u fshi me sukses");

            }
            return new NotFoundObjectResult("Aplikimi nuk ekziston");
        }
    }
}
