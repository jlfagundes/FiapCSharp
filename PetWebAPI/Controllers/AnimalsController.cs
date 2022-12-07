using Microsoft.AspNetCore.Mvc;
using PetWebAPI.Models;
using PetWebAPI.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        public readonly AnimalRepository animalRepository;
        public AnimalsController()
        {
            animalRepository = new AnimalRepository();
        }

        // GET: api/<AnimalsController>
        [HttpGet]
        public IEnumerable<Animal> Get()
        {
            return animalRepository.Listar(); ;
        }

        // GET api/<AnimalsController>/5
        [HttpGet("{id}")]
        public Animal Get(int id)
        {
            return animalRepository.Consultar(id);
        }

        // POST api/<AnimalsController>
        [HttpPost]
        public IActionResult Post([FromBody] Animal value)
        {
            animalRepository.Inserir(value);

            // Cria uma propriedade para efetuar a consulta da informação cadastrada
            string location = "https://localhost:7013/FiapSmartCityWebAPI";

            return Created(new Uri(location), value);
        }

        // PUT api/<AnimalsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Animal value)
        {
            animalRepository.Editar(value);
            return Ok();
        }

        // DELETE api/<AnimalsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            animalRepository.Deletar(id);
            return Ok();
        }
    }
}
