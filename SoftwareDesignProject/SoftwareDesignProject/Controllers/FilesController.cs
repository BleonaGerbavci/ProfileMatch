using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoftwareDesignProject.Data.Interfaces;
using SoftwareDesignProject.Data.Models;

namespace SoftwareDesignProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly IFileService _uploadService;

        public FilesController(IFileService uploadService)
        {
            _uploadService = uploadService;
        }


        [HttpPost("PostSingleFile")]
        public async Task<IActionResult> PostSingleFile(IFormFile fileData)
        {
            if (fileData == null)
                return BadRequest("File data is null.");
            if (fileData.Length == 0) return BadRequest("File is empty.");
           
           
            await _uploadService.PostFileAsync(fileData);
            return Ok("File uploaded successfully.");
        }

        [HttpGet("DownloadFileById")]
        public async Task<IActionResult> DownloadFileById(int Id)
        {
            await _uploadService.DownloadFileById(Id);
            return Ok("File downloaded successfully.");
        }
    }
}

