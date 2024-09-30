using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SWAPI.Domain.People;
using SWAPI.Service.People;
using SWAPI.Shared.DTOs;

namespace SWAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IPeopleService _peopleService;

        public PeopleController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }
        [HttpGet("{id?}")]
        public async Task<IActionResult> Get(int id) => Ok(await _peopleService.Get(id));


    }
}
