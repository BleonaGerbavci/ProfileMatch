using SoftwareDesignProject.ProfileMatchModule.Models;
using SoftwareDesignProject.ProfileMatchModule.ViewModels;

namespace SoftwareDesignProject.ProfileMatchModule.Interfaces
{
    public interface IDrejtoriService
    {

        public Drejtori DrejtoriById(int Id);
        public List<Drejtori> GetAll();
        public void AddDrejtori(DrejtoriVM drejtori);
        public void DeleteDrejtori(int Id);
        public Drejtori UpdateDrejtori(int Id, DrejtoriVM drejtori);

    }
}
