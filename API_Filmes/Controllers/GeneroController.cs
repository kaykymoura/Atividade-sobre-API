using api_filmes_senai1.Domains;
using api_filmes_senai1.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api_filmes_senai1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class GeneroController : ControllerBase
    {
        private readonly IGeneroRepositoy _generoRepository;

        public GeneroController(IGeneroRepositoy generoRepository)
        {
            _generoRepository = generoRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_generoRepository.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
        [HttpPost]
        public IActionResult Post (Genero novoGenero)
        {
            try
            {
                _generoRepository.Cadastrar(novoGenero);

                    return Created();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    
    
    }

}


