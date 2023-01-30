namespace SoftwareDesignProject.Exceptions
{
    public class StudentNotFoundException : Exception
    {
        public StudentNotFoundException()
        {
        }

        public StudentNotFoundException(string message) : base(message)
        {
        }
    }

}
