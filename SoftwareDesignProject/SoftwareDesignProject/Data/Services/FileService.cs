using Microsoft.EntityFrameworkCore;
using SoftwareDesignProject.Data.Interfaces;
using SoftwareDesignProject.Data.Models;

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
                FileDetails fileDetails = null;

                if (fileData.ContentType.Equals("application/pdf"))
                {
                    fileDetails = new PDF()
                    {
                        ID = 0,
                        FileName = fileData.FileName,
                    };
                    (fileDetails as PDF).SetFileSize(fileData);
                }
                else if (fileData.ContentType.Equals("image/png"))
                {
                    fileDetails = new PNG()
                    {
                        ID = 0,
                        FileName = fileData.FileName,
                    };
                }

                if (fileDetails == null)
                {
                    throw new Exception("Unsupported file type.");
                }


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
    }

}
