/*using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using SoftwareDesignProject.Data;

namespace SoftwareDesignProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadController : Controller
    {
        private readonly AppDbContext _context;
        public FileUploadController(AppDbContext context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file, CancellationToken cancellationToken)
        {
            var result = await WriteFile(file);
            return Ok(result);
        }
        // write file edhe download file duhet mi specifiku te IFileUploadService edhe mi implementu te service
        private async Task<string> WriteFile(IFormFile file)
        {
            string fileName = "";
            try 
            {
                var extension = "." + file.FileName.Split('.')[file.FileName.Split('.').Length - 1];
                fileName = DateTime.Now.Ticks.ToString() + extension;

                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data\\Upload\\Files");

                if (!Directory.Exists(filePath))
                { 
                    Directory.CreateDirectory(filePath);
                }

                var exactPath = Path.Combine(Directory.GetCurrentDirectory(), "Data\\Upload\\Files", fileName);
                using (var stream = new FileStream(exactPath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

            }
            catch (Exception ex)
            {

            }
            return fileName;
        }

        [HttpGet("DownloadFile")]
        public async Task<IActionResult> DownloadFile(string fileName)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data\\Upload\\Files", fileName);

            var provider = new FileExtensionContentTypeProvider();
            if(!provider.TryGetContentType(filePath, out var contenttype))
            {
                contenttype = "application/octet-stream";
            }
            var bytes = await System.IO.File.ReadAllBytesAsync(filePath);
            return File(bytes, contenttype, Path.GetFileName(filePath));

        }
    }
}

*/