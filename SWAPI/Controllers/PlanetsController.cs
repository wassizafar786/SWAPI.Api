using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SWAPI.Service.People;
using SWAPI.Service.Planets;
using SWAPI.Shared.DTOs;

namespace SWAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanetsController : ControllerBase
    {
        private readonly IPlanetsService _planetsService;

        public PlanetsController(IPlanetsService planetsService)
        {
            _planetsService = planetsService;
        }
        [HttpGet("{id?}")]
        public async Task<IActionResult> Get(int id) => Ok(await _planetsService.Get(id));
    }
}
