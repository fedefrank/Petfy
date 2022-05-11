// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Petfy.Data;
using Petfy.Data.Repositories;
using Petfy.Domain;

Console.WriteLine("Hello, World!");

using (var context = new PetfyDbContext())
{
    context.Database.EnsureCreated();

    context.Database.Migrate();

    var repository = new PetRepository(context);

    Console.WriteLine("Before Insert");

    var pets = context.Pets.ToList();

    foreach (var pet in pets)
    {
        Console.WriteLine($"Name: {pet.Name} Breed: {pet.Breed}");
    }

    var maxPetNumber = context.Pets.Max(x => x.PetNumber);

    var newPet = new Pet()
    {
        Name = "Bobby",
        Breed = "German Shepherd",
        DateOfBirth = DateTime.Today,
        Description = "My dog new",
        Type = "Dog",
        PetNumber = (maxPetNumber ?? 0) + 1,
        OwnerID = 1
    };

    newPet.PetVaccines.Add(new PetVaccine()
    {
        VaccineID = 1,
        DateApplied = DateTime.Today,
    });

    repository.AddPet(newPet);

    Console.WriteLine("After Insert");

    var petsUpdated = repository.GetAllPets();

    foreach (var pet in petsUpdated)
    {
        Console.WriteLine($"Name: {pet.Name} Breed: {pet.Breed}");

        //if (pet.ID == 1)
        //{
        //    context.Pets.Remove(pet);
        //    context.SaveChanges();
        //}
    }
}





