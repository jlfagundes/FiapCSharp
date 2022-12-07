using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FiapSmartCityWebAPI.Repository;
using FiapSmartCityWebAPI.Models;

namespace FiapSmartCityWebAPI.Controllers
{
    [Route("/")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        public readonly AnimalRepository animalRepository;
        public AnimalController()
        { 
            animalRepository= new AnimalRepository();
        }

        [HttpGet]
        [Route("GetAnimal")]
        public IActionResult Get()
        {
            try
            {
                return Ok(animalRepository.Listar());
            }
            catch (Exception)
            {
                return NotFound();
                throw new Exception("Erro ao buscar os dados no banco");
            }
        }

        [HttpPost(Name = "GetAnimal")]
        public IActionResult Post([FromBody] Animal animal) 
        {
            try
            {
                animalRepository.Inserir(animal);

                // Cria uma propriedade para efetuar a consulta da informação cadastrada
                string location = "https://localhost:7013/FiapSmartCityWebAPI";

                return Created(new Uri(location), animal);
            }
            catch (Exception)
            {
                return BadRequest();
                throw new Exception("Erro ao cadastrar os dados no banco"); ;
            }
        }

        [HttpDelete(Name = "GetAnimal")]
        public IActionResult Delete(int id)
        {
            try
            {
                animalRepository.Deletar(id);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
                throw new Exception("Erro ao deletar os dados no banco"); ;
            }
        }

        [HttpPut(Name ="GetAnimal")]
        public IActionResult Editar([FromBody] Animal animal)
        {
            try
            {
                animalRepository.Editar(animal);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
                throw new Exception("Erro ao deletar os dados no banco"); ;
            }
        }

    }
}
