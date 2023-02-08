namespace SoftwareDesignProject.Exceptions
{
    public class StudentAlreadyAppliedException : Exception
    {
        public StudentAlreadyAppliedException()
        {
        }

        public StudentAlreadyAppliedException(string message) : base(message)
        {
        }
    }

}
