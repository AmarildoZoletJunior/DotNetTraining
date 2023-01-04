using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using TesteDapper.Models;
using TesteDapper.Repository;

namespace TesteDapper.Controllers
{
    [ApiController]
    [Route("/Produtora/[Controller]")]
    public class ProdutoraController : ControllerBase
    {
        private readonly IProdutoraRepository _produtoraRepository;
        public ProdutoraController(IProdutoraRepository produtora)
        {
            _produtoraRepository = produtora;
        }

        [HttpGet]

        public async Task<IActionResult> Produtoras()
        {
            var produtoras = await _produtoraRepository.ListarProdutoras();
            if (produtoras.Any())
            {
                return Ok(produtoras);
            }
            return BadRequest();
        }

        [HttpGet("{id:int}")]

        public async Task<IActionResult> Produtora([Required][FromRoute] int id)
        {
            var produtora = await _produtoraRepository.Produtora(id);
            if (produtora != null)
            {
                return Ok(produtora);
            }
            return NotFound("Não encontrada");
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeletarProdutora([Required][FromRoute] int id)
        {
            var deletado = await _produtoraRepository.DeletarProdutora(id);
            if (deletado)
            {
                return Ok();
            }
            return NotFound();
        }

        [HttpPut("{id:int}")]

        public async Task<IActionResult> EditarProdutora([Required][FromBody] ProdutoraRequest request, [Required] int id)
        {
            var atualizar = await _produtoraRepository.EditarProdutora(request, id);
            if (atualizar)
            {
                return Ok(request);
            }
            return NotFound();
        }

        [HttpPost]

        public async Task<IActionResult> AdicionarProdutora([Required][FromBody] ProdutoraRequest request)
        {
            var atualizar = await _produtoraRepository.AdicionarProdutora(request);
            if (atualizar)
            {
                return Ok(request);
            }
            return NotFound();
        }

    }
}
