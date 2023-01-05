using ApiReceitaComDapper.Repository.Ingredientes;
using Microsoft.AspNetCore.Mvc;

namespace ApiReceitaComDapper.Controllers
{
    [ApiController]
    [Route("Ingredientes/[Controller]")]
    public class IngredientesController : ControllerBase
    {
        private readonly IIngrediente _ingrediente;
        public IngredientesController(IIngrediente ingrediente)
        {
            _ingrediente = ingrediente;
        }

        [HttpGet]
        public async Task<IActionResult> ListarIngredientes()
        {
            var lista = await _ingrediente.ListarIngredientes();
            if (lista.Any())
            {
                return Ok(lista);
            }
            return NotFound();
        }
    }
}
