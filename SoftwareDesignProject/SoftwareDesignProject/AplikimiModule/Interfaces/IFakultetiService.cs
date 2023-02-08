using SoftwareDesignProject.AplikimiModule.Models;
using SoftwareDesignProject.AplikimiModule.ViewModels;

namespace SoftwareDesignProject.AplikimiModule.Interfaces
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
