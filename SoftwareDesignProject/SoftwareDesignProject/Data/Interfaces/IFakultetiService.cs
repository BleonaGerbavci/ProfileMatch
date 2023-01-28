using SoftwareDesignProject.Data.Models;

namespace SoftwareDesignProject.Data.Interfaces
{
    public interface IFakultetiService
    {
        public List<Fakulteti> GetAll();
        public Fakulteti GetFacultyById(int id);
        public void AddFakulteti(Fakulteti fakulteti);
        public void DeleteFakulteti(int fakultetiId);
        public Fakulteti UpdateFakulteti(int fakultetiId, Fakulteti fakulteti);
  
    }
}
