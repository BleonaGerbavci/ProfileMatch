using SoftwareDesignProject.Data.Models;

namespace SoftwareDesignProject.Data.Interfaces
{
    public interface IStudentService
    {
        public List<Student> GetAllStudents();
        public Student GetStudentById(int stdId);
        public void AddStudent(Student student);
        public Student UpdateStudentById(int nrLeternjoftimit, Student student);
        public void DeleteStudentById(int StudentId);
    }
}

