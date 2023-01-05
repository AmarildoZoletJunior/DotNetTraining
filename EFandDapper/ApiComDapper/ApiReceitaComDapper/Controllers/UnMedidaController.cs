using ApiReceitaComDapper.Repository.UnMedida;
using Microsoft.AspNetCore.Mvc;

namespace ApiReceitaComDapper.Controllers
{
    [ApiController]
    [Route("Unidade/[Controller]")]
    public class UnMedidaController : ControllerBase
    {
        private readonly IUnMedida _Unidade;

        public UnMedidaController(IUnMedida unidade)
        {
            _Unidade = unidade;
        }

        [HttpGet]
        public async Task<IActionResult> ListarUnidades()
        {
            var resultado = await _Unidade.ListarUnidades();
            if (resultado.Any())
            {
                return Ok(resultado);
            }
            return NotFound("Nenhuma medida foi encontrada");
        }
    }
}
