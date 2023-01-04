using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using TesteDapper.Models;
using TesteDapper.Repository;

namespace TesteDapper.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class FilmesController : ControllerBase
    {
        private readonly IFilmeRepository Filme;
        public FilmesController(IFilmeRepository filme)
        {
            Filme = filme;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var filmes = await Filme.BuscaFilmes();
            if (filmes.Any())
            {
                return Ok(filmes);
            }
            return NoContent();
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetUnico([Required] int id)
        {
            var filmes = await Filme.BuscaFilmesAsync(id);
            if (filmes != null)
            {
                return Ok(filmes);
            }
            return NoContent();
        }
        [HttpPost]
        public async Task<IActionResult> Adicionar([Required][FromBody]FilmeRequest request)
        {
            if(string.IsNullOrEmpty(request.Nome) || request.Ano == null)
            {
                return NotFound();
            }
            var filme = await Filme.AdicionarAsync(request);
            if (filme == true)
            {
                return Ok(request);
            }
            return BadRequest();
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Atualizar([Required][FromBody] FilmeRequest request, [Required] int id)
        {
            if (string.IsNullOrEmpty(request.Nome) || request.Ano == null)
            {
                return NotFound();
            }
            var filme = await Filme.AtualizarAsync(request,id);
            if (filme == true)
            {
                return Ok(request);
            }
            return BadRequest();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Deletar([Required]int id)
        {
            var resultado =  await Filme.DeletarAsync(id);
            if(resultado == true)
            {
                return Ok("Deletado com sucesso");
            }
            return NotFound();
        }
    }
}
