using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SWAPI.Service.Films;
using SWAPI.Service.Planets;

namespace SWAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmsController : ControllerBase
    {
        private readonly IFilmService _iFilmService;

        public FilmsController(IFilmService iFilmService)
        {
            _iFilmService = iFilmService;
        }
        [HttpGet("{id?}")]
        public async Task<IActionResult> Get(int id) => Ok(await _iFilmService.Get(id));
    }
}
