using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrainingAPI.Data;
using TrainingAPI.Model;

namespace TrainingAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssociatesController : ControllerBase
    {
        // Fields
        private readonly IRepository _repo;
        private readonly ILogger<AssociatesController> _logger;

        // Constructor
        public AssociatesController(IRepository repo, ILogger<AssociatesController> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        // Methods

        // GET /api/associates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Associate>>> GetAllAssociates()
        {
            IEnumerable<Associate> associates;

            try
            {
                associates = await _repo.GetAllAssociatesAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                return StatusCode(500);
            }

            return associates.ToList();

        }


    }
}
