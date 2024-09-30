using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SWAPI.Database.Context;
using SWAPI.Domain.People;
using SWAPI.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAPI.Service.People
{
    public class PeopleService : IPeopleService
    {
        private readonly SwapiDbContext _swapiDbContext;
        private readonly IMapper _mapper;
        public PeopleService(SwapiDbContext swapiDbContext, IMapper mapper)
        {
            _swapiDbContext = swapiDbContext;
            _mapper = mapper;
        }
        public async Task<PeopleResponseDTO> Get(int id)
        {
            var result =_swapiDbContext.People.Include("Planet").FirstOrDefault(x => x.Id == id);
            return _mapper.Map<PeopleResponseDTO>(result) ;
        }
    }
}
