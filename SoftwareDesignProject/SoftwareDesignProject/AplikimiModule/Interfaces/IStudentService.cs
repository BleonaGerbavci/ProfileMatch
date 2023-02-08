using SoftwareDesignProject.AplikimiModule.Models;
using SoftwareDesignProject.AplikimiModule.ViewModels;

namespace SoftwareDesignProject.AplikimiModule.Interfaces
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

