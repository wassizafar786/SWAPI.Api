using SWAPI.Domain.Films;
using SWAPI.Domain.People;

namespace SWAPI.Service.Films
{
    public interface IFilmService
    {
        public Task<FilmsResponseDTO> Get(int id);
    }
}
