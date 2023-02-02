using Microsoft.AspNetCore.Mvc;
using SoftwareDesignProject.Data;
using SoftwareDesignProject.Data.Interfaces;
using SoftwareDesignProject.Data.Models;
using SoftwareDesignProject.Data.Services;

namespace SoftwareDesignProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileMatchController : ControllerBase
    {
     
        private readonly AppDbContext _context;
        private readonly IProfileMatchService _profileMatchService;

        public ProfileMatchController(AppDbContext context, IProfileMatchService profileMatchService)
        {
            _context = context;
            _profileMatchService = profileMatchService;
        }

        [HttpGet("getQytetiPoints/{qyteti}")]
        public IActionResult KalkuloPiket(string qyteti)
        {

            var points = _profileMatchService.CalculateCityPoints(qyteti);
            return Ok(points);

        }
    }
}
