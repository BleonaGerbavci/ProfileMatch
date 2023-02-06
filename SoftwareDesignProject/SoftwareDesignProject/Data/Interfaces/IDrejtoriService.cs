using SoftwareDesignProject.Data.Models;
using SoftwareDesignProject.Data.ViewModels;

namespace SoftwareDesignProject.Data.Interfaces
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
