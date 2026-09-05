using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AntecedentesController : ControllerBase
    {
        private readonly IAntecedentesRepository _antecedentesRepository;

        public AntecedentesController( IAntecedentesRepository antecedentesRepository) {
            _antecedentesRepository = antecedentesRepository;
        }

        [HttpGet("all")]
        public async Task<IActionResult> PegarTodosAntecedentes()
        {

            var result = await _antecedentesRepository.ObterTodosAntecedenteAsync();

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
