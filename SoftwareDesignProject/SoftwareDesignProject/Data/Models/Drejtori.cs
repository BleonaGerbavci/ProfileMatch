namespace SoftwareDesignProject.Data.Models
{
    public class Drejtori
    {
        public int Id { get; set; }
        public string? Emri { get; set; }
        public string? Mbiemri { get; set; }
        public string Vendlindja {get; set;}
        public int NumriTelefonit { get; set; }
        public Ankesa Ankesa { get; set; }

        public int AnkesaId { get; set; }
        public string Email { get; internal set; }
        public byte[] PasswordHash { get; internal set; }
        public byte[] PasswordSalt { get; internal set; }
        public string? VerificationToken { get; internal set; }
        public string? PasswordResetToken { get; internal set; }
        public DateTime? ResetTokenExpires { get; internal set; }

        //public ListaETePranuarve ListaETePranuarve { get; set; }
    }
}
