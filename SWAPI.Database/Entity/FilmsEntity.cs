using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWAPI.Database.Entity
{
    [Table("Films")]
    public class FilmsEntity
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Episode_id { get; set; }
        public string Opening_crawl { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public string Release_date { get; set; }
        //public List<string>? Characters { get; set; }
        //public List<string>? Planets { get; set; }
        //public List<string>? Starships { get; set; }
        //public List<string> Vehicles { get; set; }
        //public List<string> Species { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string Url { get; set; }
        public ICollection<FilmsPlantsEntity> FilmsPlantsEntities { get; set; }
    }
}