using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FiapSmartCityWebAPI.Repository;
using FiapSmartCityWebAPI.Models;

namespace FiapSmartCityWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        [HttpGet]
        [Route("GetAnimal")]
        public IActionResult Get()
        {
            try
            {
                return Ok(new AnimalRepository().Listar());
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
                new AnimalRepository().Inserir(animal);

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
    }
}
