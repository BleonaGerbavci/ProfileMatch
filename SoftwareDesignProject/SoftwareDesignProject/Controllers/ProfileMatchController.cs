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


        /*  private ProfileMatchVM CalculatePoints(Aplikimi a)
           {
               return new ProfileMatchVM
               {
                   Id = a.Id,
                   Emri = a.Studenti.Emri,
                   Mbiemri = a.Studenti.Mbiemri,
                   Departamenti = a.Studenti.Fakulteti.Departamenti,
                   Qyteti = a.Studenti.Qyteti,
                   PointsForGPA = _profileMatchService.CalculateAverageGradePoints(a.Studenti.NotaMesatare),
                   PointsForCity = _profileMatchService.CalculateCityPoints(a.Studenti.Qyteti),
                   ExtraPoints = _profileMatchService.CalculateExtraPoints(a.SpecialCategoryReason),
                   TotalPoints = _profileMatchService.CalculateTotalPointsForAllStudents();
               };
           }

        */


        [HttpGet("profilematches")]
           public ActionResult<IEnumerable<ProfileMatchVM>> GetProfileMatches()
           {
               _profileMatchService.CalculateTotalPointsForAllStudents();
            /*
               var aplikimet = _context.Aplikimet.ToList();
               var profileMatches = aplikimet.Select(a => CalculatePoints(a));
            */

               return Ok(_profileMatchService.CalculateTotalPointsForAllStudents());
           }
       

    }
}
