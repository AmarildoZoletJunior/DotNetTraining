using ApiReceitaComDapper.Entidades.Receita;
using ApiReceitaComDapper.Repository.Receita;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ApiReceitaComDapper.Controllers
{
    [ApiController]
    [Route("Receita/[Controller]")]
    public class ReceitaController : ControllerBase
    {

        private readonly IReceita _Ireceita;
        public ReceitaController(IReceita ireceita)
        {
            _Ireceita = ireceita;
        }

        [HttpDelete("{IdReceita:int}")]
        public async Task<IActionResult> DeletarReceita([Required]int IdReceita)
        {
            var apagar = await _Ireceita.ApagarReceita(IdReceita);
            if (apagar)
            {
                return Ok("Apagado com sucesso");
            }
            return NotFound("Não foi possivel apagar esta receita");
        }

        [HttpGet]
        public async Task<IActionResult> ListarReceitas()
        {
            var receitas = await _Ireceita.ListarReceitas();
            if (receitas.Any())
            {
                return Ok(receitas);
            }
            return NoContent();
        }
        [HttpGet("/ReceitaComIngrediente/{ingredientes}")]
        public async Task<IActionResult> ListarReceitaContendoIngredientes([Required][FromRoute] string ingredientes)
        {
            var receitas = await _Ireceita.ListarReceitaContendoIngrediente(ingredientes);
            if (receitas.Any())
            {
                return Ok(receitas);
            }
            return NotFound("Não foi possivel encontrar esta receita");
        }

        [HttpGet("/ReceitaPorNome/{NomeReceita}")]
        public async Task<IActionResult> ListarPorNomes([Required][FromRoute] string NomeReceita)
        {
            var receitas = await _Ireceita.ListarPorNome(NomeReceita);
            if (receitas.Any())
            {
                return Ok(receitas);
            }
            return NotFound("Não foi possivel encontrar esta receita");
        }
        [HttpPost]
        public async Task<IActionResult> CriarReceita([Required][FromBody]ReceitaRequest receita)
        {
                var criarReceita = await _Ireceita.CriarReceita(receita);
                if (criarReceita)
                {
                    return Ok(receita);
                }
                return NoContent();
            
        }

        [HttpPut("{id:int}")]

        public async Task<IActionResult> EditarReceita([Required][FromBody] ReceitaRequest receita,[Required][FromRoute]int id)
        {
            if (string.IsNullOrWhiteSpace(receita.TituloReceita) || string.IsNullOrWhiteSpace(receita.ModoPreparo))
            {
                return BadRequest();
            }
            else
            {
                var editarReceita = await _Ireceita.EditarReceita(receita, id);
                if (editarReceita)
                {
                    return Ok(receita);
                }
                return NoContent();
            }
        }

        [HttpGet("/Receita/{id:int}")]
        public async Task<IActionResult> ListaReceitaSolo([Required][FromRoute]int id)
        {
            var receita = await _Ireceita.ReceitaSolo(id);
            if (receita != null)
            {
               return Ok(receita);
            }
            return NoContent();
        }
    }
}
