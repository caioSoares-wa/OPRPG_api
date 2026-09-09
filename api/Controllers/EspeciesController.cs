using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EspeciesController : ControllerBase
    {
        private readonly IEspeciesRepository _especiesRepository;


        public EspeciesController(IEspeciesRepository especiesRepository)
        {
            _especiesRepository = especiesRepository;
        }


        [HttpGet("all")]
        public async Task<IActionResult> PegarTodasEspecies()
        {
            var especies = await _especiesRepository.ObterTodasEspeciesAsync();

            if (especies == null )
            {
                return NotFound();
            }
            return Ok(especies);
        }


    }
}
