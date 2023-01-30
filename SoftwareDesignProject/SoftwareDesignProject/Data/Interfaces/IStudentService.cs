using SoftwareDesignProject.Data.Models;
using SoftwareDesignProject.Data.ViewModels;

namespace SoftwareDesignProject.Data.Interfaces
{
    public interface IStudentService
    {
        public List<Student> GetAllStudents();
        public Student GetStudentById(int stdId);
        public void AddStudent(StudentVM student);
        public Student UpdateStudentById(int nrLeternjoftimit, StudentVM student);
        public void DeleteStudentById(int StudentId);
    }
}

