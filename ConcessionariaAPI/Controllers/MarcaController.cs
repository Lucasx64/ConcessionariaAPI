using ConcessionariaAPI.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConcessionariaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        private readonly IMarcaRepository _marcaRepository;

        public MarcaController(IMarcaRepository marcaRepository)
        {
            _marcaRepository = marcaRepository;
        }

        [HttpGet]
        public IActionResult ListaeTodos()
        {
            return Ok(_marcaRepository.ListarTodos());
        }
    }
}
