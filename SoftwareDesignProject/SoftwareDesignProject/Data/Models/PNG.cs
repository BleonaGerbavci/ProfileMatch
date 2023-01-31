namespace SoftwareDesignProject.Data.Models
{
    public class PNG : FileDetails
    {
        public DateTime DateUploaded { get; set; }
        
        public PNG()
        {
            DateUploaded = DateTime.Now;
        }

    }
  
}
