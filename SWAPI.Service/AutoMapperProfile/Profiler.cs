using AutoMapper;
using SWAPI.Database.Entity;
using SWAPI.Domain.Films;
using SWAPI.Domain.People;
using SWAPI.Domain.Planets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAPI.Service.AutoMapperProfile
{
    public class Profiler:Profile
    {
        public Profiler()
        {

            CreateMap<PeopleEntity, PeopleResponseDTO>().ForMember(x => x.Homeworld, y => y.MapFrom(src => src.Planet.Url));
            CreateMap<PlanetsEntity, PlanetsResponseDTO>()
                .ForMember(x => x.Residents, y => y.MapFrom(src => src.Peoples.Select(x => x.Url)))
                .ForMember(z => z.Films, o => o.MapFrom(src => src.FilmsPlantsEntities.Select(x => x.Films.Url)));
                 
            CreateMap<FilmsEntity, FilmsResponseDTO>()
                .ForMember(x => x.Planets, y => y.MapFrom(src => src.FilmsPlantsEntities.Select(x=>x.Planets.Url)));
                 
        }
    }
}
