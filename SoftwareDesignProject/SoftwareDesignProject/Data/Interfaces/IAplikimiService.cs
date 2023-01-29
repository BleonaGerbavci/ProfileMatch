using SoftwareDesignProject.Data.Models;

namespace SoftwareDesignProject.Data.Interfaces
{
    public interface IAplikimiService
    {
        Task AddAplikimi(Aplikimi aplikimi);
        //string matchFKwithNP(int nrPersonal);
    }
}
