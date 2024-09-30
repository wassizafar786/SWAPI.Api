using Microsoft.EntityFrameworkCore;
using SWAPI.Database.Entity;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Reflection.Emit;

namespace SWAPI.Database.Context
{
    public class SwapiDbContext : DbContext
    {
        public SwapiDbContext(DbContextOptions<SwapiDbContext> options)
        : base(options)
        {
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuild)
        {
            modelBuild.Entity<PeopleEntity>()
                .HasOne(p => p.Planet)
                .WithMany(e => e.Peoples)
                .HasForeignKey(x=>x.PlanetId);

            modelBuild.Entity<FilmsPlantsEntity>()
                .HasKey(bc => new { bc.PlanatId, bc.FilmsId});

            modelBuild.Entity<FilmsPlantsEntity>()
                .HasOne(bc => bc.Planets)
                .WithMany(b => b.FilmsPlantsEntities)
                .HasForeignKey(bc => bc.PlanatId);


            modelBuild.Entity<FilmsPlantsEntity>()
                .HasOne(bc => bc.Films)
                .WithMany(b => b.FilmsPlantsEntities)
                .HasForeignKey(bc => bc.FilmsId);
        }
        public DbSet<PeopleEntity> People { get; set; }
        public DbSet<PlanetsEntity> Planets { get; set; }
        public DbSet<FilmsEntity> Films { get; set; }
        public DbSet<FilmsPlantsEntity> FilmsPlantsEntities { get; set; }

    }
}
