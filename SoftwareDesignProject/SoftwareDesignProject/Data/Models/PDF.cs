namespace SoftwareDesignProject.Data.Models
{
    public class PDF : FileDetails
    {
        public long FileSize { get; set; }

        public void SetFileSize(IFormFile file)
        {
            FileSize = file.Length;
        }
    }

}

