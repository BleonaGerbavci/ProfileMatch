using Microsoft.AspNetCore.Mvc;
using SoftwareDesignProject.Data.Interfaces;
using SoftwareDesignProject.Data;
using SoftwareDesignProject.Data.ViewModels;
using SoftwareDesignProject.Services;

namespace SoftwareDesignProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AnkesaController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IAnkesaService _ankesaService;

        public AnkesaController(AppDbContext context, IAnkesaService ankesaService)
        {
            _context = context;
            _ankesaService = ankesaService;
        }

        [HttpPut("update-by-id/{ankesaId}")]
        public IActionResult UpdateAnkesa(int ankesaId, [FromBody] AnkesaVM ankesa)
        {
            var updatedAnkesa = _ankesaService.UpdateAnkesa(ankesaId, ankesa);
            return Ok(updatedAnkesa);
        }

        [HttpDelete("delete-ankesa/{id}")]
        public IActionResult DeleteAnkesa(int id)
        {
            _ankesaService.DeleteAnkesa(id);
            return Ok();
        }
    }

}
