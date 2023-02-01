using SoftwareDesignProject.Data.Models;

namespace SoftwareDesignProject.Factory
{
    public class FileFactory
    {
        //factory pattern
        public static FileDetails CreateFileDetails(IFormFile fileData)
        {
            if (fileData.ContentType.Equals("application/pdf"))
            {
                return new PDF()
                {
                    ID = 0,
                    FileName = fileData.FileName,
                };
            }
            else if (fileData.ContentType.Equals("image/png"))
            {
                return new PNG()
                {
                    ID = 0,
                    FileName = fileData.FileName,
                };
            }
            else
            {
                throw new Exception("Unsupported file type.");
            }
        }
    }
}
