using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAPI.Database.Entity
{
    [Table("Planets")]
    public class PlanetsEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rotation_period { get; set; }
        public string Orbital_period { get; set; }
        public string Diameter { get; set; }
        public string Climate { get; set; }
        public string Gravity { get; set; }
        public string Terrain { get; set; }
        public string Surface_water { get; set; }
        public string Population { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string Url { get; set; }
        public  ICollection<PeopleEntity>  Peoples { get; set; }

        public ICollection<FilmsPlantsEntity> FilmsPlantsEntities { get; set; }
    }
}
