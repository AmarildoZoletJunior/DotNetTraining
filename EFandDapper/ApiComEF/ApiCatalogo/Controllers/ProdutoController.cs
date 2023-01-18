using ApiCatalogo.Data;
using ApiCatalogo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Controllers
{
    [ApiController]
    [Route("[controller]/{action}")]

    public class ProdutoController : ControllerBase
    {
        private readonly CatalogoContext _Catalogo;

        public ProdutoController(CatalogoContext catalogo)
        {
            _Catalogo = catalogo;
        }
        [HttpGet("/Produtos")]
       public ActionResult<IEnumerable<Produto>> Produtos()
        {
            var produtos = _Catalogo.Produtos.AsNoTracking().ToList();
            if(produtos == null)
            {
                return NotFound("Não foi encontrado nenhum produto");
            }
            return Ok(produtos);
        }
        [HttpGet("/Produto/{id:int}", Name = "ObterProduto")]
        public ActionResult<Produto> Produto(int id)
        {
            var produto = _Catalogo.Produtos.AsNoTracking().FirstOrDefault(x => x.ProdutoId == id);
            if(produto == null)
            {
                return NotFound("Não foi encontrado nenhum produto");
            }
            return Ok(produto);
        }

        [HttpPost("/Produto")]
        public ActionResult Produto([FromBody] Produto produto)
        {
            if (produto is null)
            {
                return BadRequest("Produto não é valido");
            }
            _Catalogo.Produtos.Add(produto);
            _Catalogo.SaveChanges();
            return new CreatedAtRouteResult("ObterProduto", new { id = produto.ProdutoId }, produto);
        }


        [HttpPut("/Produto/{id:int}")]
        public ActionResult AlterarProduto(int id,[FromBody] Produto produto)
        {
            if (id != produto.ProdutoId)
            {
                return BadRequest("Produto não encontrado");
            }
            _Catalogo.Produtos.Update(produto);
            _Catalogo.SaveChanges();
            return Ok(produto);
        }

        [HttpDelete("/Produto/{id:int}")]

        public ActionResult DeletarProduto(int id)
        {
            var produto = _Catalogo.Produtos.FirstOrDefault(x => x.ProdutoId == id);
            if(produto is null)
            {
                return NotFound("Produto não encontrado");
            }
            _Catalogo.Produtos.Remove(produto);
            _Catalogo.SaveChanges();
            return Ok(produto);
        }

    }
}
