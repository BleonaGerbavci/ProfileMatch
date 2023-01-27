using SoftwareDesignProject.Data.Models;

namespace SoftwareDesignProject.Data.Interfaces
{
    public interface IFakultetiService
    {
        List<Fakulteti> GetAll();
        Fakulteti GetFacultyById(int id);
        void AddFakulteti(Fakulteti fakulteti);
        Task DeleteFakulteti(int fakultetiId);
        Fakulteti UpdateFakulteti(int fakultetiId, Fakulteti fakulteti);
    }
}
