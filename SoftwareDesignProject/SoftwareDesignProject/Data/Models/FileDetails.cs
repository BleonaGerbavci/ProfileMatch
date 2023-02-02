namespace SoftwareDesignProject.Data.Models
{
    public class FileDetails
    {
        public int ID { get; set; }
        public string FileName { get; set; }
        public byte[] FileData { get; set; }

        public virtual void Modify(IFormFile file) { }

    }
}

