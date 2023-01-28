using SoftwareDesignProject.Data.Models;

namespace SoftwareDesignProject.Data.Interfaces
{
    public interface IAplikimiService
    {
        void AddAplikimi(Aplikimi aplikimi);
        string matchFKwithNP(int nrPersonal);
    }
}
