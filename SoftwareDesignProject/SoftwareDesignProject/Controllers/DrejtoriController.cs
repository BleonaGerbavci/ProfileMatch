using Microsoft.AspNetCore.Mvc;
using SoftwareDesignProject.Data.Interfaces;
using SoftwareDesignProject.Data.ViewModels;
using SoftwareDesignProject.Data;
using SoftwareDesignProject.Data.Models;

namespace SoftwareDesignProject.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class DrejtoriController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IDrejtoriService _drejtoriService;


        public DrejtoriController(AppDbContext context, IDrejtoriService drejtoriService)
        {
            _context = context;
            _drejtoriService = drejtoriService;
        }

        [HttpPost("add-drejtori")]
        public IActionResult AddDrejtori([FromBody] DrejtoriVM drejtori)
        {
            _drejtoriService.AddDrejtori(drejtori);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetAllDretoret()
        {
            var drejtoret = _drejtoriService.GetAll();
            return Ok(drejtoret);

        }


        [HttpGet("get-by-id /{id}")]
        public IActionResult GetDrejtoriById(int id)
        {
            var _drejtori = _drejtoriService.DrejtoriById(id);
            return Ok(_drejtori);
        }

        [HttpPut("update-by-id/{Id}")]
        public IActionResult UpdateDrejtori(int Id, [FromBody] DrejtoriVM drejtori)
        {
            var updatedDrejtori = _drejtoriService.UpdateDrejtori(Id, drejtori);
            return Ok(updatedDrejtori);
        }


        [HttpDelete("delete-drejtori/{Id}")]
        public IActionResult DeleteDrejtori(int Id)
        {
            _drejtoriService.DeleteDrejtori(Id);
            return Ok();
        }


    }

}

