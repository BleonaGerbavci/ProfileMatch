using SoftwareDesignProject.Data.Models;

namespace SoftwareDesignProject.Data.ViewModels
{
    public class DrejtoriVM
    {
        public int Id { get; set; }
        public string? Emri { get; set; }
        public string? Mbiemri { get; set; }
        public string Vendlindja { get; set; }
        public int NumriTelefonit { get; set; }
        public int AnkesaId { get; set; }

        //public ListaETePranuarve ListaETePranuarve { get; set; }
    }
}
