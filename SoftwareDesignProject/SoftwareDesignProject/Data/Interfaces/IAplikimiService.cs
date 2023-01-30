using SoftwareDesignProject.Data.Models;
using SoftwareDesignProject.Data.ViewModels;

namespace SoftwareDesignProject.Data.Interfaces
{
    public interface IAplikimiService
    {
        public void AddAplikimi(AplikimiVM aplikimi);

        //string matchFKwithNP(int nrPersonal);
        public List<Aplikimi> GetAllAplikimet();
        public Aplikimi GetAplikimiById(int aplikimiId);
        public Aplikimi UpdateAplikiminById(int aplikimiId, AplikimiVM aplikimi);

    }
}
