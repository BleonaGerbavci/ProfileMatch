using SoftwareDesignProject.Data.Models;
using SoftwareDesignProject.Data.ViewModels;

namespace SoftwareDesignProject.Data.Interfaces
{
    public interface IAnkesaService
    {
        public void DeleteAnkesa(int ankesaId);
        public Ankesa UpdateAnkesa(int ankesaId, AnkesaVM ankesa);
    }
}
