using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SWAPI.Database.Context;
using SWAPI.Database.Entity;
using SWAPI.Shared.Helper;
using System.Numerics;

namespace SWAPI.Database
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SwapiDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<SwapiDbContext>>()))
            {
                if (context.People.Any())
                {
                    return;   // Data was already seeded
                }

                context.People.AddRange(
                    JsonFileReader.ReadJsonFromFile<List<PeopleEntity>>("Data/people.json")
                    );
                context.Planets.AddRange(
                    JsonFileReader.ReadJsonFromFile<List<PlanetsEntity>>("Data/planets.json")
                    );
                context.Films.AddRange(
                   JsonFileReader.ReadJsonFromFile<List<FilmsEntity>>("Data/films.json")
                   ); 
                context.FilmsPlantsEntities.AddRange(
                   JsonFileReader.ReadJsonFromFile<List<FilmsPlantsEntity>>("Data/filmsPlanats.json")
                   );
                context.SaveChanges();
            }
        }
    }
}
