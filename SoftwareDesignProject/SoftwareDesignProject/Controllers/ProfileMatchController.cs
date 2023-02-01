using Microsoft.AspNetCore.Mvc;
using SoftwareDesignProject.Data.Interfaces;
using SoftwareDesignProject.Data;

namespace SoftwareDesignProject.Controllers
{
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

        [HttpGet("getAverageGradePoints/{nota}")]

        public IActionResult CalculateAGPoints(float nota)
        {

            var points = _profileMatchService.CalculateAverageGradePoints(nota);
            return Ok(points);

        }
    }
}
