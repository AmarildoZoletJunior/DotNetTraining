using ApiReceitaComDapper.Entidades.IngredientesReceitas;
using ApiReceitaComDapper.Repository.IngredientesReceitas;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ApiReceitaComDapper.Controllers
{
    [ApiController]
    [Route("IngredientesReceita/[Controller]")]
    public class IngredienteReceitaController : ControllerBase
    {
        private readonly IIngredienteReceita _receita;

        public IngredienteReceitaController(IIngredienteReceita receita)
        {
            _receita = receita;
        }

        [HttpGet("{idReceita:int}")]
        public async Task<IActionResult> ListarIngredientesDeReceita([Required][FromRoute] int idReceita)
        {
            var existencia = await _receita.ReceitaExiste(idReceita);
            if (existencia)
            {
                var lista = await _receita.ListarIngredientesReceita(idReceita);
                if (lista.Any())
                {
                    return Ok(lista);
                }
                return NoContent();
            }
            return NotFound();
        }
        [HttpPost("{idReceita:int}")]
        public async Task<IActionResult> AdicionarIngredientes([Required][FromBody]List<IngredientesReceitaRequest> ingredientes, [Required] [FromRoute]int idReceita)
        {
            var existencia = await _receita.ReceitaExiste(idReceita);
            if (existencia)
            {
                var lista = await _receita.AdicionarIngredientes(ingredientes, idReceita);
                if (lista > 0)
                {
                    return Ok($"Foram adicionados {lista} a sua receita");
                }
                return NoContent();
            }
            return NotFound();
        }

        [HttpDelete("{idReceita:int}")]
        public async Task<IActionResult> RemoverIngrediente([Required][FromBody] List<int> ingredientes, [Required][FromRoute] int idReceita)
        {
            var existencia = await _receita.ReceitaExiste(idReceita);
            if (existencia)
            {
                var lista = await _receita.RemoverIngredientes(ingredientes, idReceita);
                if (lista > 0)
                {
                    return Ok($"Foram Removidos {lista} de sua receita");
                }
                return NoContent();
            }
            return NotFound();
        }

    }
}
