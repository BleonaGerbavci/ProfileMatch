using Microsoft.EntityFrameworkCore;
using SoftwareDesignProject.Data.Interfaces;
using SoftwareDesignProject.Data.Models;
using SoftwareDesignProject.Data.ViewModels;

namespace SoftwareDesignProject.Data.Services
{
    public class StudentService : IStudentService
    {
        private readonly AppDbContext _context;

        public StudentService(AppDbContext context)
        {
            _context = context;
        }


        public void AddStudent(StudentVM student)
        {
            var _student = new Student()
            {
                NrLeternjoftimit = student.NrLeternjoftimit,
                Emri = student.Emri,
                EmriIPrindit = student.EmriIPrindit,
                Mbiemri = student.Mbiemri,
                Qyteti = student.Qyteti,
                NotaMesatare = student.NotaMesatare,
                NumriKontaktues = student.NumriKontaktues,
                Email = student.Email,
                Gjinia = student.Gjinia,
                VitiIStudimeve = student.VitiIStudimeve,
                Statusi = student.Statusi,
                ProfilePicUrl = student.ProfilePicUrl,
                FakultetiId = student.FakultetiId
            };
            _context.Students.Add(_student);
            _context.SaveChanges();
        }
        public List<Student> GetAllStudents() => 
                _context.Students.Include(f => f.Fakulteti).ToList();

        public Student GetStudentById(int stdId) => 
                _context.Students.Include(f => f.Fakulteti).FirstOrDefault(n => n.NrLeternjoftimit == stdId);


        public Student UpdateStudentById(int nrLeternjoftimit, StudentVM student)
        {
            var _student = _context.Students.FirstOrDefault(n => n.NrLeternjoftimit == nrLeternjoftimit);
            if (_student != null)
            {
                _student.Emri = student.Emri;
                _student.EmriIPrindit = student.EmriIPrindit;
                _student.Mbiemri = student.Mbiemri;
                _student.Qyteti = student.Qyteti;
                _student.NotaMesatare = student.NotaMesatare;
                _student.NumriKontaktues = student.NumriKontaktues;
                _student.Email = student.Email;
                _student.Gjinia = student.Gjinia;
                _student.VitiIStudimeve = student.VitiIStudimeve;
                _student.Statusi = student.Statusi;
                _student.ProfilePicUrl = student.ProfilePicUrl;
                _student.FakultetiId = student.FakultetiId;

                _context.SaveChanges();
            }
            return _student;
        }



        public void DeleteStudentById(int StudentId)
        {
            var _student = _context.Students.FirstOrDefault(n => n.NrLeternjoftimit == StudentId);
            if (_student != null)
            {
                _context.Students.Remove(_student);
                _context.SaveChanges();
            }
        }

    }
}
