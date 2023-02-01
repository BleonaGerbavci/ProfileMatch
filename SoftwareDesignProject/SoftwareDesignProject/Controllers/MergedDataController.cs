using Microsoft.AspNetCore.Mvc;
using SoftwareDesignProject.Data.Repositories;

namespace SoftwareDesignProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MergedDataController : ControllerBase
    {
        private readonly MergedDataRepository _mergedDataRepository;

        public MergedDataController(MergedDataRepository mergedDataRepository)
        {
            _mergedDataRepository = mergedDataRepository;
        }

        [HttpGet]
        public ActionResult<List<dynamic>> Get()
        {
            var mergedData = _mergedDataRepository.GetMergedData();
            return Ok(mergedData);
        }
    }
}
