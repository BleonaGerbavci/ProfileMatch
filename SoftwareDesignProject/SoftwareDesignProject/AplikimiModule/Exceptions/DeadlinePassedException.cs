using System.Runtime.Serialization;

namespace SoftwareDesignProject.Exceptions
{
    [Serializable]
    internal class DeadlinePassedException : Exception
    {
        public DeadlinePassedException()
        {
        }

        public DeadlinePassedException(string? message) : base(message)
        {
        }
    }
}