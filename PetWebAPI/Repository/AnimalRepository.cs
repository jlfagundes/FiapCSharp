using PetWebAPI.Models;
using PetWebAPI.Repository.Context;


namespace PetWebAPI.Repository
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
