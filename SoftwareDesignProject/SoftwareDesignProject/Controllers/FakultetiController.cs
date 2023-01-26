using Microsoft.AspNetCore.Mvc;
using SoftwareDesignProject.Data;
using SoftwareDesignProject.Data.Models;
using SoftwareDesignProject.Services;

namespace SoftwareDesignProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class FakultetiController : ControllerBase
    {
        // dependency injection
        private readonly AppDbContext _context;
        private readonly IFakultetiService _fakultetiService;

        public FakultetiController(AppDbContext context, IFakultetiService fakultetiService)
        {
            _context = context;
            _fakultetiService = fakultetiService;
        }
        [HttpPost]
        public async void AddFakulteti(Fakulteti fk)
        {
            _fakultetiService.AddFakulteti(fk);
        }

        [HttpDelete("delete-fakulteti/{id}")]
        public async void DeleteFakulteti(int id)
        {
            _fakultetiService.DeleteFakulteti(id);
        }
    }
}
