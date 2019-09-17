using System;
using System.Linq;
using AnimalModel;

namespace SafariVacation
{
  class Program
  {
    static void CreateData()
    {
      // 1. reference the data
      var db = new SafariVacation();
      // 2. Do the thing
      var safariAnimal = new AnimalModel.animal()
      {
        Species = "Bear"
      };
      db.Animals.Add(safariAnimal);
      // 3. Save the thing
      db.SaveChanges();
    }

    static void ReadData()
    {
      //reference the data
      var db = new SafariVacation();
      //Do the thing
      var allTheAnimals = db.Animals
      .Where(animal => animal.Species == "Cheetah")
      .Select(movie => movie.Id);
    }

    static void UpdateData()
    {
      //1.reference the database
      var db = new SafariVacation();
      //do the thing
      var animalsToUpdate = db.Animals.FirstOrDefault(update => update.Species == "Turtle");
      animalsToUpdate.LocationOfLastSeen = "Ocean";

      db.SaveChanges();
    }

    static void deleteData()
    {
      var db = new SafariVacation();

      var animalToDelete = db.Animals.FirstOrDefault(animal => animal.LocationOfLastSeen == "Desert");
      db.Animals.Remove(animalToDelete);

      db.SaveChanges();
    }

    static void selectData()
    {
      var db = new SafariVacation();
      var safariAnimal = db.Animals.Select(animal => $"{animal.LocationOfLastSeen},{animal.Species}");
      foreach (var animals in safariAnimal)
      {
        Console.WriteLine(animals);
      }
    }

    static void selectLocation()
    {
      var db = new SafariVacation();
      var jungleAnimal = db.Animals.Where(animal => animal.LocationOfLastSeen == "Forest");
      foreach (var animals in jungleAnimal)
      {
        Console.WriteLine(jungleAnimal);
      }
    }

    static void Main(string[] args)
    {
      //   selectData();
      selectLocation();
    }
  }
}
