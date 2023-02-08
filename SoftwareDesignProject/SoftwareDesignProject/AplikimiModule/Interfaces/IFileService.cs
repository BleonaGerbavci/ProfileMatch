using SoftwareDesignProject.AplikimiModule.Models;

namespace SoftwareDesignProject.AplikimiModule.Interfaces
{

    public interface IFileService
    {
        public Task<FileDetails> PostFileAsync(IFormFile fileData);

        public Task DownloadFileById(int fileName);

        public FileDetails GetFileById(int fileId);

        public List<FileDetails> GetAll();
    }
}
