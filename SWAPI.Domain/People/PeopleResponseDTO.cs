namespace SWAPI.Domain.People
{
    public class PeopleResponseDTO
    {
        // String alwasy contains nullable values but in .Net 8 we are getting now wrrning it should be nullable I am using '?'.
        public string? Name { get; set; }
        public string? Height { get; set; }
        public string? Mass { get; set; }
        public string? Hair_olor { get; set; }
        public string? Skin_Color { get; set; }
        public string? Eye_Color { get; set; }
        public string? Birth_year { get; set; }
        public string? Gender { get; set; }
        public string? Homeworld { get; set; }
        public List<string>? Films { get; set; }
        public List<string>? Species { get; set; }
        public List<string>? Vehicles { get; set; }
        public List<string>? Starships { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Edited { get; set; }
        public string? Url { get; set; }
    }
}
