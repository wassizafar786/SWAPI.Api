using SWAPI.Domain.People;

namespace SWAPI.Service.People
{
    public interface IPeopleService
    {
        public Task<PeopleResponseDTO> Get(int id);
    }
}
