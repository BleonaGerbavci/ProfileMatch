using Microsoft.EntityFrameworkCore;
using SoftwareDesignProject.Data.Interfaces;
using SoftwareDesignProject.Data.Models;
using SoftwareDesignProject.Factory;

namespace SoftwareDesignProject.Data.Services
{
    public class FileService : IFileService
    {
        private readonly AppDbContext _context;

        public FileService(AppDbContext context)
        {
            _context = context;
        }

        public async Task PostFileAsync(IFormFile fileData)
        {
            try
            {
                //Factory pattern usage

                FileDetails fileDetails = FileFactory.CreateFileDetails(fileData);

                fileDetails.Modify(fileData);

                using (var stream = new MemoryStream())
                {
                    fileData.CopyTo(stream);
                    fileDetails.FileData = stream.ToArray();
                }

                var result = _context.FileDetails.Add(fileDetails);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }

        }



        public async Task DownloadFileById(int Id)
        {
            try
            {
                var file = await _context.FileDetails.FirstOrDefaultAsync(x => x.ID == Id);

                if (file != null)
                {
                    var content = new System.IO.MemoryStream(file.FileData);
                    var path = Path.Combine(
                        Directory.GetCurrentDirectory(), "FileDownloaded",
                        file.FileName);

                    await CopyStream(content, path);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task CopyStream(Stream stream, string downloadPath)
        {
            using (var fileStream = new FileStream(downloadPath, FileMode.Create, FileAccess.Write))
            {
                await stream.CopyToAsync(fileStream);
            }
        }

        public FileDetails GetFileById(int fileId)
        {
            return _context.FileDetails.FirstOrDefault(s => s.ID == fileId);
        }

        public List<FileDetails> GetAll()
        {
            return _context.FileDetails.ToList();
        }
    }

}
