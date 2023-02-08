using SoftwareDesignProject.ProfileMatchModule.Models;
using SoftwareDesignProject.ProfileMatchModule.ViewModels;

namespace SoftwareDesignProject.ProfileMatchModule.Interfaces
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
