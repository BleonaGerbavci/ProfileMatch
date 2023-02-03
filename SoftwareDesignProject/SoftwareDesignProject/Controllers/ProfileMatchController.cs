using Microsoft.AspNetCore.Mvc;
using SoftwareDesignProject.Data;
using SoftwareDesignProject.Data.Interfaces;
using SoftwareDesignProject.Data.Models;
using SoftwareDesignProject.Data.ViewModels;

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

        [HttpGet("getAverageGradePoints/{nota}")]

        public IActionResult CalculateAGPoints(float nota)
        {

            var points = _profileMatchService.CalculateAverageGradePoints(nota);
            return Ok(points);

        }

        [HttpGet("getExtraPoints/{kategoria}")]

        public IActionResult CalculateExtraPoints(string kategoria)
        {
            var points = _profileMatchService.CalculateExtraPoints(kategoria);
            return Ok(points);
        }

        [HttpGet("profilematches")]
        public ActionResult<IEnumerable<ProfileMatchVM>> GetProfileMatches()
        {
            _profileMatchService.CalculateTotalPointsForAllStudents();

            return Ok(_profileMatchService.CalculateTotalPointsForAllStudents());
        }

        [HttpGet("sortedByTotalPoints")]
        public IActionResult GetSortedProfileMatches()
        {
            var sorted = _profileMatchService.SortByTotalPoints();

            return Ok(sorted);
        }

        [HttpGet("top10")]
        public IActionResult GetTop10()
        {
            var top10 = _profileMatchService.GetTop10ProfileMatches();

            return Ok(top10);
        }

        [HttpGet("last10")]
        public IActionResult Getlast10()
        {
            var last10 = _profileMatchService.GetLast10ProfileMatches();

            return Ok(last10);
        }
    }
}