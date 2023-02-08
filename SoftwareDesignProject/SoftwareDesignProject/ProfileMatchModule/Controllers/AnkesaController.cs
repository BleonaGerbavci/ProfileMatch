using Microsoft.AspNetCore.Mvc;
using SoftwareDesignProject.ProfileMatchModule.Interfaces;
using SoftwareDesignProject.ProfileMatchModule.ViewModels;

namespace SoftwareDesignProject.ProfileMatchModule.Controllers
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

        [HttpPost("add-ankesa")]
        public IActionResult AddAnkesa([FromBody] AnkesaVM ankesa)
        {
            try
            {
                _ankesaService.AddAnkesa(ankesa);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet]
        public IActionResult GetAllAnkesat()
        {
            var ankesat = _ankesaService.GetAllAnkesat();
            return Ok(ankesat);

        }
        [HttpGet("get-by-id /{id}")]
        public IActionResult GetAnkesaById(int id)
        {
            var _ankesa = _ankesaService.AnkesaById(id);
            return Ok(_ankesa);
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
