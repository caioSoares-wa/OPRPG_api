using Microsoft.AspNetCore.Mvc;
using Domain.Interfaces;
using Domain.ValueObjects.AtributosVOs;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FichaController : ControllerBase
    {

        private readonly IFichaRepository _fichaRepository;
        public FichaController(IFichaRepository fichaRepository) {
            _fichaRepository = fichaRepository;
        }

        [HttpPost]
        [Route("api/criar-atributos")]
        public IActionResult CriarFichaAtributos([FromBody] ConjuntoAtributosVO)
        {


            return Ok();
        }
    }
}
