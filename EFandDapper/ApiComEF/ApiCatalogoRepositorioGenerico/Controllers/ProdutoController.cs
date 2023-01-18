using ApiCatalogo.Data;
using ApiCatalogo.DTO;
using ApiCatalogo.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Controllers
{
    [ApiController]
    [Route("[controller]/{action}")]

    public class ProdutoController : ControllerBase
    {
        private readonly CatalogoContext _Catalogo;
        private readonly IMapper _mapper;

        public ProdutoController(CatalogoContext catalogo,IMapper map)
        {
            _mapper = map;
            _Catalogo = catalogo;
        }
        [HttpGet("/Produtos")]
       public ActionResult<IEnumerable<ProdutoDTO>> Produtos()
        {
            var produtos = _Catalogo.Produtos.AsNoTracking().ToList();
            if(produtos == null)
            {
                return NotFound("Não foi encontrado nenhum produto");
            }

            var mapeamento = _mapper.Map<List<ProdutoDTO>>(produtos);
            return Ok(mapeamento);
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
        public ActionResult Produto([FromBody] ProdutoDTO produto)
        {
            var produtoMapeado = _mapper.Map<Produto>(produto);
            if (produto is null)
            {
                return BadRequest("Produto não é valido");
            }
            _Catalogo.Produtos.Add(produtoMapeado);
            _Catalogo.SaveChanges();
            return new CreatedAtRouteResult("ObterProduto", new { id = produto.ProdutoId }, produto);
        }


        [HttpPut("/Produto/{id:int}")]
        public ActionResult AlterarProduto(int id,[FromBody] ProdutoDTO produto)
        {
            var produtoMapeado = _mapper.Map<Produto>(produto);
            if (id != produto.ProdutoId)
            {
                return BadRequest("Produto não encontrado");
            }
            _Catalogo.Produtos.Update(produtoMapeado);
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
