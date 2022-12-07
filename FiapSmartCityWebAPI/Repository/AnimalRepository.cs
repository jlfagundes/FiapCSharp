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
            Animal novoAnimal = new Animal() {
                Nome = "",
                Especie = "",
                Peso = "",
            };
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

        public void Editar(Animal animal)
        {
            context.Animal.Update(animal);
            context.SaveChanges();
        }
        public void Deletar(int id)
        {
            var animal = new Animal()
            {
                IdAnimal = id
            };
            context.Animal.Remove(animal);
            context.SaveChanges();
        }

    }
}
