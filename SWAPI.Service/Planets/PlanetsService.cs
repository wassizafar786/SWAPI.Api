using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SWAPI.Database.Context;
using SWAPI.Domain.Planets;

namespace SWAPI.Service.Planets
{
    public class PlanetsService : IPlanetsService
    {
        private readonly SwapiDbContext _swapiDbContext;
        private readonly IMapper _mapper;
        public PlanetsService(SwapiDbContext swapiDbContext, IMapper mapper)
        {
            _swapiDbContext = swapiDbContext;
            _mapper = mapper;
        }
        public async Task<PlanetsResponseDTO> Get(int id)
        {
            var result = _swapiDbContext.Planets
                .Include(x=>x.Peoples)
                .Include(y=>y.FilmsPlantsEntities)
                .ThenInclude(z=>z.Films)
                .FirstOrDefault(x => x.Id == id);
            return _mapper.Map<PlanetsResponseDTO>(result);
        }
    }
}
