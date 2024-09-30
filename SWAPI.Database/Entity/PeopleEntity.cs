using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWAPI.Database.Entity
{
    [Table("People")]
    public class PeopleEntity
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Height { get; set; }
        public string? Mass { get; set; }
        public string? Hair_olor { get; set; }
        public string? Skin_Color { get; set; }
        public string? Eye_Color { get; set; }
        public string? Birth_year { get; set; }
        public string? Gender { get; set; }
        public string? Homeworld { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Edited { get; set; }
        public string? Url { get; set; }
        public int PlanetId { get; set; }
        public PlanetsEntity Planet { get; set; }
    }
}
