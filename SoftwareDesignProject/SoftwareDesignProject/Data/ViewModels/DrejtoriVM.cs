using SoftwareDesignProject.Data.Models;

namespace SoftwareDesignProject.Data.ViewModels
{
    public class DrejtoriVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Ankesa Ankesa { get; set; }

        //public ListaETePranuarve ListaETePranuarve { get; set; }
    }
}
