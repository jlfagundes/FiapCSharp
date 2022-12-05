using FiapSmartCityWebAPI.Models;
using FiapSmartCityWebAPI.Repository.Context;


namespace FiapSmartCityWebAPI.Repository
{
    public class AnimalRepository
    {
        public readonly DataBaseContext context;

        public AnimalRepository()
        { 
            context = new DataBaseContext();
        }

        public IList<Animal> Listar()
        {
            return context.Animal.ToList();
        }

        public void Inserir(Animal animal)
        {
            context.Animal.Add(animal);
            context.SaveChanges();
        }

    }
}
