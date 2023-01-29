using SoftwareDesignProject.Data.Models;
using SoftwareDesignProject.Data.ViewModels;

namespace SoftwareDesignProject.Data.Interfaces
{
    public interface IFakultetiService
    {
        public List<Fakulteti> GetAll();
        public Fakulteti GetFacultyById(int id);
        public void AddFakulteti(FakultetiVM fakulteti);
        public void DeleteFakulteti(int fakultetiId);
        public Fakulteti UpdateFakulteti(int fakultetiId, FakultetiVM fakulteti);
  
    }
}
