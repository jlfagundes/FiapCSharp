using Microsoft.AspNetCore.Mvc;
using PetWebAPI.Models;
using PetWebAPI.Repository;

namespace PetWebAPI.Controllers
{
    [ApiController]
    [Route("/")]
    public class AnimalController : ControllerBase
    {
        private readonly ILogger<AnimalController> _logger;

        public AnimalController(ILogger<AnimalController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Animal")]
        public IEnumerable<Animal> Get()
        {
            return new AnimalRepository().Listar();
        }
    }
}