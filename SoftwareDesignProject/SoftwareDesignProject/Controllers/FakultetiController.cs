﻿using Microsoft.AspNetCore.Mvc;
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
        public IActionResult AddFakulteti(Fakulteti fk)
        {
            _fakultetiService.AddFakulteti(fk);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var allFaculties = _fakultetiService.GetAll();
            return Ok(allFaculties);

        }
        [HttpGet("get-by-id /{id}")]
        public IActionResult GetFacultyById(int id)
        {
            var _fakulteti = _fakultetiService.GetFacultyById(id);
            return Ok(_fakulteti);
        }

        [HttpPut("update-by-id/{id}")]
        public IActionResult UpdateFakulteti(int fakultetiId, Fakulteti fakulteti)
        {
            var updatedFaculty = _fakultetiService.UpdateFakulteti(fakultetiId, fakulteti);
            return Ok(updatedFaculty);
        }

        [HttpDelete("delete-fakulteti/{id}")]
        public IActionResult DeleteFakulteti(int id)
        {
            _fakultetiService.DeleteFakulteti(id);
            return Ok();
        }

        
    }
}
