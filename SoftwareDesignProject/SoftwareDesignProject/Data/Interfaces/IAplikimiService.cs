using SoftwareDesignProject.Data.Models;
using SoftwareDesignProject.Data.ViewModels;

namespace SoftwareDesignProject.Data.Interfaces
{
    public interface IAplikimiService
    {
        public void AddAplikimi(AplikimiVM aplikimi);
        public void DeleteAplikimi(int id);
        public List<Aplikimi> GetAllAplikimet();
        public Aplikimi GetAplikimiById(int aplikimiId);
        public Aplikimi UpdateAplikiminById(int aplikimiId, AplikimiVM aplikimi);

    }
}
