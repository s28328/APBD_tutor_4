using APBD_tutor_4.Model;

namespace APBD_tutor_4.Repositories;

public interface IAnimalRepository
{
    IEnumerable<Animal> GetAnimals();
    int CreateAnimal(Animal animal);
    Animal GetAnimal(int idAnimal);
    int UpdateAnimal(int id,Animal animal);
    int DeleteAnimal(int idAnimal);
}