using Microsoft.AspNetCore.Mvc;
using ProjetoReceitas.Repositories;
using Receitas.Models.Models;

namespace ProjetoReceitas.Controllers
{
    [Route("ApiGoogleReceitas/[controller]")]
    [ApiController]
    public class ReceitaController : ControllerBase
    {
        private readonly IReceitaRepository _receitaRepository;

        public ReceitaController(IReceitaRepository _receitaRepository)
        {
            this._receitaRepository = _receitaRepository;
        }
        [HttpGet("{nome}")]
        public IActionResult ReceitaUnica(string nome)
        {
         Receita receita = _receitaRepository.ReceitaUnica(nome);
            if(receita == null)
            {
                return NotFound("Não encontrado");
            }
            else
            {
                return Ok(receita);
            }
        }
        [HttpGet]
        public IActionResult ListaReceitas()
        {
            var receita = _receitaRepository.ListaDeReceitas();
            if (receita == null)
            {
                return NotFound("Não encontrado");
            }
            else
            {
                return Ok(receita);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult RemoverReceita(int id)
        {
            _receitaRepository.Deletar(id);
            return Ok();
        }
        [HttpPost]
        public IActionResult AdicionarReceita([FromBody]Receita receita)
        {
            _receitaRepository.Add(receita);
            return Ok(receita);
        }
        [HttpPut]
        public IActionResult EditarReceita([FromBody] Receita receita)
        {
            _receitaRepository.Update(receita);
            return Ok(receita);
        }


        [HttpGet("/ReceitasUsuario/{id}")]
        public IActionResult ReceitasDoUsuario(int id)
        {
            var receitas = _receitaRepository.ReceitasDoUsuario(id);
            return Ok(receitas);
        }
    }
}
