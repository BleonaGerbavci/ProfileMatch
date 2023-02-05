using SoftwareDesignProject.Data.Models;
using SoftwareDesignProject.Data.ViewModels;

namespace SoftwareDesignProject.Data.Interfaces
{
    public interface IDrejtoriService 
    {
        
        public  Drejtori DrejtoriById(int Id);
        public void AddDrejtori(DrejtoriVM drejtori);
        public void DeleteDrejtori(int Id);
        public Drejtori UpdateDrejtori(int Id, DrejtoriVM drejtori);

    
        //public List<Lista> AddToLista();
    }
}
