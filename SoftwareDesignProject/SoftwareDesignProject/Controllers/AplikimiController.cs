using Microsoft.AspNetCore.Mvc;
using SoftwareDesignProject.Data.Interfaces;
using SoftwareDesignProject.Data.Models;

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
        public IActionResult AddAplikimi(Aplikimi aplikimi)
        {
            _aplikimiService.AddAplikimi(aplikimi);
            return Ok();
        }


    }
}
