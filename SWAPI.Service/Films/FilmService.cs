using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SWAPI.Database.Context;
using SWAPI.Domain.Films;
using SWAPI.Domain.People;

namespace SWAPI.Service.Films
{
    public class FilmService : IFilmService
    {
        private readonly SwapiDbContext _swapiDbContext;
        private readonly IMapper _mapper;
        public FilmService(SwapiDbContext swapiDbContext, IMapper mapper)
        {
            _swapiDbContext = swapiDbContext;
            _mapper = mapper;
        }
        public async Task<FilmsResponseDTO> Get(int id)
        {
            var result = _swapiDbContext.Films
                .Include(x=>x.FilmsPlantsEntities)
                .ThenInclude(y=>y.Planets)
                .FirstOrDefault(x => x.Id == id);
            return _mapper.Map<FilmsResponseDTO>(result);
        }
    }
}
