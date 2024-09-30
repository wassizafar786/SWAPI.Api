using SWAPI.Domain.Planets;
using SWAPI.Shared.DTOs;

namespace SWAPI.Service.Planets
{
    public interface IPlanetsService
    {
         Task<PlanetsResponseDTO> Get(int id);
    }
}
