using APBD_tutor_4.Model;

namespace APBD_tutor_4.Repositories;

public class AnimalRepository:IAnimalRepository
{
    internal static List<Animal> Animals =
    [
        new Animal
        {
            Id = 1,
            Category = "Cat",
            FurColor = "Red",
            Name = "Fluffy",
            Weight = 3.5
        },

        new Animal()
        {
            Id = 2,
            Category = "Cat",
            FurColor = "Black",
            Name = "Mamba",
            Weight = 2.6
        },

        new Animal()
        {
            Id = 3,
            Category = "Dog",
            FurColor = "Gold",
            Name = "Bobby",
            Weight = 5.6
        }
    ];
    public IEnumerable<Animal> GetAnimals()
    {
        return Animals;
    }

    public int CreateAnimal(Animal animal)
    {
        Animals.Add(animal);
        return 1;
    }

    public Animal GetAnimal(int id)
    {
        return Animals.Find(animal => animal.Id == id);
    }

    public int UpdateAnimal(int id, Animal animal)
    {
        var updatingAnimal = Animals.Find(animal => animal.Id == id);
        updatingAnimal?.Copy(animal);
        return 1;
    }

    public int DeleteAnimal(int id)
    {
        Animals.RemoveAll(animal=>animal.Id == id);
        return 1;
    }
}