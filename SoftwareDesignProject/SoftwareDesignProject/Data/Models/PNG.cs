namespace SoftwareDesignProject.Data.Models
{
    public class PNG : CustomFile
    {
        public double PaymentAmount { get; set; }
        public string ImageUrl { get; set; }
        public DateTime PaymentDate { get; set; }
        public int TransactionID { get; set; }


    }
}
