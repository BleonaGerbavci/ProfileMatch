namespace SoftwareDesignProject.Data.Models
{
    public class Drejtori
    {
        public int Id { get; set; }
        public string? Emri { get; set; }
        public string? Mbiemri { get; set; }
        public string Vendlindja { get; set; }
        public int NumriTelefonit { get; set; }

        //navigation props
      

    }
}
