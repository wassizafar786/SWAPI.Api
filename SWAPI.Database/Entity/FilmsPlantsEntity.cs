using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAPI.Database.Entity
{
    public class FilmsPlantsEntity
    {
        public int PlanatId { get; set; }
        public int FilmsId { get; set; }
        public FilmsEntity Films { get; set; }
        public PlanetsEntity Planets { get; set; }
    }
}
