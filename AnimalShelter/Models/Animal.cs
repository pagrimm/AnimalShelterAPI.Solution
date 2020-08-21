using System;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Name { get; set; }
    public string Species { get; set; }
    public string Breed { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime? AdoptionDate { get; set; }
    public Boolean IsAdopted { get; set; }
  }
}