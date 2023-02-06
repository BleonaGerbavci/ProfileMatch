using SoftwareDesignProject.Data.Models;

namespace SoftwareDesignProject.Data.Interfaces
{

    public interface IFileService
    {
        public Task PostFileAsync(IFormFile fileData);

        public Task DownloadFileById(int fileName);

        public FileDetails GetFileById(int fileId);

        public List<FileDetails> GetAll();
    }
}
