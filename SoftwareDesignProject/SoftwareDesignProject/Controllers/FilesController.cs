﻿using Microsoft.AspNetCore.Http;
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
        public async Task<ActionResult> PostSingleFile([FromForm] FileUpload fileDetails)
        {
            if (fileDetails == null)
            {
                return BadRequest();
            }

            try
            {
                await _uploadService.PostFileAsync(fileDetails.FileDetails, fileDetails.FileType);
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }

      
        [HttpGet("DownloadFile")]
        public async Task<ActionResult> DownloadFile(int id)
        {
            if (id < 1)
            {
                return BadRequest();
            }

            try
            {
                await _uploadService.DownloadFileById(id);
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

