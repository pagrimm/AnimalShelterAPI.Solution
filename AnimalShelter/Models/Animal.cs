using System;
using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    [Required]
    [StringLength(20)]
    public string Name { get; set; }
    [Required]
    public string Species { get; set; }
    public string Breed { get; set; }
    [Required]
    [Range(0, 200, ErrorMessage = "Age must be between 0 and 200.")]
    public int Age { get; set; }
    [Required]
    public string Gender { get; set; }
    [Required]
    public DateTime CheckInDate { get; set; }
    public DateTime? AdoptionDate { get; set; }
    public Boolean IsAdopted { get; set; } = false;
  }
}