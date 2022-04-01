using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;
using System;
using System.Linq;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private readonly AnimalShelterContext _db;
    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    /// <summary>
    /// Returns list animals/animals that match query parameters.
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Animal>>> Get(string name, string species, int age, int minimumAge, string gender, int minimumId )
    {
      IQueryable<Animal> query = _db.Animals.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (species != null)
      {
        query = query.Where(entry => entry.Species == species);
      }

      if (gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }

      if (age != 0)
      {
        query = query.Where(entry => entry.Age == age);
      }

      if (minimumAge > 0)
      {
        query = query.Where(entry => entry.Age >= minimumAge);
      }

      if (minimumId > 0)
      {
        query = query.Where(entry => entry.AnimalId >= minimumId);
      }
      return await query.ToListAsync();
    }

    /// <summary>
    /// Returns an animal by Animal's ID.
    /// </summary>
    [HttpGet("{id}")]
    public async Task<ActionResult<Animal>> GetAnimal(int id)
    {
      var animal = await _db.Animals.FindAsync(id);

      if (animal == null)
      {
        return NotFound();
      }

      return animal;
    }

    /// <summary>
    /// Creates a new animal.
    /// </summary>
    /// <remarks>
    /// Sample request:
    ///
    ///     POST /Animals
    ///     {
    ///        "id": 1,
    ///        "name": "SomeName",
    ///        "species": "SomeSpecies",
    ///        "age": int,
    ///        "gender": "SomeGender",
    ///        "Breed": "SomeBreed"
    ///     }
    /// </remarks>
    /// <param name="animal"></param>
    /// <returns>A newly created Place</returns>
    /// <response code="201">Returns the newly created place</response>
    /// <response code="400">If the item is null</response>
    /// <response code="201">Returns the newly created item</response>
    /// <response code="400">If the item is null</response> 
    [HttpPost]
    public async Task<ActionResult<Animal>> Post(Animal animal)
    {
      _db.Animals.Add(animal);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetAnimal), new { id = animal.AnimalId }, animal);
    }

    /// <summary>
    /// Edits a specific animal.
    /// </summary>
    /// <remarks>
    /// Sample request:
    ///
    ///     POST /Animals/{id}
    ///     {
    ///        "id": 1,
    ///        "name": "SomeName",
    ///        "species": "SomeSpecies",
    ///        "age": int,
    ///        "gender": "SomeGender",
    ///        "Breed": "NewBreed"
    ///     }
    /// </remarks>
    /// <param name="animal"></param>
    /// <param name="id"></param>
    /// <returns>A newly created Place</returns>
    /// <response code="201">Returns the newly created place</response>
    /// <response code="400">If the item is null</response>
    /// <response code="201">Returns the newly created item</response>
    /// <response code="400">If the item is null</response> 
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Animal animal)
    {
      if (id != animal.AnimalId)
      {
        return BadRequest();
      }

      _db.Entry(animal).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!AnimalExists(id))
        {
          return NotFound();
        }
        else 
        {
          throw;
        }
      }

      return NoContent();
    }

    private bool AnimalExists(int id)
    {
      return _db.Animals.Any(e => e.AnimalId == id);
    }

    
    /// <summary>
    /// Deletes a specific animal.
    /// </summary>
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAnimal(int id)
    {
      var animal = await _db.Animals.FindAsync(id);
      if (animal == null)
      {
        return NotFound();
      }

      _db.Animals.Remove(animal);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    /// <summary>
    /// Returns a random animal.
    /// </summary>
    [HttpGet("Random")]
    public async Task<ActionResult<Animal>> RandomAnimal()
    {
      Random random = new Random();
      int dbCount = _db.Animals.Count();
      int id = random.Next(1, dbCount);
      var animal = await _db.Animals.FindAsync(id);

      return animal;
    }
  }
}