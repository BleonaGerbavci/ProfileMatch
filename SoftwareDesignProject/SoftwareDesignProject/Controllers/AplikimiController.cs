using Microsoft.AspNetCore.Mvc;
using SoftwareDesignProject.Data.Interfaces;
using SoftwareDesignProject.Data.Models;
using SoftwareDesignProject.Data.ViewModels;
using SoftwareDesignProject.Exceptions;

namespace SoftwareDesignProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AplikimiController : Controller
    {
        private readonly IAplikimiService _aplikimiService;

        public AplikimiController(IAplikimiService aplikimiService)
        {
            _aplikimiService = aplikimiService;
        }

        [HttpPost("add-aplikimi")]
        public async Task<IActionResult> AddAplikimi(IFormFile fileData, AplikimiVM aplikimi)
        {
            try
            {
                await _aplikimiService.AddAplikimi(fileData, aplikimi);
                return Ok("Application submitted successfully.");
            }
            catch (StudentNotFoundException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (StudentAlreadyAppliedException ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet]
        public IActionResult GetAllAplikimet()
        {
            var allAplikimet = _aplikimiService.GetAllAplikimet();
            return Ok(allAplikimet);

        }

        [HttpGet("get-by-id /{id}")]
        public IActionResult GetAplikimiById(int id)
        {
            var _aplikimi = _aplikimiService.GetAplikimiById(id);
            return Ok(_aplikimi);
        }

        [HttpPut("update-by-id/{id}")]
        public IActionResult UpdateAplikiminById(int aplikimiId, [FromBody] AplikimiVM aplikimi)
        {
            var updatedAplikim = _aplikimiService.UpdateAplikiminById(aplikimiId, aplikimi);
            return Ok(updatedAplikim);
        }

        [HttpDelete("delete-aplikimi/{id}")]
        public async Task<ActionResult> DeleteAplikimi(int id)
        {

           return await _aplikimiService.DeleteAplikimi(id);
           
        }

    }
}
