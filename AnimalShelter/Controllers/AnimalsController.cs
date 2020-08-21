using AnimalShelter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System;

namespace AnimalShelter.Controllers
{
  [ApiVersion("1.0")]
  [Route( "api/v{version:apiVersion}/[controller]" )]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    // GET api/animals
    [HttpGet]
    public ActionResult<IEnumerable<Animal>> Get()
    {
      return _db.Animals.ToList();
    }

    // POST api/animals
    [HttpPost]
    public void Post([FromBody] Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
    }

    // GET api/animals/5
    [HttpGet("{id}")]
    public ActionResult<Animal> Get(int id)
    {
      return _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
    }

    // PUT api/animals/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Animal animal)
    {
      animal.AnimalId = id;
      _db.Entry(animal).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/animals/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var animalToDelete = _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
      _db.Animals.Remove(animalToDelete);
      _db.SaveChanges();
    }
  }

  [ApiVersion("2.0")]
  [Route( "api/v{version:apiVersion}/[controller]" )]
  [ApiController]
  public class AnimalsV2Controller : ControllerBase
  {
    private AnimalShelterContext _db;

    public AnimalsV2Controller(AnimalShelterContext db)
    {
      _db = db;
    }

    // GET api/animals
    [HttpGet]
    public ActionResult<IEnumerable<Animal>> Get(string species, string breed, string gender, string name)
    {
      var query = _db.Animals.AsQueryable();
      if (species != null)
      {
        query = query.Where(entry => entry.Species.ToLower() == species.ToLower());
      }
      if (gender != null)
      {
        query = query.Where(entry => entry.Gender.ToLower() == gender.ToLower());
      }
      if (name != null)
      {
        query = query.Where(entry => entry.Name.ToLower()== name.ToLower());
      }
      if (breed != null)
      {
        query = query.Where(entry => entry.Breed.ToLower() == breed.ToLower());
      }
      return query.ToList();
    }

    [HttpGet("random")]
    public ActionResult<Animal> Random()
    {
      Random rand = new Random();
      int toSkip = rand.Next(0, _db.Animals.Count());
      return _db.Animals.Skip(toSkip).Take(1).FirstOrDefault();
    }
  }
}