using SoftwareDesignProject.Data.Models;
using SoftwareDesignProject.Data.ViewModels;

namespace SoftwareDesignProject.Data.Interfaces
{
    public interface IAnkesaService
    {
        public List<Ankesa> GetAllAnkesat();
        public Ankesa AnkesaById(int id);
        public void AddAnkesa(AnkesaVM ankesa);
        public void DeleteAnkesa(int ankesaId);
        public Ankesa UpdateAnkesa(int ankesaId, AnkesaVM ankesa);
    }
}
