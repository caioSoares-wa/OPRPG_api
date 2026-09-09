using Application.DTOs;
using Application.UseCases;
using Microsoft.AspNetCore.Mvc;




namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FichaController : ControllerBase
    {

        private readonly FichaUseCase _fichaUseCase;
        public FichaController(FichaUseCase fichaRepository) {
            _fichaUseCase = fichaRepository;
        }


        [HttpPost]
        [Route("criar-atributos")]
        public IActionResult CriarFichaAtributos([FromBody] CriarAtributosDTO atributos)
        {
            var atributosValidados = _fichaUseCase.CriarAtributos(atributos.ValorForca,atributos.ValorDestreza,atributos.ValorConstituicao,atributos.ValorSabedoria,atributos.ValorPresenca,atributos.ValorVontade);

            if (atributosValidados == null)
            {
                return BadRequest();
            }

            return Ok(atributosValidados);
        }

        [HttpPost]
        [Route("escolher-estilo")]
        public IActionResult EscolherEstilo()
        {


            return BadRequest();
        }

    }
}
