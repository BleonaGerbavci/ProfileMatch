namespace SoftwareDesignProject.Data.Models
{
    public class PDF : FileDetails
    {
        public long FileSize { get; set; }

        public void SetFileSize(IFormFile file)
        {
            FileSize = file.Length;
        }

        public override void Modify(IFormFile file)
        {
            ID = 0;
            FileName= file.FileName;
        }


    }

}

