namespace SoftwareDesignProject.Data.Models
{
    public class PDF : FileDetails
    {
        public long FileSize { get; set; }

        public override void Modify(IFormFile file)
        {
            ID = 0;
            FileName = file.FileName;
            FileSize = file.Length;

        }


    }

}

