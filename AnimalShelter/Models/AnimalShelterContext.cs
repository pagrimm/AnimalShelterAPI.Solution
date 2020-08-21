using Microsoft.EntityFrameworkCore;
using System;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
      : base(options)
    {
    }

    public DbSet<Animal> Animals { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Boots", Species = SpeciesOptions.Cat, Breed = "Tabby", Age = 7, Gender = "Female", CheckInDate = DateTime.Parse("2017-09-14") },
          new Animal { AnimalId = 2, Name = "Bandit", Species = SpeciesOptions.Dog, Breed = "Retriever", Age = 4, Gender = "Male", CheckInDate = DateTime.Parse("2019-04-11") },
          new Animal { AnimalId = 3, Name = "Felix", Species = SpeciesOptions.Cat, Breed = "Siamese", Age = 3, Gender = "Male", CheckInDate = DateTime.Parse("2017-09-14") },
          new Animal { AnimalId = 4, Name = "Lassie", Species = SpeciesOptions.Dog, Breed = "Collie", Age = 2, Gender = "Female", CheckInDate = DateTime.Parse("2019-04-11") }
        );
    }

  }
}